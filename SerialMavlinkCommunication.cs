using CefSharp.DevTools.CSS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace SerialMavlinkCommunication
{
    /// <summary>
    /// This class manipulates the serial port. It will read continuously from the port until it is closed.
    /// To get the result, you should assign the event <see cref="OnMavlinkMessageReady"/>.
    /// <para>This class executes everything in the background.</para>
    /// </summary>
    internal class SerialMavlinkCommunication
    {
        /// <summary>
        /// Called every time a new <c>Mavlink message</c> is ready to be processed. It returns a <see cref="MAVLink.MAVLinkMessage"/>.
        /// </summary>
        public event Action<Mavlink.MavlinkMessage> OnMavlinkMessageReady;

        /// <summary>
        /// The current active SerialPort. <c>Note:</c> if the port is already open, it throws an <see cref="InvalidOperationException"/>.
        /// You should <c>always close</c> the current serial port before changing it.
        /// </summary>
        public string PortName
        {
            get { return _serialPort.PortName; }
            set
            {
                this.ChangeSerialParameter(() => this._serialPort.PortName = value);
            }
        }

        public int BaudRate
        {
            get => this._serialPort.BaudRate;
            set
            {
                this.ChangeSerialParameter(() => this._serialPort.BaudRate = value);
            }
        }

        public int ReadTimeOut
        {
            get => this._serialPort.ReadTimeout;
            set
            {
                this.ChangeSerialParameter(() => this._serialPort.ReadTimeout = value);
            }
        }

        /// <summary>
        /// Represents the current state of the serial port.
        /// </summary>
        public bool IsOpen { get { return _serialPort.IsOpen; } }

        private SerialPort _serialPort;
        private bool _cancelled = false;
        private bool _serialAborted = false;
        private Task _taskRunning = null;
        private Task _taskClose = null;
        private Task _taskOpen = null;
        private Task _taskChangingParameters = null;
        private object _serialLocker = new object();

        public SerialMavlinkCommunication(SerialPort serialPort)
        {
            this._serialPort = serialPort;
            if (this._serialPort.ReadTimeout <= 0) this._serialPort.ReadTimeout = 500;
            this._taskRunning = null;
        }
        public SerialMavlinkCommunication(string portName, int baudRate)
            : this(new SerialPort(portName, baudRate)) { }


        /// <summary>
        /// This function is called when changing any serial port parameter.
        /// </summary>
        /// <param name="funcao"></param>
        private void ChangeSerialParameter(Action funcao)
        {
            if (this._taskClose == null)
            {
                funcao();
                return;
            }

            this._taskChangingParameters = Task.Run(async () =>
            {
                if (this._taskClose != null) await this._taskClose;
                lock (this._serialLocker)
                {
                    funcao();
                }
            }).ContinueWith(t => this._taskChangingParameters = null);
        }

        /// <summary>
        /// Closes the serial port.
        /// </summary>
        public void Close()
        {
            this._taskClose = Task.Run(async () =>
            {
                try
                {
                    if (this._serialPort.IsOpen)
                    {
                        this._cancelled = true;
                        if (this._taskRunning != null)
                        {
                            await this._taskRunning;
                        }

                        lock (this._serialLocker)
                        {
                            this._serialPort.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }).ContinueWith(t => this._taskClose = null);
        }

        /// <summary>
        /// Opens the serial port.
        /// </summary>
        /// <returns><c>True</c> if successful, <c>False</c> otherwise.</returns>
        public void Open()
        {
            this._taskOpen = Task.Run(async () =>
            {
                if (this._taskClose != null) await this._taskClose;
                if (this._taskChangingParameters != null) await this._taskChangingParameters;

                try
                {
                    lock (this._serialLocker)
                    {
                        _serialPort.Open();
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                this._taskRunning = Task.Run(() => ReadMavlink()).ContinueWith(t => this._taskRunning = null);
            }).ContinueWith(t => this._taskOpen = null);

        }

        #region OLD_ASYNC_FUNCTIONS
        /// <summary>
        /// Opens the serial port asynchronously.
        /// </summary>
        /// <returns><c>True</c> if successful, <c>False</c> otherwise.</returns>
        private async Task<bool> OpenPortAsync()
        {
            try
            {
                if (this._taskRunning != null) await this._taskRunning;

                this._taskRunning = new Task(() => ReadMavlink());
                if (!this._serialPort.IsOpen)
                {
                    _serialPort.Open();
                    this._taskRunning.Start();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Verifique se a porta existe ou não está sendo usada por outro programa.");
                return false;
            }
            return false;
        }

        /// <summary>
        /// Closes the serial port asynchronously.
        /// </summary>
        /// <returns></returns>
        public async Task ClosePortAsync()
        {
            try
            {
                if (this._serialPort.IsOpen)
                {
                    this._cancelled = true;
                    if(this._taskRunning != null) await this._taskRunning;
                    this._serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Automatically changes the port name. This method is not intended for public use.
        /// </summary>
        /// <param name="newPort">The new port name.</param>
        /// <returns>A boolean indicating if the port name was successfully changed.</returns>
        private async Task ChangePortNameAsync(string newPort)
        {
            if (this._serialPort.IsOpen || this._serialAborted)
            {
                this._serialAborted = false;
                await this.ClosePortAsync();
                this._serialPort.PortName = newPort;
                this.OpenPortAsync();
            }
            else
            {
                this._serialPort.PortName = newPort;
            }
        }
        #endregion

        /// <summary>
        /// Continuously reads the serial port and throws an event if a <c>Mavlink message</c> is decoded.
        /// </summary>
        private void ReadMavlink()
        {
            Mavlink.MavlinkParser mavlinkParse = new Mavlink.MavlinkParser();
            while (!this._cancelled)
            {
                // Serial port was not closed correctly
                while (!this._cancelled && !this._serialPort.IsOpen)
                {
                    Thread.Sleep(1000);
                    try
                    {
                        this._serialPort.Open();
                    } catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
                if (this._cancelled) break;

                try
                {
                    Mavlink.MavlinkMessage message;
                    lock (this._serialLocker)
                    {
                        message = mavlinkParse.ReadPacket(this._serialPort.BaseStream);
                    }
                        if (message != null)
                    {
                        this.OnMavlinkMessageReady?.Invoke(message);
                    }

                    Thread.Sleep(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            this._cancelled = false;
        }
    }
}

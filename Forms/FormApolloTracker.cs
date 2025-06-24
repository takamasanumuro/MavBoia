using MavBoia.Utilities;
using Newtonsoft.Json;
using ScrappingTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MavBoia.Forms
{
    public partial class FormApolloTracker : Form
    {
        FormResizer resizer;

        private SocketIOClient.SocketIO client;
        public FormApolloTracker()
        {
            resizer = new FormResizer(this);
            InitializeComponent();
            resizer.InitializeResizer();

            client = new SocketIOClient.SocketIO("https://server-rastreador-barco.herokuapp.com");
        }

        private async Task InitializeSocketIO()
        {
            client.OnConnected += async (sender, e) =>
            {
                Console.WriteLine("Conectando ao ApolloTracker...");
                await client.EmitAsync("getAllEvents");
                await client.EmitAsync("joinEvent", MavBoiaConfigurations.RjTextBoxApolloTracker);
            };

            client.On("info", ProcessApolloTrackerInfo);

            await client.ConnectAsync();

        }


        private void ProcessApolloTrackerInfo(SocketIOClient.SocketIOResponse response)
        {
            Console.WriteLine("APOLLOTRACKER - Info recebida:");
            var jsonElement = response.GetValue<JsonElement>();

            foreach (var json in jsonElement.EnumerateArray())
            {
                var boat = JsonConvert.DeserializeObject<BoatInfo>(json.GetRawText());
                Console.WriteLine("Nome: " + boat.title + $" Lat: {boat.lat}; Lon: {boat.lng}");
            }
        }


        private void ApolloTracker_Resize(object sender, EventArgs e)
        {
            resizer.ResizeAll();
        }

        private async void ApolloTracker_Load(object sender, EventArgs e)
        {
            await InitializeSocketIO();
        }

        private async void ApolloTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if(client != null)
            {
                await client.DisconnectAsync();
            }

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExample
{
    public partial class FormPixhawk : Form
    {
        private object serialLock = new object();
        public FormPixhawk()
        {
            InitializeComponent();
            
            // Get enum values from MAV_CMD enum
            foreach (var item in Enum.GetValues(typeof(Mavlink.MAV_CMD)))
            {
                comboBoxCommandSelection.Items.Add(item.ToString());
            }
        }

        private void comboBoxCommandSelection_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedCommand = comboBox.SelectedItem.ToString();
            MessageBox.Show(selectedCommand);
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}

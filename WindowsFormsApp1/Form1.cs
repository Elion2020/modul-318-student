using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private Transport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBoxVon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Verbindung_Suchen_Click(object sender, EventArgs e)
        {
   
        }

        private void VerbindungenAnzeigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVon_DropDown(object sender, EventArgs e)
        {
            var von = Convert.ToString(comboBoxVon.Text);
            Stations stations = transport.GetStations(von);
            comboBoxVon.Items.Clear();
            if (stations.StationList != null)
                foreach (Station station in stations.StationList)

                {
                    comboBoxVon.Items.Add(station.Name);
                }
        }
    }
}

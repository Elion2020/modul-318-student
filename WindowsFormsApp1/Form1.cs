using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();

        public string time { get; private set; }

        public Form1()
        {
            InitializeComponent();
            
        }


        private void GetStations(string text, ListBox listBox)
        {
            try
            {
                if (text.Length >= 3)
                {
                    listBox.Items.Clear();
                    Stations stations = transport.GetStations(text);
                    foreach (Station station in stations.StationList)
                    {
                        listBox.Items.Add(station.Name);
                        listBox.Visible = true;
                        listBox.BringToFront();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Station wurde nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }





        //Bereich Methoden

        private void comboBoxVon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void Verbindung_Suchen_Click(object sender, EventArgs e)
        {
            Connections connections = transport.GetConnections(comboBoxVon.Text, comboBoxNach.Text);
            VerbindungenAnzeigen.Items.Clear();
            
            foreach (connection connection in connections.ConnectionList)
            {
                VerbindungenAnzeigen.Items.Add(comboBoxVon.Text + "\t" + comboBoxNach.Text + "\tAbfahrt" + connection.From.Departure + "\tAnkunft" + connection.To.Arrival);
            }
        }



        private void VerbindungenAnzeigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Tafel()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(comboBoxVon.Text, comboBoxNach.Text, dateTimePicker.Value.ToString("yyyy-MM-dd"), dateTimePicker.Text);

            //Fügt jede Station in die Listen hinzu
            foreach(connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(GetDate(connection.From.Departure), connection.From.Station.Name,
                GetTime(connection.From.Departure), connection.To.Station.Name, GetTime(connection.To.Arrival), connection.To.Platform);
            }

            

        }





        private void Tafel2()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");


            Station station = transport.GetStations(comboBoxStation.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);

            foreach(StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(GetTime(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number));
            }

        }







        //GetTime und GetDate Methoden erstellen
        private string GetDate(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string GetTime(string time1)
        {
            //z.B. zeigt 14:42:00 die sekunden anzahl "00" wird hier entfernt
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
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




        private void comboBoxNach_DropDown(object sender, EventArgs e)
        {
            var nach = Convert.ToString(comboBoxNach.Text);
            Stations stations = transport.GetStations(nach);
            comboBoxNach.Items.Clear();
            if (stations.StationList != null)
                foreach (Station station in stations.StationList)

                {
                    comboBoxNach.Items.Add(station.Name);
                }
        }

 




        private void dateTimePickerZeit_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStations(comboBoxStation.Text, listBoxAbfahrtsplan);
        }






        private void listBoxSituation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void comboBoxStation_DropDown(object sender, EventArgs e)
        {
            var StationEingabe = Convert.ToString(comboBoxStation.Text);
            Stations stations = transport.GetStations(StationEingabe);
            comboBoxStation.Items.Clear();
            if (stations.StationList != null)
                foreach (Station station in stations.StationList)

                {
                    comboBoxStation.Items.Add(station.Name);
                }
        }

        private void StationsortAnzeigen_Click(object sender, EventArgs e)
        {
            // wenn man in die textbox geht wird die liste angezeigt
            listBoxAbfahrtsplan.Visible = true;
        }

        private void AbfahrtsplanAnzeigen_Click(object sender, EventArgs e)
        {
            // fals mann die map noch offen hat wird sie versteckt dass man den fahrplan sieht
            // Wenn man den knopf Abfahrt gedrückt hat und das feld Von leer lässt kommt die fehler meldung dass man eine station angeben muss.
            // Wenn man den knopf Abfahrt gedrückt hat und etwas eingegeben hatt wird die tabelle abgerufen
            if (AbfahrtsplanAnzeigen.Text == string.Empty)
            {
                MessageBox.Show("Geben sie in die Textboxen von und nach eine Station ein", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tafel2();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }







    }


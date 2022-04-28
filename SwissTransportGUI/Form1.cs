using System.Diagnostics;
using System.Net.Mail;

namespace SwissTransportGUI;

public partial class Form1 : Form
{
    private readonly ÖV_Verbindungen_StationSuchen_Abfahrtstafel VerbindugZurKlasse_ÖV = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void VerbindungSuchenTab_Click(object sender, EventArgs e)
    {
    }

    private void VerbindungSuchenButton_Click(object sender, EventArgs e)


    {

        var Verbindungen = VerbindugZurKlasse_ÖV.VerbindungSuchen(StartStationComboBox.Text, EndStationComboBox.Text,GewählteUhrzeit.Value);
       

            foreach (var name in Verbindungen.ConnectionList)
            {
                VerbindungSuchenDataGridView.Rows.Add(name.From.Station.Name, name.To.Station.Name,
                    string.Format("{0:d}", name.From.Departure), string.Format("{0:d}", name.To.Arrival),
                    name.From.Platform);
            }
        
        
        

    }

    private void VerbindungSuchenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void StationSuchenButton_Click(object sender, EventArgs e)
    {
    }

    private void AbfahrtstafelButton_Click(object sender, EventArgs e)
    {
        var Stationen = VerbindugZurKlasse_ÖV.StationHerausfinden(AbfahrtstafelTextBox.Text);
        var Scho = VerbindugZurKlasse_ÖV.Abfahrtstafel(AbfahrtstafelTextBox.Text, Stationen.StationList.First().Id);
        var x = 0;
        foreach (var Name in Scho.Entries)
        {
            if (x != 5)
            {
                var Verbindungen = VerbindugZurKlasse_ÖV.VerbindungSuchen(AbfahrtstafelTextBox.Text, Name.To, GewählteUhrzeit.Value);
                foreach (var NameVerbindungen in Verbindungen.ConnectionList)
                {
                    AbfahrtstafelDataGridView.Rows.Add(Name.To, string.Format("{0:t}", NameVerbindungen.To.Arrival));

                    break;
                }
            }
            else
            {
                break;
            }

            x++;
        }
    }



    private void StartStationComboBox_KeyUp(object sender, KeyEventArgs e)
    {



        if (StartStationComboBox.Text != "")
        {


            StartStationComboBox.Items.Clear();
            StartStationComboBox.SelectionStart = StartStationComboBox.Text.Length;
            var StartStationVorschläge = VerbindugZurKlasse_ÖV.StationHerausfinden(StartStationComboBox.Text);



            foreach (SwissTransport.Models.Station Station in StartStationVorschläge.StationList)
            {
                if(Station.Name != null){
                    StartStationComboBox.Items.Add(Station.Name);
                }


            }
        }
    }

    private void EndStationComboBox_KeyUp(object sender, KeyEventArgs e)
    {
       

        if (EndStationComboBox.Text != "")
        {


            var EndStationsVorschläge = VerbindugZurKlasse_ÖV.StationHerausfinden(EndStationComboBox.Text);

            
            EndStationComboBox.Items.Clear();

            foreach (SwissTransport.Models.Station Station in EndStationsVorschläge.StationList)
            {
                if (Station.Name != null)
                {
                    EndStationComboBox.Items.Add(Station.Name);

                }

                    EndStationComboBox.SelectionStart = EndStationComboBox.Text.Length;

            }
        }

    }

    private void MailButton_Click(object sender, EventArgs e)
    {
       /* Outlook.Application oApp = new Outlook.Application();
        Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
        oMailItem.To = address;
        // body, bcc etc...
        oMailItem.Display(true);*/


    }

    private void DatumCheckBox_CheckedChanged(object sender, EventArgs e)
    {

    }
}
using System.Diagnostics;
using System.Net.Mail;
using System.Net.NetworkInformation;

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
        try
        {
            var Verbindungen = VerbindugZurKlasse_ÖV.VerbindungSuchen(StartStationComboBox.Text, EndStationComboBox.Text, GewählteUhrzeit.Value, UhrZeit.Value);

            foreach (var name in Verbindungen.ConnectionList)
            {
                VerbindungSuchenDataGridView.Rows.Add(name.From.Station.Name, name.To.Station.Name,
                    string.Format("{0:t}", name.From.Departure), string.Format("{0:t}", name.To.Arrival),
                    name.From.Platform);

            }

        }
        catch
        {
            MessageBox.Show("Kein Internet ");
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

        try
        {
            {
            var Stationen = VerbindugZurKlasse_ÖV.StationHerausfinden(AbfahrtstafelTextBox.Text);
            var Scho = VerbindugZurKlasse_ÖV.Abfahrtstafel(AbfahrtstafelTextBox.Text, Stationen.StationList.First().Id);
            var x = 0;
            foreach (var Name in Scho.Entries)
            {
                if (x != 5)
                {
                    var Verbindungen = VerbindugZurKlasse_ÖV.VerbindungSuchen(AbfahrtstafelTextBox.Text, Name.To, GewählteUhrzeit.Value, UhrZeit.Value);
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
    }
        catch
        {
            MessageBox.Show("Kein Internet ");
        }
    }



    private void StartStationComboBox_KeyUp(object sender, KeyEventArgs e)
    {



        try
        {
            if (StartStationComboBox.Text != "")
            {


                StartStationComboBox.Items.Clear();
                StartStationComboBox.SelectionStart = StartStationComboBox.Text.Length;
                var StartStationVorschläge = VerbindugZurKlasse_ÖV.StationHerausfinden(StartStationComboBox.Text);



                foreach (SwissTransport.Models.Station Station in StartStationVorschläge.StationList)
                {
                    if (Station.Name != null)
                    {
                        StartStationComboBox.Items.Add(Station.Name);
                    }


                }
            }
        }
            
        catch
{
    MessageBox.Show("Kein Internet ");
}
    }

    private void EndStationComboBox_KeyUp(object sender, KeyEventArgs e)
    {



    try
    {
        if (EndStationComboBox.Text != "")
            {

                EndStationComboBox.Items.Clear();

                EndStationComboBox.SelectionStart = EndStationComboBox.Text.Length;
                var EndStationsVorschläge = VerbindugZurKlasse_ÖV.StationHerausfinden(EndStationComboBox.Text);



                foreach (SwissTransport.Models.Station Station in EndStationsVorschläge.StationList)
                {
                    if (Station.Name != null)
                    {
                        EndStationComboBox.Items.Add(Station.Name);

                    }


                }
            }
    }
        catch
    {
        MessageBox.Show("Kein Internet ");
    }
}

    private void MailButton_Click(object sender, EventArgs e)
    {

    try
    {
        string s = "";

 
        foreach (DataGridViewRow row in VerbindungSuchenDataGridView.Rows)
        {
        foreach( var cell in row.Cells)
            {
                s+=cell.CE;
            }
            
            
        }
            Process.Start(new ProcessStartInfo($"mailto:{""}?body={s}") { UseShellExecute = true });
}
        catch
{
    MessageBox.Show("Kein Internet ");
}
    }
private void GewählteUhrzeit_ValueChanged(object sender, EventArgs e)
    {

    }

    private void WebView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}



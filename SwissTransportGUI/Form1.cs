using System.Diagnostics;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace SwissTransportGUI;

public partial class Form1 : Form
{
    private readonly �V_Verbindungen_StationSuchen_Abfahrtstafel VerbindugZurKlasse_�V = new();
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
            var Verbindungen = VerbindugZurKlasse_�V.VerbindungSuchen(StartStationComboBox.Text, EndStationComboBox.Text, Gew�hlteUhrzeit.Value, UhrZeit.Value);

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
            var Stationen = VerbindugZurKlasse_�V.StationHerausfinden(AbfahrtstafelTextBox.Text);
            var Scho = VerbindugZurKlasse_�V.Abfahrtstafel(AbfahrtstafelTextBox.Text, Stationen.StationList.First().Id);
            var x = 0;
            foreach (var Name in Scho.Entries)
            {
                if (x != 5)
                {
                    var Verbindungen = VerbindugZurKlasse_�V.VerbindungSuchen(AbfahrtstafelTextBox.Text, Name.To, Gew�hlteUhrzeit.Value, UhrZeit.Value);
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
                var StartStationVorschl�ge = VerbindugZurKlasse_�V.StationHerausfinden(StartStationComboBox.Text);



                foreach (SwissTransport.Models.Station Station in StartStationVorschl�ge.StationList)
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
                var EndStationsVorschl�ge = VerbindugZurKlasse_�V.StationHerausfinden(EndStationComboBox.Text);



                foreach (SwissTransport.Models.Station Station in EndStationsVorschl�ge.StationList)
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
private void Gew�hlteUhrzeit_ValueChanged(object sender, EventArgs e)
    {

    }

    private void WebView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}



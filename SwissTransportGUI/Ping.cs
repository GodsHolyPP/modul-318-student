using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace SwissTransportGUI
{
    public class Ping
    {

         public bool Pingfilter()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private PingReply Send(string host, int timeout, byte[] buffer, PingOptions pingOptions)
        {
            throw new NotImplementedException();
        }
    }
}

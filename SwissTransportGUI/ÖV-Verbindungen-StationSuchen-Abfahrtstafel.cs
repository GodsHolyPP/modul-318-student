using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    public class ÖV_Verbindungen_StationSuchen_Abfahrtstafel
    {
        ITransport transport = new Transport();
       
       // Transport transport = new Transport();

        public Connections VerbindungSuchen(string StationsName,string  EndStation, DateTime date,DateTime time){
         
         
            return transport.GetConnections(StationsName, EndStation, date, time);
      

   
                    }

   public Stations StationHerausfinden(string Abfahrtstafel ){

     
            return transport.GetStations(Abfahrtstafel);

        }
        public StationBoardRoot Abfahrtstafel(string Abfahrtstafel, string id)
        {


            return transport.GetStationBoard(Abfahrtstafel, id);

        }


    }
}

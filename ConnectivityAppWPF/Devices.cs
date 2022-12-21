using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConnectivityAppWPF
{
    internal class Devices
    {
        public string DeviceLocation { get; set; }
        public string Station { get; set; }
        public string DeviceType { get; set; }
        public string DeviceID { get; set; }
        public string ControlUnit { get; set; }
        public string PLCrevision { get; set; }
        public string IoTport { get; set; }
        public string IPadress { get; set; }
        public string MacAdress { get; set; }
        public string LastBackUp { get; set; }
        public string Link { get; set; }
        public string Comment { get; set; }

        public Devices(string deviceLocation, string station, string deviceType, string deviceID, string controlUnit, string pLCrevision, string ioTport, string iPadress, string macAdress, string lastBackUp, string link, string comment)
        {
            DeviceLocation = deviceLocation;
            Station = station;
            DeviceType = deviceType;
            DeviceID = deviceID;
            ControlUnit = controlUnit;
            PLCrevision = pLCrevision;
            IoTport = ioTport;
            IPadress = iPadress;
            MacAdress = macAdress;
            LastBackUp = lastBackUp;
            Link = link;
            Comment = comment;
        }
    }
}

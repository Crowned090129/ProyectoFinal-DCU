using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;

namespace BusApp.Common
{
    public class AdmBus
    {
        AutobusManager autobusManager = null;

        public List<AutoBus> GetAutoBuses(string code = "") 
        {
            autobusManager = new AutobusManager("BUS_GET");
            List<AutoBus> buses = new List<AutoBus>();

            if(code != "")
                buses = autobusManager.Get(code);
            else
               buses = autobusManager.Get();

            autobusManager.Dispose();
            return buses;
        }

        public void AutoBusesPut(int opt, AutoBus bus) 
        {
            autobusManager = new AutobusManager("BUS_PUT");
            autobusManager.Put(opt, bus);
            autobusManager.Dispose();
        }
    }
}

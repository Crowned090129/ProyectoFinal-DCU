using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;

namespace BusApp.Common
{
    public class AdmConductor
    {
        ConductorManager conductorManager = null;

        public List<ConductorPersona> GetConductor(string code = "")
        {
            conductorManager = new ConductorManager("CONDUCTOR_GET");
            List<ConductorPersona> conductor = new List<ConductorPersona>();

            if (code != "")
                conductor = conductorManager.Get(code);
            else
                conductor = conductorManager.Get();

            conductorManager.Dispose();
            return conductor;
        }

        public void ConductorPut(int opt, ConductorPersona conductorPersona)
        {
            conductorManager = new ConductorManager("CONDUCTOR_PUT");
            conductorManager.Put(opt, conductorPersona);
            conductorManager.Dispose();
        }
    }
}

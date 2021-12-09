using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;


namespace BusApp.Common
{
    public class AdmRuta
    {
        RutaManager rutaManager = null;

        public List<Ruta> GetRutas(string code = "")
        {
            rutaManager = new RutaManager("RUTA_GET");
            List<Ruta> rutas = new List<Ruta>();

            if (code != "")
                rutas = rutaManager.Get(code);
            else
                rutas = rutaManager.Get();

            rutaManager.Dispose();
            return rutas;
        }

        public void RutaPut(int opt, Ruta ruta)
        {
            rutaManager = new RutaManager("RUTA_PUT");
            rutaManager.Put(opt, ruta);
            rutaManager.Dispose();
        }
    }
}

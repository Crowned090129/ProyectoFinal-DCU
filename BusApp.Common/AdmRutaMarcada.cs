using BusApp.Data.Entities;
using BusApp.Data.Managers;
using System.Collections.Generic;

namespace BusApp.Common
{
    public class AdmRutaMarcada
    {
        RutaMarcadaManager rutaManager = null;

        public List<RutaMarcada> GetRutasMarcadas(string code = "")
        {
            rutaManager = new RutaMarcadaManager("RUTA_MARCADA_GET");
            List<RutaMarcada> rutas = new List<RutaMarcada>();

            if (code != "")
                rutas = rutaManager.Get(code);
            else
                rutas = rutaManager.Get();

            rutaManager.Dispose();
            return rutas;
        }

        public void RutaMarcadasPut(int opt, RutaMarcada ruta)
        {
            rutaManager = new RutaMarcadaManager("SPC_RUTAS_MARCADAS_PUT");
            rutaManager.Put(opt, ruta);
            rutaManager.Dispose();
        }
    }
}

using System;

namespace BusApp.Data.Entities
{
    public class Ruta : IRuta
    {
        public int RUTA_ID { get; set; }
        public string RUTA_COD { get; set; }
        public string COODENADAS_INICIO { get; set; }
        public string COORDENADAS_FIN { get; set; }
        public bool Activo { get; set; }
        public DateTime Ctrl_F_Inserted { get; set; }
        public bool Ctrl_L_Deleted { get; set; }
    }
}

using System;

namespace BusApp.Data.Entities
{
    public class RutaMarcada : IRutaMarcada_V1, IRutaMarcada_V2
    {
        public int RUTA_MARCADA_ID { get; set; }
        public string RUTA_COD { get; set; }
        public int RUTA_ID { get; set; }
        public int CONDUCTOR_ID { get; set; }
        public int AUTOBUS_ID { get; set; }
        public int UserId { get; set; }
        public DateTime Ctrl_F_Inserted { get; set; }
        public bool Ctrl_L_Deleted { get; set; }
        public string RUTA_MARCADA_COD { get; set; }
        public string COODENADAS_INICIO { get; set; }
        public string COORDENADAS_FIN { get; set; }
        public string Conductor_COD { get; set; }
        public string ConductorNombre { get; set; }
        public string Autobus_COD { get; set; }
    }
}

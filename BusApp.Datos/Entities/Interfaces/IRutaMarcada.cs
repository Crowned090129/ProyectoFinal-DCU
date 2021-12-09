using System;

namespace BusApp.Data.Entities
{
    public interface IRutaMarcada_V1
    {
        int RUTA_MARCADA_ID { get; set; }
        string RUTA_COD { get; set; }
        int RUTA_ID { get; set; }
        int CONDUCTOR_ID { get; set; }
        int AUTOBUS_ID { get; set; }
        int UserId { get; set; }
        DateTime Ctrl_F_Inserted { get; set; }
        bool Ctrl_L_Deleted { get; set; }
    }

    public interface IRutaMarcada_V2
    {
        int RUTA_MARCADA_ID { get; }
        string RUTA_MARCADA_COD { get; }
        string RUTA_COD { get; }
        string COODENADAS_INICIO { get; }
        string COORDENADAS_FIN { get; }
        string Conductor_COD { get; }
        string ConductorNombre { get; }
        string Autobus_COD { get; }
        int UserId { get; }
        DateTime Ctrl_F_Inserted { get; set; }
    }
}

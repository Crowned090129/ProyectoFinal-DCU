using System;

namespace BusApp.Data.Entities
{
    public interface IRuta
    {
        int RUTA_ID { get; set; }
        string RUTA_COD { get; set; }
        string COODENADAS_INICIO { get; set; }
        string COORDENADAS_FIN { get; set; }
        bool Activo { get; set; }
        DateTime Ctrl_F_Inserted { get; set; }
        bool Ctrl_L_Deleted { get; set; }
    }
}

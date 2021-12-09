using System;

namespace BusApp.Data.Entities
{
    internal interface IConductorPersona
    {
        string PersonCOD { get; set; }
        string Conductor_COD { get; set; }
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DateTime Fecha_de_nacimiento { get; set; }
        bool Activo { get; set; }
        DateTime Ctrl_F_Inserted { get; set; }
    }
}

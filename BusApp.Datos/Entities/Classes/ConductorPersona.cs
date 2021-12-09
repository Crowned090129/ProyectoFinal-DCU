using System;

namespace BusApp.Data.Entities
{
    public class ConductorPersona : IConductorPersona
    {
        public string PersonCOD { get; set; }
        public string Conductor_COD { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_de_nacimiento { get; set; }
        public bool Activo { get; set; }
        public DateTime Ctrl_F_Inserted { get; set; }
    }
}

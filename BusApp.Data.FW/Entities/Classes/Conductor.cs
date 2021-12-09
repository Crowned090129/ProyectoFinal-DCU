using System;

namespace BusApp.Data.Entities
{
    public class Conductor : IConductor
    {
        public int Id_conductor { get; set; }
        public string Conductor_COD { get; set; }
        public int Id_Persona { get; set; }
        public bool Activo { get; set; }
        public DateTime Ctrl_F_Inserted { get; set; }
        public bool Ctrl_L_Deleted { get; set; }
    }
}

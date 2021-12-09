using System;

namespace BusApp.Data.Entities
{
    public interface IConductor
    {
        int Id_conductor { get; set; }
        string Conductor_COD { get; set; }
        int Id_Persona { get; set; }
        bool Activo { get; set; }
        DateTime Ctrl_F_Inserted { get; set; }
        bool Ctrl_L_Deleted { get; set; }

    }
}

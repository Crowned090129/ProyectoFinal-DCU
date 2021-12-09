using System;

namespace BusApp.Data.Entities
{
    internal interface IAutoBus
    {
        int Id_Autobus { get; set; }
        string BUS_CODE { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        string Placa { get; set; }
        string Color { get; set; }
        DateTime Año { get; set; }
        bool Activo { get; set; }
        DateTime Ctrl_F_Inserted { get; set; }
        bool Ctrl_L_Deleted { get; set; }
    }
}

using System;

namespace BusApp.Data.Entities
{
    public class AutoBus : IAutoBus
    {
        public int Id_Autobus { get; set; }
        public string BUS_CODE { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public DateTime Año { get; set; }
        public bool Activo { get; set; }
        public DateTime Ctrl_F_Inserted { get; set; }
        public bool Ctrl_L_Deleted { get; set; }
    }
}

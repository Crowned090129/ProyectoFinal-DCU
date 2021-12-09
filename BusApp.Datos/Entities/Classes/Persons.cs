using System;

namespace BusApp.Data.Entities
{
    internal class Persons : IPersons
    {
        public int PersonId { get; set; }
        public string PersonCOD { get; set; }
        public string Cedula { get; set; }
        public int FaceId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_de_nacimiento { get; set; }
    }
}

using System;

namespace BusApp.Data.Entities
{
    public interface IPersons
    {
        int PersonId { get; set; }
        string PersonCOD { get; set; }
        string Cedula { get; set; }
        int FaceId { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        DateTime Fecha_de_nacimiento { get; set; }

    }
}

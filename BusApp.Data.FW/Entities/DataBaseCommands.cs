using System.Collections.Generic;
using System.Linq;

namespace BusApp.Data
{
    public abstract class DataBaseCommands
    {
        // BUS DATABASE PROCEDURES 
        readonly static List<KeyValuePair<string, string>> CommandList = new List<KeyValuePair<string, string>>()
        {
            // BUS
            new KeyValuePair<string, string>("BUS_GET", "SPC_BUS_GET"),
            new KeyValuePair<string, string>("BUS_PUT", "SPC_BUS_PUT"),

            //Conductores

            new KeyValuePair<string, string>("CONDUCTOR_GET", "SPC_CONDUCTORES_GET"),
            new KeyValuePair<string, string>("CONDUCTOR_PUT", "SPC_CONDUCTORES_PUT"),

            // Rutas
            new KeyValuePair<string, string>("RUTA_GET", "SPC_RUTA_GET"),
            new KeyValuePair<string, string>("RUTA_PUT", "SPC_RUTA_PUT"),

            // Rutas Marcadas
            new KeyValuePair<string, string>("RUTA_MARCADA_GET", "SPC_RUTA_MARCADA_GET"),
            new KeyValuePair<string, string>("RUTA_MARCADA_PUT", "SPC_RUTA_MARCADA_GET"),

            // Users
            new KeyValuePair<string, string>("USER_GET", "SPC_USERS_GET"),
            new KeyValuePair<string, string>("USER_PUT", "SPC_USERS_PUT"),
        };

        public static string GetCommand(string CommandName) 
        {
            return CommandList.Where(cmdName => cmdName.Key == CommandName).First().Value;
        }
    }
}

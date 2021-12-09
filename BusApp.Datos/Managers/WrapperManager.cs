using System.Configuration;

namespace BusApp.Data.Managers
{
    public class WrapperManager
    {
        public string ConnectionString { get; set; }
        public string CommandDetail { get; set; }

        public WrapperManager(string command)
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnString"]?.Trim();
            CommandDetail = DataBaseCommands.GetCommand(command);
        }
    }
}

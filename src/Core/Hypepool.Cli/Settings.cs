using System.Collections.Generic;

namespace Hypepool.Cli
{
    //todo: this is an example of reading yaml config. Make interface and proper Settings properties
    public class Settings
    {
        public Settings()
        {
        }

        public string LogPath { get; set; }
        public int ApiPort { get; set; }

        public List<Daemon> Daemons { get; set; }
    }

    public class Daemon
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

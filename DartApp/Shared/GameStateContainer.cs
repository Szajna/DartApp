using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartApp.Shared
{
    public class GameStateContainer
    {
        public string GameName { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public List<int> Darts { get; set; } = new List<int>();
    }
}

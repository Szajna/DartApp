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
        public int TurnCount { get; set; }

        public void ClearGameState()
        {
            Players.Clear();
            GameName = string.Empty;
            TurnCount = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartApp.Shared
{
    public class Player
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int AvgScore { get; set; }
        public int TopScore { get; set; }
        public List<int> ScoreHistory { get; set; } = new List<int>();
        public Player()
        {
            Id = new Guid().ToString();
        }
    }
}

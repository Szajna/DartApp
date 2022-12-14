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
        public double AvgScore { get; set; }
        public int TopScore { get; set; }
        public List<int> ScoreHistory { get; set; } = new List<int>();
        public Player()
        {
            Id = new Guid().ToString();
            AvgScore = 0;
            TopScore = 0;
        }

        public void AddScore(int? newScore)
        {
            Score = Score - newScore ?? Score;
            ScoreHistory.Add(newScore ?? 0);
            AvgScore = Math.Round(ScoreHistory.Average(), 2);
            if (TopScore < newScore)
            {
                TopScore = newScore.Value;
            }
        }
    }
}

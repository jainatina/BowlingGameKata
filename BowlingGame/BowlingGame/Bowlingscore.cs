using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingScore
    {
        private int score;

        public BowlingScore()
        {
            score = 0;
        }

        public void Roll(int pins)
        {
            score = score + pins;
        }

        public int GetScore()
        {
            return score;        } 

    }
}

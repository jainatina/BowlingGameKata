using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class BowlingScore
    {

        private int[] rolls;
        private int curRoll;

        public BowlingScore()
        {
            rolls = new int[21];
            curRoll = 0;

            //rolls = new List<int>(21);
            //score = 0;
        }

        public void Roll(int pins)
        {
            rolls[curRoll] = pins;
            curRoll++;
            //rolls.Add(pins);
            //score = score + pins;
        }

        public int GetScore()
        {
            int score = 0;
            int rollCount = 0;

            for (var frame = 0; frame < 10; frame++)
            {

                if (rolls[rollCount] == 10)
                {
                    score = score + rolls[rollCount] + rolls[rollCount + 1] + rolls[rollCount + 2];
                    rollCount = rollCount + 1;
                }
                else if (rolls[rollCount] + rolls[rollCount + 1] == 10)
                {
                    score = score + rolls[rollCount] + rolls[rollCount + 1] + rolls[rollCount + 2];
                    rollCount = rollCount + 2;
                }

                else
                {
                    score = score + rolls[rollCount] + rolls[rollCount + 1];
                    rollCount = rollCount + 2;
                }


            }

            return score;
        }

    }
}

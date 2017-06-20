using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace UnitTestProject1
{
    [TestClass]
    public class BowlingTesting
    {
        [TestMethod]
        public void ZeroScore()
        {
            var score = new BowlingScore();

            for (var i = 0; i < 20; i++)
            {
                score.Roll(0);
            }

            Assert.AreEqual(0, score.GetScore());
        }

        [TestMethod]
        public void AllOnes()
        {
            var score = new BowlingScore();

            for (var i = 0; i < 20; i++)
            {
                score.Roll(1);
            }

            Assert.AreEqual(20, score.GetScore());
        }
        [TestMethod]
        public void AllTwos()
        {
            var score = new BowlingScore();

            for (var i = 0; i < 20; i++)
            {
                score.Roll(2);
            }

            Assert.AreEqual(40, score.GetScore());
        }
        [TestMethod]
        public void Spares()
        {
            var score = new BowlingScore();

            score.Roll(4);
            score.Roll(6);
            score.Roll(3);

            Assert.AreEqual(16, score.GetScore());

        }

        [TestMethod]
        public void ResetScore()
        {
            var score = new BowlingScore();

            score.Roll(3);
            score.Roll(3);
            score.GetScore();

            Assert.AreEqual(6, score.GetScore());

        }

        [TestMethod]
        public void Strike()
        {
            var score = new BowlingScore();

            score.Roll(10);
            score.Roll(3);
            score.Roll(3);

            Assert.AreEqual(22, score.GetScore());

        }

        [TestMethod]
        public void LastStrike()
        {
            var score = new BowlingScore();

            for (int i = 0; i < 12; i++)
            {
                score.Roll(10);
            }

            Assert.AreEqual(300, score.GetScore());

        }
    }
}

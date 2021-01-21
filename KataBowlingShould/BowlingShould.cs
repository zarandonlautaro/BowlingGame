using NUnit.Framework;
using kata_bowling_game;

namespace KataBowlingShould
{
    public class Tests
    {
        Bowling bowling;
        [SetUp]
        public void Setup()
        {
            bowling = new Bowling();

        }


        [Test]
        public void PointsWithoutStrikeAndSpare()
        {
            int[,] scores = new int[10, 2] { 
                { 5, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 } 
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(53 , points);
        }
        [Test]
        public void PointsWithoutStrikeAndSpareAgain()
        {
            int[,] scores = new int[10, 2] {
                { 5, 3 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(52, points);
        }
        [Test]
        public void PointsWithSpare()
        {
            int[,] scores = new int[10, 2] {
                { 5, 5 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(59, points);
        }
        [Test]
        public void PointsWithStrike()
        {
            int[,] scores = new int[10, 2] {
                { 10, 0 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(61, points);
        }
        [Test]
        public void PointsSpareInLastThrow()
        {
            int[,] scores = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 5, 5 }, { 1, 0 }
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(57, points);
        }
        [Test]
        public void PointsStrikeInLastThrow()
        {
            int[,] scores = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 10, 0 }, { 5, 3 }
            };
            int points = bowling.GetScore(scores);
            Assert.AreEqual(71, points);
        }
    }
}
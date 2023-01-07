using BowlingBall.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BowlingBall.Test
{
    [TestClass]
    public class BowlingBallTest
    {
        private Game _game;
        private RuleEngine _ruleEngine;

        [TestInitialize]
        public void TestInitialize()
        {
            _game = new Game();
            _ruleEngine = new RuleEngine();
        }

        [TestMethod]
        public void TestRegularFrameRule_ZeroScore()
        {
            _game.Frames = new List<Frame>
             {
                 new Frame { FirstRoll = 0, SecondRoll = 0 }
             };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(0, _game.Frames[0].Score);
            Assert.AreEqual(0, _game.Score);
        }

        [TestMethod]
        public void TestRegularFrameRule_OneGutter()
        {
            _game.Frames = new List<Frame>
             {
                 new Frame { FirstRoll = 0, SecondRoll = 7 }
             };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(7, _game.Frames[0].Score);
            Assert.AreEqual(7, _game.Score);
        }

        [TestMethod]
        public void TestRegularFrameRule()
        {
            _game.Frames = new List<Frame>
             {
                 new Frame { FirstRoll = 3, SecondRoll = 4 }
             };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(7, _game.Frames[0].Score);
            Assert.AreEqual(7, _game.Score);
        }

        [TestMethod]
        public void TestRegularFrameRule_MultiFrames()
        {
            _game.Frames = new List<Frame>
             {
                 new Frame { FirstRoll = 3, SecondRoll = 4 }
             };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(7, _game.Frames[0].Score);
            Assert.AreEqual(7, _game.Score);
        }

        [TestMethod]
        public void TestSpareFrameRule()
        {
            _game.Frames = new List<Frame>
             {
                 new Frame { FirstRoll = 3, SecondRoll = 7 },
                 new Frame { FirstRoll = 4, SecondRoll = 5 }
             };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(14, _game.Frames[0].Score);
            Assert.AreEqual(23, _game.Score);
        }

        [TestMethod]
        public void TestStrikeFrameRule()
        {
            _game.Frames = new List<Frame>
            {
                new Frame { FirstRoll = 10 },
                new Frame { FirstRoll = 3, SecondRoll = 4 }
            };

            _ruleEngine.CalculateScore(_game);

            Assert.AreEqual(17, _game.Frames[0].Score);
            Assert.AreEqual(24, _game.Score);
        }
    }
}

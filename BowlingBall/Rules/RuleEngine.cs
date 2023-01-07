using System.Collections.Generic;
using System.Linq;

namespace BowlingBall.Rules
{
    /// <summary>
    /// Decides which rule to execute based on rule formula
    /// </summary>
    public class RuleEngine
    {
        private readonly List<IRule> _rules;

        public RuleEngine()
        {
            _rules = new List<IRule>
            {
                 new StrikeFrameRule(),
                 new SpareFrameRule(),
                 new RegularFrameRule()
            };
        }

        public void CalculateScore(Game game)
        {
            foreach (var frame in game.Frames)
            {
                var rule = _rules.First(r => r.IsMatch(frame));
                frame.Score = rule.CalculateScore(frame, game.Frames);
                game.Score += frame.Score;
            }
        }
    }
}

using System.Collections.Generic;

namespace BowlingBall.Rules
{
    public class RegularFrameRule : IRule
    {
        public bool IsMatch(Frame frame)
        {
            return (frame.FirstRoll.HasValue && frame.SecondRoll.HasValue) && frame.FirstRoll.GetValueOrDefault() + frame.SecondRoll.GetValueOrDefault() < 10;
        }

        public int CalculateScore(Frame frame, List<Frame> frames)
        {
            return frame.FirstRoll.GetValueOrDefault() + frame.SecondRoll.GetValueOrDefault();
        }
    }
}

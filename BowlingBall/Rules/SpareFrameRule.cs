using System.Collections.Generic;

namespace BowlingBall.Rules
{
    public class SpareFrameRule : IRule
    {
        public bool IsMatch(Frame frame)
        {
            return (frame.FirstRoll.HasValue && frame.SecondRoll.HasValue) && frame.FirstRoll + frame.SecondRoll == 10 ;
        }

        public int CalculateScore(Frame frame, List<Frame> frames)
        {
            return 10 + frames[frames.IndexOf(frame) + 1].FirstRoll.GetValueOrDefault();
        }
    }
}

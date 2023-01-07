using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Rules
{
    public class StrikeFrameRule : IRule
    {
        public bool IsMatch(Frame frame)
        {
            return frame.FirstRoll == 10;
        }

        public int CalculateScore(Frame frame, List<Frame> frames)
        {
            return 10 + frames[frames.IndexOf(frame) + 1].FirstRoll.GetValueOrDefault() + frames[frames.IndexOf(frame) + 1].SecondRoll.GetValueOrDefault();
        }
    }
}

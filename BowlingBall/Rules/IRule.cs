using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Rules
{
    public interface IRule
    {
     /// <summary>
     /// Return true if rules matches
     /// </summary>
     /// <param name="frame"></param>
     /// <returns></returns>
        bool IsMatch(Frame frame);

        /// <summary>
        /// Calculate total score of game
        /// </summary>
        /// <param name="frame"></param>
        /// <param name="frames"></param>
        /// <returns></returns>
        int CalculateScore(Frame frame, List<Frame> frames);
    }
}

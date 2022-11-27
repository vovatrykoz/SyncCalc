using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncCalc
{
    public class BeatsCalculator
    {
        public double CalculateBeatsPerMinute(double startSeconds, int startFrames, double endSeconds, int endFrames, double beats, double framerate)
        {
            double output;

            output = (beats * (framerate * 60)) / (((endSeconds * framerate) + endFrames) - ((startSeconds * framerate) + startFrames));

            output  = Math.Round(output, 3);

            return output;
        }

        public double CalculateBeats(double startSeconds, int startFrames, double endSeconds, int endFrames, double bpm, double framerate)
        {
            double output;

            output = (bpm * (((endSeconds * framerate) + endFrames) - ((startSeconds * framerate) + startFrames)))/(framerate * 60);

            output = Math.Round(output, 3);

            return output;
        }
    }
}

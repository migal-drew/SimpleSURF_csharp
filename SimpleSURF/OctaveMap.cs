using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class OctaveMap
    {
        public static int INTERVALS = 0x03;
        /*
        public static int FILTER_MIN_SIZE = 0x9;
        public static int FILTER_INCR =  0x6;
        public static int MIN_LONGER_SIDE = 0x5;
        public static int INCR_LONGER_SIDE = 0x4;
        */
        //Set of the octave layers
        public OctaveLayer[] map;

        public bool pointIsExtremum(int row, int col,
            OctaveLayer bot, OctaveLayer mid, OctaveLayer top, double threshold)
        {
            double curPoint = mid.detHessians[row, col];
            //Hessian should be higher than threshold
            if (curPoint < threshold)
                return false;

            //Hessian should be higher than hessians of all neighbours 
            for (int i = -1; i <= 1; i++) {
                for (int j = -1; j <= 1; j++) {
                    double topPoint = top.detHessians[row + i, col + j];
                    double midPoint = mid.detHessians[row + i, col + j];
                    double botPoint = bot.detHessians[row + i, col + j];

                    if (topPoint >= curPoint || botPoint >= curPoint)
                        return false;

                    if (i != 0 && j != 0) 
                        if (midPoint >= curPoint)
                            return false;
                }
            }

            return true;
        }
    }
}

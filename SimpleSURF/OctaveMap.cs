using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class OctaveMap
    {
        public static int INTERVALS = 0x04;

        //Set of the octave layers
        public OctaveLayer[] map;

        private IntegImage img;

        public OctaveMap(int octaveNum, IntegImage img, int imgWidth, int imgHeight)
        {
            this.img = img;
            this.map = new OctaveLayer[INTERVALS];
            for (int i = 0; i < INTERVALS; i++)
                map[i] = new OctaveLayer(octaveNum, i + 1, imgWidth, imgHeight);
        }

        public void computeMap()
        {
            for (int i = 0; i < INTERVALS; i++)
                map[i].computeLayer(img);
        }

        public bool pointIsExtremum(int row, int col,
            OctaveLayer bot, OctaveLayer mid, OctaveLayer top, double threshold)
        {
            //Check that point in middle layer has all neighbours
            if (row <= top.radius || col <= top.radius ||
                row + top.radius >= top.height || col + top.radius >= top.width)
                return false;

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

                    if (i != 0 || j != 0) 
                        if (midPoint >= curPoint)
                            return false;
                }
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class OctaveLayer
    {
        public static int filterMinSize = 9;
        //Octave which contains this layer
        public int octaveNum;
        //Length of the side of filter
        public int filterSize;
        //Scale for this layer. Hessian is computed for points which are located
        //between each other on distance of <scale> pixels
        public int scale;
        //Image width / scale
        public int width;
        //Image height / scale
        public int height;

        public double[,] detHessians;
        public int[,] signs;

        /// <summary>
        /// Creates layer of octave
        /// (octave and interval numbers start with one)
        /// </summary>
        /// <param name="octave">Number of octave which contains this layer</param>
        /// <param name="interval">Number in octave(number of interval in octave)</param>
        /// <param name="imgWidth">Width of image in pixels</param>
        /// <param name="imgHeight">Height of image in pixels</param>
        public OctaveLayer(int octave, int interval, int imgWidth, int imgHeight)
        {
            this.octaveNum = octave;
            this.filterSize = 3 * ((int)Math.Pow(2, octave) * interval + 1);
            this.scale = (int)Math.Pow(2, octave);
            this.width = imgWidth / scale;
            this.height = imgHeight / scale;
            this.detHessians = new double[this.height, this.width];
            this.signs = new int[this.height, this.width];
        }

        public void computeLayer(IntegImage img)
        {
            //Values of Fast Hessian filters
            double dxx, dyy, dxy;
            //Useful values for faster computation of filters
            int lobe = this.filterSize / 3;
            int radius = (this.filterSize - 1) / 2;
            //Length of the longer side of the lobe in dxx and dyy filters
            //int longerSide = OctaveMap.MIN_LONGER_SIDE + OctaveMap.INCR_LONGER_SIDE * (
                //(this.filterSize - OctaveMap.FILTER_MIN_SIZE) / OctaveMap.FILTER_INCR);
            int longPart = 2 * lobe - 1;
            int normalization = this.filterSize * this.filterSize;

            int imgHeight = height * scale;
            int imgWidth = width * scale;
            int curRow = 0; 
            int curCol = 0;
            for (int r = radius; r < imgHeight; r += scale) {
                for (int c = radius; c < imgWidth; c += scale) {

                    dxx = img.getRectSum(r - lobe + 1, c - radius, filterSize, longPart)
                        - 3 * img.getRectSum(r - lobe + 1, c - (lobe - 1) / 2, lobe, longPart);
                    dyy = img.getRectSum(r - radius, c - lobe - 1, longPart, filterSize)
                        - 3 * img.getRectSum(r - lobe + 1, c - lobe + 1, longPart, lobe);
                    dxy = img.getRectSum(r - lobe, c - lobe, lobe, lobe)
                        + img.getRectSum(r + 1, c + 1, lobe, lobe)
                        - img.getRectSum(r - lobe, c + 1, lobe, lobe)
                        - img.getRectSum(r + 1, c - lobe, lobe, lobe);

                    this.detHessians[curRow, curCol] =
                        dxx * dyy - 0.9 * 0.9 * dxy * dxy;
                    this.signs[curRow, curCol] = (dxx + dyy >= 0) ? 1 : -1;
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class OctaveLayer
    {
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
        public int[,] laplacians;

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
        }

        public void computeHessians(IntegImage img)
        {
            for (int r = 0; r < height; r+=scale) {
                for (int c = 0; c < width; c+=scale) {
                    
                }
            }
        }


    }
}

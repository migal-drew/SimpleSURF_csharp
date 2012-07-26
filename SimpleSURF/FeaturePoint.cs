using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class FeaturePoint
    {
        public static int DESC_SIZE = 64;

        //Coordinates of point
        public int x;
        public int y;
        public int scale;
        public int radius;

        public double[] descriptor;
        

        public FeaturePoint()
        {
            this.descriptor = new double[DESC_SIZE];
        }

        public FeaturePoint(int x, int y, int scale, int radius)
        {
            this.x = x;
            this.y = y;
            this.scale = scale;
            this.radius = radius;
            this.descriptor = new double[DESC_SIZE];
        }
            
    }
}

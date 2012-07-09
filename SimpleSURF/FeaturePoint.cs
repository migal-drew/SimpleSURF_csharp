using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    class FeaturePoint
    {
        public static int DESC_SIZE = 64;

        //Coordinates of point
        public int x;
        public int y;

        public double[] descriptor;
        

        public FeaturePoint()
        {
            this.descriptor = new double[DESC_SIZE];
        }

        public FeaturePoint(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.descriptor = new double[DESC_SIZE];
        }
            
    }
}

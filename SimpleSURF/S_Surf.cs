using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSURF
{
    public class S_Surf
    {
        private double threshold;
        private int octaveStart;
        private int octaveEnd;
        private OctaveMap octMap;

        public S_Surf(int octaveStart, int octaveEnd, double threshold)
        {
            this.threshold = threshold;
            this.octaveStart = octaveStart;
            this.octaveEnd = octaveEnd;
        }

        public List<FeaturePoint> extractPoints(IntegImage img, int imgWidth, int imgHeight)
        {
            List<FeaturePoint> resPoints = new List<FeaturePoint>();

            this.octMap = new OctaveMap(octaveStart, img, imgWidth, imgHeight);
            this.octMap.computeMap();

            for (int k = 0; k < OctaveMap.INTERVALS - 2; k++)
            {
                OctaveLayer bot = octMap.map[k];
                OctaveLayer mid = octMap.map[k + 1];
                OctaveLayer top = octMap.map[k + 2];

                for (int i = 0; i < mid.height; i++)
                    for (int j = 0; j < mid.width; j++)
                        if (octMap.pointIsExtremum(i, j, bot, mid, top, this.threshold))
                        {
                            octMap.pointIsExtremum(i, j, bot, mid, top, this.threshold);
                            resPoints.Add(new FeaturePoint(j, i, mid.scale, mid.radius));
                        }
            }
            return resPoints;
        }
    }
}

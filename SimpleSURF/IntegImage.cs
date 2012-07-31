using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimpleSURF
{
    public class IntegImage
    {
        private double[,] m_matrix;
        public int width;
        public int height;

        public double this[int r, int c]
        {
            get
            { 
                return m_matrix[r, c]; 
            }
            set 
            { 
                m_matrix[r, c] = value;
            }
        }

        public IntegImage(int width, int height)
        {
            m_matrix = new double[height, width];
            this.width = width;
            this.height = height;
        }

        public IntegImage(double[,] ar)
        {
            this.width = ar.GetLength(1);
            this.height = ar.GetLength(0);
            m_matrix = new double[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    double val = ar[i, j];
                    double a = 0, b = 0, c = 0;

                    if (i - 1 >= 0 && j - 1 >= 0)
                        a = m_matrix[i - 1, j - 1];
                    if (j - 1 >= 0)
                        b = m_matrix[i, j - 1];
                    if (i - 1 >= 0)
                        c = m_matrix[i - 1, j];

                    //New value based on previous calculations
                    m_matrix[i, j] = val - a + b + c;
                }
        }

        /// <summary>
        /// Creates double array of pixels brightness
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double[,] arrayFromBitmap(Bitmap b)
        {
            
            int width = b.Width;
            int height = b.Height;
            double[,] pixels = new double[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Color c = b.GetPixel(j, i);
                    double v = (c.R + c.B + c.G) / (3.0 * 255.0);

                    pixels[i, j] = v;
                }

            return pixels;
        }

        /// <summary>
        /// Sum of rectangle. Left top point of rectangle,
        /// its width and height
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double getRectSum(int row, int col, int width, int height)
        {
            double a = 0, b = 0, c = 0, d = 0;

            //Left top point of rectangle is first
            int w = width - 1;
            int h = height - 1;

            //Left top point
            int lt_row = (row <= this.height) ? (row - 1) : -1;
            int lt_col = (col <= this.width) ? (col - 1) : -1;
            //Right bottom point of the rectangle
            int rb_row = (row + h < this.height) ? (row + h) : (this.height - 1);
            int rb_col = (col + w < this.width) ? (col + w) : (this.width - 1);

            if (lt_row >= 0 && lt_col >= 0)
                a = this[lt_row, lt_col];

            if (lt_row >= 0 && rb_col >= 0)
                b = this[lt_row, rb_col];

            if (rb_row >= 0 && rb_col >= 0)
                c = this[rb_row, rb_col];

            if (rb_row >= 0 && lt_col >= 0)
                d = this[rb_row, lt_col];

            /*
            if (row > 0 && col > 0) 
                a = m_matrix[row - 1, col - 1];
            if (row > 0 && col + w < this.width)
                b = m_matrix[row - 1, col + w];
            if (row + h < this.height
                && col + w < m_matrix.GetLength(1) )
                c = m_matrix[row + h, col + w];
            if (row + h < this.height && col > 0)
                d = m_matrix[row + h, col - 1];
            */

            double res = a + c - b - d;

            return (res > 0) ? res : 0; 
        }


        /// <summary>
        /// Horizontal Haar wavelet (X)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public double HaarWavelet_X(int row, int col, int size)
        {
            return this.getRectSum(row, col + size / 2, size / 2, size)
                - this.getRectSum(row, col, size / 2, size);
        }

        /// <summary>
        /// Vertical Haar wavelet (Y)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public double HaarWavelet_Y(int row, int col, int size)
        {
            return this.getRectSum(row + size / 2, col, size, size / 2)
                - this.getRectSum(row, col, size, size / 2);
        }

    }

    
}

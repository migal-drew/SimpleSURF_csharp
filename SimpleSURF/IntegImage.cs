using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimpleSURF
{
    public class IntegImage
    {
        public double[,] m_matrix;

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
            m_matrix = new double[width, height];
        }

        public IntegImage(double[,] ar)
        {
            int width = ar.GetLength(1);
            int height = ar.GetLength(0);
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
        /// it's width and height
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
            width -= 1;
            height -=1;

            if (row - 1 >= 0 && col - 1 >= 0) 
                a = m_matrix[row - 1, col - 1];
            if (row - 1 >= 0 && col + width < m_matrix.GetLength(1))
                b = m_matrix[row - 1, col + width];
            if (row + height < m_matrix.GetLength(0)
                && col + width < m_matrix.GetLength(1) )
                c = m_matrix[row + height, col + width];
            if (row + height < m_matrix.GetLength(0) && col - 1 >= 0)
                d = m_matrix[row + height, col - 1];

            return a + c - b - d; 
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

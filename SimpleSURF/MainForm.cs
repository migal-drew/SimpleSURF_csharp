using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleSURF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void drawPoints(Bitmap btmp, List<FeaturePoint> points)
        {
            Graphics g = Graphics.FromImage(btmp);

            foreach (FeaturePoint fp in points)
            {
                //Pen p = new Pen((
                g.DrawEllipse(new Pen(Color.Red), fp.x - fp.radius, fp.y - fp.radius,
                    fp.radius * 2, fp.radius * 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string pathToFile = openFileDialog.FileName;
            
            Bitmap btmp = new Bitmap(pathToFile);
            this.pictureBox1.Image = btmp;

            double[,] ar = IntegImage.arrayFromBitmap(btmp);
            IntegImage img = new IntegImage(ar);
            S_Surf surf = new S_Surf(3, 1, 0.001);
            List<FeaturePoint> points = surf.extractPoints(img, img.width, img.height);

            this.drawPoints(btmp, points);


            /*
            double [,] ar = new double[,] {{1, 3, 4, 2, 5}, {7, 1, 2, 3, 4}, {2, 3, 5, 1, 2}};

            

            double[,] res = i.m_matrix;

            double ans = i.getRectSum(0, 0, 3, 3);
            ans = i.getRectSum(0, 0, 1, 1);
            ans = i.getRectSum(0, 0, 3, 1);
            ans = i.getRectSum(0, 0, 5, 5);
            ans = i.g
             */

            this.Text = "Has been found " + points.Count.ToString() 
                + " cool feature points";
        }
    }
}

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
        private Bitmap m_btmp;
        private Bitmap m_resultBtmp;
        private IntegImage m_integImg;

        private string m_stats;

        public MainForm()
        {
            InitializeComponent();
        }

        private void drawPoints(Bitmap btmp, List<FeaturePoint> points)
        {
            Graphics g = Graphics.FromImage(btmp);

            foreach (FeaturePoint fp in points)
            {
                g.DrawEllipse(new Pen(Color.Red), fp.x - fp.radius, fp.y - fp.radius,
                    fp.radius * 2, fp.radius * 2);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (m_btmp == null)
            {
                MessageBox.Show("Open image first");
                return;
            }

            m_resultBtmp = (Bitmap)m_btmp.Clone();
            m_integImg = new IntegImage(IntegImage.arrayFromBitmap(m_btmp));

            double threshold = Double.Parse(this.txtBoxThreshold.Text);
            int botOctave = Int32.Parse(this.txtBoxBottomOct.Text);
            int topOctave = Int32.Parse(this.txtBoxTopOct.Text);

            S_Surf surf = new S_Surf(botOctave, topOctave, threshold);
            List<FeaturePoint> points = surf.extractPoints(
                m_integImg, m_integImg.width, m_integImg.height);

            this.drawPoints(m_resultBtmp, points);
            this.picBox.Image = m_resultBtmp;
            this.picBox.Invalidate();

            /*
            double [,] ar = new double[,] {{1, 3, 4, 2, 5}, {7, 1, 2, 3, 4}, {2, 3, 5, 1, 2}};
            double[,] res = i.m_matrix;
            double ans = i.getRectSum(0, 0, 3, 3);
            ans = i.getRectSum(0, 0, 1, 1);
            ans = i.getRectSum(0, 0, 3, 1);
            ans = i.getRectSum(0, 0, 5, 5);
            ans = i.g
             */

            this.Text = points.Count.ToString() 
                + " total feature points";

            Dictionary<int, int> statistic = new Dictionary<int, int>();

            for (int i = 0; i < points.Count; i++)
            {
                int specRad = points[i].radius;
                bool isMemorized = false;
                foreach (KeyValuePair<int, int> pair in statistic)
                    if (pair.Key == (specRad * 2 + 1))
                    {
                        isMemorized = true;
                        break;
                    }

                if (!isMemorized)
                {
                    int count = 0;
                    for (int j = 0; j < points.Count; j++)
                    {
                        if (points[j].radius == specRad)
                            count++;
                    }
                    statistic.Add(specRad * 2 + 1, count);
                }
            }

            m_stats = "";
            foreach(KeyValuePair<int, int> pair in statistic)
                m_stats += "Size : " + pair.Key.ToString() + " | " 
                    + pair.Value.ToString() + " points" + "\n";

            MessageBox.Show(m_stats);
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string pathToFile = openFileDialog.FileName;

            if (pathToFile.Equals(""))
                return;

            m_btmp = new Bitmap(pathToFile);
            this.picBox.Image = m_btmp;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_stats);
        }
    }
}

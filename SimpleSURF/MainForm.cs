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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string pathToFile = openFileDialog.FileName;
            
            Bitmap btmp = new Bitmap(pathToFile);

            double[,]  ar = IntegImage.arrayFromBitmap(btmp);
            */

            double [,] ar = new double[,] {{1, 3, 4, 2, 5}, {7, 1, 2, 3, 4}, {2, 3, 5, 1, 2}};

            IntegImage i = new IntegImage(ar);

            double[,] res = i.m_matrix;

            double ans = i.getRectSum(0, 0, 3, 3);
            ans = i.getRectSum(0, 0, 1, 1);
            ans = i.getRectSum(0, 0, 3, 1);
            ans = i.getRectSum(0, 0, 5, 5);
            ans = i.getRectSum(0, 0, 2, 2);
            ans = i.getRectSum(1, 1, 4, 2);

            IntegImage ghug = new IntegImage(ar);
        }
    }
}

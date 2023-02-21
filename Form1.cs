using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionChart
{
    public partial class Form1 : Form
    {
        int a, b, c;
        Graphics graphics;

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            graphics = pictureBox1.CreateGraphics();
            a = Convert.ToInt32(AtextBox.Text);
            b = Convert.ToInt32(CtextBox.Text);
            c = Convert.ToInt32(BtextBox.Text);

            Pen pen = new Pen(Color.Black, 3f);
            Pen penXY = new Pen(Color.Gray, 1f);

            Point[] points = new Point[1000];
            Point[] nPoints = new Point[1000];
            Point[] pointsX = new Point[1000];
            Point[] pointsY = new Point[1000];
            int y,i1;
            for (int i = 0; i < points.Length; i++)
            {
                i1 = 500 - i;

                // points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
                y = 500-(a * i * i + b * i + c);
                points[i] = new Point(i+460, y);
                nPoints[i]= new Point(460 - i, y);
                pointsX[i] = new Point(i, 500);
                pointsY[i] = new Point(460, i);
            }

            graphics.DrawLines(pen, points);
            graphics.DrawLines(pen, nPoints);
            graphics.DrawLines(penXY, pointsX);
            graphics.DrawLines(penXY, pointsY);                         

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Program10
{
    public partial class Form1 : Form
    {
        Graphics Graph1;
        Bitmap image1 = new Bitmap(500, 800);
        Pen Pen1 = new Pen(Color.Black, 1);
        Pen Pen2 = new Pen(Color.Brown, 2);
        Pen Pen3 = new Pen(Color.Cyan, 4);
        Pen Pen4 = new Pen(Color.Purple, 4);
        Font drawFont = new Font("Arial", 12);
        SolidBrush Brush1 = new SolidBrush(Color.Blue);
        SolidBrush Brush2 = new SolidBrush(Color.LightGoldenrodYellow);
        HatchBrush hatchbrush1 = new HatchBrush(HatchStyle.SolidDiamond, Color.Green);
        int i = 0;
        Point point1 = new Point(0, -200);
        Point point2 = new Point(0, 200);
        Point point3 = new Point(-200, 200);
        Point point4 = new Point(0, 0);
        Point point5 = new Point(-200, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void системаКоординатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.Clear(Color.White);
            for (i = -250; i <= 250; i += 50)
            {
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, i + 250, 410);
            }
            for (i = -400; i <= 400; i += 50)
            {
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, 260, 400 - i);
            }
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.DrawLine(Pen1, -250, 0, 250, 0);
            Graph1.DrawLine(Pen1, 0, -400, 0, 400);
            for (int i = -250; i <= 250; i += 50)
            {
                Graph1.DrawEllipse(Pen3, i, 0, 1, 1);
            }
            for (int i = -400; i <= 400; i += 50)
            {
                Graph1.DrawEllipse(Pen3, 0, i, 1, 1);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BMP(*.bmp)|*.bmp";
            saveFileDialog1.ShowDialog();
            image1.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void дугиИСекторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            for (i = 0; i <= 250; i += 10)
                Graph1.DrawLine(Pen1, i, 400, i, 0);
            for (i = 0; i <= 400; i += 10)
                Graph1.DrawLine(Pen1, 0, i, 250, i);
            Graph1.DrawArc(Pen3, 80, 80, 100, 100, 90, 45);
            Graph1.DrawEllipse(Pen3, 130, 130, 1, 1);
            Graph1.DrawPie(Pen4, 30, 40, 100, 100, 175, 110);
        }

        private void путьКонтурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            GraphicsPath GP = new GraphicsPath();
            GP.StartFigure();
            GP.AddLine(-200, 0, -100, -100);
            GP.AddLine(-100, -100, -100, 0);
            GP.AddLine(-100, -100, 0, 0);
            GP.AddLine(0, 0, 100, 0);
            GP.CloseFigure();
            GP.StartFigure();
            GP.AddArc(0, 0, 200, 200, -90, -90);
            GP.AddLine(0, 0, 0, 100);
            GP.AddArc(-200, 0, 200, 200, 0, -90);
            GP.CloseFigure();
            Graph1.DrawPath(Pen2, GP);
        }

        private void простоКонтурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Pen3.Color = colorDialog1.Color;
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.DrawLine(Pen3, -200, 0, -100, -100);
            Graph1.DrawLine(Pen3, -100, -100, -100, 0);
            Graph1.DrawLine(Pen3, -100, -100, 0, 0);
            Graph1.DrawLine(Pen3, 0, 0, 100, 0);
            Graph1.DrawArc(Pen3, 0, 0, 200, 200, -90, -90);
            Graph1.DrawLine(Pen3, 0, 0, 0, 100);
            Graph1.DrawArc(Pen3, -200, 0, 200, 200, 0, -90);
            Graph1.DrawLine(Pen3, 0, 0, -200, 0);
            
        }

        private void hQКонтурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen3.DashStyle = DashStyle.Solid;
            colorDialog1.ShowDialog();
            Pen3.Color = colorDialog1.Color;
            Graph1.PageUnit = GraphicsUnit.Pixel;
            Graph1.SmoothingMode = SmoothingMode.HighQuality;
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.DrawLine(Pen3, -200, 0, -100, -100);
            Graph1.DrawLine(Pen3, -100, -100, -100, 0);
            Graph1.DrawLine(Pen3, -100, -100, 0, 0);
            Graph1.DrawLine(Pen3, 0, 0, 100, 0);
            Graph1.DrawArc(Pen3, 0, 0, 200, 200, -90, -90);
            Graph1.DrawLine(Pen3, 0, 0, 0, 100);
            Graph1.DrawArc(Pen3, -200, 0, 200, 200, 0, -90);
            Graph1.DrawLine(Pen3, 0, 0, -200, 0);
        }

        private void сплошнаяЗаливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            GraphicsPath GP = new GraphicsPath();
            GP.StartFigure();
            GP.AddLine(-200, 0, -100, -100);
            GP.AddLine(-100, -100, -100, 0);
            GP.AddLine(-100, -100, 0, 0);
            GP.AddLine(0, 0, 100, 0);
            GP.CloseFigure();
            GP.StartFigure();
            GP.AddArc(0, 0, 200, 200, -90, -90);
            GP.AddLine(0, 0, 0, 100);
            GP.AddArc(-200, 0, 200, 200, 0, -90);
            GP.CloseFigure();
            Graph1.FillPath(Brush1, GP);
        }

        private void узорнаяЗаливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            GraphicsPath GP = new GraphicsPath();
            GP.StartFigure();
            GP.AddLine(-200, 0, -100, -100);
            GP.AddLine(-100, -100, -100, 0);
            GP.AddLine(-100, -100, 0, 0);
            GP.AddLine(0, 0, 100, 0);
            GP.CloseFigure();
            GP.StartFigure();
            GP.AddArc(0, 0, 200, 200, -90, -90);
            GP.AddLine(0, 0, 0, 100);
            GP.AddArc(-200, 0, 200, 200, 0, -90);
            GP.CloseFigure();
            Graph1.FillPath(hatchbrush1, GP);
        }

        private void градиентнаяЗалливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearGradientBrush LgBrush = new LinearGradientBrush(point3, point1, Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 0, 0));
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            GraphicsPath GP = new GraphicsPath();
            GP.StartFigure();
            GP.AddLine(-200, 0, -100, -100);
            GP.AddLine(-100, -100, -100, 0);
            GP.AddLine(-100, -100, 0, 0);
            GP.AddLine(0, 0, 100, 0);
            GP.CloseFigure();
            GP.StartFigure();
            GP.AddArc(0, 0, 200, 200, -90, -90);
            GP.AddLine(0, 0, 0, 100);
            GP.AddArc(-200, 0, 200, 200, 0, -90);
            GP.CloseFigure();
            Graph1.FillPath(LgBrush, GP);
        }
    }
}
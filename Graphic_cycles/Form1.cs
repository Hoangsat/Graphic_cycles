using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_cycles
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            IniGraph();
        }
        public void IniGraph()
        {
            Bitmap bmp = new Bitmap( pictureBox1.Width, pictureBox1.Height );
            pictureBox1.Image= bmp;
            g= Graphics.FromImage( pictureBox1.Image );
            pen = new Pen(Color.DarkRed);
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            g.Clear(pictureBox1.BackColor);
            RefreshPicture();
        }

        private void RefreshPicture()
        {
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawLine(pen, 0, 0, 300, 300);
            g.DrawLine(pen, 300, 0, 0, 300);
            RefreshPicture();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, y, 300, y);
                sleep1();
            }
            RefreshPicture();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int x = 0; x <= 300; x += 30)
            {
                g.DrawLine(pen, x, 300, x, 0);
                sleep1();
            }
            RefreshPicture();
        }
        public void sleep1()
        {
            RefreshPicture();
            Thread.Sleep(100);
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
                for (int y = 0; y <= 300; y += 30)
            { 
                    g.DrawLine(pen, 0, y, 300, y);
                sleep1();
                int x = y; 
            
                g.DrawLine(pen, x, 300, x, 0);
                sleep1();
            }
            RefreshPicture();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, 0, a, a, 0);
                sleep1();
            }
            
            RefreshPicture();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, a, 300, 300, a);
                sleep1();
            }
            RefreshPicture();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, a, 300, 300, a);
                sleep1();
            }
            for (int a = 0; a <= 300; a += 30)
            {
                g.DrawLine(pen, 0, a, a, 0);
                sleep1();
            }
            RefreshPicture();
        }
    }
}

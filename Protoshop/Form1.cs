using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protoshop
{
    public partial class Form1 : Form
    {
        bool mouse = false;
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel4.CreateGraphics();
            pen = new Pen(Color.Black, 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x!=-1 && y!=-1 && mouse == true)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void Panel4_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            mouse = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            mouse = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

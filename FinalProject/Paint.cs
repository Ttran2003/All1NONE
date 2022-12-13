using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PaintApp : Form
    {
        Graphics graphics;
        int x = -1;
        int y = -1;
        bool MouseMove = false;
        Pen pen;
        int size = 1;
        string number;

        public PaintApp()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, size);
            graphics = panel1.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        // Changes the color depending on the background color of he picture
        #region PictureClick
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Red;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Orange;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.LightSalmon;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.LightCoral;
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.GreenYellow;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Yellow;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Green;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.LightBlue;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Teal;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Blue;
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.DarkViolet;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.Black;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
            BackColor.BackColor = Color.White;
        }

        #endregion

        // Locates the place of the mouse and coordinates it to draw
        #region MouseMovingColor
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseMove = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMove = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseMove && x != -1 && y != -1)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        #endregion
        
        //the differnt button clicks
        #region Clicks
        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void plus_Click_1(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, size += 1);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            BackColor.BackColor = Color.Black;
            if (size < 1)
            {
                size = 1;
            }
            number = Convert.ToString(size);
            SizeNumber.Text = number;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //decrese or minus
            pen = new Pen(Color.Black, size -= 1);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            BackColor.BackColor = Color.Black;
            if (size < 1)
            {
                size = 1;
            }
            number = Convert.ToString(size);
            SizeNumber.Text = number;
        }
        #endregion

        private void SizeNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

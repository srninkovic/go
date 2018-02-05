using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGrid
{

    struct Coord : IEquatable<Coord>
    {
        public int x;
        public int y;
        public bool IsRed;

        public bool Equals(Coord other)
        {
            return (x == other.x && y == other.y);
        }
    }

    public partial class Form1 : Form
    {
        private const int RectSize = 50;
        private int PieceSize = RectSize- 10;
        private bool Turn = true;
        private List<Coord> Pieces = new List<Coord>();

        private Graphics g;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
 
        }
        protected override void OnPaint(PaintEventArgs e)
        {
           base.OnPaint(e);

            int x = 60;
            int y = 60;

            using (Pen Pen = new Pen(Color.Black))
            {
                for (int row = 0; row < 19; ++row)
                {
                    for (int col = 0; col < 19; ++col)
                    {
                        e.Graphics.DrawRectangle(Pen, x + (row * RectSize), y + (col * RectSize), RectSize, RectSize);
                    }
                }
            }

            //foreach (Coord p in Pieces)
            //{
            //    // if p.isred then red
            //    // else black
            //    DrawCircle(e, x, y, PieceSize, PieceSize);
            //}
        }

        private bool getPiecePosition(ref int x, ref int y)
        {
            if ((x - (60 + RectSize)) % RectSize <= 40 && 
                (y - (60 + RectSize)) % RectSize <= 40)
            {
                x = ((x - (60)) / RectSize) * RectSize + 60;
                y = ((y - (60)) / RectSize) * RectSize + 60;
                return true;
            }
            return false;
        }




        private void  Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            int x = e.X;
            int y = e.Y;

            if (!getPiecePosition(ref x,ref y))
            {
                return;
            }
  
            Rectangle rect = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rect);

            //if (x > 20 * RectSize || y > 20 * RectSize || x < 2 * RectSize || y < 2 * RectSize)
            //{
            //    return;
            //}
            DrawCircle(arg, x, y, PieceSize, PieceSize);

           // pictureBox1.Refresh();
        }

        private void DrawCircle(PaintEventArgs e, int x, int y, int width, int height)
        {
            Coord c;
            c.x = x;
            c.y = y;
            c.IsRed = Turn;

            var existsP = Pieces.Contains(c);

            if (existsP)
                return;

            Pieces.Add(c);
            Pen pen;

            if (Turn)
            {
                pen = new Pen(Color.Red, 3);
            } else 
            {
                pen = new Pen(Color.Black, 3);
            }

                 e.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);
           Turn = !Turn;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBox2.Visible = !pictureBox2.Visible;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using TestGrid.Properties;

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

         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        protected override void OnPaint(PaintEventArgs e)
        {
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
            
            //int x = e.X;
           // int y = e.Y;

           // if (!getPiecePosition(ref x,ref y))
            //{
            //    return;
           // }
  //
           // Rectangle rect = new Rectangle();
           // PaintEventArgs arg = new PaintEventArgs(g, rect);

            //if (x > 20 * RectSize || y > 20 * RectSize || x < 2 * RectSize || y < 2 * RectSize)
            //{
            //    return;
            //}
           // DrawCircle(arg, x, y, PieceSize, PieceSize);

           // pictureBox1.Refresh();
        }

        private void DrawCircle(PaintEventArgs e, int x, int y, int width, int height)
        {
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

        private void cmdCreateBoard_Click(object sender, EventArgs e)
        {
            for (int idx = 0; idx != 19*20; ++idx)
            {
                PictureBox p = new PictureBox();
                p.Parent = flGame;
                p.Width = 50;
                p.Height = 50;
                p.Tag = idx;
                p.Margin = new Padding(0);

                if (idx == 0)
                {
                    p.Image = Resource1.LeftTop;
                }
                else if (idx < 19)
                {
                    p.Image = Resource1.Top;
                }
                else if (idx == 19)
                {
                    p.Image = Resource1.RightTop;
                }
                else if (idx % 20 == 0)
                {
                    p.Image = Resource1.Left;
                }
                else if (idx % 20 == 19)
                {
                    p.Image = Resource1.Right;
                }
                else
                {
                    p.MouseEnter += pictureBox1_MouseEnter;
                    p.MouseLeave += pictureBox1_MouseLeave;
                    p.Click += pictureBox1_Click;

                    p.Image = Resource1.Empty;


                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox) sender).Image = Resource1.Selected;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Resource1.Empty;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox) sender;
            Piece p = new Piece();

            p.Index = (int)pb.Tag;
            p.Color = Turn ? PieceColor.Red : PieceColor.Black;
            pb.Image = Turn ? Resource1.Red : Resource1.Black;

            pb.MouseEnter -= pictureBox1_MouseEnter;
            pb.MouseLeave -= pictureBox1_MouseLeave;
            pb.Click -= pictureBox1_Click;

            Turn = !Turn;

        }
    }
}

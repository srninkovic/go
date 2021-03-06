﻿using System;
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
//using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;


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

        private Board myBoard = new Board();

        private List<Coord> Pieces = new List<Coord>();

        private Board GameBoard = null;

         public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Resource1.pattern;
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
            frmPlayerNames frm = new frmPlayerNames(this);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            frm = null;
            
            //GameBoard = null;
            //GameBoard = new Board();
            label1.Text = "Position :";

            for (int idx = 0; idx != 21; ++idx)
            {
                PictureBox p = new PictureBox();
                p.Parent = flTop;
                p.Width = 46;
                p.Height = 46;
                p.Margin = new Padding(0);
                Bitmap screen = (Bitmap)Resource1.ResourceManager.GetObject("Label" + idx);

                p.Image = screen;
            }

            for (int idx = 0; idx != 21; ++idx)
            {
                PictureBox p = new PictureBox();
                p.Parent = flLeft;
                p.Width = 46;
                p.Height = 46;
                p.Margin = new Padding(0);
                Bitmap screen = (Bitmap)Resource1.ResourceManager.GetObject("Label" + idx);

                p.Image = screen;

            }


            for (int idx = 0; idx != 21*21; ++idx)
            {
                PictureBox p = new PictureBox();
                p.Parent = flGame;
                p.Width = 46;
                p.Height = 46;
                p.Tag = -1;
                p.Margin = new Padding(0);

                if (idx == 0)
                {
                    p.Image = Resource1.LeftTop;
                }
                else if (idx < 20)
                {
                    p.Image = Resource1.Top;
                }
                else if (idx == 20)
                {
                    p.Image = Resource1.RightTop;
                }
                else if (idx == 420)
                {
                    p.Image = Resource1.LeftBot;
                }
                else if (idx == 440)
                {
                    p.Image = Resource1.RightBot;
                }
                else if (idx % 21 == 0)
                {
                    p.Image = Resource1.Left;
                }
                else if (idx % 21 == 20)
                {
                    p.Image = Resource1.Right;
                }
                else if (idx >= 421 && idx <= 439)
                {
                    p.Image = Resource1.Bot;
                }
                
                else
                {
                    p.MouseEnter += pictureBox1_MouseEnter;
                    p.MouseLeave += pictureBox1_MouseLeave;
                    p.Click += pictureBox1_Click;

                    p.Image = Resource1.Empty;

                    p.Tag = idx;
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.Image = Resource1.Selected;

            Piece p = new Piece();

            p.Index = (int)pb.Tag;

            lblPos.Text = "Row: " + p.Row.ToString() + " col: " + p.Col.ToString();

            p = null;
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


            p.Color = myBoard.Turn ? PieceColor.Red : PieceColor.Black;
            pb.Image = myBoard.Turn ? Resource1.Red : Resource1.Black;

            pb.MouseEnter -= pictureBox1_MouseEnter;
            pb.MouseLeave -= pictureBox1_MouseLeave;
            pb.Click -= pictureBox1_Click;

            myBoard.PlacePiece(p);

            
            myBoard.ChangeTurn();

        }

        string CONFIG = Directory.GetCurrentDirectory() + "\\config.json";


        private void Restart_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            Board d_configuration = null; // container for the system settings

            using (StreamReader file = File.OpenText(CONFIG))
            {
                JsonSerializer serializer = new JsonSerializer();
                d_configuration = (Board)serializer.Deserialize(file, typeof(Board));
            }

            using (StreamWriter file = File.CreateText(CONFIG))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, d_configuration);
            }
            MessageBox.Show("Action Completed");
        }

       

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // list of database connection arguments and 
            // a few settings to test for diffent types


            // serialize JSON to a string and then write string to a file
            // File.WriteAllText(@"c:\tmp\configuration.json", JsonConvert.SerializeObject(conf));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(CONFIG))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, myBoard);
            }



        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var con in flGame.Controls)
            {
                PictureBox pb =  con as PictureBox;

                if (pb != null && (int)pb.Tag != -1)
                {
                    pb.Image = Resource1.Empty;

                    pb.MouseEnter -= pictureBox1_MouseEnter;
                    pb.MouseLeave -= pictureBox1_MouseLeave;
                    pb.Click -= pictureBox1_Click;

                    pb.MouseEnter += pictureBox1_MouseEnter;
                    pb.MouseLeave += pictureBox1_MouseLeave;
                    pb.Click += pictureBox1_Click;
                }

            }
            // reset current board

            myBoard = null;

            using (StreamReader file = File.OpenText(CONFIG))
            {
                JsonSerializer serializer = new JsonSerializer();
                myBoard = (Board)serializer.Deserialize(file, typeof(Board));
            }

            foreach (var pcs in myBoard.Pieces)
            {
                foreach (var con in flGame.Controls)
                {
                    PictureBox pb = con as PictureBox;

                    if (pb != null && (int)pb.Tag == pcs.Index)
                    {
                        pb.Image = pcs.Color == PieceColor.Red ? Resource1.Red : Resource1.Black;

                        pb.MouseEnter -= pictureBox1_MouseEnter;
                        pb.MouseLeave -= pictureBox1_MouseLeave;
                        pb.Click -= pictureBox1_Click;
                    }
                }
                 
            }
        }
    }
}

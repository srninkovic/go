namespace TestGrid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdCreateBoard = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Label();
            this.sp1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.sp2 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flGame = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPos = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.piecescount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCreateBoard
            // 
            this.cmdCreateBoard.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdCreateBoard.Location = new System.Drawing.Point(1082, 128);
            this.cmdCreateBoard.Name = "cmdCreateBoard";
            this.cmdCreateBoard.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateBoard.TabIndex = 0;
            this.cmdCreateBoard.Text = "Start";
            this.cmdCreateBoard.UseVisualStyleBackColor = false;
            this.cmdCreateBoard.Click += new System.EventHandler(this.cmdCreateBoard_Click);
            this.cmdCreateBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(1096, 206);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(45, 13);
            this.p1.TabIndex = 3;
            this.p1.Text = "Player 1";
            // 
            // sp1
            // 
            this.sp1.AutoSize = true;
            this.sp1.Location = new System.Drawing.Point(1205, 206);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(73, 13);
            this.sp1.TabIndex = 4;
            this.sp1.Text = "score player 1";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(1096, 276);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(45, 13);
            this.p2.TabIndex = 5;
            this.p2.Text = "Player 2";
            // 
            // sp2
            // 
            this.sp2.AutoSize = true;
            this.sp2.Location = new System.Drawing.Point(1205, 276);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(73, 13);
            this.sp2.TabIndex = 6;
            this.sp2.Text = "score player 2";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(1267, 128);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 7;
            this.quit.Text = "quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flTop);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 60);
            this.panel1.TabIndex = 8;
            // 
            // flTop
            // 
            this.flTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTop.Location = new System.Drawing.Point(60, 0);
            this.flTop.Margin = new System.Windows.Forms.Padding(1);
            this.flTop.Name = "flTop";
            this.flTop.Size = new System.Drawing.Size(1331, 60);
            this.flTop.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 60);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 621);
            this.panel2.TabIndex = 9;
            // 
            // flLeft
            // 
            this.flLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLeft.Location = new System.Drawing.Point(0, 0);
            this.flLeft.Margin = new System.Windows.Forms.Padding(1);
            this.flLeft.Name = "flLeft";
            this.flLeft.Size = new System.Drawing.Size(60, 621);
            this.flLeft.TabIndex = 2;
            // 
            // flGame
            // 
            this.flGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.flGame.Location = new System.Drawing.Point(60, 60);
            this.flGame.Name = "flGame";
            this.flGame.Size = new System.Drawing.Size(1000, 621);
            this.flGame.TabIndex = 10;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(1085, 81);
            this.lblPos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(35, 13);
            this.lblPos.TabIndex = 11;
            this.lblPos.Text = "label1";
            // 
            // Reset
            // 
            this.Reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Reset.Location = new System.Drawing.Point(1174, 128);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Restart_Click);
            // 
            // piecescount
            // 
            this.piecescount.AutoSize = true;
            this.piecescount.Location = new System.Drawing.Point(1082, 346);
            this.piecescount.Name = "piecescount";
            this.piecescount.Size = new System.Drawing.Size(65, 13);
            this.piecescount.TabIndex = 13;
            this.piecescount.Text = "piecescount";
            this.piecescount.Click += new System.EventHandler(this.piecescount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 681);
            this.Controls.Add(this.piecescount);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.flGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.sp2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.cmdCreateBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateBoard;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label sp1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label sp2;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flGame;
        private System.Windows.Forms.FlowLayoutPanel flTop;
        private System.Windows.Forms.FlowLayoutPanel flLeft;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label piecescount;
    }
}


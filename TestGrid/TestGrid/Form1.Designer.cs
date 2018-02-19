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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCreateBoard
            // 
            this.cmdCreateBoard.Location = new System.Drawing.Point(2525, 286);
            this.cmdCreateBoard.Margin = new System.Windows.Forms.Padding(7);
            this.cmdCreateBoard.Name = "cmdCreateBoard";
            this.cmdCreateBoard.Size = new System.Drawing.Size(175, 51);
            this.cmdCreateBoard.TabIndex = 0;
            this.cmdCreateBoard.Text = "start/reset";
            this.cmdCreateBoard.UseVisualStyleBackColor = true;
            this.cmdCreateBoard.Click += new System.EventHandler(this.cmdCreateBoard_Click);
            this.cmdCreateBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(2557, 460);
            this.p1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 29);
            this.p1.TabIndex = 3;
            this.p1.Text = "Player 1";
            // 
            // sp1
            // 
            this.sp1.AutoSize = true;
            this.sp1.Location = new System.Drawing.Point(2812, 460);
            this.sp1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(164, 29);
            this.sp1.TabIndex = 4;
            this.sp1.Text = "score player 1";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(2557, 616);
            this.p2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 29);
            this.p2.TabIndex = 5;
            this.p2.Text = "Player 2";
            // 
            // sp2
            // 
            this.sp2.AutoSize = true;
            this.sp2.Location = new System.Drawing.Point(2812, 616);
            this.sp2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(164, 29);
            this.sp2.TabIndex = 6;
            this.sp2.Text = "score player 2";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(2807, 286);
            this.quit.Margin = new System.Windows.Forms.Padding(7);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(175, 51);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3631, 134);
            this.panel1.TabIndex = 8;
            // 
            // flTop
            // 
            this.flTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTop.Location = new System.Drawing.Point(140, 0);
            this.flTop.Name = "flTop";
            this.flTop.Size = new System.Drawing.Size(3491, 134);
            this.flTop.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 134);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 1037);
            this.panel2.TabIndex = 9;
            // 
            // flLeft
            // 
            this.flLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLeft.Location = new System.Drawing.Point(0, 0);
            this.flLeft.Name = "flLeft";
            this.flLeft.Size = new System.Drawing.Size(140, 1037);
            this.flLeft.TabIndex = 2;
            // 
            // flGame
            // 
            this.flGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.flGame.Location = new System.Drawing.Point(140, 134);
            this.flGame.Margin = new System.Windows.Forms.Padding(7);
            this.flGame.Name = "flGame";
            this.flGame.Size = new System.Drawing.Size(2333, 1037);
            this.flGame.TabIndex = 10;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(2532, 180);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(79, 29);
            this.lblPos.TabIndex = 11;
            this.lblPos.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3631, 1171);
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
            this.Margin = new System.Windows.Forms.Padding(7);
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
    }
}


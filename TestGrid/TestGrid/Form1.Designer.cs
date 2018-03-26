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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quit = new System.Windows.Forms.Button();
            this.sp2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.sp1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.cmdCreateBoard = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flGame = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flTop);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 60);
            this.panel1.TabIndex = 20;
            // 
            // flTop
            // 
            this.flTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTop.Location = new System.Drawing.Point(60, 0);
            this.flTop.Margin = new System.Windows.Forms.Padding(1);
            this.flTop.Name = "flTop";
            this.flTop.Size = new System.Drawing.Size(1514, 60);
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
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.White;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(1419, 128);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(131, 75);
            this.quit.TabIndex = 19;
            this.quit.Text = "quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // sp2
            // 
            this.sp2.AutoSize = true;
            this.sp2.BackColor = System.Drawing.Color.Transparent;
            this.sp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp2.Location = new System.Drawing.Point(1158, 728);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(317, 54);
            this.sp2.TabIndex = 18;
            this.sp2.Text = "score player 2";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(1159, 665);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(316, 63);
            this.p2.TabIndex = 17;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sp1
            // 
            this.sp1.AutoSize = true;
            this.sp1.BackColor = System.Drawing.Color.Transparent;
            this.sp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp1.Location = new System.Drawing.Point(1158, 454);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(317, 54);
            this.sp1.TabIndex = 16;
            this.sp1.Text = "score player 1";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(1159, 391);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(311, 63);
            this.p1.TabIndex = 15;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCreateBoard
            // 
            this.cmdCreateBoard.BackColor = System.Drawing.Color.White;
            this.cmdCreateBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreateBoard.Location = new System.Drawing.Point(1079, 128);
            this.cmdCreateBoard.Name = "cmdCreateBoard";
            this.cmdCreateBoard.Size = new System.Drawing.Size(131, 75);
            this.cmdCreateBoard.TabIndex = 14;
            this.cmdCreateBoard.Text = "Start";
            this.cmdCreateBoard.UseVisualStyleBackColor = false;
            this.cmdCreateBoard.Click += new System.EventHandler(this.cmdCreateBoard_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.White;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Reset.Location = new System.Drawing.Point(1249, 128);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(131, 75);
            this.Reset.TabIndex = 24;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Restart_Click);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(1295, 96);
            this.lblPos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(0, 20);
            this.lblPos.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 749);
            this.panel2.TabIndex = 26;
            // 
            // flLeft
            // 
            this.flLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLeft.Location = new System.Drawing.Point(0, 0);
            this.flLeft.Margin = new System.Windows.Forms.Padding(1);
            this.flLeft.Name = "flLeft";
            this.flLeft.Size = new System.Drawing.Size(60, 749);
            this.flLeft.TabIndex = 3;
            // 
            // flGame
            // 
            this.flGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.flGame.Location = new System.Drawing.Point(60, 84);
            this.flGame.Name = "flGame";
            this.flGame.Size = new System.Drawing.Size(1000, 749);
            this.flGame.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1218, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 833);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.sp2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.sp1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.cmdCreateBoard);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label sp2;
        private System.Windows.Forms.Label sp1;
        private System.Windows.Forms.Button cmdCreateBoard;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flLeft;
        private System.Windows.Forms.FlowLayoutPanel flGame;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label p1;
        public System.Windows.Forms.Label p2;
    }
}


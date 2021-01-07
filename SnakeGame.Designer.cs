namespace SnakeGame
{
    partial class SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.status_l = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausedLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score_l = new System.Windows.Forms.Label();
            this.controlsbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playernamelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logopanle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.controlsbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.logopanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            resources.ApplyResources(this.canvas, "canvas");
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.canvas.BackgroundImage = global::SnakeGame.Resources1.Jungle;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.canvas.Name = "canvas";
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // status_l
            // 
            resources.ApplyResources(this.status_l, "status_l");
            this.status_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.status_l.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_l.ForeColor = System.Drawing.Color.Lime;
            this.status_l.Image = global::SnakeGame.Properties.Resources.statusshow;
            this.status_l.Name = "status_l";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(34, 34);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.quitToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fileToolStripMenuItem.Image = global::SnakeGame.Properties.Resources.snakeico;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::SnakeGame.Properties.Resources.sttingicon;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Image = global::SnakeGame.Properties.Resources.mapicon;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            resources.ApplyResources(this.mapToolStripMenuItem, "mapToolStripMenuItem");
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::SnakeGame.Properties.Resources.endico;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pausedLBL
            // 
            resources.ApplyResources(this.pausedLBL, "pausedLBL");
            this.pausedLBL.BackColor = System.Drawing.Color.Firebrick;
            this.pausedLBL.ForeColor = System.Drawing.Color.Cornsilk;
            this.pausedLBL.Name = "pausedLBL";
            this.pausedLBL.Click += new System.EventHandler(this.pausedLBL_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            // 
            // score_l
            // 
            resources.ApplyResources(this.score_l, "score_l");
            this.score_l.BackColor = System.Drawing.Color.Gray;
            this.score_l.Name = "score_l";
            // 
            // controlsbox
            // 
            this.controlsbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.controlsbox.Controls.Add(this.label3);
            resources.ApplyResources(this.controlsbox, "controlsbox");
            this.controlsbox.ForeColor = System.Drawing.Color.DarkGray;
            this.controlsbox.Name = "controlsbox";
            this.controlsbox.TabStop = false;
            this.controlsbox.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseMnemonic = false;
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Name = "label5";
            // 
            // playernamelbl
            // 
            resources.ApplyResources(this.playernamelbl, "playernamelbl");
            this.playernamelbl.BackColor = System.Drawing.Color.Gray;
            this.playernamelbl.ForeColor = System.Drawing.SystemColors.Info;
            this.playernamelbl.Name = "playernamelbl";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::SnakeGame.Properties.Resources.dadhboard;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.playernamelbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.controlsbox);
            this.panel1.Controls.Add(this.score_l);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // logopanle
            // 
            this.logopanle.BackColor = System.Drawing.Color.Transparent;
            this.logopanle.Controls.Add(this.label2);
            resources.ApplyResources(this.logopanle, "logopanle");
            this.logopanle.Name = "logopanle";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // SnakeGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::SnakeGame.Resources1.backgroundsnake;
            this.Controls.Add(this.logopanle);
            this.Controls.Add(this.pausedLBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status_l);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SnakeGame";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlsbox.ResumeLayout(false);
            this.controlsbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.logopanle.ResumeLayout(false);
            this.logopanle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status_l;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label pausedLBL;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_l;
        private System.Windows.Forms.GroupBox controlsbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label playernamelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logopanle;
        private System.Windows.Forms.Label label2;
    }
}


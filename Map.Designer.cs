namespace SnakeGame
{
    partial class Map
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
            this.prevBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prevBTN
            // 
            this.prevBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.prevBTN.ForeColor = System.Drawing.Color.Cornsilk;
            this.prevBTN.Location = new System.Drawing.Point(141, 420);
            this.prevBTN.Name = "prevBTN";
            this.prevBTN.Size = new System.Drawing.Size(144, 34);
            this.prevBTN.TabIndex = 2;
            this.prevBTN.Text = "◄ السابق";
            this.prevBTN.UseVisualStyleBackColor = true;
            this.prevBTN.Click += new System.EventHandler(this.prevBTN_Click);
            // 
            // nextBTN
            // 
            this.nextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nextBTN.ForeColor = System.Drawing.Color.Cornsilk;
            this.nextBTN.Location = new System.Drawing.Point(291, 420);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(146, 34);
            this.nextBTN.TabIndex = 3;
            this.nextBTN.Text = "التالي ►";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateBTN.FlatAppearance.BorderSize = 2;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.Cornsilk;
            this.updateBTN.Location = new System.Drawing.Point(141, 464);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(296, 34);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "حفظ";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // previewBox
            // 
            this.previewBox.BackgroundImage = global::SnakeGame.Resources1.darklake;
            this.previewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(12, 14);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(425, 400);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(12, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 78);
            this.button1.TabIndex = 6;
            this.button1.Text = "اغلاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(451, 506);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.prevBTN);
            this.Controls.Add(this.previewBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Map";
            this.Text = "الخرائط";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button prevBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button button1;
    }
}
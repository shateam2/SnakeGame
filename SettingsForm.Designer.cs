namespace SnakeGame
{
    partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.appearanceGB = new System.Windows.Forms.GroupBox();
			this.foodColorCB = new System.Windows.Forms.ComboBox();
			this.bodyColorCB = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.headColorCB = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.applyBTN = new System.Windows.Forms.Button();
			this.closeBTN = new System.Windows.Forms.Button();
			this.shapeGB = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.foodShapeSquare = new System.Windows.Forms.RadioButton();
			this.foodShapeCircle = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.snakeShapeSquare = new System.Windows.Forms.RadioButton();
			this.snakeShapeCircle = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.difficultyGB = new System.Windows.Forms.GroupBox();
			this.hardRadio = new System.Windows.Forms.RadioButton();
			this.mediumRadio = new System.Windows.Forms.RadioButton();
			this.easyRadio = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.playerName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.appearanceGB.SuspendLayout();
			this.shapeGB.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.difficultyGB.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// appearanceGB
			// 
			this.appearanceGB.Controls.Add(this.foodColorCB);
			this.appearanceGB.Controls.Add(this.bodyColorCB);
			this.appearanceGB.Controls.Add(this.label4);
			this.appearanceGB.Controls.Add(this.headColorCB);
			this.appearanceGB.Controls.Add(this.label2);
			this.appearanceGB.Controls.Add(this.label1);
			this.appearanceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appearanceGB.Location = new System.Drawing.Point(12, 115);
			this.appearanceGB.Name = "appearanceGB";
			this.appearanceGB.Size = new System.Drawing.Size(200, 178);
			this.appearanceGB.TabIndex = 0;
			this.appearanceGB.TabStop = false;
			this.appearanceGB.Text = "الالوان";
			// 
			// foodColorCB
			// 
			this.foodColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.foodColorCB.FormattingEnabled = true;
			this.foodColorCB.Location = new System.Drawing.Point(7, 136);
			this.foodColorCB.Name = "foodColorCB";
			this.foodColorCB.Size = new System.Drawing.Size(184, 26);
			this.foodColorCB.TabIndex = 7;
			// 
			// bodyColorCB
			// 
			this.bodyColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bodyColorCB.FormattingEnabled = true;
			this.bodyColorCB.Location = new System.Drawing.Point(7, 86);
			this.bodyColorCB.Name = "bodyColorCB";
			this.bodyColorCB.Size = new System.Drawing.Size(184, 26);
			this.bodyColorCB.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(121, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "لون الطعام";
			// 
			// headColorCB
			// 
			this.headColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.headColorCB.FormattingEnabled = true;
			this.headColorCB.Location = new System.Drawing.Point(7, 39);
			this.headColorCB.Name = "headColorCB";
			this.headColorCB.Size = new System.Drawing.Size(184, 26);
			this.headColorCB.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(124, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "لون الجسم";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(123, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "لون الرأس";
			// 
			// applyBTN
			// 
			this.applyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.applyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.applyBTN.Location = new System.Drawing.Point(218, 18);
			this.applyBTN.Name = "applyBTN";
			this.applyBTN.Size = new System.Drawing.Size(75, 32);
			this.applyBTN.TabIndex = 1;
			this.applyBTN.Text = "حفظ";
			this.applyBTN.UseVisualStyleBackColor = true;
			this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
			// 
			// closeBTN
			// 
			this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.closeBTN.FlatAppearance.BorderSize = 2;
			this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.closeBTN.Location = new System.Drawing.Point(218, 80);
			this.closeBTN.Name = "closeBTN";
			this.closeBTN.Size = new System.Drawing.Size(75, 33);
			this.closeBTN.TabIndex = 2;
			this.closeBTN.Text = "اغلاق";
			this.closeBTN.UseVisualStyleBackColor = true;
			this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
			// 
			// shapeGB
			// 
			this.shapeGB.Controls.Add(this.panel2);
			this.shapeGB.Controls.Add(this.panel1);
			this.shapeGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shapeGB.Location = new System.Drawing.Point(10, 299);
			this.shapeGB.Name = "shapeGB";
			this.shapeGB.Size = new System.Drawing.Size(200, 110);
			this.shapeGB.TabIndex = 3;
			this.shapeGB.TabStop = false;
			this.shapeGB.Text = "الشكل";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.foodShapeSquare);
			this.panel2.Controls.Add(this.foodShapeCircle);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(6, 60);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(187, 35);
			this.panel2.TabIndex = 5;
			// 
			// foodShapeSquare
			// 
			this.foodShapeSquare.AutoSize = true;
			this.foodShapeSquare.Location = new System.Drawing.Point(72, 10);
			this.foodShapeSquare.Name = "foodShapeSquare";
			this.foodShapeSquare.Size = new System.Drawing.Size(54, 22);
			this.foodShapeSquare.TabIndex = 4;
			this.foodShapeSquare.Text = "مربع";
			this.foodShapeSquare.UseVisualStyleBackColor = true;
			// 
			// foodShapeCircle
			// 
			this.foodShapeCircle.AutoSize = true;
			this.foodShapeCircle.Checked = true;
			this.foodShapeCircle.Location = new System.Drawing.Point(3, 10);
			this.foodShapeCircle.Name = "foodShapeCircle";
			this.foodShapeCircle.Size = new System.Drawing.Size(61, 22);
			this.foodShapeCircle.TabIndex = 3;
			this.foodShapeCircle.TabStop = true;
			this.foodShapeCircle.Text = "دائري";
			this.foodShapeCircle.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label5.ForeColor = System.Drawing.Color.Cornsilk;
			this.label5.Location = new System.Drawing.Point(135, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 18);
			this.label5.TabIndex = 1;
			this.label5.Text = "الطعام";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.snakeShapeSquare);
			this.panel1.Controls.Add(this.snakeShapeCircle);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(6, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 35);
			this.panel1.TabIndex = 4;
			// 
			// snakeShapeSquare
			// 
			this.snakeShapeSquare.AutoSize = true;
			this.snakeShapeSquare.Location = new System.Drawing.Point(72, 7);
			this.snakeShapeSquare.Name = "snakeShapeSquare";
			this.snakeShapeSquare.Size = new System.Drawing.Size(54, 22);
			this.snakeShapeSquare.TabIndex = 4;
			this.snakeShapeSquare.Text = "مربع";
			this.snakeShapeSquare.UseVisualStyleBackColor = true;
			// 
			// snakeShapeCircle
			// 
			this.snakeShapeCircle.AutoSize = true;
			this.snakeShapeCircle.Checked = true;
			this.snakeShapeCircle.Location = new System.Drawing.Point(3, 7);
			this.snakeShapeCircle.Name = "snakeShapeCircle";
			this.snakeShapeCircle.Size = new System.Drawing.Size(61, 22);
			this.snakeShapeCircle.TabIndex = 3;
			this.snakeShapeCircle.TabStop = true;
			this.snakeShapeCircle.Text = "دائري";
			this.snakeShapeCircle.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Cornsilk;
			this.label3.Location = new System.Drawing.Point(132, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "الثعبان";
			// 
			// difficultyGB
			// 
			this.difficultyGB.Controls.Add(this.hardRadio);
			this.difficultyGB.Controls.Add(this.mediumRadio);
			this.difficultyGB.Controls.Add(this.easyRadio);
			this.difficultyGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difficultyGB.Location = new System.Drawing.Point(220, 125);
			this.difficultyGB.Name = "difficultyGB";
			this.difficultyGB.Size = new System.Drawing.Size(73, 284);
			this.difficultyGB.TabIndex = 4;
			this.difficultyGB.TabStop = false;
			this.difficultyGB.Text = "المستوي";
			// 
			// hardRadio
			// 
			this.hardRadio.AutoSize = true;
			this.hardRadio.Location = new System.Drawing.Point(6, 222);
			this.hardRadio.Name = "hardRadio";
			this.hardRadio.Size = new System.Drawing.Size(59, 22);
			this.hardRadio.TabIndex = 2;
			this.hardRadio.Text = "صعب";
			this.hardRadio.UseVisualStyleBackColor = true;
			// 
			// mediumRadio
			// 
			this.mediumRadio.AutoSize = true;
			this.mediumRadio.Checked = true;
			this.mediumRadio.Location = new System.Drawing.Point(6, 116);
			this.mediumRadio.Name = "mediumRadio";
			this.mediumRadio.Size = new System.Drawing.Size(65, 22);
			this.mediumRadio.TabIndex = 1;
			this.mediumRadio.TabStop = true;
			this.mediumRadio.Text = "متوسط";
			this.mediumRadio.UseVisualStyleBackColor = true;
			// 
			// easyRadio
			// 
			this.easyRadio.AutoSize = true;
			this.easyRadio.Location = new System.Drawing.Point(6, 25);
			this.easyRadio.Name = "easyRadio";
			this.easyRadio.Size = new System.Drawing.Size(52, 22);
			this.easyRadio.TabIndex = 0;
			this.easyRadio.Text = "سهل";
			this.easyRadio.UseVisualStyleBackColor = true;
			this.easyRadio.CheckedChanged += new System.EventHandler(this.easyRadio_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.playerName);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(198, 97);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "تغيير اسم اللاعب";
			// 
			// playerName
			// 
			this.playerName.Location = new System.Drawing.Point(6, 52);
			this.playerName.Name = "playerName";
			this.playerName.Size = new System.Drawing.Size(184, 24);
			this.playerName.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(117, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 18);
			this.label6.TabIndex = 1;
			this.label6.Text = "اسم اللاعب";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.applyBTN;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.closeBTN;
			this.ClientSize = new System.Drawing.Size(306, 428);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.difficultyGB);
			this.Controls.Add(this.shapeGB);
			this.Controls.Add(this.closeBTN);
			this.Controls.Add(this.applyBTN);
			this.Controls.Add(this.appearanceGB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(322, 467);
			this.MinimumSize = new System.Drawing.Size(322, 467);
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "الاعدادت";
			this.appearanceGB.ResumeLayout(false);
			this.appearanceGB.PerformLayout();
			this.shapeGB.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.difficultyGB.ResumeLayout(false);
			this.difficultyGB.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appearanceGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.GroupBox shapeGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton foodShapeSquare;
        private System.Windows.Forms.RadioButton foodShapeCircle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton snakeShapeSquare;
        private System.Windows.Forms.RadioButton snakeShapeCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox difficultyGB;
        private System.Windows.Forms.RadioButton hardRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.ComboBox headColorCB;
        private System.Windows.Forms.ComboBox foodColorCB;
        private System.Windows.Forms.ComboBox bodyColorCB;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox playerName;
	}
}
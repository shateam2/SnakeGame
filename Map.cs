﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Map : Form
    {
    
        private readonly Bitmap[] images = {Resources1.Jungledark ,Resources1.Jungle  ,Resources1.grassdarkbackground};
        private int index = 0;

        public Map()
        {
            InitializeComponent();
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            bool atStart = index == 0;
            index = (atStart) ?images.Length - 1 : index - 1;
            previewBox.BackgroundImage = images[index];
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            bool atEnd = index == images.Length - 1;
            index = (atEnd) ? index = 0 : index + 1;
            previewBox.BackgroundImage = images[index];
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            //TODO
            SnakeGame.changeBackground(previewBox.BackgroundImage);
            GameInput.ChangeState(Keys.U, true);
            MessageBox.Show("تم تغيير الخريطة بنجاح");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

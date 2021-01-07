using System;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            playerName.Text = Settings.player1Name;
            string[] colors = { "احمر" , "برتقالي", "اصفر", "اخضر", "ازرق", "بنفسجي","اسود"};
            for(var i = 0; i < colors.Length; i++)
            {
                headColorCB.Items.Add(colors[i]);
                bodyColorCB.Items.Add(colors[i]);
                foodColorCB.Items.Add(colors[i]);
            }
            headColorCB.Text = "برتقالي";
            bodyColorCB.Text = "اصفر";
            foodColorCB.Text = "بنفسجي";
        }
        
        private Brush changeColor(string color, Brush fallback)
        {
            Brush result;
            switch (color) {
                case "احمر":
                    result = Brushes.Red;
                    break;
                case "برتقالي":
                        result = Brushes.Orange;
                    break;
                case "اصفر":
                    result = Brushes.Yellow;
                    break;
                case "اخضر":
                    result = Brushes.Green;
                    break;
                case "اسود":
                    result = Brushes.Orange;
                    break;
                case "بنفسجي":
                    result = Brushes.Purple;
                    break;
                case "ازرق":
                    result = Brushes.Blue;
                    break;
                default:
                    result = fallback;
                    break;
            }


            return result;
        }   
        private void applyBTN_Click(object sender, EventArgs e)
        {
            //difficulty radio
            string defaultDifficulty = Settings.difficulty;
            if (easyRadio.Checked) { Settings.difficulty = "easy"; }
            else if (mediumRadio.Checked) { Settings.difficulty = "medium"; }
            else if (hardRadio.Checked) { Settings.difficulty = "hard"; }
           

            //shapes
            if (snakeShapeCircle.Checked) { Settings.snakeShape = "circle"; }
            else if (snakeShapeSquare.Checked) { Settings.snakeShape = "square"; }

            if (foodShapeCircle.Checked) { Settings.foodShape = "circle"; }
            else if (foodShapeSquare.Checked) { Settings.foodShape = "square"; }

            Settings.player1Name = playerName.Text;
            //change color new
            Settings.headColor = changeColor(headColorCB.Text, Settings.headColor);
            Settings.bodyColor = changeColor(bodyColorCB.Text, Settings.bodyColor);
            Settings.foodColor = changeColor(foodColorCB.Text, Settings.foodColor);

            MessageBox.Show("تم الحفظ");
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

   
    }
}

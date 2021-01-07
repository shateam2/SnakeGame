using System.Drawing;

namespace SnakeGame
{
    //Probably wont add diagonals soon
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        private static int speedX = 5;
        public static int Speed {
            get { return speedX; }
            set { speedX = value; } }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static bool IsGameOver { get; set; }
        public static bool IsGamePaused { get; set; }
        public static Direction InGameDirection { get; set; }
        public static Brush headColor { get; set; }
        public static Brush bodyColor { get; set; }
        public static Brush foodColor { get; set; }
        public static string snakeShape { get; set; }
        public static string foodShape { get; set; }
        public static string difficulty { get; set; }

        /*Player Names*/
        public static string player1Name { get; set; }
 

        public Settings()
        {
            difficulty = "medium";
            Speed = 10;
            Points = 110;
            headColor = Brushes.Orange;
            bodyColor = Brushes.Yellow;
            foodColor = Brushes.Purple;
            snakeShape = "circle";
            foodShape = "circle";
            Score = 0;
            Width = 15;
            Height = 16;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            IsGamePaused = false;
            player1Name = "Player 1";

        }
        public static void resetGame()
        {
            switch(difficulty)
            {
                case "easy":
                    Speed = 5;
                    Points = 100;
                    break;
                case "medium":
                    Speed = 15;
                    Points = 110;
                    break;
                case "hard":
                    Speed = 30;
                    Points = 120;
                    break;
                default:
                    Speed = 30;
                    Points = 250;
 
                    break;
            }
            Score = 0;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            IsGamePaused = false;
        }

    }
}

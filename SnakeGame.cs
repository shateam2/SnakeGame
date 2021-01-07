using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
	public partial class SnakeGame : Form
	{
		private static List<Shape> Snake = new List<Shape>();
		private Shape food = new Shape();

		private string deathCause = "انت مت من غير سبب ";


		private static Image background = Resources1.background_01_01;


		//sounds
		readonly System.Media.SoundPlayer crunch = new System.Media.SoundPlayer(Resources1.crunch);
		readonly System.Media.SoundPlayer die = new System.Media.SoundPlayer(Resources1.The_Game_Over_1);


		readonly private SettingsForm settings;
		readonly private Map maps;


		public SnakeGame()
		{
			InitializeComponent();
			//Default settings
			Settings st = new Settings();
			settings = new SettingsForm();
			maps = new Map();

			//for starting the timer and setting the timer interval for tick
			setGameTimer();

			//i want to play a sound when the game starts

		}
		public void setGameTimer()
		{
			GameTimer.Interval = 1000 / Settings.Speed;
			GameTimer.Tick += UpdateScreen;
			GameTimer.Start();

			StartGame();

		}
		public void cutSnake()
		{
			int len = Snake.Count;
			if (len > 1)
				Snake.RemoveAt(len - 1);
		}
		public static void changeBackground(Image i)
		{
			background = i;
		}

		private void StartGame()
		{
			status_l.Visible = false;
			playernamelbl.Text = Settings.player1Name;

			//Default settings
			Settings.resetGame();

			Snake.Clear();

			Shape head = new Shape { X = 0, Y = 0 };
			//default start for game
			Snake.Add(head);
			score_l.Text = Settings.Score.ToString();

			CreateFood();
		}

		private void UpdateScreen(object sender, EventArgs e)
		{

			//Check for Game Over
			if (Settings.IsGameOver)
			{
				//Check if Enter is pressed
				if (GameInput.PressedKey(Keys.Enter))
				{
					StartGame();

				}
			}
			else
			{

				//(()or())and()
				if (GameInput.PressedKey(Keys.Space))
				{
					Settings.IsGamePaused = !Settings.IsGamePaused;
					pausedLBL.Visible = !pausedLBL.Visible;
				}
				if (GameInput.PressedKey(Keys.K))
				{
					cutSnake();
				}

				//move when unpaused
				if (!Settings.IsGamePaused)
				{
					if ((GameInput.PressedKey(Keys.Right) || (GameInput.PressedKey(Keys.D))) && Settings.InGameDirection != Direction.Left)
					{
						Settings.InGameDirection = Direction.Right;
					}
					else if ((GameInput.PressedKey(Keys.Left) || (GameInput.PressedKey(Keys.A))) && Settings.InGameDirection != Direction.Right)
					{
						Settings.InGameDirection = Direction.Left;
					}
					else if ((GameInput.PressedKey(Keys.Up) || (GameInput.PressedKey(Keys.W))) && Settings.InGameDirection != Direction.Down)
					{
						Settings.InGameDirection = Direction.Up;
					}
					else if ((GameInput.PressedKey(Keys.Down) || (GameInput.PressedKey(Keys.S))) && Settings.InGameDirection != Direction.Up)
					{
						Settings.InGameDirection = Direction.Down;
					}
					MoveSnake(Snake);
				}
			}


			canvas.Invalidate();
		}

		private void MoveSnake(List<Shape> snake)
		{
			for (int i = Snake.Count - 1; i >= 0; i--)
			{
				//Move the head
				if (i == 0)
				{
					switch (Settings.InGameDirection)
					{
						case Direction.Up:
							Snake[i].Y--;
							break;
						case Direction.Down:
							Snake[i].Y++;
							break;
						case Direction.Right:
							Snake[i].X++;
							break;
						case Direction.Left:
							Snake[i].X--;
							break;
						default:
							//do nothing
							break;
					}

					//Maximum X ,Y coordinates
					int MaxX = canvas.Size.Width / Settings.Width;
					int MaxY = canvas.Size.Height / Settings.Height;

					//Finding whether there is collision of snake with the screen border
					if (Snake[i].X >= MaxX || Snake[i].Y >= MaxY || Snake[i].X < 0 || Snake[i].Y < 0)
					{
						deathCause = " كلنا لها معلش ";
						die.Play();
						GameOver();

					}

					// snake snake collision
					for (int k = 1; k < Snake.Count; k++)
					{
						if (Snake[i].X == Snake[k].X && Snake[i].Y == Snake[k].Y)
						{
							deathCause = "من حلاوتك اكلت نفسك";
							die.Play();
							GameOver();
						}
					}

					//eat food
					if (Snake[0].X == food.X && Snake[0].Y == food.Y)
					{
						crunch.Play();
						EatFood();
					}

				}
				else
				{
					Snake[i].X = Snake[i - 1].X;
					Snake[i].Y = Snake[i - 1].Y;
				}
			}
		}

		//food spawn on canvas
		private void CreateFood()
		{
			int MaxX = canvas.Size.Width / Settings.Width;
			int MaxY = canvas.Size.Height / Settings.Height;
			Random rand = new Random();

			int x = rand.Next(0, MaxX);
			int y = rand.Next(0, MaxY);

			food = new Shape { X = x, Y = y };

		}

		private void GameOver()
		{
			Settings.IsGameOver = true;
		}

		private void EatFood()
		{
			//For adding circle to snake's body on eating the food
			Shape snake = new Shape
			{
				X = Snake[Snake.Count - 1].X,
				Y = Snake[Snake.Count - 1].Y,
				//testing


			};
			Snake.Add(snake);
			//for updating the score
			Settings.Score += Settings.Points;
			score_l.Text = Settings.Score.ToString();
			CreateFood();

		}


		private void canvas_Paint(object sender, PaintEventArgs e)
		{

			Graphics draw = e.Graphics;

			if (!Settings.IsGameOver)
			{
				//Draw snake's body 
				for (int i = 0; i < Snake.Count; i++)
				{
					//TODO: Add image implementation or different rendering methods
					Brush SnakeColour;
					

					//head
					if (i == 0) { SnakeColour = Settings.headColor; }
					else { SnakeColour = Settings.bodyColor; }

					//For drawing the snake

					if (Settings.snakeShape == "circle") { draw.FillEllipse(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height)); }
					else if (Settings.snakeShape == "square") { draw.FillRectangle(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height)); }

					//For drawing the food
					if (Settings.foodShape == "circle") { draw.FillEllipse(Settings.foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height)); }
					else if (Settings.foodShape == "square") { draw.FillRectangle(Settings.foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height)); }

					//draw powerup

				}
			}

			else
			{
				string message;
				string pressenter = "ENTER";
				message = String.Format("{2}\n\nلقد حصلت علي {0} نقطة \n\n اضغط {1} للعب مرة اخري", score_l.Text, pressenter, deathCause);


				status_l.Text = message;
				status_l.Visible = true;
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			GameInput.ChangeState(e.KeyCode, true);
			if (GameInput.PressedKey(Keys.U))
			{
				canvas.BackgroundImage = background;
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			GameInput.ChangeState(e.KeyCode, false);
		}


		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings.IsGamePaused = true;
			settings.ShowDialog();
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void mapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings.IsGamePaused = true;
			maps.ShowDialog();
		}

		private void pausedLBL_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void SnakeGame_Load(object sender, EventArgs e)
		{

		}

		private void canvas_Click(object sender, EventArgs e)
		{

		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}

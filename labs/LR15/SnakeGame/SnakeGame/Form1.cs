using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace SnakeGame
{
    public partial class Form1 : Form
    {
        List<Point> snake = new List<Point>();
        Point food;

        int dx = 0;
        int dy = 0;

        int score = 0;
        int gameTime = 0;

        Timer gameTimer = new Timer();
        Random rand = new Random();

        DatabaseHelper db = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;

            gameTimer.Interval = 120;
            gameTimer.Tick += GameLoop;

            StartGame();
        }

        // =========================
        // Старт игры
        // =========================
        private void StartGame()
        {
            snake.Clear();
            snake.Add(new Point(10, 10));

            dx = 1;
            dy = 0;

            score = 0;
            gameTime = 0;

            SpawnFood();

            gameTimer.Start();
        }

        // =========================
        // Еда
        // =========================
        private void SpawnFood()
        {
            food = new Point(rand.Next(0, 25), rand.Next(0, 20));
        }

        // =========================
        // Игровой цикл
        // =========================
        private void GameLoop(object sender, EventArgs e)
        {
            gameTime++;

            Point head = new Point(snake[0].X + dx, snake[0].Y + dy);

            // Столкновение со стеной
            if (head.X < 0 || head.Y < 0 || head.X >= 25 || head.Y >= 20)
            {
                GameOver();
                return;
            }

            // Столкновение с собой
            foreach (var part in snake)
            {
                if (head == part)
                {
                    GameOver();
                    return;
                }
            }

            snake.Insert(0, head);

            // Съел еду
            if (head == food)
            {
                score += 10;
                SpawnFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            this.Invalidate();
        }

        // =========================
        // Управление
        // =========================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dy == 0)
            {
                dx = 0; dy = -1;
            }
            if (e.KeyCode == Keys.Down && dy == 0)
            {
                dx = 0; dy = 1;
            }
            if (e.KeyCode == Keys.Left && dx == 0)
            {
                dx = -1; dy = 0;
            }
            if (e.KeyCode == Keys.Right && dx == 0)
            {
                dx = 1; dy = 0;
            }
        }

        // =========================
        // Game Over
        // =========================
        private void GameOver()
        {
            gameTimer.Stop();

            Form inputForm = new Form();
            inputForm.Width = 300;
            inputForm.Height = 150;
            inputForm.Text = "Game Over - Введите имя";

            TextBox txtName = new TextBox();
            txtName.Location = new Point(20, 20);
            txtName.Width = 240;

            Button btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.Location = new Point(20, 60);
            btnOk.DialogResult = DialogResult.OK;

            inputForm.Controls.Add(txtName);
            inputForm.Controls.Add(btnOk);
            inputForm.AcceptButton = btnOk;

            string name = "Player";

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                name = txtName.Text;
            }

            db.SaveResult(name, score, gameTime);

            MessageBox.Show($"Игра окончена!\nОчки: {score}");

            StartGame();
        }

        // =========================
        // Отрисовка
        // =========================
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // змейка
            foreach (var part in snake)
            {
                g.FillRectangle(Brushes.Green, part.X * 20, part.Y * 20, 20, 20);
            }

            // еда
            g.FillEllipse(Brushes.Red, food.X * 20, food.Y * 20, 20, 20);

            // счет
            g.DrawString("Score: " + score, this.Font, Brushes.Black, 5, 5);
        }
    }
}
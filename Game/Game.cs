using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        private const int CELL_SIZE_PIXELS = 30;                    // Размер клетки игрового поля, в пикселях
        private const int ROWS_NUMBER = 10;                         // Количество рядов в игровом поле
        private const int COLS_NUMBER = 10;                         // Количество столбцов в игровом поле
        private const int FIELD_LEFT_OFFSET_PIXELS = 40;            // Отступ в пикселях от левого края формы
        private const int FIELD_TOP_OFFSET_PIXELS = 15;             // Отступ в пикселях от правого края формы
        private const int INITIAL_GAMER_SPEED_INTERVAL = 250;       // Задержка (свойство "Interval") для основного игрового таймера TimerGameLoop

        private enum GamerDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        private GamerDirection gamerDirection = GamerDirection.Up;  // Текущее направление движения "Змейки"
        //private PictureBox<Point> gamer = 
        //private LinkedList<Point> gamer = new LinkedList<Point>();  // Список точек, содержащих координаты всего "тела Змейки"
        private Random rand = new Random();                         // Генератор псевдослучайных чисел. нужен для генерации очередной "Еды" в произвольном месте игрового поля
        private bool isGameEnded;                                   // Признак: игра завершена?

        public Game()
        {
            InitializeComponent();
        }

        private void TimerGame_Tick(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    GameOver();
                    break;
                default:
                    Invalidate();
                    break;
            }
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            BackColor = Color.Black;
            StartGame();
        }

        private void StartGame()
        {
            gamerDirection = GamerDirection.Up;
            gamer.Location = new Point(150, 150);
            isGameEnded = false;
            TimerGame.Start();
            TimerGame.Interval = INITIAL_GAMER_SPEED_INTERVAL;
        }

        private void GameOver()
        {
            isGameEnded = true;
            TimerGame.Stop();
            Close();
        }

        private bool IsGameOver()
        {
            switch (gamerDirection)
            {
                case GamerDirection.Left:
                    return gamer.Location.X - CELL_SIZE_PIXELS < COLS_NUMBER + CELL_SIZE_PIXELS;
                case GamerDirection.Right:
                    return gamer.Location.X + CELL_SIZE_PIXELS >= COLS_NUMBER * CELL_SIZE_PIXELS + CELL_SIZE_PIXELS;
                case GamerDirection.Down:
                    return gamer.Location.Y + CELL_SIZE_PIXELS >= ROWS_NUMBER * CELL_SIZE_PIXELS;
                case GamerDirection.Up:
                    return gamer.Location.Y - CELL_SIZE_PIXELS < CELL_SIZE_PIXELS * 3;
            }
            return false;
        }

        private void MoveGamer()
        {
            switch (gamerDirection)
            {
                case GamerDirection.Up:
                    if (IsGameOver())
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y - CELL_SIZE_PIXELS);
                    break;
                case GamerDirection.Down:
                    if (IsGameOver())
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y + CELL_SIZE_PIXELS);
                    break;
                case GamerDirection.Right:
                    if (IsGameOver())
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X + CELL_SIZE_PIXELS, gamer.Location.Y);
                    break;
                case GamerDirection.Left:
                    if (IsGameOver())
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X - CELL_SIZE_PIXELS, gamer.Location.Y);
                    break;
            }
        }

        private void Gamer_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid();
            DrawGamer();
        }

        private void DrawGrid()
        {
            location.Location = new Point(FIELD_LEFT_OFFSET_PIXELS, FIELD_TOP_OFFSET_PIXELS);
            location.Image = Image.FromFile("Fon.png");
            location.Width = CELL_SIZE_PIXELS * COLS_NUMBER;
            location.Height = CELL_SIZE_PIXELS * ROWS_NUMBER;
            
        }

        private void DrawGamer()
        {
            gamer.Image = Image.FromFile("Starlight.png");
            gamer.Width = CELL_SIZE_PIXELS;
            gamer.Height = CELL_SIZE_PIXELS;
        }

        private void Gamer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    gamerDirection = GamerDirection.Left;
                    MoveGamer();
                    break;
                case Keys.Right:
                case Keys.D:
                    gamerDirection = GamerDirection.Right;
                    MoveGamer();
                    break;
                case Keys.Down:
                case Keys.S:
                    gamerDirection = GamerDirection.Down;
                    MoveGamer();
                    break;
                case Keys.Up:
                case Keys.W:
                    gamerDirection = GamerDirection.Up;
                    MoveGamer();
                    break;
                case Keys.Escape:
                    TimerGame.Stop();
                    Close();
                    break;
                case Keys.Space:
                    if (isGameEnded && !TimerGame.Enabled)
                        StartGame();
                    break;
            }
        }

        private void location_Click(object sender, EventArgs e)
        {

        }
    }
}

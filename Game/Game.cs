using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        private const int CELL_SIZE_PIXELS = 30;                    // Размер клетки игрового поля, в пикселях
        private const int ROWS_NUMBER = 11;                         // Количество рядов в игровом поле
        private const int COLS_NUMBER = 13;                         // Количество столбцов в игровом поле
        private const int FIELD_LEFT_OFFSET_PIXELS = 30;            // Отступ в пикселях от левого края формы
        private const int FIELD_TOP_OFFSET_PIXELS = 15;             // Отступ в пикселях от правого края формы

        private ISceneGenerate sceneGenerate = new SceneGenerate();
        private IGamer player = new Gamer();

        private int[] ConstantValue()
        {
            int[] constant = new int[] { CELL_SIZE_PIXELS, ROWS_NUMBER, COLS_NUMBER, FIELD_LEFT_OFFSET_PIXELS, FIELD_TOP_OFFSET_PIXELS };
            return constant;
        }

        public Game()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Gamer_KeyDown;

            DoubleBuffered = true;
            BackColor = Color.Black;

            gamer.Location = new Point(210, 150);
            money.Location = new Point(150, 150);
            creeper.Location = new Point(150, 210);
            sceneGenerate.CreateLocation(location, gamer, ConstantValue());
        }

        private void Gamer_KeyDown(object sender, KeyEventArgs e)
        {
            int button;
            switch (e.KeyCode)
            {
                case Keys.A:
                    button = 3;
                    player.MoveDirection(button);
                    player.MoveGamer(gamer, ConstantValue());
                    InventoryPickUp();
                    break;

                case Keys.D:
                    button = 2;
                    player.MoveDirection(button);
                    player.MoveGamer(gamer, ConstantValue());
                    InventoryPickUp();
                    break;

                case Keys.S:
                    button = 1;
                    player.MoveDirection(button);
                    player.MoveGamer(gamer, ConstantValue());
                    InventoryPickUp();
                    break;

                case Keys.W:
                    button = 0;
                    player.MoveDirection(button);
                    player.MoveGamer(gamer, ConstantValue());
                    InventoryPickUp();
                    break;

                case Keys.F:
                    player.GetInventory().Drop(inventory, money, gamer);
                    player.GetInventory().Drop(inventory, creeper, gamer);
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void InventoryPickUp()
        {
            player.GetInventory().PickUp(inventory, money, gamer);
            player.GetInventory().PickUp(inventory, creeper, gamer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.GetInventory().Drop(inventory, money, gamer);
            player.GetInventory().Drop(inventory, creeper, gamer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class Gamer : IGamer
    {
        public IInventory inventory = new Inventory();

        private enum GamerDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        private GamerDirection gamerDirection = GamerDirection.Up;  // Текущее направление движения "Игрока"

        public IInventory GetInventory() { return inventory; }

        public void MoveDirection(int button)
        {
            switch (button)
            {
                case 0:
                    gamerDirection = GamerDirection.Up;
                    break;
                case 1:
                    gamerDirection = GamerDirection.Down;
                    break;
                case 2:
                    gamerDirection = GamerDirection.Right;
                    break;
                case 3:
                    gamerDirection = GamerDirection.Left;
                    break;
            }
        }

        private bool IsGameOver(PictureBox gamer, int[] constant)
        {
            switch (gamerDirection)
            {
                case GamerDirection.Left:
                    return gamer.Location.X - constant[0] < constant[2] + constant[0];
                case GamerDirection.Right:
                    return gamer.Location.X + constant[0] >= constant[2] * constant[0] + constant[0];
                case GamerDirection.Down:
                    return gamer.Location.Y + constant[0] >= constant[1] * constant[0];
                case GamerDirection.Up:
                    return gamer.Location.Y - constant[0] < constant[0];
            }
            return false;
        }

        public void MoveGamer(PictureBox gamer, int[] constant)
        {
            switch (gamerDirection)
            {
                case GamerDirection.Up:
                    if (IsGameOver(gamer, constant))
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y - constant[0] / 2);
                    break;
                case GamerDirection.Down:
                    if (IsGameOver(gamer, constant))
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y + constant[0]  / 2);
                    break;
                case GamerDirection.Right:
                    if (IsGameOver(gamer, constant))
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X + constant[0] / 2, gamer.Location.Y);
                    break;
                case GamerDirection.Left:
                    if (IsGameOver(gamer, constant))
                        gamer.Location = new Point(gamer.Location.X, gamer.Location.Y);
                    else
                        gamer.Location = new Point(gamer.Location.X - constant[0] / 2, gamer.Location.Y);
                    break;
            }
        }
    }
}

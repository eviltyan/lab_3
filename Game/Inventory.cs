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
    internal class Inventory : IInventory
    {
        public void PickUp(ListBox inventory, PictureBox item, PictureBox gamer)
        {
            if ((item.Visible) && item.Location.X.Equals(gamer.Location.X) && item.Location.Y.Equals(gamer.Location.Y))
            {
                inventory.Items.Add(item.Name);
                item.Visible = false;
            }
        }

        public void Drop(ListBox inventory, PictureBox item, PictureBox gamer)
        {
            string nameItem = inventory.Text;

            if (item.Name ==  nameItem)
            {
                inventory.Items.Remove(nameItem);

                item.Location = new Point(gamer.Location.X + 30, gamer.Location.Y);
                item.Visible = true;
            }
        }
    }
}

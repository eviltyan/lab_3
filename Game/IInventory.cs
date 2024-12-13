using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal interface IInventory
    {
        void PickUp(ListBox inventory, PictureBox item, PictureBox gamer);
        void Drop(ListBox inventory, PictureBox item, PictureBox gamer);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal interface IGamer 
    {
        IInventory GetInventory();
        void MoveGamer(PictureBox gamer, int[] constant);
        void MoveDirection(int button);
    }
}

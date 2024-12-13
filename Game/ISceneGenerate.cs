using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal interface ISceneGenerate
    {
        void CreateLocation(PictureBox location, PictureBox gamer, int[] constant);
    }
}

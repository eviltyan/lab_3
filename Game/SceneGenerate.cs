using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class SceneGenerate : ISceneGenerate
    {
        public void CreateLocation(PictureBox location, PictureBox gamer, int[] constant)
        {
            DrawGrid(location, constant);
            DrawGamer(gamer, constant);
        }

        private void DrawGrid(PictureBox location, int[] constant)
        {
            location.Location = new Point(constant[3], constant[4]);
            location.BackColor = Color.Coral;
            location.Width = constant[0] * constant[2];
            location.Height = constant[0] * constant[1];

        }

        private void DrawGamer(PictureBox gamer, int[] constant)
        {
            gamer.Image = Image.FromFile("Starlight.png");
            gamer.Width = constant[0];
            gamer.Height = constant[0];
        }
    }
}

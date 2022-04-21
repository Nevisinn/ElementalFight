using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ElementalFight.Models
{
    internal class Hero
    {
        public int posX;
        public int posY;

        public static int idleFrames = 5;
        public static int runFrames=6;
        public static int attackFrames=7;
        public static int deathFrames=8;
    }
}

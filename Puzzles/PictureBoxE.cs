using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Puzzles
{
    class PictureBoxE : PictureBox
    {
        private int rotateCount;
        public int RotateCount
        { get { return rotateCount; } set { rotateCount = value % 4; } }
        public int Number;

    }
}

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

        //public Image Rotate(Image bitmap, int count)
        //{
        //    if(count % 4 == 1)
        //    bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //    else if (count % 4 == 2)
        //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
        //    else if (count % 4 == 3)
        //        bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);

        //   return bitmap;
        //}
    }
}

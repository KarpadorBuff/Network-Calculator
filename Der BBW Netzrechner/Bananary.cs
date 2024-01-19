using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Der_BBW_Netzrechner
{
    internal class Bananary
    {
        public static void BinaryToBananary(Boolean[]ipadresse)
        {
            PictureBox[] banana = new PictureBox[32];
            for (int i = 0; i < 32; i++) 
            {
                banana[i].Visible = ipadresse[i];
            }
        }
    }
}

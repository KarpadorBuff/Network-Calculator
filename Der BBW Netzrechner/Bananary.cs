namespace Der_BBW_Netzrechner
{
    internal class Bananary
    {
        public static void BinaryToBananary(bool[] ipadresse, PictureBox[] pbarray)
        {

            for (int i = 0; i < 32; i++)
            {
                pbarray[i].Enabled = ipadresse[i];
            }
        }
    }
}

using System.Diagnostics;

namespace Der_BBW_Netzrechner
{
    internal class Methods
    {
        public static int StringToInt(string input)
        {
            string str = null;
            int ret;
            int? output;
            foreach (char c in input)
            {
                output = null;
                if (c >= 48 && c <= 59)
                    output = c - 48;
                if (output != null) str += output.ToString();
            }
            str ??= "";
            try
            {
                return Int16.Parse(str);
            }
            catch
            {
                return 0;
            }

        }
        public static string StringToBinary(string decimalvalue)
        {
            Debug.WriteLine(decimalvalue);
            if (decimalvalue == "") return "";
            else return Convert.ToString(Convert.ToInt16(decimalvalue), 2).PadLeft(8, '0');
        }
    }
}
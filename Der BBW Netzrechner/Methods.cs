using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(str == null) str = "";
            foreach (char c in str) 
            { 
            
            }
            return str;
        }
        public static string StringToBinary(string decimalvalue)
        {
            Debug.WriteLine(decimalvalue);
            if (decimalvalue == "") return "0";
            else return Convert.ToString(Convert.ToInt16(decimalvalue), 2);
        }
    }
}

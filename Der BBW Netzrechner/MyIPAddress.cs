using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Der_BBW_Netzrechner
{
    internal class MyIPAddress
    {
        int[]       ip_Decimal;
        string[]    ip_Binary;

        public int netmask_decimal = 16;
        public MyIPAddress(int[] ipDecimal) 
        { 
            this.ip_Decimal = new int[4];
            ip_Binary = new string[4];
            setIPDecimal(ipDecimal);
            
        }
        public void setIPDecimal(int[] arr)
        {
            if (arr.Length == 4)
            {
                 ip_Decimal[0] = arr[0];
                 ip_Decimal[1] = arr[1];
                 ip_Decimal[2] = arr[2];
                 ip_Decimal[3] = arr[3];
            }            
            calcBinaryfromDecimal();
        }
        public void calcBinaryfromDecimal()
        {
            int[] arr = getIpDecimal();
            foreach (int i in arr)
            {
                //Debug.WriteLine(i);
            }
            ip_Binary[0] = Methods.StringToBinary(arr[0].ToString()).PadRight(8, '0');
            ip_Binary[1] = Methods.StringToBinary(arr[1].ToString()).PadRight(8, '0');
            ip_Binary[2] = Methods.StringToBinary(arr[2].ToString()).PadRight(8, '0');
            ip_Binary[3] = Methods.StringToBinary(arr[3].ToString()).PadRight(8, '0');
        }
        public int[] getIpDecimal()
        {
            return ip_Decimal;
        }
        public string[] getIpBinary() 
        {
            return ip_Binary;
        }
        public string[] getSubnetmaskBinary()
        {
            string[] ret = new string[4];
            string s = "";
            for (int i = 1; i <= 32; i++)
            {
                if(i <= netmask_decimal)s += "1";
                else s += "0";
                //Debug.WriteLine(s + " L:" + s.Length);
            }
            if(s.Length == 32)
            {
                ret[0] = s.Substring(0, 8);
                ret[1] = s.Substring(8, 8);
                ret[2] = s.Substring(16, 8);
                ret[3] = s.Substring(24, 8);
            }
            return ret;
        }
        public int[] getSubnetmaskDecimal()
        {
            int[] ret = new int[4];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = Convert.ToInt32(getSubnetmaskBinary()[i], 2);
            }

            return ret;
        }
        public string[] getWildcardMask()
        {
            string[] ret = new string[4];
            for (int i = 0; i <= 3; i++) { 
                string newstring = "";
                
                for (int l = 0; l <= getSubnetmaskBinary()[i].Length-1; l++)
                {
                    //Debug.Write(getSubnetmaskBinary()[i][l] + "-->" + newstring + "\n");
                    if (getSubnetmaskBinary()[i][l] == '1')newstring += "0";
                    else newstring += "1";
                }
                ret[i] = newstring;
            }
            return ret;
        }
        public string[] getBroadcast_Binary()
        {
            string[] ret = new string[]{"", "", "", "" };
            int netmaskremainder = netmask_decimal;
            for (int i = 0; i < 4; i++)
            {
                if(netmaskremainder > 8)
                {
                    ret[i] = getIpBinary()[i];
                    netmaskremainder -= 8;
                }
                else
                {
                    for (int j = 0; j < netmaskremainder; j++)
                    {
                        ret[i] += getIpBinary()[i][j];
                    }
                    netmaskremainder = 0;
                    ret[i] = ret[i].PadRight(8, '1');
                }
            }
            return ret;
        }
        public string[] getNetaddress_Binary()
        {
            string[] ret = new string[] { "", "", "", "" };
            int netmaskremainder = netmask_decimal;
            for (int i = 0; i < 4; i++)
            {
                if (netmaskremainder > 8)
                {
                    ret[i] = getIpBinary()[i];
                    netmaskremainder -= 8;
                }
                else
                {
                    for (int j = 0; j < netmaskremainder; j++)
                    {
                        ret[i] += getIpBinary()[i][j];
                    }
                    netmaskremainder = 0;
                    ret[i] = ret[i].PadRight(8, '0');
                }
            }
            return ret;
        }
    }
}

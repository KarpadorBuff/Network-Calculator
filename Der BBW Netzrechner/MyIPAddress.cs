namespace Der_BBW_Netzrechner
{
    internal class MyIPAddress
    {
        readonly int[] ip_Decimal;
        readonly string[] ip_Binary;

        public int netmask_decimal = 16;
        public MyIPAddress(int[] ipDecimal)
        {
            this.ip_Decimal = new int[4];
            ip_Binary = new string[4];
            SetIPDecimal(ipDecimal);

        }
        public int[] GetIpDecimal()
        {
            return ip_Decimal;
        }
        public void SetIPDecimal(int[] arr)
        {
            if (arr.Length == 4)
            {
                ip_Decimal[0] = arr[0];
                ip_Decimal[1] = arr[1];
                ip_Decimal[2] = arr[2];
                ip_Decimal[3] = arr[3];
            }
            CalcBinaryfromDecimal();
        }

        public string[] GetIpBinary()
        {
            return ip_Binary;
        }
        public static bool[] GetIpBinary(string[] stringarray)
        {
            string bin32 = "";
            bool[] ret = new bool[32];
            for (int i = 0; i < 4; i++)
            {
                bin32 += stringarray[i];
            }
            for (int i = 0; i < 32; i++)
            {
                if (bin32[i] == '1') ret[i] = true;
                else ret[i] = false;
            }

            return ret;
        }
        
        public void CalcBinaryfromDecimal()
        {
            int[] arr = GetIpDecimal();
            ip_Binary[0] = Methods.StringToBinary(arr[0].ToString()).PadRight(8, '0');
            ip_Binary[1] = Methods.StringToBinary(arr[1].ToString()).PadRight(8, '0');
            ip_Binary[2] = Methods.StringToBinary(arr[2].ToString()).PadRight(8, '0');
            ip_Binary[3] = Methods.StringToBinary(arr[3].ToString()).PadRight(8, '0');
        }

        
        public string[] GetSubnetmaskBinary()
        {
            string[] ret = new string[4];
            string s = "";
            for (int i = 1; i <= 32; i++)
            {
                if (i <= netmask_decimal) s += "1";
                else s += "0";
            }
            if (s.Length == 32)
            {
                ret[0] = s[..8];
                ret[1] = s.Substring(8, 8);
                ret[2] = s.Substring(16, 8);
                ret[3] = s.Substring(24, 8);
            }
            return ret;
        }
        public int[] GetSubnetmaskDecimal()
        {
            int[] ret = new int[4];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = Convert.ToInt32(GetSubnetmaskBinary()[i], 2);
            }

            return ret;
        }
        
        public string[] GetWildcardMask()
        {
            string[] ret = new string[4];
            for (int i = 0; i <= 3; i++)
            {
                string newstring = "";

                for (int l = 0; l <= GetSubnetmaskBinary()[i].Length - 1; l++)
                {
                    if (GetSubnetmaskBinary()[i][l] == '1') newstring += "0";
                    else newstring += "1";
                }
                ret[i] = newstring;
            }
            return ret;
        }
        
        public string[] GetBroadcast_Binary()
        {
            string[] ret = new string[] { "", "", "", "" };
            int netmaskremainder = netmask_decimal;
            for (int i = 0; i < 4; i++)
            {
                if (netmaskremainder > 8)
                {
                    ret[i] = GetIpBinary()[i];
                    netmaskremainder -= 8;
                }
                else
                {
                    for (int j = 0; j < netmaskremainder; j++)
                    {
                        ret[i] += GetIpBinary()[i][j];
                    }
                    netmaskremainder = 0;
                    ret[i] = ret[i].PadRight(8, '1');
                }
            }
            return ret;
        }
        
        public string[] GetNetaddress_Binary()
        {
            string[] ret = new string[] { "", "", "", "" };
            int netmaskremainder = netmask_decimal;
            for (int i = 0; i < 4; i++)
            {
                if (netmaskremainder > 8)
                {
                    ret[i] = GetIpBinary()[i];
                    netmaskremainder -= 8;
                }
                else
                {
                    for (int j = 0; j < netmaskremainder; j++)
                    {
                        ret[i] += GetIpBinary()[i][j];
                    }
                    netmaskremainder = 0;
                    ret[i] = ret[i].PadRight(8, '0');
                }
            }
            return ret;
        }
    }
}

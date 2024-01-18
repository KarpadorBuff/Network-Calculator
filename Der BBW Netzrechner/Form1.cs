using System.Diagnostics;
using System.Net;

namespace Der_BBW_Netzrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyIPAddress address;
        private readonly int[] baseIP = { 192, 168, 0, 0 };
        private void Form1_Load(object sender, EventArgs e)
        {
            address = new MyIPAddress(baseIP);
            //Fill Decimal values from address values
            TDecOct1.Text = baseIP[0].ToString();
            TDecOct2.Text = baseIP[1].ToString();
            TDecOct3.Text = baseIP[2].ToString();
            TDecOct4.Text = baseIP[3].ToString();
        }
        private void UpdateAll()
        {
            address.netmask_decimal = Methods.StringToInt(TBnetmask.Text);
            address.setIPDecimal(
                new int[] {
                Methods.StringToInt(TDecOct1.Text),
                Methods.StringToInt(TDecOct2.Text),
                Methods.StringToInt(TDecOct3.Text),
                Methods.StringToInt(TDecOct4.Text)});

            //variables
            int[] arrayDecimal = address.getIpDecimal();
            string[] arrayBinary = address.getIpBinary();
            string[] subnetBinary = address.getSubnetmaskBinary();



            


            

            //debug msgs
            Debug.Write("current IP: ");
            for (int i = 0; i < arrayDecimal.Length; i++)
            {
                Debug.Write(arrayDecimal[i]);
                if (i != 3)
                {
                    Debug.Write('.');
                }
            }
            Debug.Write('\n');
        }

        private void Decimal_Textchanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] arr;
            int i = Methods.StringToInt(TBnetmask.Text);
            // input Maximaler Wert prüfen
            if (i > 32) address.netmask_decimal = 32;
            else if (i < 0) address.netmask_decimal = 0;
            else address.netmask_decimal = i;
            Debug.WriteLine(address.netmask_decimal);
            arr = address.getSubnetmaskBinary();
            netmask1.Text = arr[0];
            netmask2.Text = arr[1];
            netmask3.Text = arr[2];
            netmask4.Text = arr[3];

        }

        private void Any_text_changed(object sender, EventArgs e)
        {

        }

        private void Decimal_Text_Changed(object sender, EventArgs e)
        {
            address.setIPDecimal(
                new int[] {
                Methods.StringToInt(TDecOct1.Text),
                Methods.StringToInt(TDecOct2.Text),
                Methods.StringToInt(TDecOct3.Text),
                Methods.StringToInt(TDecOct4.Text)});

            //Fill Binary values from address values
            LBinOct1.Text = address.getIpBinary()[0];
            LBinOct2.Text = address.getIpBinary()[1];
            LBinOct3.Text = address.getIpBinary()[2];
            LBinOct4.Text = address.getIpBinary()[3];
        }

        private void netmaskDecimalChanged(object sender, EventArgs e)
        {
            address.netmask_decimal = Methods.StringToInt(TBnetmask.Text);
            Subnet1.Text = address.getSubnetmaskDecimal()[0].ToString();
            Subnet2.Text = address.getSubnetmaskDecimal()[1].ToString();
            Subnet3.Text = address.getSubnetmaskDecimal()[2].ToString();
            Subnet4.Text = address.getSubnetmaskDecimal()[3].ToString();

            netmask1.Text = address.getSubnetmaskBinary()[0].ToString();
            netmask2.Text = address.getSubnetmaskBinary()[1].ToString();
            netmask3.Text = address.getSubnetmaskBinary()[2].ToString();
            netmask4.Text = address.getSubnetmaskBinary()[3].ToString();

            netmask_I1.Text = address.getWildcardMask()[0];
            netmask_I2.Text = address.getWildcardMask()[1];
            netmask_I3.Text = address.getWildcardMask()[2];
            netmask_I4.Text = address.getWildcardMask()[3];

        }
    }
}
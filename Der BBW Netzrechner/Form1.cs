using Der_BBW_Netzrechner.Properties;
using System.Globalization;

namespace Der_BBW_Netzrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int EasterEgg_clicks_to_activation = 10;
        readonly MyIPAddress address = new(new int[] { 192, 168, 30, 101 });
        bool finished_loading = false;
        private readonly PictureBox[] pbarray = new PictureBox[32];

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                for (int y = 8 * i; y < 8 + 8 * i; y++)
                {
                    PictureBox pb = new()
                    {
                        Image = Resources.banana_happy,
                        Visible = true,
                        Enabled = true,
                        Size = new Size(15, 15),
                        Location = new Point(15 * y + i * 10, 375),
                        SizeMode = PictureBoxSizeMode.StretchImage

                    };
                    this.Controls.Add(pb);
                    pb.Show();
                    pb.Update();
                    pbarray[y] = pb;
                    Thread.Sleep(0);
                }
            }
            //Fill Decimal values from address values
            TDecOct1.Text = address.GetIpDecimal()[0].ToString();
            TDecOct2.Text = address.GetIpDecimal()[1].ToString();
            TDecOct3.Text = address.GetIpDecimal()[2].ToString();
            TDecOct4.Text = address.GetIpDecimal()[3].ToString();
            finished_loading = true;
        }

        private void Decimal_Text_Changed(object sender, EventArgs e)
        {
            if (finished_loading)
                address.SetIPDecimal(
                    new int[] {
                Methods.StringToInt(TDecOct1.Text),
                Methods.StringToInt(TDecOct2.Text),
                Methods.StringToInt(TDecOct3.Text),
                Methods.StringToInt(TDecOct4.Text)
                    });



            //Fill Binary values from address values
            LBinOct1.Text = address.GetIpBinary()[0];
            LBinOct2.Text = address.GetIpBinary()[1];
            LBinOct3.Text = address.GetIpBinary()[2];
            LBinOct4.Text = address.GetIpBinary()[3];

            address.netmask_decimal = Methods.StringToInt(TBnetmask.Text);
            Subnet1.Text = address.GetSubnetmaskDecimal()[0].ToString();
            Subnet2.Text = address.GetSubnetmaskDecimal()[1].ToString();
            Subnet3.Text = address.GetSubnetmaskDecimal()[2].ToString();
            Subnet4.Text = address.GetSubnetmaskDecimal()[3].ToString();

            netmask1.Text = address.GetSubnetmaskBinary()[0].ToString();
            netmask2.Text = address.GetSubnetmaskBinary()[1].ToString();
            netmask3.Text = address.GetSubnetmaskBinary()[2].ToString();
            netmask4.Text = address.GetSubnetmaskBinary()[3].ToString();

            netmask_I1.Text = address.GetWildcardMask()[0];
            netmask_I2.Text = address.GetWildcardMask()[1];
            netmask_I3.Text = address.GetWildcardMask()[2];
            netmask_I4.Text = address.GetWildcardMask()[3];

            broadcast1.Text = address.GetBroadcast_Binary()[0];
            broadcast2.Text = address.GetBroadcast_Binary()[1];
            broadcast3.Text = address.GetBroadcast_Binary()[2];
            broadcast4.Text = address.GetBroadcast_Binary()[3];

            netzaddresse1.Text = address.GetNetaddress_Binary()[0];
            netzaddresse2.Text = address.GetNetaddress_Binary()[1];
            netzaddresse3.Text = address.GetNetaddress_Binary()[2];
            netzaddresse4.Text = address.GetNetaddress_Binary()[3];

            NetzAddr1.Text = Convert.ToInt16(netzaddresse1.Text, 2).ToString();
            NetzAddr2.Text = Convert.ToInt16(netzaddresse2.Text, 2).ToString();
            NetzAddr3.Text = Convert.ToInt16(netzaddresse3.Text, 2).ToString();
            NetzAddr4.Text = Convert.ToInt16(netzaddresse4.Text, 2).ToString();

            ipBroadcast1.Text = Convert.ToInt16(broadcast1.Text, 2).ToString();
            ipBroadcast2.Text = Convert.ToInt16(broadcast2.Text, 2).ToString();
            ipBroadcast3.Text = Convert.ToInt16(broadcast3.Text, 2).ToString();
            ipBroadcast4.Text = Convert.ToInt16(broadcast4.Text, 2).ToString();

            Bananary.BinaryToBananary(MyIPAddress.GetIpBinary(address.GetIpBinary()), pbarray);
            if (address.netmask_decimal != Methods.StringToInt(TBnetmask.Text))
                address.netmask_decimal = Methods.StringToInt(TBnetmask.Text);
            if(address.netmask_decimal >= 0 && address.netmask_decimal <= 35)
            {
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                if (address.netmask_decimal < 32)
                    hostamount.Text = (Math.Pow(2, 32 - address.netmask_decimal) - 2).ToString("0,0", elGR);
                else switch (address.netmask_decimal)
                    {
                        default:
                            hostamount.Text = "now you broke it...";
                            break;
                        case 32:
                            hostamount.Text = "whatchu tryna do?";
                            break;
                        case 33:
                            hostamount.Text = "ur makin it worse";
                            break;
                        case 34:
                            hostamount.Text = "no STOP!";
                            break;


                    }

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            EasterEgg_clicks_to_activation--;
            if (EasterEgg_clicks_to_activation == 0)
            {
                this.Size = new Size(this.Width, this.Height + 30);

            }

        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            if(address.netmask_decimal < 35)
            address.netmask_decimal++;
            TBnetmask.Text = address.netmask_decimal.ToString();
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            if (address.netmask_decimal > 0)
            address.netmask_decimal--;
            TBnetmask.Text = address.netmask_decimal.ToString();
        }
    }
}
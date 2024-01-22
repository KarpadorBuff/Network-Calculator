using Der_BBW_Netzrechner.Properties;

namespace Der_BBW_Netzrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int EasterEgg_clicks_to_activation = 1;
        readonly MyIPAddress address = new(new int[] {1,2,3,4});
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
            //for (int i = 0; i < 32; i++)
            //{
            //    PictureBox pb = new()
            //    {
            //        Image = Resources.banana_happy,
            //        Visible = true,
            //        Enabled = true,
            //        Size = new Size(15, 15),
            //        Location = new Point(15 * i + 10*i, 500),
            //        SizeMode = PictureBoxSizeMode.StretchImage
            //    };
            //    this.Controls.Add(pb);
            //    pb.Show();
            //    pb.Update();
            //    pbarray[i] = pb;
            //    Thread.Sleep(0);
            //}
            //Fill Decimal values from address values
            TDecOct1.Text = address.GetIpDecimal()[0].ToString();
            TDecOct2.Text = address.GetIpDecimal()[1].ToString();
            TDecOct3.Text = address.GetIpDecimal()[2].ToString();
            TDecOct4.Text = address.GetIpDecimal()[3].ToString();
        }

        private void Decimal_Text_Changed(object sender, EventArgs e)
        {
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

            Bananary.BinaryToBananary(MyIPAddress.GetIpBinary(address.GetIpBinary()), pbarray);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (EasterEgg_clicks_to_activation == 0)
            {
                this.Size = new Size(this.Width, this.Height + 30);

            }
            EasterEgg_clicks_to_activation--;

        }
    }
}
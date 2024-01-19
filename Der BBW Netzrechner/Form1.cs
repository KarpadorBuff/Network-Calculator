using Der_BBW_Netzrechner.Properties;
using System.Diagnostics;

namespace Der_BBW_Netzrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int EasterEgg_clicks_to_activation = 10;
        MyIPAddress address;
        private readonly int[] baseIP = { 192, 168, 0, 0 };
        private PictureBox[] pbarray = new PictureBox[32];
        private void Form1_Load(object sender, EventArgs e)
        {
            address = new MyIPAddress(baseIP);
            //Fill Decimal values from address values
            TDecOct1.Text = baseIP[0].ToString();
            TDecOct2.Text = baseIP[1].ToString();
            TDecOct3.Text = baseIP[2].ToString();
            TDecOct4.Text = baseIP[3].ToString();
            for (int i = 0; i <= 32; i++)
            {
                PictureBox pb = new()
                {
                    Image = Resources.banana_happy,
                    Visible = true,
                    Enabled = true,
                    Size = new Size(15, 15),
                    Location = new Point(15 * i, 500),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                this.Controls.Add(pb);
                pb.Show();
                pb.Update();
                pbarray[i] = pb;
                Thread.Sleep(0);
            }
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

            broadcast1.Text = address.getBroadcast_Binary()[0];
            broadcast2.Text = address.getBroadcast_Binary()[1];
            broadcast3.Text = address.getBroadcast_Binary()[2];
            broadcast4.Text = address.getBroadcast_Binary()[3];

            netzaddresse1.Text = address.getNetaddress_Binary()[0];
            netzaddresse2.Text = address.getNetaddress_Binary()[1];
            netzaddresse3.Text = address.getNetaddress_Binary()[2];
            netzaddresse4.Text = address.getNetaddress_Binary()[3];

            Bananary.BinaryToBananary(address.getIpBinary(address.getIpBinary()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (EasterEgg_clicks_to_activation == 0)
            {
                this.Size = new Size(this.Width, this.Height + 200);
                
            }
            EasterEgg_clicks_to_activation--;
            
        }
    }
}
namespace Der_BBW_Netzrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if(Methods.StringToInt(Text) > 255)
            {

            }
            string s = Methods.StringToBinary(Methods.StringToInt(Text));
            if(Text.Length > 0) 
                LBinOct1.Text = s;
            this.Text = s;
        }
    }
}
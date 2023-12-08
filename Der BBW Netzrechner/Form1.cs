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
            string s = Methods.StringToBinary(Methods.StringToInt(TDecOct1.Text));
            if(Text.Length > 0) 
                LBinOct1.Text = s.PadLeft(8, '0');
        }
    }
}
namespace KeyBoradKeyCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblAscii.Text = e.KeyCode.ToString();
            lblDec.Text = e.KeyCode.ToString();
            lblHex.Text = $"0x{e.KeyCode.ToString("X2")}";
            lblMod.Text = e.Modifiers.ToString();
            lblModKey.Text = e.KeyCode.ToString();
        }
    }
}
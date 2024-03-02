namespace kpl_tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textme = txtIn.Text;

            lblOutput.Text = "Output : Hi! " + textme + ", Selamat menikmati kenyataan :)";
        }
    }
}

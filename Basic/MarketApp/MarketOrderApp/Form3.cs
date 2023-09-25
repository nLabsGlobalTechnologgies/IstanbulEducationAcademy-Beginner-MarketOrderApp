namespace MarketOrderApp
{
    public partial class Form3 : Form
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        private Form1 frm = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
            Password = textBox2.Text;

            if (UserName == null || UserName == "" && Password == null || Password == "")
            {
            }
            else
            {
                if (UserName == frm.userName && Password == frm.password)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz.");
                return;
            }
            this.Close();
        }
    }
}

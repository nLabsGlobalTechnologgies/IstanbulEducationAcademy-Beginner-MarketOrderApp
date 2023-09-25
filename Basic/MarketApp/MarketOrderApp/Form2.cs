namespace MarketOrderApp
{
    public partial class Form2 : Form
    {
        public int inPiece { get; set; }
        public int inPrice { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            inPrice = Convert.ToInt32(textBox2.Text);
            inPiece = Convert.ToInt32(nPiece.Text);
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Lütfen Fiyat bilgisi giriniz.");
                return;
            }
            this.Close();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
    }
}

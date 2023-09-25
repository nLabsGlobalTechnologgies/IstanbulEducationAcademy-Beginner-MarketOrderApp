using System.Security.Principal;
using Excel = Microsoft.Office.Interop.Excel;

namespace MarketOrderApp
{
    public partial class Form1 : Form
    {
        public string userName = "admin";
        public string password = "admin";
        int inPiece;
        decimal inPrice;
        private decimal total = 0;
        private List<Basket> list = new List<Basket>();
        private Basket basket;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            userName = login.UserName;
            password = login.Password;
            login.ShowDialog();
            this.Hide();
            label2.Text = $"Hoş Geldin : {userName} Rol : {userName}";
            TotalBasket();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ShowBasket()
        {
            gridListe.DataSource = "";
            gridListe.DataSource = list;
            gridListe.Columns[0].HeaderText = "Ürün";
            gridListe.Columns[1].HeaderText = "Fiyat";
            gridListe.Columns[2].HeaderText = "Adet";
            gridListe.Columns[3].HeaderText = "total";
            TotalBasket();
        }

        void TotalBasket()
        {
            total = 0;
            foreach (var item in list)
            {
                total = item.Total + total;
                ltotal.Text = String.Format("{0:C2}", total);
            }
        }

        void AddBasket(string name)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            if (frm.inPiece == 0)
            {
                return;
            }

            if (frm.inPrice == null || frm.inPrice == 0)
            {
                return;
            }
            inPiece = frm.inPiece;
            inPrice = frm.inPrice;
            basket = new Basket
            {
                Name = name,
                Price = inPrice,
                Piece = inPiece
            };
            basket.Total = basket.Price * basket.Piece;
            list.Add(basket);
            ShowBasket();
        }

        private void bCola_Click(object sender, EventArgs e)
        {
            AddBasket(bCola.Text);
        }

        private void bPepsi_Click(object sender, EventArgs e)
        {
            AddBasket(bPepsi.Text);
        }

        private void bMarul_Click(object sender, EventArgs e)
        {
            AddBasket(bMarul.Text);
        }

        private void bSogan_Click(object sender, EventArgs e)
        {
            AddBasket(bSogan.Text);
        }

        private void bBiber_Click(object sender, EventArgs e)
        {
            AddBasket(bBiber.Text);
        }

        private void gridListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {
                string result = gridListe.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                if (MessageBox.Show($"{result}Adlı Ürünü Silmek İstediginize emin misiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    list.RemoveAt(e.RowIndex);
                    ShowBasket();
                }
            }
        }

        void ExportToExcel(string message)
        {
            //Created Excel Object
            Excel.Application excel = new Excel.ApplicationClass();
            object Missing = Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.Worksheets[1];

            //Title SetNames
            worksheet.Range["A1"].Value = "#";
            worksheet.Range["B1"].Value = "Ürün";
            worksheet.Range["C1"].Value = "Adet";
            worksheet.Range["D1"].Value = "Fiyat";
            worksheet.Range["E1"].Value = "Toplam";

            //Title SetNames Font Bold Action
            worksheet.Range["A1"].Font.Bold = true;
            worksheet.Range["B1"].Font.Bold = true;
            worksheet.Range["C1"].Font.Bold = true;
            worksheet.Range["D1"].Font.Bold = true;
            worksheet.Range["E1"].Font.Bold = true;

            //Sheet Withs
            worksheet.Range["A1"].ColumnWidth = 3.43;
            worksheet.Range["B1"].ColumnWidth = 13.29;
            worksheet.Range["C1"].ColumnWidth = 4.57;
            worksheet.Range["D1"].ColumnWidth = 10.57;
            worksheet.Range["E1"].ColumnWidth = 13.71;

            //Title Set Color Red
            worksheet.Range["A1:E1"].Font.ColorIndex = 3;

            //Product List Add To Excell Export
            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;
            rowCount++;
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Range["A" + rowCount].Value = i + 1;
                worksheet.Range["B" + rowCount].Value = list[i].Name;
                worksheet.Range["C" + rowCount].Value = list[i].Piece;
                worksheet.Range["D" + rowCount].Value = list[i].Price;
                worksheet.Range["E" + rowCount].Value = list[i].Total;
                rowCount++;
            }
            worksheet.Range["A1:E" + (rowCount - 1)].Borders.LineStyle = 1;

            //Add To Total Price Worksheet
            worksheet.Range["E" + rowCount].Formula = "=Sum(E2:E" + (rowCount - 1) + ")";
            worksheet.Range["E" + rowCount].Borders.LineStyle = 1;
            rowCount++;
            //Total Payment method Title Action
            worksheet.Range["A" + rowCount].Value = $"{message}";
            worksheet.Range["A" + rowCount + ":E" + rowCount].MergeCells = true;
            worksheet.Range["A" + rowCount].HorizontalAlignment = 3;
            worksheet.Range["A" + rowCount].VerticalAlignment = 2;
            worksheet.Range["A" + rowCount].Font.ColorIndex = 3;
            worksheet.Range["A" + rowCount].Font.Bold = true;

            //Price,Total Price Numbers ConvertTo Currency Format
            worksheet.Range["D2:D" + rowCount].NumberFormat = "#,##0.00" + " ₺";
            worksheet.Range["E2:E" + rowCount].NumberFormat = "#,##0.00" + " ₺";

            //if you Export To Pdf this Code Bottom Code
            //worksheet.PrintOutEx();

            //or you export to excell this COde Bottom Code

            // Active User on the Computer Code
            //Export To Desktop Save Excell File and DateTime this file name example payment_Datetime.Now example payment_12.12.2025.xlsx
            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            string userName = currentUser.Name.Split('\\')[1];
            string desktopPath = @$"C:\Users\{userName}\Desktop\";
            string folder = $"payment_{DateTime.Now:dd.MM.yyyy}.xlsx";

            workbook.SaveAs(desktopPath + folder);

            excel.Visible = true;
        }

        private void bNakit_Click(object sender, EventArgs e)
        {
            ShowMessage("Sepetteki Ürünler Nakit Yöntemi İle Ödendi!", "Nakit İle Ödeme İşlem");
        }

        private void bKrediKart_Click(object sender, EventArgs e)
        {
            ShowMessage("Sepetteki Ürünler Kredi Kartı Yöntemi İle Ödendi!", "Kredi Kartı İle Ödeme İşlemi");
        }

        void ShowMessage(string message, string information)
        {
            if (list.Count > 0)
            {
                MessageBox.Show(message, information, MessageBoxButtons.OK, MessageBoxIcon.Question);
                ExportToExcel(message);
                list = new List<Basket>();
                ShowBasket();
            }
            else
            {
                MessageBox.Show("Sepetiniz Boş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

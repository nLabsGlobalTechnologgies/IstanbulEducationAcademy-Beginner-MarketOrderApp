namespace MarketOrderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bCola = new Button();
            ltotal = new Label();
            gridListe = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            bPepsi = new Button();
            bMarul = new Button();
            bSogan = new Button();
            bBiber = new Button();
            bNakit = new Button();
            bKrediKart = new Button();
            bClose = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridListe).BeginInit();
            SuspendLayout();
            // 
            // bCola
            // 
            bCola.BackColor = Color.Chocolate;
            bCola.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bCola.Location = new Point(12, 128);
            bCola.Name = "bCola";
            bCola.Size = new Size(353, 158);
            bCola.TabIndex = 0;
            bCola.Text = "Kola";
            bCola.UseVisualStyleBackColor = false;
            bCola.Click += bCola_Click;
            // 
            // ltotal
            // 
            ltotal.AutoSize = true;
            ltotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ltotal.ForeColor = Color.ForestGreen;
            ltotal.Location = new Point(792, 716);
            ltotal.Name = "ltotal";
            ltotal.Size = new Size(63, 32);
            ltotal.TabIndex = 1;
            ltotal.Text = "0,00";
            // 
            // gridListe
            // 
            gridListe.AllowUserToAddRows = false;
            gridListe.AllowUserToDeleteRows = false;
            gridListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListe.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            gridListe.DefaultCellStyle = dataGridViewCellStyle4;
            gridListe.GridColor = SystemColors.InactiveCaption;
            gridListe.Location = new Point(792, 12);
            gridListe.Name = "gridListe";
            gridListe.ReadOnly = true;
            gridListe.RowTemplate.Height = 25;
            gridListe.Size = new Size(463, 680);
            gridListe.TabIndex = 2;
            gridListe.CellContentClick += gridListe_CellContentClick;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Maroon;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "Sil";
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.HeaderText = "Sil";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Sil";
            // 
            // bPepsi
            // 
            bPepsi.BackColor = Color.Chocolate;
            bPepsi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bPepsi.Location = new Point(425, 128);
            bPepsi.Name = "bPepsi";
            bPepsi.Size = new Size(339, 158);
            bPepsi.TabIndex = 0;
            bPepsi.Text = "Pepsi";
            bPepsi.UseVisualStyleBackColor = false;
            bPepsi.Click += bPepsi_Click;
            // 
            // bMarul
            // 
            bMarul.BackColor = Color.Chocolate;
            bMarul.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bMarul.Location = new Point(12, 292);
            bMarul.Name = "bMarul";
            bMarul.Size = new Size(353, 154);
            bMarul.TabIndex = 0;
            bMarul.Text = "Marul";
            bMarul.UseVisualStyleBackColor = false;
            bMarul.Click += bMarul_Click;
            // 
            // bSogan
            // 
            bSogan.BackColor = Color.Chocolate;
            bSogan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bSogan.Location = new Point(425, 292);
            bSogan.Name = "bSogan";
            bSogan.Size = new Size(339, 154);
            bSogan.TabIndex = 0;
            bSogan.Text = "Sogan";
            bSogan.UseVisualStyleBackColor = false;
            bSogan.Click += bSogan_Click;
            // 
            // bBiber
            // 
            bBiber.BackColor = Color.Chocolate;
            bBiber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bBiber.Location = new Point(12, 452);
            bBiber.Name = "bBiber";
            bBiber.Size = new Size(752, 159);
            bBiber.TabIndex = 0;
            bBiber.Text = "Biber";
            bBiber.UseVisualStyleBackColor = false;
            bBiber.Click += bBiber_Click;
            // 
            // bNakit
            // 
            bNakit.BackColor = Color.FromArgb(0, 192, 0);
            bNakit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bNakit.Location = new Point(32, 624);
            bNakit.Name = "bNakit";
            bNakit.Size = new Size(220, 124);
            bNakit.TabIndex = 0;
            bNakit.Text = "Nakit";
            bNakit.UseVisualStyleBackColor = false;
            bNakit.Click += bNakit_Click;
            // 
            // bKrediKart
            // 
            bKrediKart.BackColor = Color.Green;
            bKrediKart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bKrediKart.Location = new Point(277, 624);
            bKrediKart.Name = "bKrediKart";
            bKrediKart.Size = new Size(220, 124);
            bKrediKart.TabIndex = 0;
            bKrediKart.Text = "Kredi Kartı";
            bKrediKart.UseVisualStyleBackColor = false;
            bKrediKart.Click += bKrediKart_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.Maroon;
            bClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bClose.ForeColor = Color.Transparent;
            bClose.Location = new Point(518, 624);
            bClose.Name = "bClose";
            bClose.Size = new Size(220, 124);
            bClose.TabIndex = 0;
            bClose.Text = "Programı Kapat";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(687, 45);
            label1.TabIndex = 3;
            label1.Text = "İstanbul Egitim Akademi Market Uygulaması";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(32, 61);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bClose;
            ClientSize = new Size(1265, 777);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridListe);
            Controls.Add(ltotal);
            Controls.Add(bBiber);
            Controls.Add(bSogan);
            Controls.Add(bMarul);
            Controls.Add(bPepsi);
            Controls.Add(bClose);
            Controls.Add(bKrediKart);
            Controls.Add(bNakit);
            Controls.Add(bCola);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bCola;
        private Label ltotal;
        private DataGridView gridListe;
        private Button bPepsi;
        private Button bMarul;
        private Button bSogan;
        private Button bBiber;
        private Button bNakit;
        private Button bKrediKart;
        private Button bClose;
        private Label label1;
        private Label label2;
        private DataGridViewButtonColumn Delete;
    }
}
namespace MarketOrderApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bSave = new Button();
            label1 = new Label();
            bClose = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            nPiece = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nPiece).BeginInit();
            SuspendLayout();
            // 
            // bSave
            // 
            bSave.Location = new Point(13, 111);
            bSave.Name = "bSave";
            bSave.Size = new Size(100, 23);
            bSave.TabIndex = 2;
            bSave.Text = "Ekle";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Adet Girin";
            // 
            // bClose
            // 
            bClose.Location = new Point(13, 140);
            bClose.Name = "bClose";
            bClose.Size = new Size(100, 23);
            bClose.TabIndex = 3;
            bClose.Text = "Vazgeç";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyat Girin";
            // 
            // nPiece
            // 
            nPiece.Location = new Point(12, 82);
            nPiece.Name = "nPiece";
            nPiece.Size = new Size(101, 23);
            nPiece.TabIndex = 4;
            nPiece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bClose;
            ClientSize = new Size(128, 174);
            Controls.Add(nPiece);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bClose);
            Controls.Add(textBox2);
            Controls.Add(bSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bSave;
        private Label label1;
        private Button bClose;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown nPiece;
    }
}
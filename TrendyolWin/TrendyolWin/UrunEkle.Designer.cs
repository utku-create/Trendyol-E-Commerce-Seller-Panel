namespace TrendyolWin
{
    partial class UrunEkle
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
            nmbBirimFiyati = new NumericUpDown();
            nmbSatirTutari = new NumericUpDown();
            nmbMiktar = new NumericUpDown();
            txtUrunAdi = new TextBox();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmbBirimFiyati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbSatirTutari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbMiktar).BeginInit();
            SuspendLayout();
            // 
            // nmbBirimFiyati
            // 
            nmbBirimFiyati.DecimalPlaces = 2;
            nmbBirimFiyati.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nmbBirimFiyati.Location = new Point(103, 85);
            nmbBirimFiyati.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmbBirimFiyati.Name = "nmbBirimFiyati";
            nmbBirimFiyati.Size = new Size(150, 29);
            nmbBirimFiyati.TabIndex = 2;
            nmbBirimFiyati.ValueChanged += nmbBirimFiyati_ValueChanged;
            // 
            // nmbSatirTutari
            // 
            nmbSatirTutari.DecimalPlaces = 2;
            nmbSatirTutari.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nmbSatirTutari.Location = new Point(103, 118);
            nmbSatirTutari.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmbSatirTutari.Name = "nmbSatirTutari";
            nmbSatirTutari.ReadOnly = true;
            nmbSatirTutari.Size = new Size(150, 29);
            nmbSatirTutari.TabIndex = 2;
            // 
            // nmbMiktar
            // 
            nmbMiktar.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            nmbMiktar.Location = new Point(103, 52);
            nmbMiktar.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmbMiktar.Name = "nmbMiktar";
            nmbMiktar.Size = new Size(150, 29);
            nmbMiktar.TabIndex = 3;
            nmbMiktar.ValueChanged += nmbMiktar_ValueChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrunAdi.Location = new Point(103, 19);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(306, 29);
            txtUrunAdi.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnEkle.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(169, 155);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 38);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 6;
            label1.Text = "Ürün Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 22);
            label2.TabIndex = 7;
            label2.Text = "Adet:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 94);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 125);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 9;
            label4.Text = "Satır Tutarı:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 92);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 10;
            label5.Text = "Birim Fiyat:";
            label5.Click += label5_Click;
            // 
            // UrunEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 196);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(txtUrunAdi);
            Controls.Add(nmbMiktar);
            Controls.Add(nmbSatirTutari);
            Controls.Add(nmbBirimFiyati);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += UrunEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nmbBirimFiyati).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbSatirTutari).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmbBirimFiyati;
        private NumericUpDown nmbSatirTutari;
        private NumericUpDown nmbMiktar;
        private TextBox txtUrunAdi;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
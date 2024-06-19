namespace TrendyolWin
{
    partial class YeniSiparis
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
            groupBox1 = new GroupBox();
            dgList = new DataGridView();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbDurum = new ComboBox();
            cmbOdemeSekli = new ComboBox();
            cmbTeslimatSekli = new ComboBox();
            dtpTarih = new DateTimePicker();
            nmbTutar = new NumericUpDown();
            txtSiparisNo = new TextBox();
            txtAdSoyad = new TextBox();
            btnDetayEkle = new Button();
            btnSaveClose = new Button();
            btnKapat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbTutar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgList);
            groupBox1.Location = new Point(12, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1308, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dgList
            // 
            dgList.BackgroundColor = Color.FromArgb(255, 192, 128);
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(3, 23);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.Size = new Size(1302, 352);
            dgList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbDurum);
            groupBox2.Controls.Add(cmbOdemeSekli);
            groupBox2.Controls.Add(cmbTeslimatSekli);
            groupBox2.Controls.Add(dtpTarih);
            groupBox2.Controls.Add(nmbTutar);
            groupBox2.Controls.Add(txtSiparisNo);
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1305, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trendyolcom2977;
            pictureBox1.Location = new Point(1150, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 198);
            label7.Name = "label7";
            label7.Size = new Size(99, 22);
            label7.TabIndex = 13;
            label7.Text = "Ödeme Şekli:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 165);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 12;
            label6.Text = "Teslimat Şekli:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(289, 166);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 11;
            label5.Text = "Sipariş Durumu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 130);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 10;
            label4.Text = "Sipariş No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 95);
            label3.Name = "label3";
            label3.Size = new Size(44, 22);
            label3.TabIndex = 9;
            label3.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 62);
            label2.Name = "label2";
            label2.Size = new Size(45, 22);
            label2.TabIndex = 8;
            label2.Text = "Tutar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 7;
            label1.Text = "Ad Soyad";
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "SİPARİŞ ALINDI", "HAZIRLANIYOR", "KARGOYA TESLİM EDİLDİ" });
            cmbDurum.Location = new Point(419, 165);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(151, 29);
            cmbDurum.TabIndex = 3;
            // 
            // cmbOdemeSekli
            // 
            cmbOdemeSekli.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOdemeSekli.FormattingEnabled = true;
            cmbOdemeSekli.Items.AddRange(new object[] { "KREDİ KARTI", "KAPIDA ÖDEME" });
            cmbOdemeSekli.Location = new Point(123, 192);
            cmbOdemeSekli.Name = "cmbOdemeSekli";
            cmbOdemeSekli.Size = new Size(151, 29);
            cmbOdemeSekli.TabIndex = 3;
            // 
            // cmbTeslimatSekli
            // 
            cmbTeslimatSekli.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTeslimatSekli.FormattingEnabled = true;
            cmbTeslimatSekli.Items.AddRange(new object[] { "EVE TESLİM", "KOMŞUMA BIRAK", "GEL-AL" });
            cmbTeslimatSekli.Location = new Point(123, 158);
            cmbTeslimatSekli.Name = "cmbTeslimatSekli";
            cmbTeslimatSekli.Size = new Size(151, 29);
            cmbTeslimatSekli.TabIndex = 3;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(124, 92);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 28);
            dtpTarih.TabIndex = 2;
            // 
            // nmbTutar
            // 
            nmbTutar.DecimalPlaces = 2;
            nmbTutar.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nmbTutar.Location = new Point(124, 59);
            nmbTutar.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmbTutar.Name = "nmbTutar";
            nmbTutar.Size = new Size(150, 28);
            nmbTutar.TabIndex = 1;
            // 
            // txtSiparisNo
            // 
            txtSiparisNo.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSiparisNo.Location = new Point(124, 125);
            txtSiparisNo.Name = "txtSiparisNo";
            txtSiparisNo.Size = new Size(125, 28);
            txtSiparisNo.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(124, 26);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 28);
            txtAdSoyad.TabIndex = 0;
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnDetayEkle.Location = new Point(15, 655);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(148, 55);
            btnDetayEkle.TabIndex = 3;
            btnDetayEkle.Text = "Ürün Ekle";
            btnDetayEkle.UseVisualStyleBackColor = false;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // btnSaveClose
            // 
            btnSaveClose.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveClose.Location = new Point(1050, 654);
            btnSaveClose.Name = "btnSaveClose";
            btnSaveClose.Size = new Size(132, 56);
            btnSaveClose.TabIndex = 4;
            btnSaveClose.Text = "Kaydet";
            btnSaveClose.UseVisualStyleBackColor = false;
            btnSaveClose.Click += btnSaveClose_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(255, 192, 192);
            btnKapat.Location = new Point(1188, 654);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(132, 55);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // YeniSiparis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 713);
            Controls.Add(btnKapat);
            Controls.Add(btnSaveClose);
            Controls.Add(btnDetayEkle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "YeniSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniSiparis";
            Load += YeniSiparis_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbTutar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgList;
        private GroupBox groupBox2;
        private ComboBox cmbDurum;
        private ComboBox cmbOdemeSekli;
        private ComboBox cmbTeslimatSekli;
        private DateTimePicker dtpTarih;
        private NumericUpDown nmbTutar;
        private TextBox txtSiparisNo;
        private TextBox txtAdSoyad;
        private Button btnDetayEkle;
        private Button btnSaveClose;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKapat;
        private PictureBox pictureBox1;
    }
}
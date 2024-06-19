namespace TrendyolWin
{
    partial class SiparisListesi
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
            btnYeniSiparis = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1154, 606);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgList
            // 
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(3, 23);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.Size = new Size(1148, 580);
            dgList.TabIndex = 0;
            // 
            // btnYeniSiparis
            // 
            btnYeniSiparis.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnYeniSiparis.BackColor = Color.FromArgb(255, 128, 0);
            btnYeniSiparis.Location = new Point(974, 624);
            btnYeniSiparis.Name = "btnYeniSiparis";
            btnYeniSiparis.Size = new Size(192, 48);
            btnYeniSiparis.TabIndex = 1;
            btnYeniSiparis.Text = "Yeni Sipariş";
            btnYeniSiparis.UseVisualStyleBackColor = false;
            btnYeniSiparis.Click += btnYeniSiparis_Click;
            // 
            // SiparisListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 684);
            Controls.Add(btnYeniSiparis);
            Controls.Add(groupBox1);
            Name = "SiparisListesi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiparisListesi";
            WindowState = FormWindowState.Maximized;
            Load += SiparisListesi_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnYeniSiparis;
        private DataGridView dgList;
    }
}
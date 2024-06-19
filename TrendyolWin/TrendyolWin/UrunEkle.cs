using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendyolWin
{
    public partial class UrunEkle : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public int siparisId;
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            nmbBirimFiyati.Value = 0;
            nmbMiktar.Value = 0;
            nmbSatirTutari.Value = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "IN_SIPARISDETAYI";

                    command.Parameters.AddWithValue("@SIPARISID", siparisId);
                    command.Parameters.AddWithValue("@URUNADI", txtUrunAdi.Text);
                    command.Parameters.AddWithValue("@BIRIMFIYATI", nmbBirimFiyati.Value);
                    command.Parameters.AddWithValue("@MIKTARI", nmbMiktar.Value);
                    command.Parameters.AddWithValue("@SATIRTUTARI", nmbSatirTutari.Value);
                    command.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        private void nmbMiktar_ValueChanged(object sender, EventArgs e)
        {
            nmbSatirTutari.Value = nmbMiktar.Value * nmbBirimFiyati.Value;
        }

        private void nmbBirimFiyati_ValueChanged(object sender, EventArgs e)
        {
            nmbSatirTutari.Value = nmbMiktar.Value * nmbBirimFiyati.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}

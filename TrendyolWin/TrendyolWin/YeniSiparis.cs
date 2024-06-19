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
    public partial class YeniSiparis : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        int id;
        public YeniSiparis()
        {
            InitializeComponent();
        }

        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtSiparisNo.Text = "";
            nmbTutar.Value = 0;
            dtpTarih.Value = System.DateTime.Now;
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "IN_SIPARISLER";
                        SqlParameter outputIdParam = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);
                        command.Parameters.AddWithValue("@ADSOYAD", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@SIPARISNO", txtSiparisNo.Text);
                        command.Parameters.AddWithValue("@TUTAR", nmbTutar.Value);
                        command.Parameters.AddWithValue("@TARIH", dtpTarih.Value);
                        command.Parameters.AddWithValue("@ODEMESEKLI", cmbOdemeSekli.Text);
                        command.Parameters.AddWithValue("@TESLIMATSEKLI", cmbTeslimatSekli.Text);
                        command.Parameters.AddWithValue("@DURUM", cmbDurum.Text);
                        //combolar eklenecek + store procedure yazılacak.
                        command.ExecuteNonQuery();
                        id = Convert.ToInt32(command.Parameters["@ID"].Value);
                    }
                }
            }
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            btnSaveClose_Click(null, null);
            UrunEkle urunEkleForm = new UrunEkle();
            urunEkleForm.siparisId = id;
            urunEkleForm.ShowDialog();
            FillDetailGrid();
        }

        private void FillDetailGrid()
        {
            DataTable dtTable = new DataTable();
            try
            {

                SqlConnection conn = new SqlConnection(conString);

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SEL_SIPARISDETAYLARI_BYSIPID";
                    cmd.Parameters.AddWithValue("@SIPARISID", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    da.Fill(dtTable);
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dgList.DataSource = dtTable;
            dgList.Columns["ID"].Visible = false;
            dgList.Columns["SIPARISID"].Visible = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

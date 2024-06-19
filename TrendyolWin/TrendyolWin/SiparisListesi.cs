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
    public partial class SiparisListesi : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public SiparisListesi()
        {
            InitializeComponent();
        }

        private void SiparisListesi_Load(object sender, EventArgs e)
        {
            dgList.DataSource = FillGrid();
            dgList.Columns["ID"].Visible = false;
        }

        private DataTable FillGrid()
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
                    cmd.CommandText = "SEL_SIPARISLER_BV";
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
            return dtTable;
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            YeniSiparis yeniSiparisForm = new YeniSiparis();
            yeniSiparisForm.ShowDialog();
            FillGrid();
        }
    }
}

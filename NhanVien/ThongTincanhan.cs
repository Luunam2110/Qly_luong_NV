using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_luong.NhanVien
{
    public partial class ThongTincanhan : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        string manv;
        public ThongTincanhan(string manv)
        {
            this.manv = manv;
            InitializeComponent();
        }
        
        private void LoadNV ()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("HoSoNhanVien",cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", manv);
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch { MessageBox.Show("Đã có lỗi sảy ra !"); }
                finally { cnn.Close(); }

            }
            txtmaNV.Text = table.Rows[0][0].ToString();
            txtHoten.Text = table.Rows[0][1].ToString();
            cbbGt.Text = table.Rows[0][2].ToString();
            dtNgS.Value = Convert.ToDateTime(table.Rows[0][3]);
            txtSDT.Text = table.Rows[0][4].ToString();
            txtDiachi.Text = table.Rows[0][5].ToString();
            txtchucvu.Text = table.Rows[0][6].ToString();
            txtmaPB.Text = table.Rows[0][7].ToString();
            txtmaNV.Enabled = false;
            txtHoten.Enabled = false;
            cbbGt.Enabled = false;
            dtNgS.Enabled = false;
            txtSDT.Enabled = false;
            txtDiachi.Enabled = false;
            txtchucvu.Enabled = false;
            txtmaPB.Enabled = false;
        }
        private void ThongTincanhan_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
    }
}

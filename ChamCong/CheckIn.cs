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

namespace Qly_luong.ChamCong
{
    public partial class CheckIn : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        String PB;
        public CheckIn(string Phongban)
        {
            this.PB = Phongban;
            InitializeComponent();
        }
        private void load_NV()
        {
            using (SqlCommand cmd = new SqlCommand("xemnhavien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                try
                {
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch
                {
                    MessageBox.Show("lỗi sql!");
                }
                finally
                {
                    cnn.Close();
                }
                DgvNhanVien.DataSource = table;
                DgvNhanVien.Columns["maPB"].Visible = false;
                DgvNhanVien.Columns["maCV"].Visible = false;
                DgvNhanVien.Columns["SDT"].Visible = false;
                DgvNhanVien.Columns["diaChi"].Visible = false;
                DgvNhanVien.Columns["gioiTinh"].Visible = false;
            }
            
        }
        private void init()
        {
            load_NV();
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}

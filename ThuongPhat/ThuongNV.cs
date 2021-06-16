using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_luong.ThuongPhat
{
    public partial class ThuongNV : Form
    {
        string PB;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public ThuongNV(string Phongban)
        {
            this.PB = Phongban;
            InitializeComponent();
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtMaNV.Text = DgvNhanVien.Rows[i].Cells["maNhanvien"].Value.ToString();
                txtTenNV.Text = DgvNhanVien.Rows[i].Cells["tenNV"].Value.ToString();
            }
            catch { }
        }
        void LoadThuong()
        {
            string query = "select maThuong, noiDung,mucThuong from tblThuong";
            using (SqlCommand cmd  =new SqlCommand())
            {
                cmd.Connection = cnn;
                cmd.CommandText = query;
                DataTable table = new DataTable();
                cmd.CommandType = CommandType.Text;
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);    
                    da.Fill(table);
                }
                catch
                {
                    MessageBox.Show("Lỗi Sql load thuong!");
                }
                finally { cnn.Close(); }
                CbbNoidungThuong.DataSource = table;
                CbbNoidungThuong.DisplayMember = table.Columns["noiDung"].ToString();
                CbbNoidungThuong.ValueMember = table.Columns["maThuong"].ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }
        private void LoadListNhanVien()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemnhavien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PB", PB);
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi  sảy ra");
                }
                finally { cnn.Close(); }
                DgvNhanVien.DataSource = table;
                DgvNhanVien.Columns["maPB"].Visible = false;
                DgvNhanVien.Columns["maCV"].Visible = false;
                DgvNhanVien.Columns["SDT"].Visible = false;
                DgvNhanVien.Columns["diaChi"].Visible = false;
                DgvNhanVien.Columns["gioiTinh"].Visible = false;
            }
        }
        private void CbbNoidungThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ThuongNV_Load(object sender, EventArgs e)
        {
            LoadThuong();
            LoadListNhanVien();
        }

        private void CbbNoidungThuong_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadThuong();
            string query = "select mucThuong from tblThuong where maThuong = '" + CbbNoidungThuong.SelectedValue.ToString() + "'";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cnn;
                cmd.CommandText = query;
                DataTable table = new DataTable();
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    txtMucThuong.Text = table.Rows[0][0].ToString();
                }

                catch {MessageBox.Show("Lỗi load mức thưởng!" }
                finally {cnn.Close(); }
                  
            }
        }
    }
}

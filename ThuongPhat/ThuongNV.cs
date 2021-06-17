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
        private int getmaPT(string maNV)
        {
            DataTable TablegetmaPT = new DataTable();
            using (SqlCommand cmd = new SqlCommand("TimPhieuThuong", cnn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@thang", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@nam", DateTime.Now.Year);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TablegetmaPT);
                cnn.Close();
                if (TablegetmaPT.Rows.Count == 0)
                    return -1;
                return Convert.ToInt32(TablegetmaPT.Rows[0][0].ToString());
            }
        }
        private void loadDSThuong(string maNV)
        {
            int mathuong = getmaPT(maNV);
            DataTable table = new DataTable();
            string query = "select noiDung,mucThuong,soLan from tblCTPhieuThuong, tblThuong where tblCTPhieuThuong.maThuong = tblThuong.maThuong and tblCTPhieuThuong.maPT= " + getmaPT(maNV) + "";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = cnn;
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                cnn.Close();
                DgvCtthuong.DataSource = table;
            }
        }
        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtMaNV.Text = DgvNhanVien.Rows[i].Cells["maNhanvien"].Value.ToString();
                txtTenNV.Text = DgvNhanVien.Rows[i].Cells["tenNV"].Value.ToString();
                btnThem.Enabled = true;
                loadDSThuong(DgvNhanVien.Rows[i].Cells["maNhanvien"].Value.ToString());
                
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
                cbbMucThuong.DataSource = table;
                cbbMucThuong.DisplayMember = table.Columns["noiDung"].ToString();
                cbbMucThuong.ValueMember = table.Columns["maThuong"].ToString();
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
                    MessageBox.Show("Đã có lỗi  xảy ra");
                }
                finally { cnn.Close(); }
                DgvNhanVien.DataSource = table;
                DgvNhanVien.Columns["tenPB"].Visible = false;
                DgvNhanVien.Columns["tenCV"].Visible = false;
                DgvNhanVien.Columns["SDT"].Visible = false;
                DgvNhanVien.Columns["diaChi"].Visible = false;
                DgvNhanVien.Columns["gioiTinh"].Visible = false;
                DgvNhanVien.Columns["matKhau"].Visible = false;
            }
        }
        private void CbbNoidungThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ThuongNV_Load(object sender, EventArgs e)
        {
            LoadThuong();
            btnThem.Enabled = false;
            LoadListNhanVien();
        }
        
        private void CbbNoidungThuong_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "select mucThuong from tblThuong where maThuong = '" + cbbMucThuong.SelectedValue.ToString() + "'";
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

                catch { }
                finally { cnn.Close(); }
                  
                    
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("thuong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@mathuong", cbbMucThuong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@thang", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@nam", DateTime.Now.Year);
                if ( cnn.State== ConnectionState.Closed)cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi  sảy ra");
                }
                finally { cnn.Close(); }
                
            }
            loadDSThuong(txtMaNV.Text);
        }
    }
}

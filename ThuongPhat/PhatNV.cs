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
    public partial class PhatNV : Form
    {
        string PB;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public PhatNV(string Phongban)
        {
            this.PB = Phongban;
            InitializeComponent();
        }
        private int getmaPP(string maNV)
        {
            DataTable TablegetmaPP = new DataTable();
            using (SqlCommand cmd = new SqlCommand("TimPhieuPhat", cnn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@thang", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@nam", DateTime.Now.Year);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TablegetmaPP);
                cnn.Close();
                if (TablegetmaPP.Rows.Count == 0)
                    return -1;
                else
                return Convert.ToInt32(TablegetmaPP.Rows[0][0].ToString());
            }
        }
        private void loadDSPhat(string maNV)
        {
            int maPhat = getmaPP(maNV);
            DataTable table = new DataTable();
            string query = "select noiDung,mucPhat,soLan from tblCTPhieuPhat, tblPhat where tblCTPhieuPhat.maPhat = tblPhat.maPhat and tblCTPhieuPhat.maPP= " + maPhat + "";
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = cnn;
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                cnn.Close();
                DgvCtphat.DataSource = table;
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
                loadDSPhat(DgvNhanVien.Rows[i].Cells["maNhanvien"].Value.ToString());

            }
            catch { }
        }
        void LoadPhat()
        {
            string query = "select maPhat, noiDung,mucPhat from tblPhat";
            using (SqlCommand cmd = new SqlCommand())
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
                    MessageBox.Show("Lỗi Sql load phat!");
                }
                finally { cnn.Close(); }
                cbbMucPhat.DataSource = table;
                cbbMucPhat.DisplayMember = table.Columns["noiDung"].ToString();
                cbbMucPhat.ValueMember = table.Columns["maPhat"].ToString();
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
                DgvNhanVien.Columns["maPB"].Visible = false;
                DgvNhanVien.Columns["maCV"].Visible = false;
                DgvNhanVien.Columns["SDT"].Visible = false;
                DgvNhanVien.Columns["diaChi"].Visible = false;
                DgvNhanVien.Columns["gioiTinh"].Visible = false;
                DgvNhanVien.Columns["matKhau"].Visible = false;
            }
        }
        private void CbbNoidungPhat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PhatNV_Load(object sender, EventArgs e)
        {
            LoadPhat();
            btnThem.Enabled = false;
            LoadListNhanVien();
        }

        private void CbbNoidungPhat_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "select mucPhat from tblPhat where maPhat = '" + cbbMucPhat.SelectedValue.ToString() + "'";
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
                    txtMucPhat.Text = table.Rows[0][0].ToString();
                }

                catch { }
                finally { cnn.Close(); }


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("phat", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@maphat", cbbMucPhat.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@thang", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@nam", DateTime.Now.Year);
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi  xảy ra");
                }
                finally { cnn.Close(); }

            }
            loadDSPhat(txtMaNV.Text);
        }
    }
}

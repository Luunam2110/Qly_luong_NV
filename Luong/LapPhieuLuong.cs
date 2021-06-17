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

namespace Qly_luong.Luong
{
    public partial class LapPhieuLuong : Form
    {
        string Pb;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public LapPhieuLuong(string phongban)
        {
            this.Pb = phongban;
            InitializeComponent();
        }
        private void loadPhieuLuong()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("timphieuluong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@Pb", Pb);
                cmd.Parameters.AddWithValue("@thang", Convert.ToInt32(cbbThang.Text));
                cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(txtnam.Text));
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        txtmaMV.Text = table.Rows[0][0].ToString();
                        txtten.Text = table.Rows[0][1].ToString();
                        txtsdt.Text = table.Rows[0][2].ToString();
                        txthsl.Text = table.Rows[0][3].ToString();
                        txtphucap.Text = table.Rows[0][4].ToString();
                        txtlcb.Text = table.Rows[0][5].ToString();

                        txtgiohanhchinh.Text = table.Rows[0][8].ToString();
                        txtgiolamthem.Text = table.Rows[0][9].ToString();
                        txtgionghile.Text = table.Rows[0][10].ToString();
                        txtgiongaynghi.Text = table.Rows[0][11].ToString();

                        txtthuong.Text = table.Rows[0][12].ToString();
                        txtphat.Text = table.Rows[0][13].ToString();
                        txtTongluong.Text = Convert.ToInt32(table.Rows[0][14]).ToString() + "VNĐ";
                    }
                    else
                    {
                        txtmaMV.Text = "";
                        txtten.Text = "";
                        txtsdt.Text = "";
                        txthsl.Text = "";
                        txtphucap.Text = "";
                        txtlcb.Text = "";

                        txtgiohanhchinh.Text = "";
                        txtgiolamthem.Text = "";
                        txtgionghile.Text = "";
                        txtgiongaynghi.Text = "";

                        txtthuong.Text = "";
                        txtphat.Text = "";
                        txtTongluong.Text = "";
                    }
                }
                catch { MessageBox.Show("Đã có lỗi xảy ra!"); }
                finally { cnn.Close(); }
            }
        }
        private void LoadListNhanVien()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemnhavien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PB", Pb);
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
                DgvNhanVien.Columns["tenPB"].Visible = false;
                DgvNhanVien.Columns["tenCV"].Visible = false;
                DgvNhanVien.Columns["SDT"].Visible = false;
                DgvNhanVien.Columns["diaChi"].Visible = false;
                DgvNhanVien.Columns["gioiTinh"].Visible = false;
                DgvNhanVien.Columns["matKhau"].Visible = false;
            }
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
            btnLap.Enabled = true;
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("lapphieuluong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@thang", Convert.ToInt32(cbbThang.Text));
                cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(txtnam.Text));
                cnn.Open();
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
            loadPhieuLuong();
        }

        private void LapPhieuLuong_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}

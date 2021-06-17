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
    public partial class DSPhieuLuong : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        string Pb;
        public DSPhieuLuong(string phongban)
        {
            this.Pb = phongban;
            InitializeComponent();
        }
        private void LoadPhieuLuongNhanVien(int thang, int nam, string manv)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("timphieuluong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pb", Pb);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
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

            }
            DgvPhieuLuong.DataSource = table;
            DgvPhieuLuong.Columns["thang"].Visible = false;
            DgvPhieuLuong.Columns["nam"].Visible = false;
        }
        private void LoadDS(int thang, int nam)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemphieuluong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pb", Pb);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
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
                DgvPhieuLuong.DataSource = table;
                DgvPhieuLuong.Columns["thang"].Visible = false;
                DgvPhieuLuong.Columns["nam"].Visible = false;
            }
            
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtnam.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nhập năm!");
            }
            else if (!checkBox1.Checked)
                LoadDS(Convert.ToInt32(cbbThang.SelectedItem), Convert.ToInt32(txtnam.Text));
            else if (txtMaNV.Text.ToString().Trim() == "" )
                MessageBox.Show("Nhập mã nhân viên");
            else 
                LoadPhieuLuongNhanVien(Convert.ToInt32(cbbThang.SelectedItem), Convert.ToInt32(txtnam.Text), txtMaNV.Text);
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) txtMaNV.Enabled = false;
            if (checkBox1.Checked) txtMaNV.Enabled = true;
        }

        private void DSPhieuLuong_Load(object sender, EventArgs e)
        {
            LoadDS(DateTime.Now.Month, DateTime.Now.Year);
            cbbThang.Text = Convert.ToString(DateTime.Now.Month);
            txtnam.Text = Convert.ToString(DateTime.Now.Year);
        }
    }
}

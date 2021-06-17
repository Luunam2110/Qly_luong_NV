using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qly_luong.ChamCong
{
    public partial class DSChamCong : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        private string Pb;
        Boolean qly;
        string manv;
        public DSChamCong(string Pb,Boolean quanly, string maNV)
        {
            this.Pb = Pb;
            this.qly = quanly;
            this.manv = maNV;
            InitializeComponent();
        }
        private void LoadDS(int thang, int nam)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemchamcong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pb", Pb);
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
            DgvChamCong.DataSource = table;
            foreach (DataGridViewRow row in DgvChamCong.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ngayLe"].Value) == true)
                {
                    row.Cells["ngayLe"].Value = "True";
                }
                else row.Cells["ngayLe"].Value = "False";
            }
        }
        private void LoadChamCongNhanVien(int thang,int nam,string manv)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("Timchamcong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pb", Pb);
                cmd.Parameters.AddWithValue("@maNV", manv); 
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
            DgvChamCong.DataSource = table;
            foreach (DataGridViewRow row in DgvChamCong.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ngayLe"].Value) == true)
                {
                    row.Cells["ngayLe"].Value = "True";
                }
                else row.Cells["ngayLe"].Value = "False";
            }
        }
        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar== 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) txtMaNV.Enabled = false;
            if (checkBox1.Checked) txtMaNV.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtnam.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Nhập năm!");
            }
            else if (!checkBox1.Checked && qly)
                LoadDS(Convert.ToInt32(cbbThang.SelectedItem), Convert.ToInt32(txtnam.Text));
            else if (txtMaNV.Text.ToString().Trim() == "" && qly)
                MessageBox.Show("Nhập mã nhân viên");
            else if (qly)
                LoadChamCongNhanVien(Convert.ToInt32(cbbThang.SelectedItem), Convert.ToInt32(txtnam.Text), txtMaNV.Text); 
            else
                LoadChamCongNhanVien(Convert.ToInt32(cbbThang.SelectedItem), Convert.ToInt32(txtnam.Text), this.manv);

        }

        private void DSChamCong_Load(object sender, EventArgs e)
        {
            LoadChamCongNhanVien(DateTime.Now.Month, DateTime.Now.Year,manv);
            cbbThang.Text = Convert.ToString(DateTime.Now.Month);
            txtnam.Text =Convert.ToString( DateTime.Now.Year);
        }
    }
}

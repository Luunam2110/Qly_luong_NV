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

namespace Qly_luong.ThuongPhat
{
    public partial class ThemPhat : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public ThemPhat()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "" || txtNoidung.Text.Trim() == "" || txtMucphat.Text.Trim() == "")
                MessageBox.Show("Nhập đầy đủ thông tin!");
            else
            {
                using (SqlCommand cmd = new SqlCommand("themphat", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                    cmd.Parameters.AddWithValue("@noidung", txtNoidung.Text);
                    cmd.Parameters.AddWithValue("@phat", txtMucphat.Text);
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
                LoadPhat();
            }
        }
        void LoadPhat()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemPhat", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
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
                DgvPhat.DataSource = table;
            }
        }
        private void ThemPhat_Load(object sender, EventArgs e)
        {
            LoadPhat();
        }

        private void txtMucphat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtMucphat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "" || txtNoidung.Text.Trim() == "" || txtMucphat.Text.Trim() == "")
                MessageBox.Show("Nhập đầy đủ thông tin!");
            else
            {
                using (SqlCommand cmd = new SqlCommand("themphat", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                    cmd.Parameters.AddWithValue("@noidung", txtNoidung.Text);
                    cmd.Parameters.AddWithValue("@phat", txtMucphat.Text);
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
                LoadPhat();
            }
        }
    }
}

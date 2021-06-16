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
    public partial class ThemThuong : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public ThemThuong()
        {
            InitializeComponent();
        }
        
        

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "" || txtNoidung.Text.Trim() == "" || txtMucthuong.Text.Trim() == "")
                MessageBox.Show("Nhập đầy đủ thông tin!");
            else
            {
                using (SqlCommand cmd = new SqlCommand("themthuong", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                    cmd.Parameters.AddWithValue("@noidung", txtNoidung.Text);
                    cmd.Parameters.AddWithValue("@thuong", txtMucthuong.Text);
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
                LoadThuong();
            }
        }

        void LoadThuong()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemThuong", cnn))
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
                DgvThuong.DataSource = table;
            }
        }
        private void ThemThuong_Load(object sender, EventArgs e)
        {
            LoadThuong();
        }

        private void txtMucthuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtMucthuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

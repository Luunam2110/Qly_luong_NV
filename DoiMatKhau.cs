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

namespace Qly_luong
{
    public partial class DoiMatKhau : Form
    {
        string maNV;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public DoiMatKhau(string maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }
        private void updatepass(string newpass)
        {
            using (SqlCommand cmd = new SqlCommand("doimatkhau", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@matKhau", newpass);
                DataTable table = new DataTable();
                cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch { MessageBox.Show("cập nhật không thành công !"); }
                finally { cnn.Close(); }
                MessageBox.Show("cập nhật thành công !");
                cnn.Close();
            }
        }
        private void BtnDoiMK_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("dangnhap", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma",maNV);
                DataTable table = new DataTable();
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                cnn.Close();
                if (table.Rows[0][1].ToString() != txtMatkhaucu.Text)
                {
                    MessageBox.Show("sai mật khẩu");
                }
                else if (txtMatkhaumoi.Text.Length < 8)
                    MessageBox.Show("mật khẩu tối thiểu 8 kí tự");
                else 
                {
                    if (txtMatkhaumoi.Text != txtNhaclaimatkhau.Text)
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp !");
                    }

                    else updatepass(txtMatkhaumoi.Text.ToString());
                }
            }
        }
    }
}

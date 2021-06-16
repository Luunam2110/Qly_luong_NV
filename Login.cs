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

namespace Qly_luong
{
    public partial class Login : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Txtma.Text.Trim() == "")
            {
                MessageBox.Show("bạn chưa nhập tài khoản");
                Txtma.Focus();
            }
            else if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("bạn chưa nhập mật khẩu");
                txtpass.Focus();
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("dangnhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", Txtma.Text);
                    DataTable table = new DataTable();
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    cnn.Close();
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("sai tên đăng nhập");
                    }
                    else if (table.Rows[0][1].ToString() != txtpass.Text)
                    {
                        MessageBox.Show("sai mật khẩu");
                    }
                    else
                    {
                        this.Hide();
                        if (table.Rows[0][2].ToString() == "CV001" || table.Rows[0][2].ToString() == "CV002")
                        {
                            Trangchu tc = new Trangchu(true, table.Rows[0][3].ToString());
                            tc.Show();
                        }

                        else { Trangchu tc = new Trangchu(false, table.Rows[0][3].ToString()); tc.Show();  }
                    }
                }    
            }
        }
    }
}

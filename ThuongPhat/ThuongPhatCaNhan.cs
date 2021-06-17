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
    public partial class ThuongPhatCaNhan : Form
    {
        string maNV;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public ThuongPhatCaNhan(string maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            
            LoadPhat();
            LoadThuong();
        }

        private void LoadThuong()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("thuongcanhan", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@thang", cbbThang.Text);
                cmd.Parameters.AddWithValue("@nam", txtnam.Text);
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch { MessageBox.Show("Đã có lỗi sảy ra!"); }
                finally { cnn.Close(); }
                DgvThuong.DataSource = table;
            }    
        }
        private void LoadPhat()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("phatcanhan", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@thang", cbbThang.Text);
                cmd.Parameters.AddWithValue("@nam", txtnam.Text);
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch { MessageBox.Show("Đã có lỗi sảy ra!"); }
                finally { cnn.Close(); }
                DgvPhat.DataSource = table;
            }
        }
        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void ThuongPhatCaNhan_Load(object sender, EventArgs e)
        {
            cbbThang.Text = DateTime.Now.Month.ToString();
            txtnam.Text = DateTime.Now.Year.ToString();
            LoadPhat();
            LoadThuong();
        }
    }
}

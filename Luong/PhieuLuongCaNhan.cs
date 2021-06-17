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
    public partial class PhieuLuongCaNhan : Form
    {
        string Pb;
        string manV;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public PhieuLuongCaNhan(string maNV,string phongban)
        {
            this.Pb = phongban;
            this.manV = maNV;
            InitializeComponent();
        }
        private void loadPhieuLuong()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("timphieuluong", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", manV);
                cmd.Parameters.AddWithValue("@Pb", Pb);
                cmd.Parameters.AddWithValue("@thang", Convert.ToInt32(cbbThang.Text));
                cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(txtnam.Text));
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                try {
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
                        txtTongluong.Text =Convert.ToInt32( table.Rows[0][14]).ToString()+"VNĐ";
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
        private void PhieuLuongCaNhan_Load(object sender, EventArgs e)
        {
            cbbThang.Text = Convert.ToString(DateTime.Now.Month - 1);
            if (DateTime.Now.Month>1)
            {
                cbbThang.Text = Convert.ToString(DateTime.Now.Month - 1);
                txtnam.Text = Convert.ToString(DateTime.Now.Year);
            }
            else
            {
                cbbThang.Text = Convert.ToString(12);
                txtnam.Text = Convert.ToString(DateTime.Now.Year-1);
            }                
             
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadPhieuLuong();
        }
    }
}

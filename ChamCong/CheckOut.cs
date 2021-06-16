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

namespace Qly_luong.ChamCong
{
    public partial class CheckOut : Form
    {
        string PB;
        string maCC;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public CheckOut(string phongban)
        {
            this.PB = phongban;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void loadDL ()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("ListCheckout",cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pb", PB);
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
                finally { cnn.Close();}
                
            }
            dgvListCheckout.DataSource = table;
            dgvListCheckout.Columns["maCC"].Visible = false;
            foreach (DataGridViewRow row in dgvListCheckout.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ngayLe"].Value) == true)
                {
                    row.Cells["ngayLe"].Value = "True";
                }
                else row.Cells["ngayLe"].Value = "False";
            }

        }
        private void CheckOut_Load(object sender, EventArgs e)
        {
            loadDL();
            dtpGioRa.Enabled = false;
            btnCheckout.Enabled = false;
            txtMa.Enabled = false;
            txtTenNv.Enabled = false;
            dtpGioRa.Enabled = false;
        }

        private void dgvListCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListCheckout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtMa.Text = dgvListCheckout.Rows[i].Cells["maNV"].Value.ToString();
                txtTenNv.Text = dgvListCheckout.Rows[i].Cells["hoTen"].Value.ToString();
                maCC= dgvListCheckout.Rows[i].Cells["maCC"].Value.ToString();
                btnCheckout.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string time = dtpGioRa.Value.ToString("HH:mm");
            using (SqlCommand cmd = new SqlCommand("checkout", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maCC", maCC);
                cmd.Parameters.AddWithValue("@out",time);
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
            maCC = "";
            btnCheckout.Enabled = false;
            loadDL();
        }
    }
}

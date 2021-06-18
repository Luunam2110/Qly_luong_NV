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
    public partial class CheckIn : Form
    {
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        String PB;
        public CheckIn(string Phongban)
        {
            this.PB = Phongban;
            InitializeComponent();
        }
        private void LoadListCheckedIn()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("ListCheckout", cnn))
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
                finally { cnn.Close(); }

            }
            dgvListCheckout.DataSource = table;
            dgvListCheckout.Columns["maCC"].Visible = false;
            dgvListCheckout.Columns["gioDiVe"].Visible = false;
            foreach (DataGridViewRow row in dgvListCheckout.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ngayLe"].Value) == true)
                {
                    row.Cells["ngayLe"].Value = "True";
                }
                else row.Cells["ngayLe"].Value = "False";
            }
        }
        private void LoadListNhanVien()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemnhavien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PB", PB);
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
            }
        }
        private void init()
        {
            LoadListCheckedIn();
            LoadListNhanVien();
            BtnCheckIn.Enabled = false;
            txtTenNV.Enabled = false;
            txtMaNV.Enabled = false;
            DtpIn.Enabled = false;
        }
      
        private void CheckIn_Load(object sender, EventArgs e)
        {
            init();
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
            BtnCheckIn.Enabled = true;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            string time = DtpIn.Value.ToString("HH:mm");
            using (SqlCommand cmd = new SqlCommand("checkin", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@ngay", DtpIn.Value.Day);
                cmd.Parameters.AddWithValue("@thang", DtpIn.Value.Month);
                cmd.Parameters.AddWithValue("@nam", DtpIn.Value.Year);
                cmd.Parameters.AddWithValue("@in", time);
                cmd.Parameters.AddWithValue("@le", CBNgayLe.Checked);
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
            BtnCheckIn.Enabled = false;
            LoadListCheckedIn();
        }
    }
}

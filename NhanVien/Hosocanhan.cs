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

namespace Qly_luong.NhanVien
{
    public partial class Hosocanhan : Form
    {
        String Pb;
        SqlConnection cnn = new SqlConnection(Connectionstring.connectionstring);
        public Hosocanhan(string Phongban)
        {
            this.Pb = Phongban;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMK_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDSNV()
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("xemnhavien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PB", Pb);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch {
                    MessageBox.Show("Đã sảy ra lỗi!");
                }
                finally { cnn.Close(); }
            }
            dtgNV.DataSource = table;
            
        }
        private void Hosocanhan_Load(object sender, EventArgs e)
        {
            LoadDSNV();
            LoadCV();
            init();


        }
        void init ()
        {
            txtmaNV.Enabled = false;
            txtDiachi.Enabled = false;
            txtHoten.Enabled = false;
            txtmaPB.Enabled = false;
            cbbCV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiachi.Enabled = false;
            cbbGt.Enabled = false;
            dtNgS.Enabled = false;
            btnsua.Enabled = false;
        }
        private void LoadCV()
        {
            DataTable table = new DataTable();
            string query = "select * from tblChucVu where maCV != 'CV001'"; 
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch { MessageBox.Show("Đã có lỗi sảy ra !"); }
                finally { cnn.Close(); }
                cbbCV.DataSource = table;
                cbbCV.DisplayMember = table.Columns["tenCV"].ToString();
                cbbCV.ValueMember = table.Columns["maCV"].ToString();

            }
        }
        private void dtgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                txtmaNV.Text = dtgNV.Rows[index].Cells[0].Value.ToString();
                txtHoten.Text = dtgNV.Rows[index].Cells[1].Value.ToString();
                cbbGt.Text = dtgNV.Rows[index].Cells[4].Value.ToString();
                dtNgS.Value = Convert.ToDateTime(dtgNV.Rows[index].Cells[5].Value);
                txtSDT.Text = dtgNV.Rows[index].Cells[3].Value.ToString();
                txtDiachi.Text = dtgNV.Rows[index].Cells[2].Value.ToString();
                cbbCV.Text= dtgNV.Rows[index].Cells[6].Value.ToString();
                txtmaPB.Text = dtgNV.Rows[index].Cells[7].Value.ToString();
                txtHoten.Enabled = true;
                btnsua.Enabled = true;
                txtDiachi.Enabled = true;
                txtSDT.Enabled = true;
                cbbGt.Enabled = true;
                dtNgS.Enabled = true;
            }
            catch { }   
                
                /*MessageBox.Show("0:" + dtgNV.Rows[index].Cells[0].Value.ToString()+" 1:"+
                    dtgNV.Rows[index].Cells[1].Value.ToString()+"  2:"+
                    dtgNV.Rows[index].Cells[2].Value.ToString()+"  3: "+
                    dtgNV.Rows[index].Cells[3].Value.ToString()+ "  4:"+
                    dtgNV.Rows[index].Cells[4].Value.ToString()+ "   5:"+
                    dtgNV.Rows[index].Cells[5].Value.ToString()+ "   6:"+
                    dtgNV.Rows[index].Cells[6].Value.ToString()+ "   7:"+
                    dtgNV.Rows[index].Cells[7].Value.ToString());*/
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("suaNV", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", txtmaNV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                cmd.Parameters.AddWithValue("@birthday", dtNgS.Value);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                Boolean gt;
                if (cbbGt.Text == "Nam") gt = true;
                else gt = false;
                cmd.Parameters.AddWithValue("@gioitinh", gt);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi!");
                }
                finally { cnn.Close(); }
            }
            LoadDSNV();
        }
        private void btnThemtextisthemmoi()
        {
            txtmaNV.Enabled = true;
            cbbCV.Enabled = true;
            txtHoten.Enabled = true;
            btnsua.Enabled = false;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            cbbGt.Enabled = true;
            dtNgS.Enabled = true;
            btnThem.Text = "Thêm";
            btnHuy.Visible = true;
        }
        private void btnThemtextisthem()
        {
            if (txtmaNV.Text.Trim() == "" || txtHoten.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtDiachi.Text.Trim() == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            else
                using (SqlCommand cmd = new SqlCommand("InserNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", txtmaNV.Text);
                    cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                    cmd.Parameters.AddWithValue("@birthday", dtNgS.Value);
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    Boolean gt;
                    if (cbbGt.Text == "Nam") gt = true;
                    else gt = false;
                    cmd.Parameters.AddWithValue("@gioitinh", gt);
                    cmd.Parameters.AddWithValue("@Cv", cbbCV.SelectedValue);

                    cmd.Parameters.AddWithValue("@pb", Pb);
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }

                    catch
                    {
                        MessageBox.Show("Đã có lỗi sảy ra!");
                    }
                    finally { cnn.Close(); }
                }
                   
            LoadDSNV();
            init();
            btnThem.Text = "Thêm mới";
            btnHuy.Visible = false;
            
        }
            
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text=="Thêm mới")
            { btnThemtextisthemmoi(); }
            else { btnThemtextisthem(); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            init();
            btnThem.Text = "Thêm mới";
            btnHuy.Visible = false;
        }
    }
}

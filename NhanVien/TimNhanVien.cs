using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_luong.NhanVien
{
    public partial class TimNhanVien : Form
    {
        Hosocanhan formcha;
        public TimNhanVien(Hosocanhan formcha)
        {
            this.formcha = formcha;
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            cbma.Checked = false;
            if (cbsdt.Checked)
                txtsdt.Enabled = true;
            else txtsdt.Enabled = false;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbma.Checked)
            {
                cbten.Checked = false;
                cbngaysinh.Checked = false;
                cbdiachi.Checked = false;
                cbsdt.Checked = false;
                cbgt.Checked = false;
                txtMaNV.Enabled = true;
                txtMaNV.Enabled = true;
            }
                
            else txtMaNV.Enabled = false;
        }

        private void cbdiachi_CheckedChanged(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;
            if (cbdiachi.Checked)
                txtdiachi.Enabled = true;
            else txtdiachi.Enabled = false;
        }

        private void cbten_CheckedChanged(object sender, EventArgs e)
        {
            cbma.Checked = false;
            if (cbten.Checked)
                txtten.Enabled = true;
            else txtten.Enabled = false;
            
        }

        private void TimNhanVien_Load(object sender, EventArgs e)
        {
            cbma.Checked = false;
        }

        private void cbngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            cbma.Checked = false;
            if (cbngaysinh.Checked)
                
            dtNgS.Enabled = true;
            else dtNgS.Enabled = false;

        }

        private void cbgt_CheckedChanged(object sender, EventArgs e)
        {
            cbma.Checked = false;
            if (cbgt.Checked)
                cbbGt.Enabled = true;
            else cbbGt.Enabled = false;
        }

        private void dtNgS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string manv;
            string hoten;
            DateTime sinhnhat= DateTime.Now;
            Boolean havesinhnhat = true;
            Boolean havegt = true;
            string diachi;
            string sdt;
            Boolean gt=true;
            if (cbma.Checked) manv = txtMaNV.Text; else manv = "";
            if (cbten.Checked) hoten = txtten.Text; else hoten = "";
            if (cbngaysinh.Checked) sinhnhat = dtNgS.Value; else havesinhnhat = false;
            if (cbdiachi.Checked) diachi = txtdiachi.Text; else diachi = "";
            if (cbsdt.Checked) sdt = txtsdt.Text; else sdt = "";
            if (cbgt.Checked)
            {
                if (cbbGt.Text == "Nam") gt = true;
                else if (cbbGt.Text == "Nữ") gt = false;
                else havegt = false;
            }
            else havegt = false;
           // MessageBox.Show(gt.ToString()+"  "+havegt.ToString());
            formcha.Timnhanvien(manv,hoten,sinhnhat,diachi,sdt,gt,havegt,havesinhnhat);
            this.Hide();
        }
    }
}

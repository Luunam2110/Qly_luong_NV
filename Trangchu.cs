using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_luong
{
    public partial class Trangchu : Form
    {
        Boolean quanly;
        string PB;
        string maNV;
        public Trangchu(Boolean qly,String Phongban,string maNV)
        {
            this.maNV = maNV;
            this.PB = Phongban;
            this.quanly = qly;
            InitializeComponent();
        }
        private void init()
        {
            if (quanly== false)
            {
                Itemmenu1_Luong.Visible = false;
                Itemmenu1_Chamcong.Visible = false;
                ItemMenu1_NhanVien.Visible = false;
            }
        }
        private void Trangchu_Load(object sender, EventArgs e)
        {
            init();
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong.CheckIn f1 = new ChamCong.CheckIn(PB);
            f1.MdiParent = this;
            f1.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong.CheckOut f1 = new ChamCong.CheckOut(PB);
            f1.MdiParent = this;
            f1.Show();
        }

        private void thươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuongPhat.ThemThuong f1 = new ThuongPhat.ThemThuong();
            f1.MdiParent = this;
            f1.Show();
        }

        private void thôngTinChâmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamCong.DSChamCong f1 = new ChamCong.DSChamCong(PB);
            f1.MdiParent = this;
            f1.Show();
        }

        private void thươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuongPhat.ThuongNV f1 = new ThuongPhat.ThuongNV(PB);
            f1.MdiParent = this;
            f1.Show();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f1 = new DoiMatKhau(maNV);
            f1.MdiParent = this; ;
            f1.Show();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }
    }
}

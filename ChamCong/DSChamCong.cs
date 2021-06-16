using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_luong.ChamCong
{
    public partial class DSChamCong : Form
    {
        public DSChamCong()
        {
            InitializeComponent();
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}

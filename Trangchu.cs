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
        public Trangchu(Boolean qly)
        {
            this.quanly = qly;
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýChiTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LietKeChiTieu qlct = new LietKeChiTieu();
            qlct.Show();
        }

        private void btQlct_Click(object sender, EventArgs e)
        {
            LietKeChiTieu qlct = new LietKeChiTieu();
            qlct.Show();
        }

        private void btQldt_Click(object sender, EventArgs e)
        {
            DauTu dt = new DauTu();
            dt.Show();
        }
    }
}

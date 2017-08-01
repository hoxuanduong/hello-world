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
    public partial class DauTu : Form
    {
        public DauTu()
        {
            InitializeComponent();
        }

        private void btTienVon_Click(object sender, EventArgs e)
        {
            GiaoDichVon gdv = new GiaoDichVon();
            gdv.Show();
        }

        private void giaoDịchVốnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDichVon gdv = new GiaoDichVon();
            gdv.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NhapNgonNgu : Form
    {
        public NhapNgonNgu()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            duLieuNN.WriteXml(String.Format("{0}/data.xml", Application.StartupPath));

            ResourceWriter ren = new ResourceWriter(Application.StartupPath + "/resource.en-US.resources");

            ResourceWriter rde = new ResourceWriter(Application.StartupPath + "/resource.de-DE.resources");

            ResourceWriter rvn = new ResourceWriter(Application.StartupPath + "/resource.vn-VN.resources");

            foreach (DuLieuNN.NgonNguRow row in duLieuNN.NgonNgu.Rows)
            {
                ren.AddResource(row.ID, row.English);
                rde.AddResource(row.ID, row.German);
                rvn.AddResource(row.ID, row.Vietnamese);
            }
            ren.Generate();
            ren.Close();
            rde.Generate();
            rde.Close();
            rvn.Generate();
            rvn.Close();
            MessageBox.Show("đã nhập ngôn ngữ thành công", "thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

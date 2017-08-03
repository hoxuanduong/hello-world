using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resource;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

        ResourceManager res_man;    // declare Resource manager to access to specific cultureinfo
        CultureInfo cul;            // declare culture info

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

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // NhapNgonNgu nnn = new NhapNgonNgu();
           // nnn.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //DuLieuNN dlnn = new DuLieuNN();
            //dlnn.ReadXml(String.Format("{0}/data.xml", Application.StartupPath));
            //CultureInfo ci = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
            //ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath, null);

            //if (rm.GetString("0001") != null)
            //{
            //    this.btQlct.Text = rm.GetString("0001");
            //}
            Assembly a = Assembly.Load("WindowsFormsApp1");
            res_man = new ResourceManager("WindowsFormsApp1.Resource",a);
            this.btQlct.Text = res_man.GetString("btqlct",cul);
            this.btQldt.Text = res_man.GetString("btqldt", cul);
            this.btQltn.Text = res_man.GetString("btqltn", cul);
            this.btQlgt.Text = res_man.GetString("btqlgt", cul);
            this.btQlcvlh.Text = res_man.GetString("btqlcvlh", cul);
            this.btQlhd.Text = res_man.GetString("btqlhd", cul);


        }

        public void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

            // Select the other MenuItens from the ParentMenu(OwnerItens) and unchecked this,
            // The current Linq Expression verify if the item is a real ToolStripMenuItem
            // and if the item is a another ToolStripMenuItem to uncheck this.
            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;

            // This line is optional, for show the mainMenu after click
            selectedMenuItem.Owner.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            cul = CultureInfo.CreateSpecificCulture("en");
        }

        private void vietnamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            cul = CultureInfo.CreateSpecificCulture("vi");
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            cul = CultureInfo.CreateSpecificCulture("de");
        }
    }
}

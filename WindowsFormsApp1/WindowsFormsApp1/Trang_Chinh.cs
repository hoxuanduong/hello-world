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
            Global_Class.Language.cul = CultureInfo.CreateSpecificCulture("en");
            Global_Class.Language.res_man = new ResourceManager("WindowsFormsApp1.Resource.resources", Assembly.GetExecutingAssembly());
            update_UI_Main();
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
            Global_Class.Language.cul = CultureInfo.CreateSpecificCulture("en");
            update_UI_Main();
        }

        private void vietnamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            Global_Class.Language.cul = CultureInfo.CreateSpecificCulture("vi");
            update_UI_Main();
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            Global_Class.Language.cul = CultureInfo.CreateSpecificCulture("de");
            update_UI_Main();
        }

        private void update_UI_Main()
        {
            this.btQlct.Text = Global_Class.Language.res_man.GetString("btqlct", Global_Class.Language.cul);
            this.btQldt.Text = Global_Class.Language.res_man.GetString("btqldt", Global_Class.Language.cul);
            this.btQltn.Text = Global_Class.Language.res_man.GetString("btqltn", Global_Class.Language.cul);
            this.btQlgt.Text = Global_Class.Language.res_man.GetString("btqlgt", Global_Class.Language.cul);
            this.btQlcvlh.Text = Global_Class.Language.res_man.GetString("btqlcvlh", Global_Class.Language.cul);
            this.btQlhd.Text = Global_Class.Language.res_man.GetString("btqlhd", Global_Class.Language.cul);
            this.menuStrip1.Items[0].Text = Global_Class.Language.res_man.GetString("mnctr", Global_Class.Language.cul);
            this.menuStrip1.Items[1].Text = Global_Class.Language.res_man.GetString("mntrg", Global_Class.Language.cul);
            this.menuStrip1.Items[2].Text = Global_Class.Language.res_man.GetString("mnnn", Global_Class.Language.cul);
            this.Text = Global_Class.Language.res_man.GetString("mainText", Global_Class.Language.cul);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(tbTH.Text))
            {
                MessageBox.Show("Vui lòng điền thêm thông tin Tên Hàng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbHSX.Text))
            {
                MessageBox.Show("Vui lòng điền thêm thông tin Hãng Sản Xuất", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tbNM.Text))
            {
                MessageBox.Show("Vui lòng điền thêm thông tin Nơi Mua", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem item = new ListViewItem(dateTimePicker1.Text);
                item.SubItems.Add(tbTH.Text);
                item.SubItems.Add(tbHSX.Text);
                item.SubItems.Add(tbNM.Text);
                item.SubItems.Add(nupG.Value.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btMF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open csv File";
            openFileDialog1.Filter = "CSV files|*.csv";
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //temporary listview lvtempo to keep items read form file
                //copy to listview1 only if file read is successfull

                ListView lvtempo = new ListView();

                char[] delimiter = { ';' };
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                lvtempo.Columns.Add(listView1.Columns[0].Name);
                lvtempo.Columns.Add(listView1.Columns[1].Name);
                lvtempo.Columns.Add(listView1.Columns[2].Name);
                lvtempo.Columns.Add(listView1.Columns[3].Name);
                lvtempo.Columns.Add(listView1.Columns[4].Name);
                //read first line from file
                string line = sr.ReadLine();    

                while (line != null)
                {
                    string[] elements = line.Split(delimiter);
                    
                    try
                    {
                        ListViewItem lvi = new ListViewItem(elements[0]);
                        lvi.SubItems.Add(elements[1]);
                        lvi.SubItems.Add(elements[2]);
                        lvi.SubItems.Add(elements[3]);
                        lvi.SubItems.Add(elements[4]);
                        lvtempo.Items.Add(lvi);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        MessageBox.Show("file format không đúng", "Lỗi đọc file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sr.Close();
                        return;
                    }
         
                    line = sr.ReadLine();

                }

                sr.Close();

                //delete all items of listview 1 but not listview (columns wont't be deleted)
                //to delete listview use listview1.Clear();
                listView1.Items.Clear();

                foreach (ListViewItem item in lvtempo.Items)
                {
                    listView1.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void btLF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Lưu dữ liệu vào file csv";
            saveFileDialog1.Filter = "CSV files|*.csv";
            saveFileDialog1.InitialDirectory = @"C:\";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {

                            string line = "";
                            int j = 0;

                            for (j = 0; j < listView1.Items[i].SubItems.Count - 1; j++)
                            {
                                
                                line += listView1.Items[i].SubItems[j].Text + ";";

                            }

                            line += listView1.Items[i].SubItems[j].Text;

                            sw.WriteLine(line);

                        }

                        sw.Dispose();
                        sw.Close();
                        
                    }

            }
        }

        private void cbXtc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXtc.Checked)
            {
                cbT.Enabled = false;
                cbN.Enabled = false;
            }
            else
            {
                cbT.Enabled = true;
                cbN.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testdbDataSet4.TestTable". Sie können sie bei Bedarf verschieben oder entfernen.
            this.testTableTableAdapter.Fill(this.testdbDataSet4.TestTable);

        }

        private void btSdb_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=BIB-LHOX\\CONEXIO;Initial Catalog=Testdb;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connect;
                    command.CommandText = "insert into TestTable(Date, Product, Manufacturer, Place, Price) values(@Date, @Product, @Manufacturer, @Place, @Price)";

                    command.Parameters.Add(new SqlParameter("@Date", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@Place", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));
                    connect.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            command.Parameters["@Date"].Value = row.Cells[0].Value;
                            command.Parameters["@Product"].Value = row.Cells[1].Value;
                            command.Parameters["@Manufacturer"].Value = row.Cells[2].Value;
                            command.Parameters["@Place"].Value = row.Cells[3].Value;
                            command.Parameters["@Price"].Value = row.Cells[4].Value;

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}

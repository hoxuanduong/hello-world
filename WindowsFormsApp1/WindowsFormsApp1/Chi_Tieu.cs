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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class LietKeChiTieu : Form
    {
        //string use to connect to server
        //server explorer, datenverbindungen, Eigenschaften -> Verbindungszeichenfolge
        private const string str = "Data Source=BIB-LHOX\\CONEXIO;Initial Catalog=Testdb;Integrated Security=True";

        public LietKeChiTieu()
        {
            InitializeComponent();
        }

        //button Them (add) is clicked
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
                insert_database();
                update_datagridview();
            }
        }

        //button Xoa (delete) is clicked
        private void btXoa_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {

                if (dataGridView1.SelectedRows[0].Index != dataGridView1.NewRowIndex)
                {
                    using (SqlConnection conn = new SqlConnection(str))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "Delete from TestTable where Product=@Product and Date = @Date";
                            cmd.Parameters.Add(new SqlParameter("@Product", SqlDbType.NVarChar));
                            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));

                            try
                            {
                                conn.Open();
                            }
                            catch (Exception exc)
                            {
                                Console.WriteLine(exc.ToString());
                            }
                            cmd.Parameters["@Product"].Value = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                            cmd.Parameters["@Date"].Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[0].Value).Date;
                            cmd.ExecuteNonQuery();

                            try
                            {
                                conn.Close();
                            }
                            catch (Exception exc)
                            {
                                Console.WriteLine(exc.ToString());
                            }
                        }
                    }

                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }


            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        //checkbox: xem tất cả hay theo filter ngày tháng
        private void cbXtc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXtc.Checked)
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
                btLoc.Enabled = false;
                testTableBindingSource.RemoveFilter();
            }
            else
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
                btLoc.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testdbDataSet4.TestTable". Sie können sie bei Bedarf verschieben oder entfernen.
            this.testTableTableAdapter.Fill(this.testdbDataSet4.TestTable);

            update_UI_ChiTieu();

        }

        private void update_UI_ChiTieu()
        {
            this.lbTenHang.Text = Global_Class.Language.res_man.GetString("lbTenHang", Global_Class.Language.cul);
            this.lbHSX.Text = Global_Class.Language.res_man.GetString("lbHSX", Global_Class.Language.cul);
            this.lbNoiMua.Text = Global_Class.Language.res_man.GetString("lbNoiMua", Global_Class.Language.cul);
            this.lbNgayMua.Text = Global_Class.Language.res_man.GetString("lbNgayMua", Global_Class.Language.cul);
            this.lbGia.Text = Global_Class.Language.res_man.GetString("lbGia", Global_Class.Language.cul);
            this.lbTu.Text = Global_Class.Language.res_man.GetString("lbTu", Global_Class.Language.cul);
            this.lbToi.Text = Global_Class.Language.res_man.GetString("lbToi", Global_Class.Language.cul);
            this.cbXtc.Text = Global_Class.Language.res_man.GetString("cbXtc", Global_Class.Language.cul);
            this.cbXtc.Text = Global_Class.Language.res_man.GetString("cbXtc", Global_Class.Language.cul);
            this.btLoc.Text = Global_Class.Language.res_man.GetString("btLoc", Global_Class.Language.cul);
            this.btThem.Text = Global_Class.Language.res_man.GetString("btThem", Global_Class.Language.cul);
            this.btXoa.Text = Global_Class.Language.res_man.GetString("btXoa", Global_Class.Language.cul);
            this.dataGridView1.Columns[0].HeaderText = Global_Class.Language.res_man.GetString("lbNgayMua", Global_Class.Language.cul);
            this.dataGridView1.Columns[1].HeaderText = Global_Class.Language.res_man.GetString("lbTenHang", Global_Class.Language.cul);
            this.dataGridView1.Columns[2].HeaderText = Global_Class.Language.res_man.GetString("lbHSX", Global_Class.Language.cul);
            this.dataGridView1.Columns[3].HeaderText = Global_Class.Language.res_man.GetString("lbNoiMua", Global_Class.Language.cul);
            this.dataGridView1.Columns[4].HeaderText = Global_Class.Language.res_man.GetString("lbGia", Global_Class.Language.cul);

        }
        //delete TestTable form server database
        private void delete_database()
        {
            using (SqlConnection connect = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand("Delete from TestTable", connect))
                {
                    try
                    {
                        connect.Open();

                        command.ExecuteNonQuery();

                        connect.Close();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }


                }
            }
        }

 
        //insert new record into database
        private void insert_database()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into TestTable(Date,Product,Manufacturer,Place,Price) values(@Date, @Product, @Manufacturer, @Place, @Price)";
                    cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@Product", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Place", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));

                    try
                    {
                        conn.Open();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    cmd.Parameters["@Date"].Value = dateTimePicker1.Value.Date;
                    cmd.Parameters["@Product"].Value = tbTH.Text;
                    cmd.Parameters["@Manufacturer"].Value = tbHSX.Text;
                    cmd.Parameters["@Place"].Value = tbNM.Text;
                    cmd.Parameters["@Price"].Value = nupG.Value;
                    cmd.ExecuteNonQuery();

                    try
                    {
                        conn.Close();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }
                }
            }
        }

        //update from database to datagridview
        private void update_datagridview()
        {
            this.testTableTableAdapter.Fill(this.testdbDataSet4.TestTable);
        }

        //ấn nút Lọc kết quả theo khoảng ngày tháng
        private void btLoc_Click(object sender, EventArgs e)
        {
            testTableBindingSource.Filter = "Date >= '" + dateTimePicker2.Value + "' And Date <='" + dateTimePicker3.Value + "'";
        }

        //chọn 1 dòng trong datagridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "," };

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Index != dataGridView1.NewRowIndex)
                {
                    tbTH.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    tbHSX.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    tbNM.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    nupG.Value = Decimal.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), NumberStyles.AllowDecimalPoint, numberFormatInfo);
                    //nupG.Value = Decimal.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                }
            }
            else
            {
                tbTH.Text = "";
                tbHSX.Text = "";
                tbNM.Text = "";
                dateTimePicker1.Value = DateTime.Now.Date;
                nupG.Value = 0;
            }

        }

    }
}

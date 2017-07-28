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

        private const string str = "Data Source=BIB-LHOX\\CONEXIO;Initial Catalog=Testdb;Integrated Security=True";

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
                insert_database();
                update_datagridview();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {

                using (SqlConnection conn = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "Delete from TestTable where Product=@Product";
                        cmd.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar));

                        try
                        {
                            conn.Open();
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.ToString());
                        }
                        cmd.Parameters["@Product"].Value = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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

        //save data from datagridview to database - no more used
        //private void btSdb_Click(object sender, EventArgs e)
        //{

        //    delete_database();

        //    using (SqlConnection connect = new SqlConnection(str))
        //    {
        //        using (SqlCommand command = new SqlCommand())
        //        {
        //            command.Connection = connect;
        //            command.CommandText = "insert into TestTable(Date, Product, Manufacturer, Place, Price) values(@Date, @Product, @Manufacturer, @Place, @Price)";

        //            command.Parameters.Add(new SqlParameter("@Date", SqlDbType.VarChar));
        //            command.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar));
        //            command.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.VarChar));
        //            command.Parameters.Add(new SqlParameter("@Place", SqlDbType.VarChar));
        //            command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Real));

        //            try
        //            {
        //                connect.Open();
        //            }
        //            catch (Exception exc)
        //            {
        //                Console.WriteLine(exc.ToString());
        //            }
                    
        //            foreach (DataGridViewRow row in dataGridView1.Rows)
        //            {
        //                if (!row.IsNewRow)
        //                {
        //                    command.Parameters["@Date"].Value = row.Cells[0].Value;
        //                    command.Parameters["@Product"].Value = row.Cells[1].Value;
        //                    command.Parameters["@Manufacturer"].Value = row.Cells[2].Value;
        //                    command.Parameters["@Place"].Value = row.Cells[3].Value;
        //                    command.Parameters["@Price"].Value = row.Cells[4].Value;

        //                    command.ExecuteNonQuery();
        //                }
        //            }

        //            try
        //            {
        //                connect.Close();
        //            }
        //            catch (Exception exc)
        //            {
        //                Console.WriteLine(exc.ToString());
        //            }

        //        }
        //    }
        //}

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
                    cmd.Parameters.Add(new SqlParameter("@Product", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Manufacturer", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Place", SqlDbType.VarChar));
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


    }
}

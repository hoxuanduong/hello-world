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

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

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

        //save data from datagridview to database
        private void btSdb_Click(object sender, EventArgs e)
        {

            delete_table();

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

                    try
                    {
                        connect.Open();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }
                    
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

                    try
                    {
                        connect.Close();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }

                }
            }
        }

        private void delete_table()
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

        //take data from database to listview
        private void btUd_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand("select * from TestTable",connect))
                {

                    SqlDataReader myReader = null;

                    //open connection to sql server
                    try
                    {
                        connect.Open();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }

                    try
                    {

                        //execute read command from database in sql server                
                        myReader = command.ExecuteReader();

                        // read each row from TestTable and write it into listView1
                        while (myReader.Read())
                        {

                        //do something with data read

                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }

                    //close the reader 
                    try
                    {
                        myReader.Close();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }

                    //close the connection
                    try
                    {
                        connect.Close();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }


                }
            }


        }

        //update from database to datagridview
        private void button1_Click(object sender, EventArgs e)
        {
            this.testTableTableAdapter.Fill(this.testdbDataSet4.TestTable);
        }
    }
}

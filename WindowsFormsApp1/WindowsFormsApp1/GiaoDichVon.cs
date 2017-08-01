using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;


namespace WindowsFormsApp1
{
    public partial class GiaoDichVon : Form
    {

        //string use to connect to server
        //server explorer, datenverbindungen, Eigenschaften -> Verbindungszeichenfolge
        private const string str = "Data Source=BIB-LHOX\\CONEXIO;Initial Catalog=Testdb;Integrated Security=True";

        enum MenhGia { euro = 1, usd, vnd };
        enum LoaiGiaoDich { them = 1, thoai};

        public GiaoDichVon()
        {
            InitializeComponent();
        }

        private void GiaoDichVon_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testdbDataSetGiaoDichVon.GiaoDichVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.giaoDichVonTableAdapter.Fill(this.testdbDataSetGiaoDichVon.GiaoDichVon);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbLoaiGiaoDichVon.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch vốn", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbMenhGia.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng chọn loại tiền", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                insert_gdv();
                update_tkv();
                update_datagridview();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void insert_gdv()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into GiaoDichVon(Type,Date,Amount,Currency,Note) values(@Type, @Date, @Amount, @Currency, @Note)";
                    cmd.Parameters.Add(new SqlParameter("@Type", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@Currency", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Note", SqlDbType.VarChar));

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    cmd.Parameters["@Type"].Value = cbLoaiGiaoDichVon.SelectedItem.ToString();
                    cmd.Parameters["@Date"].Value = dtpGiaoDichVon.Value.Date;
                    cmd.Parameters["@Amount"].Value = nudGiaoDichVon.Value;
                    cmd.Parameters["@Currency"].Value = cbMenhGia.SelectedItem.ToString();
                    cmd.Parameters["@Note"].Value = tbNote.Text;
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

        private void update_tkv()
        {

            decimal tkv = actual_tkv((MenhGia)cbMenhGia.SelectedIndex);          

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE TaiKhoanVon SET Amount = @amount Where Currency = @currency";
                    cmd.Parameters.Add(new SqlParameter("@amount", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@currency", SqlDbType.VarChar));

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    switch ((MenhGia)cbMenhGia.SelectedIndex)
                    {
                        case MenhGia.euro:
                            cmd.Parameters["@currency"].Value = "euro";
                            break;
                        case MenhGia.usd:
                            cmd.Parameters["@currency"].Value = "usd";
                            break;
                        case MenhGia.vnd:
                            cmd.Parameters["@currency"].Value = "vnd";
                            break;
                        default:
                            break;

                    }

                    switch ((LoaiGiaoDich)cbLoaiGiaoDichVon.SelectedIndex)
                    {
                        case LoaiGiaoDich.them:
                            cmd.Parameters["@amount"].Value = tkv + nudGiaoDichVon.Value;
                            break;
                        case LoaiGiaoDich.thoai:
                            cmd.Parameters["@amount"].Value = tkv - nudGiaoDichVon.Value;
                            break;
                        default:
                            break;

                    }

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

        //lay gia tri tai khoan von hien thoi cua menh gia tuong ung
        private decimal actual_tkv(MenhGia lgd)
        {

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    decimal ketqua = 0;

                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * from TaiKhoanVon Where Currency = @currency";
                    cmd.Parameters.Add(new SqlParameter("@currency", SqlDbType.VarChar));

                    switch (lgd)
                    {
                        case MenhGia.euro:
                            cmd.Parameters["@currency"].Value = "euro";
                            break;
                        case MenhGia.usd:
                            cmd.Parameters["@currency"].Value = "usd";
                            break;
                        case MenhGia.vnd:
                            cmd.Parameters["@currency"].Value = "vnd";
                            break;
                        default:
                            break;

                    }

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ketqua = Decimal.Parse(reader["Amount"].ToString());
                        }
                    }
                  
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.ToString());
                    }

                    return ketqua;
                }

            }
         
        }

        private void update_datagridview()
        {
            this.giaoDichVonTableAdapter.Fill(this.testdbDataSetGiaoDichVon.GiaoDichVon);
        }


    }
}

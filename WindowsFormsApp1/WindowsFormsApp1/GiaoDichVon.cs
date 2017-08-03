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

        enum MenhGia { nothing = -1, euro, usd, vnd };
        enum LoaiGiaoDich { nothing = -1, them, thoai};

        public GiaoDichVon()
        {
            InitializeComponent();
            this.dgvGiaoDichVon.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            

        }

        private void GiaoDichVon_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "gDV.GiaoDichVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.giaoDichVonTableAdapter.Fill(this.GDV.GiaoDichVon);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "gDV.GiaoDichVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.giaoDichVonTableAdapter.Fill(this.GDV.GiaoDichVon);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if ((LoaiGiaoDich)cbLoaiGiaoDichVon.SelectedIndex == LoaiGiaoDich.nothing)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch vốn", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((MenhGia)cbMenhGia.SelectedIndex == MenhGia.nothing)
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
            if (this.dgvGiaoDichVon.SelectedRows.Count > 0)
            {
                if(dgvGiaoDichVon.SelectedRows[0].Index != dgvGiaoDichVon.NewRowIndex)
                {
                    using (SqlConnection conn = new SqlConnection(str))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "Delete from GiaoDichVon where Date = @Date";
                            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime));

                            try
                            {
                                conn.Open();
                            }
                            catch (Exception exc)
                            {
                                Console.WriteLine(exc.ToString());
                            }
                            cmd.Parameters["@Date"].Value = Convert.ToDateTime(dgvGiaoDichVon.SelectedRows[0].Cells[1].Value);

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

                    dgvGiaoDichVon.Rows.RemoveAt(this.dgvGiaoDichVon.SelectedRows[0].Index);
                }
               
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insert_gdv()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into GiaoDichVon(Type,Date,Amount,Currency,Note) values(@Type, @Date, @Amount, @Currency, @Note)";
                    cmd.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@Currency", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar));

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    cmd.Parameters["@Type"].Value = cbLoaiGiaoDichVon.SelectedItem.ToString();
                    cmd.Parameters["@Date"].Value = dtpGDV_D.Value;
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
                    cmd.Parameters.Add(new SqlParameter("@currency", SqlDbType.NVarChar));

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
                    cmd.Parameters.Add(new SqlParameter("@currency", SqlDbType.NVarChar));

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
                            string tempo_kq;
                            tempo_kq = reader["Amount"].ToString();
                            if (String.IsNullOrEmpty(tempo_kq))
                            {
                                ketqua = 0;
                            }
                            else
                            {
                                ketqua = Decimal.Parse(reader["Amount"].ToString());
                            }

                                
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
            this.giaoDichVonTableAdapter.Fill(this.GDV.GiaoDichVon);
        }

        private void giaoDichVonBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaoDichVon.Rows)
            {

                if (row.Index != dgvGiaoDichVon.NewRowIndex) //this condition is very important, otherwise always have error null object of the newline
                {
                    //the string read from cell contain a space at the end -> before compare remove this space
                    if (row.Cells[0].Value.ToString().TrimEnd().Equals(cbLoaiGiaoDichVon.Items[0]))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (row.Cells[0].Value.ToString().TrimEnd().Equals(cbLoaiGiaoDichVon.Items[1]))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Purple;
                    }

                }
                
            }
        }

        private void cbXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXemTatCa.Checked)
            {
                dtpTu.Enabled = false;
                dtpDen.Enabled = false;
                btLoc.Enabled = false;
            }
            else
            {
                dtpTu.Enabled = true;
                dtpDen.Enabled = true;
                btLoc.Enabled = true;
            }
        }

        private void btLoc_Click(object sender, EventArgs e)
        {

        }
    }
}

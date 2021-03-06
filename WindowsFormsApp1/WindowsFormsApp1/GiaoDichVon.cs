﻿using System;
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

        
        enum MenhGia { nothing = -1, euro, usd, vnd };
        enum LoaiGiaoDich { nothing = -1, them, thoai};

        public GiaoDichVon()
        {
            InitializeComponent();
            this.dgvGiaoDichVon.DefaultCellStyle.Font = new Font("Arial Unicode MS", 9);
            

        }

        private void GiaoDichVon_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testdbGDVDataSet.GiaoDichVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.giaoDichVonTableAdapter.Fill(this.testdbGDVDataSet.GiaoDichVon);

            cbLoaiGiaoDichVon.SelectedIndex = 0;
            cbMenhGia.SelectedIndex = 0;
            update_UI_GiaoDichVon();

        }

        private void update_UI_GiaoDichVon()
        {

            this.lbLoaiGiaoDich.Text = Global_Class.Language.res_man.GetString("lbLoaiGiaoDich", Global_Class.Language.cul);
            this.lbSoTien.Text = Global_Class.Language.res_man.GetString("lbSoTien", Global_Class.Language.cul);
            this.lbMenhGia.Text = Global_Class.Language.res_man.GetString("lbMenhGia", Global_Class.Language.cul);
            this.lbNgayGiaoDich.Text = Global_Class.Language.res_man.GetString("lbNgayGiaoDich", Global_Class.Language.cul);
            this.lbGhiChu.Text = Global_Class.Language.res_man.GetString("lbGhiChu", Global_Class.Language.cul);
            this.lbLichSuGdv.Text = Global_Class.Language.res_man.GetString("lbLichSuGdv", Global_Class.Language.cul);
            this.lbTu.Text = Global_Class.Language.res_man.GetString("lbTu", Global_Class.Language.cul);
            this.lbToi.Text = Global_Class.Language.res_man.GetString("lbToi", Global_Class.Language.cul);
            this.cbXtc.Text = Global_Class.Language.res_man.GetString("cbXtc", Global_Class.Language.cul);

            this.btLoc.Text = Global_Class.Language.res_man.GetString("btLoc", Global_Class.Language.cul);
            this.btThem.Text = Global_Class.Language.res_man.GetString("btThem", Global_Class.Language.cul);
            this.btXoa.Text = Global_Class.Language.res_man.GetString("btXoa", Global_Class.Language.cul);

            this.dgvGiaoDichVon.Columns[0].HeaderText = Global_Class.Language.res_man.GetString("lbLoaiGiaoDich", Global_Class.Language.cul);
            this.dgvGiaoDichVon.Columns[1].HeaderText = Global_Class.Language.res_man.GetString("lbNgayGiaoDich", Global_Class.Language.cul);
            this.dgvGiaoDichVon.Columns[2].HeaderText = Global_Class.Language.res_man.GetString("lbSoTien", Global_Class.Language.cul);
            this.dgvGiaoDichVon.Columns[3].HeaderText = Global_Class.Language.res_man.GetString("lbMenhGia", Global_Class.Language.cul);
            this.dgvGiaoDichVon.Columns[4].HeaderText = Global_Class.Language.res_man.GetString("lbGhiChu", Global_Class.Language.cul);
           
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
                    using (SqlConnection conn = new SqlConnection(Global_Class.awsserver))
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
            using (SqlConnection conn = new SqlConnection(Global_Class.awsserver))
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

            using (SqlConnection conn = new SqlConnection(Global_Class.awsserver))
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

            using (SqlConnection conn = new SqlConnection(Global_Class.awsserver))
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
            this.giaoDichVonTableAdapter.Fill(this.testdbGDVDataSet.GiaoDichVon);
        }

        //contain of the datagridview has been changed
        private void giaoDichVonBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

            update_dgv_display();

        }

        private void update_dgv_display()
        {
            double euro = 0, usd = 0, vnd = 0;

            foreach (DataGridViewRow row in dgvGiaoDichVon.Rows)
            {



                //update rows color
                if (row.Index != dgvGiaoDichVon.NewRowIndex) //this condition is very important, otherwise always have error null object of the newline
                {
                    //the string read from cell contain a space at the end -> before compare remove this space
                    if (row.Cells[0].Value.ToString().TrimEnd().Equals(cbLoaiGiaoDichVon.Items[0]))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green;
                        switch (row.Cells[3].Value.ToString().TrimEnd())
                        {
                            case "euro":
                                euro += double.Parse(row.Cells[2].Value.ToString());
                                break;
                            case "usd":
                                usd += double.Parse(row.Cells[2].Value.ToString());
                                break;
                            case "vnd":
                                vnd += double.Parse(row.Cells[2].Value.ToString());
                                break;
                            default:
                                break;

                        }
                    }
                    else if (row.Cells[0].Value.ToString().TrimEnd().Equals(cbLoaiGiaoDichVon.Items[1]))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        switch (row.Cells[3].Value.ToString().TrimEnd())
                        {
                            case "euro":
                                euro -= double.Parse(row.Cells[2].Value.ToString());
                                break;
                            case "usd":
                                usd -= double.Parse(row.Cells[2].Value.ToString());
                                break;
                            case "vnd":
                                vnd -= double.Parse(row.Cells[2].Value.ToString());
                                break;
                            default:
                                break;

                        }
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Purple;
                    }

                }

                lbeuro.Text = euro.ToString();
                lbusd.Text = usd.ToString();
                lbvnd.Text = vnd.ToString();


            }
        }

        private void cbXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXtc.Checked)
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
            giaoDichVonBindingSource.Filter = "Date >= '" + dtpTu.Value + "' And Date <='" + dtpDen.Value + "'";
        }
    }
}

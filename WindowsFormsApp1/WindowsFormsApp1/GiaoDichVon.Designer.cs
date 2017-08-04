namespace WindowsFormsApp1
{
    partial class GiaoDichVon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbLoaiGiaoDichVon = new System.Windows.Forms.ComboBox();
            this.nudGiaoDichVon = new System.Windows.Forms.NumericUpDown();
            this.dtpGDV_D = new System.Windows.Forms.DateTimePicker();
            this.dgvGiaoDichVon = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoDichVonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GDV = new WindowsFormsApp1.gDV();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbLoaiGiaoDich = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.cbMenhGia = new System.Windows.Forms.ComboBox();
            this.lbMenhGia = new System.Windows.Forms.Label();
            this.lbNgayGiaoDich = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.cbXtc = new System.Windows.Forms.CheckBox();
            this.lbLichSuGdv = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbToi = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.btLoc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbeuro = new System.Windows.Forms.Label();
            this.lbusd = new System.Windows.Forms.Label();
            this.lbvnd = new System.Windows.Forms.Label();
            this.giaoDichVonTableAdapter = new WindowsFormsApp1.gDVTableAdapters.GiaoDichVonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaoDichVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichVonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiGiaoDichVon
            // 
            this.cbLoaiGiaoDichVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGiaoDichVon.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGiaoDichVon.FormattingEnabled = true;
            this.cbLoaiGiaoDichVon.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbLoaiGiaoDichVon.Location = new System.Drawing.Point(100, 96);
            this.cbLoaiGiaoDichVon.Name = "cbLoaiGiaoDichVon";
            this.cbLoaiGiaoDichVon.Size = new System.Drawing.Size(121, 26);
            this.cbLoaiGiaoDichVon.TabIndex = 0;
            // 
            // nudGiaoDichVon
            // 
            this.nudGiaoDichVon.DecimalPlaces = 2;
            this.nudGiaoDichVon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGiaoDichVon.Location = new System.Drawing.Point(249, 97);
            this.nudGiaoDichVon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGiaoDichVon.Name = "nudGiaoDichVon";
            this.nudGiaoDichVon.Size = new System.Drawing.Size(100, 22);
            this.nudGiaoDichVon.TabIndex = 1;
            // 
            // dtpGDV_D
            // 
            this.dtpGDV_D.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGDV_D.Location = new System.Drawing.Point(499, 98);
            this.dtpGDV_D.Name = "dtpGDV_D";
            this.dtpGDV_D.Size = new System.Drawing.Size(125, 22);
            this.dtpGDV_D.TabIndex = 2;
            // 
            // dgvGiaoDichVon
            // 
            this.dgvGiaoDichVon.AutoGenerateColumns = false;
            this.dgvGiaoDichVon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDichVon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDichVon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvGiaoDichVon.DataSource = this.giaoDichVonBindingSource;
            this.dgvGiaoDichVon.Location = new System.Drawing.Point(100, 318);
            this.dgvGiaoDichVon.MultiSelect = false;
            this.dgvGiaoDichVon.Name = "dgvGiaoDichVon";
            this.dgvGiaoDichVon.RowTemplate.Height = 24;
            this.dgvGiaoDichVon.Size = new System.Drawing.Size(1150, 500);
            this.dgvGiaoDichVon.TabIndex = 3;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // giaoDichVonBindingSource
            // 
            this.giaoDichVonBindingSource.DataMember = "GiaoDichVon";
            this.giaoDichVonBindingSource.DataSource = this.GDV;
            this.giaoDichVonBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.giaoDichVonBindingSource_ListChanged);
            // 
            // GDV
            // 
            this.GDV.DataSetName = "GDV";
            this.GDV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(666, 98);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(782, 98);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbLoaiGiaoDich
            // 
            this.lbLoaiGiaoDich.AutoSize = true;
            this.lbLoaiGiaoDich.Location = new System.Drawing.Point(100, 60);
            this.lbLoaiGiaoDich.Name = "lbLoaiGiaoDich";
            this.lbLoaiGiaoDich.Size = new System.Drawing.Size(99, 16);
            this.lbLoaiGiaoDich.TabIndex = 6;
            this.lbLoaiGiaoDich.Text = "Loại Giao Dịch:";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(246, 61);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(58, 16);
            this.lbSoTien.TabIndex = 7;
            this.lbSoTien.Text = "Số Tiền:";
            // 
            // cbMenhGia
            // 
            this.cbMenhGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenhGia.FormattingEnabled = true;
            this.cbMenhGia.Items.AddRange(new object[] {
            "euro",
            "usd",
            "vnd"});
            this.cbMenhGia.Location = new System.Drawing.Point(372, 95);
            this.cbMenhGia.Name = "cbMenhGia";
            this.cbMenhGia.Size = new System.Drawing.Size(100, 24);
            this.cbMenhGia.TabIndex = 8;
            // 
            // lbMenhGia
            // 
            this.lbMenhGia.AutoSize = true;
            this.lbMenhGia.Location = new System.Drawing.Point(369, 60);
            this.lbMenhGia.Name = "lbMenhGia";
            this.lbMenhGia.Size = new System.Drawing.Size(68, 16);
            this.lbMenhGia.TabIndex = 9;
            this.lbMenhGia.Text = "Mệnh Giá:";
            // 
            // lbNgayGiaoDich
            // 
            this.lbNgayGiaoDich.AutoSize = true;
            this.lbNgayGiaoDich.Location = new System.Drawing.Point(496, 62);
            this.lbNgayGiaoDich.Name = "lbNgayGiaoDich";
            this.lbNgayGiaoDich.Size = new System.Drawing.Size(170, 16);
            this.lbNgayGiaoDich.TabIndex = 10;
            this.lbNgayGiaoDich.Text = "Ngày Thực Hiện Giao Dịch:";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(100, 159);
            this.tbNote.MaxLength = 50;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(757, 25);
            this.tbNote.TabIndex = 11;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(100, 140);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(57, 16);
            this.lbGhiChu.TabIndex = 12;
            this.lbGhiChu.Text = "Ghi Chú:";
            // 
            // cbXtc
            // 
            this.cbXtc.AutoSize = true;
            this.cbXtc.Checked = true;
            this.cbXtc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbXtc.Location = new System.Drawing.Point(100, 249);
            this.cbXtc.Name = "cbXtc";
            this.cbXtc.Size = new System.Drawing.Size(97, 20);
            this.cbXtc.TabIndex = 13;
            this.cbXtc.Text = "Xem Tất Cả";
            this.cbXtc.UseVisualStyleBackColor = true;
            this.cbXtc.CheckedChanged += new System.EventHandler(this.cbXemTatCa_CheckedChanged);
            // 
            // lbLichSuGdv
            // 
            this.lbLichSuGdv.AutoSize = true;
            this.lbLichSuGdv.Location = new System.Drawing.Point(100, 218);
            this.lbLichSuGdv.Name = "lbLichSuGdv";
            this.lbLichSuGdv.Size = new System.Drawing.Size(143, 16);
            this.lbLichSuGdv.TabIndex = 14;
            this.lbLichSuGdv.Text = "Lịch Sử Giao Dịch Vốn:";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(295, 250);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(27, 16);
            this.lbTu.TabIndex = 15;
            this.lbTu.Text = "Từ:";
            // 
            // lbToi
            // 
            this.lbToi.AutoSize = true;
            this.lbToi.Location = new System.Drawing.Point(480, 249);
            this.lbToi.Name = "lbToi";
            this.lbToi.Size = new System.Drawing.Size(35, 16);
            this.lbToi.TabIndex = 16;
            this.lbToi.Text = "Đến:";
            // 
            // dtpTu
            // 
            this.dtpTu.Enabled = false;
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(298, 279);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(125, 22);
            this.dtpTu.TabIndex = 17;
            // 
            // dtpDen
            // 
            this.dtpDen.Enabled = false;
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(483, 279);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(125, 22);
            this.dtpDen.TabIndex = 18;
            // 
            // btLoc
            // 
            this.btLoc.Enabled = false;
            this.btLoc.Location = new System.Drawing.Point(666, 243);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(75, 23);
            this.btLoc.TabIndex = 19;
            this.btLoc.Text = "&Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 851);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng Vốn Giao Dịch Theo Thời Gian Lọc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(621, 851);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "euro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 879);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "usd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(621, 906);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "vnđ";
            // 
            // lbeuro
            // 
            this.lbeuro.AutoSize = true;
            this.lbeuro.Location = new System.Drawing.Point(454, 851);
            this.lbeuro.Name = "lbeuro";
            this.lbeuro.Size = new System.Drawing.Size(32, 16);
            this.lbeuro.TabIndex = 24;
            this.lbeuro.Text = "0,00";
            // 
            // lbusd
            // 
            this.lbusd.AutoSize = true;
            this.lbusd.Location = new System.Drawing.Point(454, 879);
            this.lbusd.Name = "lbusd";
            this.lbusd.Size = new System.Drawing.Size(32, 16);
            this.lbusd.TabIndex = 25;
            this.lbusd.Text = "0,00";
            // 
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(454, 906);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(32, 16);
            this.lbvnd.TabIndex = 26;
            this.lbvnd.Text = "0,00";
            // 
            // giaoDichVonTableAdapter
            // 
            this.giaoDichVonTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoDichVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 961);
            this.Controls.Add(this.lbvnd);
            this.Controls.Add(this.lbusd);
            this.Controls.Add(this.lbeuro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.lbToi);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.lbLichSuGdv);
            this.Controls.Add(this.cbXtc);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lbNgayGiaoDich);
            this.Controls.Add(this.lbMenhGia);
            this.Controls.Add(this.cbMenhGia);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbLoaiGiaoDich);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvGiaoDichVon);
            this.Controls.Add(this.dtpGDV_D);
            this.Controls.Add(this.nudGiaoDichVon);
            this.Controls.Add(this.cbLoaiGiaoDichVon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GiaoDichVon";
            this.Text = "GiaoDichVon";
            this.Load += new System.EventHandler(this.GiaoDichVon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaoDichVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichVonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiGiaoDichVon;
        private System.Windows.Forms.NumericUpDown nudGiaoDichVon;
        private System.Windows.Forms.DateTimePicker dtpGDV_D;
        private System.Windows.Forms.DataGridView dgvGiaoDichVon;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbLoaiGiaoDich;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.ComboBox cbMenhGia;
        private System.Windows.Forms.Label lbMenhGia;
        private System.Windows.Forms.Label lbNgayGiaoDich;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.CheckBox cbXtc;
        private System.Windows.Forms.Label lbLichSuGdv;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbToi;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbeuro;
        private System.Windows.Forms.Label lbusd;
        private System.Windows.Forms.Label lbvnd;
        private gDV GDV;
        private System.Windows.Forms.BindingSource giaoDichVonBindingSource;
        private gDVTableAdapters.GiaoDichVonTableAdapter giaoDichVonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}
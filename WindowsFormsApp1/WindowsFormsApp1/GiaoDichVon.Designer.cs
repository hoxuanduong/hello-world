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
            this.dtpGiaoDichVon = new System.Windows.Forms.DateTimePicker();
            this.dgvGiaoDichVon = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMenhGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbXemTatCa = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.testdbDataSetGiaoDichVon = new WindowsFormsApp1.TestdbDataSetGiaoDichVon();
            this.giaoDichVonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoDichVonTableAdapter = new WindowsFormsApp1.TestdbDataSetGiaoDichVonTableAdapters.GiaoDichVonTableAdapter();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaoDichVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSetGiaoDichVon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichVonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiGiaoDichVon
            // 
            this.cbLoaiGiaoDichVon.FormattingEnabled = true;
            this.cbLoaiGiaoDichVon.Items.AddRange(new object[] {
            "Thêm Vốn",
            "Thoái Vốn"});
            this.cbLoaiGiaoDichVon.Location = new System.Drawing.Point(100, 96);
            this.cbLoaiGiaoDichVon.Name = "cbLoaiGiaoDichVon";
            this.cbLoaiGiaoDichVon.Size = new System.Drawing.Size(121, 24);
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
            // dtpGiaoDichVon
            // 
            this.dtpGiaoDichVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGiaoDichVon.Location = new System.Drawing.Point(499, 98);
            this.dtpGiaoDichVon.Name = "dtpGiaoDichVon";
            this.dtpGiaoDichVon.Size = new System.Drawing.Size(125, 22);
            this.dtpGiaoDichVon.TabIndex = 2;
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
            this.dgvGiaoDichVon.Name = "dgvGiaoDichVon";
            this.dgvGiaoDichVon.RowTemplate.Height = 24;
            this.dgvGiaoDichVon.Size = new System.Drawing.Size(1150, 500);
            this.dgvGiaoDichVon.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(666, 97);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(782, 97);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại Giao Dịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Tiền:";
            // 
            // cbMenhGia
            // 
            this.cbMenhGia.FormattingEnabled = true;
            this.cbMenhGia.Items.AddRange(new object[] {
            "euro",
            "usd",
            "vnđ"});
            this.cbMenhGia.Location = new System.Drawing.Point(372, 95);
            this.cbMenhGia.Name = "cbMenhGia";
            this.cbMenhGia.Size = new System.Drawing.Size(100, 24);
            this.cbMenhGia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mệnh Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Thực Hiện Giao Dịch:";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(100, 159);
            this.tbNote.MaxLength = 50;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(757, 22);
            this.tbNote.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ghi Chú:";
            // 
            // cbXemTatCa
            // 
            this.cbXemTatCa.AutoSize = true;
            this.cbXemTatCa.Location = new System.Drawing.Point(100, 249);
            this.cbXemTatCa.Name = "cbXemTatCa";
            this.cbXemTatCa.Size = new System.Drawing.Size(97, 20);
            this.cbXemTatCa.TabIndex = 13;
            this.cbXemTatCa.Text = "Xem Tất Cả";
            this.cbXemTatCa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lịch Sử Giao Dịch Vốn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Từ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Đến:";
            // 
            // dtpTu
            // 
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(298, 279);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(125, 22);
            this.dtpTu.TabIndex = 17;
            // 
            // dtpDen
            // 
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(483, 279);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(125, 22);
            this.dtpDen.TabIndex = 18;
            // 
            // btLoc
            // 
            this.btLoc.Location = new System.Drawing.Point(666, 243);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(75, 23);
            this.btLoc.TabIndex = 19;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
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
            // testdbDataSetGiaoDichVon
            // 
            this.testdbDataSetGiaoDichVon.DataSetName = "TestdbDataSetGiaoDichVon";
            this.testdbDataSetGiaoDichVon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoDichVonBindingSource
            // 
            this.giaoDichVonBindingSource.DataMember = "GiaoDichVon";
            this.giaoDichVonBindingSource.DataSource = this.testdbDataSetGiaoDichVon;
            // 
            // giaoDichVonTableAdapter
            // 
            this.giaoDichVonTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbXemTatCa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMenhGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvGiaoDichVon);
            this.Controls.Add(this.dtpGiaoDichVon);
            this.Controls.Add(this.nudGiaoDichVon);
            this.Controls.Add(this.cbLoaiGiaoDichVon);
            this.Name = "GiaoDichVon";
            this.Text = "GiaoDichVon";
            this.Load += new System.EventHandler(this.GiaoDichVon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaoDichVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSetGiaoDichVon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichVonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiGiaoDichVon;
        private System.Windows.Forms.NumericUpDown nudGiaoDichVon;
        private System.Windows.Forms.DateTimePicker dtpGiaoDichVon;
        private System.Windows.Forms.DataGridView dgvGiaoDichVon;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMenhGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbXemTatCa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
        private TestdbDataSetGiaoDichVon testdbDataSetGiaoDichVon;
        private System.Windows.Forms.BindingSource giaoDichVonBindingSource;
        private TestdbDataSetGiaoDichVonTableAdapters.GiaoDichVonTableAdapter giaoDichVonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}
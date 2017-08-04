namespace WindowsFormsApp1
{
    partial class LietKeChiTieu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbTH = new System.Windows.Forms.TextBox();
            this.tbHSX = new System.Windows.Forms.TextBox();
            this.nupG = new System.Windows.Forms.NumericUpDown();
            this.btThem = new System.Windows.Forms.Button();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbHSX = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbNM = new System.Windows.Forms.TextBox();
            this.lbNoiMua = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNgayMua = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbXtc = new System.Windows.Forms.CheckBox();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbToi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdbDataSet4 = new WindowsFormsApp1.TestdbDataSet4();
            this.btSdb = new System.Windows.Forms.Button();
            this.testTableTableAdapter = new WindowsFormsApp1.TestdbDataSet4TableAdapters.TestTableTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*  ";
            this.openFileDialog1.Title = "Select a picture file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tbTH
            // 
            this.tbTH.Location = new System.Drawing.Point(67, 92);
            this.tbTH.Margin = new System.Windows.Forms.Padding(4);
            this.tbTH.Name = "tbTH";
            this.tbTH.Size = new System.Drawing.Size(199, 22);
            this.tbTH.TabIndex = 0;
            // 
            // tbHSX
            // 
            this.tbHSX.Location = new System.Drawing.Point(333, 92);
            this.tbHSX.Margin = new System.Windows.Forms.Padding(4);
            this.tbHSX.Name = "tbHSX";
            this.tbHSX.Size = new System.Drawing.Size(199, 22);
            this.tbHSX.TabIndex = 1;
            // 
            // nupG
            // 
            this.nupG.DecimalPlaces = 2;
            this.nupG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupG.Location = new System.Drawing.Point(867, 92);
            this.nupG.Margin = new System.Windows.Forms.Padding(4);
            this.nupG.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupG.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nupG.Name = "nupG";
            this.nupG.Size = new System.Drawing.Size(100, 22);
            this.nupG.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(867, 142);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 28);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(67, 49);
            this.lbTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(68, 16);
            this.lbTenHang.TabIndex = 10;
            this.lbTenHang.Text = "Tên Hàng";
            // 
            // lbHSX
            // 
            this.lbHSX.AutoSize = true;
            this.lbHSX.Location = new System.Drawing.Point(333, 49);
            this.lbHSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHSX.Name = "lbHSX";
            this.lbHSX.Size = new System.Drawing.Size(100, 16);
            this.lbHSX.TabIndex = 11;
            this.lbHSX.Text = "Hãng Sản Xuất:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(867, 49);
            this.lbGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(32, 16);
            this.lbGia.TabIndex = 13;
            this.lbGia.Text = "Giá:";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(993, 142);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbNM
            // 
            this.tbNM.Location = new System.Drawing.Point(600, 92);
            this.tbNM.Margin = new System.Windows.Forms.Padding(4);
            this.tbNM.Name = "tbNM";
            this.tbNM.Size = new System.Drawing.Size(199, 22);
            this.tbNM.TabIndex = 2;
            // 
            // lbNoiMua
            // 
            this.lbNoiMua.AutoSize = true;
            this.lbNoiMua.Location = new System.Drawing.Point(600, 49);
            this.lbNoiMua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNoiMua.Name = "lbNoiMua";
            this.lbNoiMua.Size = new System.Drawing.Size(61, 16);
            this.lbNoiMua.TabIndex = 12;
            this.lbNoiMua.Text = "Nơi Mua:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(993, 92);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbNgayMua
            // 
            this.lbNgayMua.AutoSize = true;
            this.lbNgayMua.Location = new System.Drawing.Point(993, 49);
            this.lbNgayMua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayMua.Name = "lbNgayMua";
            this.lbNgayMua.Size = new System.Drawing.Size(73, 16);
            this.lbNgayMua.TabIndex = 14;
            this.lbNgayMua.Text = "Ngày Mua:";
            // 
            // cbXtc
            // 
            this.cbXtc.AutoSize = true;
            this.cbXtc.Checked = true;
            this.cbXtc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbXtc.Location = new System.Drawing.Point(67, 154);
            this.cbXtc.Margin = new System.Windows.Forms.Padding(4);
            this.cbXtc.Name = "cbXtc";
            this.cbXtc.Size = new System.Drawing.Size(100, 20);
            this.cbXtc.TabIndex = 15;
            this.cbXtc.Text = "Xem Tất Cả:";
            this.cbXtc.UseVisualStyleBackColor = true;
            this.cbXtc.CheckedChanged += new System.EventHandler(this.cbXtc_CheckedChanged);
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(333, 154);
            this.lbTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(27, 16);
            this.lbTu.TabIndex = 18;
            this.lbTu.Text = "Từ:";
            // 
            // lbToi
            // 
            this.lbToi.AutoSize = true;
            this.lbToi.Location = new System.Drawing.Point(460, 154);
            this.lbToi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToi.Name = "lbToi";
            this.lbToi.Size = new System.Drawing.Size(31, 16);
            this.lbToi.TabIndex = 19;
            this.lbToi.Text = "Tới:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 646);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            this.testTableBindingSource.DataSource = this.testdbDataSet4;
            // 
            // testdbDataSet4
            // 
            this.testdbDataSet4.DataSetName = "TestdbDataSet4";
            this.testdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSdb
            // 
            this.btSdb.Location = new System.Drawing.Point(0, 0);
            this.btSdb.Margin = new System.Windows.Forms.Padding(4);
            this.btSdb.Name = "btSdb";
            this.btSdb.Size = new System.Drawing.Size(100, 28);
            this.btSdb.TabIndex = 0;
            // 
            // testTableTableAdapter
            // 
            this.testTableTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(336, 174);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(463, 174);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker3.TabIndex = 22;
            // 
            // btLoc
            // 
            this.btLoc.Enabled = false;
            this.btLoc.Location = new System.Drawing.Point(600, 168);
            this.btLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(100, 28);
            this.btLoc.TabIndex = 23;
            this.btLoc.Text = "&Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // LietKeChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 961);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btSdb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbToi);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.cbXtc);
            this.Controls.Add(this.lbNgayMua);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNoiMua);
            this.Controls.Add(this.tbNM);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbHSX);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.nupG);
            this.Controls.Add(this.tbHSX);
            this.Controls.Add(this.tbTH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LietKeChiTieu";
            this.Text = "Liệt Kê Chi Tiêu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbTH;
        private System.Windows.Forms.TextBox tbHSX;
        private System.Windows.Forms.NumericUpDown nupG;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbHSX;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbNM;
        private System.Windows.Forms.Label lbNoiMua;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNgayMua;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbXtc;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbToi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSdb;
        private TestdbDataSet4 testdbDataSet4;
        private System.Windows.Forms.BindingSource testTableBindingSource;
        private TestdbDataSet4TableAdapters.TestTableTableAdapter testTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btLoc;
    }
}


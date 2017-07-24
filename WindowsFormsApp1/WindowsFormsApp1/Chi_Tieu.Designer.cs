namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btXoa = new System.Windows.Forms.Button();
            this.tbNM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btMF = new System.Windows.Forms.Button();
            this.btLF = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nupG)).BeginInit();
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
            this.tbTH.Location = new System.Drawing.Point(50, 100);
            this.tbTH.Name = "tbTH";
            this.tbTH.Size = new System.Drawing.Size(150, 20);
            this.tbTH.TabIndex = 0;
            // 
            // tbHSX
            // 
            this.tbHSX.Location = new System.Drawing.Point(250, 100);
            this.tbHSX.Name = "tbHSX";
            this.tbHSX.Size = new System.Drawing.Size(150, 20);
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
            this.nupG.Location = new System.Drawing.Point(650, 100);
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
            this.nupG.Size = new System.Drawing.Size(100, 20);
            this.nupG.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(650, 140);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hãng Sản Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(50, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 400);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày Mua";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Hàng";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hãng Sản Xuất";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nơi Mua";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            this.columnHeader5.Width = 103;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(800, 140);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbNM
            // 
            this.tbNM.Location = new System.Drawing.Point(450, 100);
            this.tbNM.Name = "tbNM";
            this.tbNM.Size = new System.Drawing.Size(150, 20);
            this.tbNM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nơi Mua:";
            // 
            // btMF
            // 
            this.btMF.Location = new System.Drawing.Point(760, 647);
            this.btMF.Name = "btMF";
            this.btMF.Size = new System.Drawing.Size(75, 23);
            this.btMF.TabIndex = 8;
            this.btMF.Text = "Mở Từ File";
            this.btMF.UseVisualStyleBackColor = true;
            this.btMF.Click += new System.EventHandler(this.btMF_Click);
            // 
            // btLF
            // 
            this.btLF.Location = new System.Drawing.Point(875, 647);
            this.btLF.Name = "btLF";
            this.btLF.Size = new System.Drawing.Size(75, 23);
            this.btLF.TabIndex = 9;
            this.btLF.Text = "Lưu Vào File";
            this.btLF.UseVisualStyleBackColor = true;
            this.btLF.Click += new System.EventHandler(this.btLF_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(800, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày Mua:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btLF);
            this.Controls.Add(this.btMF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNM);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.nupG);
            this.Controls.Add(this.tbHSX);
            this.Controls.Add(this.tbTH);
            this.Name = "Form1";
            this.Text = "Liệt Kê Chi Tiêu";
            ((System.ComponentModel.ISupportInitialize)(this.nupG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbTH;
        private System.Windows.Forms.TextBox tbHSX;
        private System.Windows.Forms.NumericUpDown nupG;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbNM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMF;
        private System.Windows.Forms.Button btLF;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


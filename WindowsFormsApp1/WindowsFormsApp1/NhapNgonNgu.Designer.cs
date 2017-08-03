namespace WindowsFormsApp1
{
    partial class NhapNgonNgu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.duLieuNN = new WindowsFormsApp1.DuLieuNN();
            this.ngonNguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vietnameseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieuNN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.vietnameseDataGridViewTextBoxColumn,
            this.germanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ngonNguBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(619, 348);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "button1";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // duLieuNN
            // 
            this.duLieuNN.DataSetName = "DuLieuNN";
            this.duLieuNN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ngonNguBindingSource
            // 
            this.ngonNguBindingSource.DataMember = "NgonNgu";
            this.ngonNguBindingSource.DataSource = this.duLieuNN;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            // 
            // vietnameseDataGridViewTextBoxColumn
            // 
            this.vietnameseDataGridViewTextBoxColumn.DataPropertyName = "Vietnamese";
            this.vietnameseDataGridViewTextBoxColumn.HeaderText = "Vietnamese";
            this.vietnameseDataGridViewTextBoxColumn.Name = "vietnameseDataGridViewTextBoxColumn";
            // 
            // germanDataGridViewTextBoxColumn
            // 
            this.germanDataGridViewTextBoxColumn.DataPropertyName = "German";
            this.germanDataGridViewTextBoxColumn.HeaderText = "German";
            this.germanDataGridViewTextBoxColumn.Name = "germanDataGridViewTextBoxColumn";
            // 
            // NhapNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 395);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NhapNgonNgu";
            this.Text = "NhapNgonNgu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieuNN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vietnameseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ngonNguBindingSource;
        private DuLieuNN duLieuNN;
        private System.Windows.Forms.Button btSave;
    }
}
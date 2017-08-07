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
            this.btSave = new System.Windows.Forms.Button();
            this.dgvNgonNgu = new System.Windows.Forms.DataGridView();
            this.testdbNNDataSet = new WindowsFormsApp1.testdbNNDataSet();
            this.ngonNguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngonNguTableAdapter = new WindowsFormsApp1.testdbNNDataSetTableAdapters.NgonNguTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vietnameseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbNNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(464, 283);
            this.btSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(56, 19);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "button1";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgvNgonNgu
            // 
            this.dgvNgonNgu.AutoGenerateColumns = false;
            this.dgvNgonNgu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNgonNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgonNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vietnameseDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.germanDataGridViewTextBoxColumn});
            this.dgvNgonNgu.DataSource = this.ngonNguBindingSource;
            this.dgvNgonNgu.Location = new System.Drawing.Point(9, 10);
            this.dgvNgonNgu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNgonNgu.Name = "dgvNgonNgu";
            this.dgvNgonNgu.RowTemplate.Height = 24;
            this.dgvNgonNgu.Size = new System.Drawing.Size(512, 254);
            this.dgvNgonNgu.TabIndex = 2;
            // 
            // testdbNNDataSet
            // 
            this.testdbNNDataSet.DataSetName = "testdbNNDataSet";
            this.testdbNNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ngonNguBindingSource
            // 
            this.ngonNguBindingSource.DataMember = "NgonNgu";
            this.ngonNguBindingSource.DataSource = this.testdbNNDataSet;
            // 
            // ngonNguTableAdapter
            // 
            this.ngonNguTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vietnameseDataGridViewTextBoxColumn
            // 
            this.vietnameseDataGridViewTextBoxColumn.DataPropertyName = "Vietnamese";
            this.vietnameseDataGridViewTextBoxColumn.HeaderText = "Vietnamese";
            this.vietnameseDataGridViewTextBoxColumn.Name = "vietnameseDataGridViewTextBoxColumn";
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            // 
            // germanDataGridViewTextBoxColumn
            // 
            this.germanDataGridViewTextBoxColumn.DataPropertyName = "German";
            this.germanDataGridViewTextBoxColumn.HeaderText = "German";
            this.germanDataGridViewTextBoxColumn.Name = "germanDataGridViewTextBoxColumn";
            // 
            // NhapNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 321);
            this.Controls.Add(this.dgvNgonNgu);
            this.Controls.Add(this.btSave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhapNgonNgu";
            this.Text = "NhapNgonNgu";
            this.Load += new System.EventHandler(this.NhapNgonNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbNNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvNgonNgu;
        private testdbNNDataSet testdbNNDataSet;
        private System.Windows.Forms.BindingSource ngonNguBindingSource;
        private testdbNNDataSetTableAdapters.NgonNguTableAdapter ngonNguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vietnameseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanDataGridViewTextBoxColumn;
    }
}
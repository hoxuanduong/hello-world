namespace WindowsFormsApp1
{
    partial class DauTu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btTienVon = new System.Windows.Forms.Button();
            this.btDauTu = new System.Windows.Forms.Button();
            this.btLichSu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchVốnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchĐầuTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCổTứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btTienVon);
            this.flowLayoutPanel1.Controls.Add(this.btDauTu);
            this.flowLayoutPanel1.Controls.Add(this.btLichSu);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1334, 937);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btTienVon
            // 
            this.btTienVon.Location = new System.Drawing.Point(3, 3);
            this.btTienVon.Name = "btTienVon";
            this.btTienVon.Size = new System.Drawing.Size(200, 200);
            this.btTienVon.TabIndex = 0;
            this.btTienVon.Text = "Giao Dịch Vốn Tài Khoản Đầu Tư";
            this.btTienVon.UseVisualStyleBackColor = true;
            this.btTienVon.Click += new System.EventHandler(this.btTienVon_Click);
            // 
            // btDauTu
            // 
            this.btDauTu.Location = new System.Drawing.Point(209, 3);
            this.btDauTu.Name = "btDauTu";
            this.btDauTu.Size = new System.Drawing.Size(200, 200);
            this.btDauTu.TabIndex = 1;
            this.btDauTu.Text = "Giao Dịch Đầu Tư";
            this.btDauTu.UseVisualStyleBackColor = true;
            // 
            // btLichSu
            // 
            this.btLichSu.Location = new System.Drawing.Point(415, 3);
            this.btLichSu.Name = "btLichSu";
            this.btLichSu.Size = new System.Drawing.Size(200, 200);
            this.btLichSu.TabIndex = 2;
            this.btLichSu.Text = "Lịch Sử Giao Dịch";
            this.btLichSu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quản Lý Cổ Tức";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDichToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDichToolStripMenuItem
            // 
            this.giaoDichToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDịchVốnToolStripMenuItem,
            this.giaoDịchĐầuTưToolStripMenuItem,
            this.lịchSửGiaoDịchToolStripMenuItem,
            this.quảnLýCổTứcToolStripMenuItem});
            this.giaoDichToolStripMenuItem.Name = "giaoDichToolStripMenuItem";
            this.giaoDichToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.giaoDichToolStripMenuItem.Text = "Danh Mục";
            // 
            // giaoDịchVốnToolStripMenuItem
            // 
            this.giaoDịchVốnToolStripMenuItem.Name = "giaoDịchVốnToolStripMenuItem";
            this.giaoDịchVốnToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.giaoDịchVốnToolStripMenuItem.Text = "Giao Dịch Vốn";
            this.giaoDịchVốnToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchVốnToolStripMenuItem_Click);
            // 
            // giaoDịchĐầuTưToolStripMenuItem
            // 
            this.giaoDịchĐầuTưToolStripMenuItem.Name = "giaoDịchĐầuTưToolStripMenuItem";
            this.giaoDịchĐầuTưToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.giaoDịchĐầuTưToolStripMenuItem.Text = "Giao Dịch Đầu Tư";
            // 
            // lịchSửGiaoDịchToolStripMenuItem
            // 
            this.lịchSửGiaoDịchToolStripMenuItem.Name = "lịchSửGiaoDịchToolStripMenuItem";
            this.lịchSửGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.lịchSửGiaoDịchToolStripMenuItem.Text = "Lịch Sử Giao Dịch";
            // 
            // quảnLýCổTứcToolStripMenuItem
            // 
            this.quảnLýCổTứcToolStripMenuItem.Name = "quảnLýCổTứcToolStripMenuItem";
            this.quảnLýCổTứcToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quảnLýCổTứcToolStripMenuItem.Text = "Quản Lý Cổ Tức";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // DauTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 961);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DauTu";
            this.Text = "DauTu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btTienVon;
        private System.Windows.Forms.Button btDauTu;
        private System.Windows.Forms.Button btLichSu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giaoDichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchVốnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchĐầuTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCổTứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}
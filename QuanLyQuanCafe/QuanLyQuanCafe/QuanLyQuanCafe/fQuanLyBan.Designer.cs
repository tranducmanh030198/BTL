namespace QuanLyQuanCafe
{
    partial class fQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyBan));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvwHoaDon = new System.Windows.Forms.ListView();
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.cboBanChuyen = new System.Windows.Forms.ComboBox();
            this.txtTienBan = new System.Windows.Forms.TextBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cboDoAn = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.flpnlBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtBanID = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblBanID = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(852, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "&Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "&Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đăngXuấtToolStripMenuItem.Text = "&Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Enabled = false;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lvwHoaDon);
            this.panel2.Location = new System.Drawing.Point(449, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 330);
            this.panel2.TabIndex = 2;
            // 
            // lvwHoaDon
            // 
            this.lvwHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.lvwHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.lvwHoaDon.GridLines = true;
            this.lvwHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lvwHoaDon.Name = "lvwHoaDon";
            this.lvwHoaDon.Size = new System.Drawing.Size(385, 324);
            this.lvwHoaDon.TabIndex = 0;
            this.lvwHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvwHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món";
            this.colTenMon.Width = 150;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSoLuong.Width = 70;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDonGia.Width = 78;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colThanhTien.Width = 82;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblGiamGia);
            this.panel3.Controls.Add(this.cboBanChuyen);
            this.panel3.Controls.Add(this.txtTienBan);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.nudGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(449, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 76);
            this.panel3.TabIndex = 3;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(10, 49);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(68, 13);
            this.lblGiamGia.TabIndex = 8;
            this.lblGiamGia.Text = "Giảm giá (%):";
            // 
            // cboBanChuyen
            // 
            this.cboBanChuyen.FormattingEnabled = true;
            this.cboBanChuyen.Location = new System.Drawing.Point(84, 10);
            this.cboBanChuyen.Name = "cboBanChuyen";
            this.cboBanChuyen.Size = new System.Drawing.Size(75, 21);
            this.cboBanChuyen.TabIndex = 7;
            // 
            // txtTienBan
            // 
            this.txtTienBan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienBan.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTienBan.Location = new System.Drawing.Point(174, 26);
            this.txtTienBan.Name = "txtTienBan";
            this.txtTienBan.ReadOnly = true;
            this.txtTienBan.Size = new System.Drawing.Size(114, 24);
            this.txtTienBan.TabIndex = 6;
            this.txtTienBan.Text = "0,00 ₫";
            this.txtTienBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Enabled = false;
            this.btnChuyenBan.Location = new System.Drawing.Point(3, 5);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 30);
            this.btnChuyenBan.TabIndex = 4;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(84, 47);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(75, 20);
            this.nudGiamGia.TabIndex = 3;
            this.nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(294, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 68);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.nudSoLuong);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cboDoAn);
            this.panel4.Controls.Add(this.cboDanhMuc);
            this.panel4.Location = new System.Drawing.Point(449, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 57);
            this.panel4.TabIndex = 4;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(333, 20);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(55, 20);
            this.nudSoLuong.TabIndex = 3;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Enabled = false;
            this.btnThemMon.Location = new System.Drawing.Point(235, 3);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(83, 51);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cboDoAn
            // 
            this.cboDoAn.FormattingEnabled = true;
            this.cboDoAn.Location = new System.Drawing.Point(3, 33);
            this.cboDoAn.Name = "cboDoAn";
            this.cboDoAn.Size = new System.Drawing.Size(217, 21);
            this.cboDoAn.TabIndex = 1;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(217, 21);
            this.cboDanhMuc.TabIndex = 0;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // flpnlBan
            // 
            this.flpnlBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnlBan.AutoScroll = true;
            this.flpnlBan.Location = new System.Drawing.Point(12, 27);
            this.flpnlBan.Name = "flpnlBan";
            this.flpnlBan.Size = new System.Drawing.Size(431, 509);
            this.flpnlBan.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.txtTenBan);
            this.panel1.Controls.Add(this.txtBanID);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.lblTenBan);
            this.panel1.Controls.Add(this.lblBanID);
            this.panel1.Location = new System.Drawing.Point(449, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 34);
            this.panel1.TabIndex = 6;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(316, 7);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(58, 20);
            this.txtTrangThai.TabIndex = 5;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(151, 7);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.ReadOnly = true;
            this.txtTenBan.Size = new System.Drawing.Size(82, 20);
            this.txtTenBan.TabIndex = 4;
            // 
            // txtBanID
            // 
            this.txtBanID.Location = new System.Drawing.Point(43, 7);
            this.txtBanID.Name = "txtBanID";
            this.txtBanID.ReadOnly = true;
            this.txtBanID.Size = new System.Drawing.Size(31, 20);
            this.txtBanID.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(252, 10);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(95, 10);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(50, 13);
            this.lblTenBan.TabIndex = 1;
            this.lblTenBan.Text = "Tên bàn:";
            // 
            // lblBanID
            // 
            this.lblBanID.AutoSize = true;
            this.lblBanID.Location = new System.Drawing.Point(16, 10);
            this.lblBanID.Name = "lblBanID";
            this.lblBanID.Size = new System.Drawing.Size(21, 13);
            this.lblBanID.TabIndex = 0;
            this.lblBanID.Text = "ID:";
            // 
            // fQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpnlBan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(868, 587);
            this.Name = "fQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cboDoAn;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.FlowLayoutPanel flpnlBan;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.TextBox txtTienBan;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblBanID;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtBanID;
        private System.Windows.Forms.ComboBox cboBanChuyen;
        private System.Windows.Forms.Label lblGiamGia;
    }
}
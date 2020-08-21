namespace QuanLyQuanCafe
{
    partial class fThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTinTaiKhoan));
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblLoiNhapLai = new System.Windows.Forms.Label();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.lblLoiMatKhauMoi = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(29, 24);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(76, 13);
            this.lblTenTaiKhoan.TabIndex = 5;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(50, 69);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(111, 21);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(122, 20);
            this.txtTenTaiKhoan.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Location = new System.Drawing.Point(111, 66);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(122, 20);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(111, 111);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(122, 20);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhapLai.Location = new System.Drawing.Point(111, 156);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(122, 20);
            this.txtNhapLai.TabIndex = 2;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(31, 114);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(74, 13);
            this.lblMatKhauMoi.TabIndex = 7;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Location = new System.Drawing.Point(56, 159);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(49, 13);
            this.lblNhapLai.TabIndex = 8;
            this.lblNhapLai.Text = "Nhập lại:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Location = new System.Drawing.Point(68, 237);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(158, 237);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLoiNhapLai
            // 
            this.lblLoiNhapLai.AutoSize = true;
            this.lblLoiNhapLai.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhapLai.Location = new System.Drawing.Point(108, 179);
            this.lblLoiNhapLai.Name = "lblLoiNhapLai";
            this.lblLoiNhapLai.Size = new System.Drawing.Size(69, 13);
            this.lblLoiNhapLai.TabIndex = 12;
            this.lblLoiNhapLai.Text = "*Không khớp";
            this.lblLoiNhapLai.Visible = false;
            // 
            // lblLoiMatKhau
            // 
            this.lblLoiMatKhau.AutoSize = true;
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhau.Location = new System.Drawing.Point(108, 89);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(73, 13);
            this.lblLoiMatKhau.TabIndex = 10;
            this.lblLoiMatKhau.Text = "*Sai mật khẩu";
            this.lblLoiMatKhau.Visible = false;
            // 
            // lblLoiMatKhauMoi
            // 
            this.lblLoiMatKhauMoi.AutoSize = true;
            this.lblLoiMatKhauMoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhauMoi.Location = new System.Drawing.Point(108, 134);
            this.lblLoiMatKhauMoi.Name = "lblLoiMatKhauMoi";
            this.lblLoiMatKhauMoi.Size = new System.Drawing.Size(63, 13);
            this.lblLoiMatKhauMoi.TabIndex = 11;
            this.lblLoiMatKhauMoi.Text = "*Chưa nhập";
            this.lblLoiMatKhauMoi.Visible = false;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.ForeColor = System.Drawing.Color.Indigo;
            this.lblKetQua.Location = new System.Drawing.Point(117, 205);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 13;
            this.lblKetQua.Visible = false;
            // 
            // fThongTinTaiKhoan
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(272, 295);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblLoiMatKhauMoi);
            this.Controls.Add(this.lblLoiMatKhau);
            this.Controls.Add(this.lblLoiNhapLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fThongTinTaiKhoan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLoiNhapLai;
        private System.Windows.Forms.Label lblLoiMatKhau;
        private System.Windows.Forms.Label lblLoiMatKhauMoi;
        private System.Windows.Forms.Label lblKetQua;
    }
}
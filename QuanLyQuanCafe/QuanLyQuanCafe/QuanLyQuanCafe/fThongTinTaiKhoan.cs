using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fThongTinTaiKhoan : Form 
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }
        public string TenTaikhoan { get; set; }
        public string MatKhau { get; set; }

        public fThongTinTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            ConnStr = Properties.Settings.Default.CafeConnectionString;
            Conn = new SqlConnection(ConnStr);
            InitializeComponent();

            TenTaikhoan = tenTaiKhoan;
            MatKhau = matKhau;

            txtTenTaiKhoan.Text = TenTaikhoan;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (CatNhatMatKhau() == true)
            {
                lblKetQua.Text = "Cập nhật thành công!";

                MatKhau = txtMatKhauMoi.Text;

                txtMatKhau.Text = "";
                txtMatKhauMoi.Text = "";
                txtNhapLai.Text = "";
            }
            else
            {
                lblKetQua.Text = "Cập nhật thất bại!";
            }

            lblKetQua.Visible = true;
        }

        public bool CatNhatMatKhau()
        {
            bool ketQua = false;

            if (txtMatKhauMoi.Text != "") // Kiểm tra Mật khẩu mới
            {
                lblLoiMatKhauMoi.Visible = false;

                if (txtMatKhau.Text == MatKhau)
                {
                    lblLoiMatKhau.Visible = false;

                    if (txtNhapLai.Text == txtMatKhauMoi.Text)
                    {
                        // Mở kết nối đến CSDL
                        SqlConnection conn = new SqlConnection(ConnStr);
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        // Cập nhật mật khẩu mới
                        SqlCommand cmdUpdateMatKhau = new SqlCommand("SP_DoiMatKhau", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmdUpdateMatKhau.Parameters.AddWithValue("@TenTaiKhoan", TenTaikhoan);
                        cmdUpdateMatKhau.Parameters.AddWithValue("@MatKhauMoi", txtMatKhauMoi.Text);
                        cmdUpdateMatKhau.ExecuteNonQuery();

                        lblLoiNhapLai.Visible = false;

                        ketQua = true;
                    }
                    else
                    {
                        lblLoiNhapLai.Text = "*Không khớp";
                        lblLoiNhapLai.Visible = true;
                    }
                }
                else
                {
                    lblLoiMatKhau.Text = "*Sai mật khẩu";
                    lblLoiMatKhau.Visible = true;
                }
            }
            else
            {
                lblLoiMatKhauMoi.Text = "*Chưa nhập";
                lblLoiMatKhauMoi.Visible = true;
            }

            return ketQua;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

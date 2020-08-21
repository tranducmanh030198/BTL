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
    public partial class fDangNhap : Form
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }

        public fDangNhap()
        {
            ConnStr = Properties.Settings.Default.CafeConnectionString;
            Conn = new SqlConnection(ConnStr);
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Kiểm tra Tên Tài Khoản + Mật Khẩu
            SqlCommand cmdGetTaiKhoan = new SqlCommand("SP_DangNhap", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
            cmdGetTaiKhoan.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
            SqlParameter loai = cmdGetTaiKhoan.Parameters.Add("@Loai", SqlDbType.Int);
            loai.Direction = ParameterDirection.ReturnValue;
            cmdGetTaiKhoan.ExecuteNonQuery();

            // Đăng nhập thành công
            if ((int)loai.Value != -1)
            {
                this.Hide();
                fQuanLyBan fQuanLyBan = new fQuanLyBan(txtTenTaiKhoan.Text, txtMatKhau.Text, (int)loai.Value);
                fQuanLyBan.ShowDialog();
                this.Show();
            }
            // Đăng nhập thất bại
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng. Xin vui lòng nhập lại!", "Lỗi đăng nhập");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel);

            if (dialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

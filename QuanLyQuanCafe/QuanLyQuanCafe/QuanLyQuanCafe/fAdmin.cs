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
    public partial class fAdmin : Form
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }

        public fAdmin()
        {
            ConnStr = Properties.Settings.Default.CafeConnectionString;
            Conn = new SqlConnection(ConnStr);
            InitializeComponent();

            LoadDateTimePicker();
            LoadHoaDon(dtpkNgayDau.Value, dtpkNgayCuoi.Value);

            
            LoadDanhMuc();
            LoadDoAn((int)cboDanhMuc.SelectedValue);
            LoadBanAn();
            LoadTaiKhoan();
        }

        #region Doanh Thu
        public void LoadDateTimePicker()
        {
            dtpkNgayDau.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpkNgayCuoi.Value = dtpkNgayDau.Value.AddMonths(1).AddDays(-1);
        }

        public void LoadHoaDon(DateTime ngayDau, DateTime ngayCuoi)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu hoá đơn theo thời gian
            SqlCommand cmdGetHoaDon = new SqlCommand("SP_GetHoaDon", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetHoaDon.Parameters.AddWithValue("@NgayDau", ngayDau);
            cmdGetHoaDon.Parameters.AddWithValue("@NgayCuoi", ngayCuoi);

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetHoaDon.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvDoanhThu.DataSource = dt;

            // Tính doanh thu
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            txtDoanhThu.Text = TinhDoanhThu().ToString("c", culture);

            Conn.Close();
        }

        public int TinhDoanhThu()
        {
            int doanhThu = 0;

            foreach (DataGridViewRow row in dtgvDoanhThu.Rows)
            {
                int tongTien = Convert.ToInt32(row.Cells[6].Value);
                doanhThu += tongTien;
            }

            return doanhThu;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadHoaDon(dtpkNgayDau.Value, dtpkNgayCuoi.Value);
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int hoaDonID = Convert.ToInt32(txtHoaDonID.Text);

                // Mở kết nối đến CSDL
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }

                // Lấy dữ liệu hoá đơn theo thời gian
                SqlCommand cmdGetHoaDon = new SqlCommand("SP_SearchHoaDon", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdGetHoaDon.Parameters.AddWithValue("@HoaDonID", hoaDonID);

                // Lưu dữ liệu vào DataTable
                DataTable dt = new DataTable();
                dt.Load(cmdGetHoaDon.ExecuteReader());

                // Gắn dữ liệu lên DataGridView
                dtgvDoanhThu.DataSource = dt;

                Conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("ID không hợp lệ!", "Lỗi ID hoá đơn");
            }
        }
        #endregion

        #region Đồ ăn
        public void LoadDoAn(int danhMucID)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Đồ Ăn
            SqlCommand cmdGetDoAn = new SqlCommand("SP_GetDoAn", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetDoAn.Parameters.AddWithValue("@DanhMucID", danhMucID);

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetDoAn.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvDoAn.DataSource = dt;

            // Binding Đồ Ăn
            //AddDoAnBinding();

            Conn.Close();
        }

        public void AddDoAnBinding()
        {
            txtDoAnID.DataBindings.Clear();
            txtDoAnID.DataBindings.Add(new Binding("Text", dtgvDoAn.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenDoAn.DataBindings.Clear();
            txtTenDoAn.DataBindings.Add(new Binding("Text", dtgvDoAn.DataSource, "TenDoAn", true, DataSourceUpdateMode.Never));
            nudGia.DataBindings.Clear();
            nudGia.DataBindings.Add(new Binding("Value", dtgvDoAn.DataSource, "Gia", true, DataSourceUpdateMode.Never));
            cboDanhMuc.DataBindings.Clear();
            cboDanhMuc.DataBindings.Add(new Binding("SelectedValue", dtgvDoAn.DataSource, "DanhMucID", true, DataSourceUpdateMode.Never));
        }

        private void btnThemDoAn_Click(object sender, EventArgs e)
        {
            txtDoAnID.Text = "";
            txtTenDoAn.Text = "";
            nudGia.Value = nudGia.Minimum;
        }

        private void btnXoaDoAn_Click(object sender, EventArgs e)
        {
            if (txtDoAnID.Text != "")
            {
                if (MessageBox.Show("Xoá " + txtTenDoAn.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int doAnID = Convert.ToInt32(txtDoAnID.Text);

                    // Mở kết nối đến CSDL
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }

                    SqlCommand cmdDeleteDoAn = new SqlCommand("SP_DeleteDoAn", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdDeleteDoAn.Parameters.AddWithValue("@DoAnID", doAnID);
                    cmdDeleteDoAn.ExecuteNonQuery();    // Rằng buộc khoá ngoại

                    LoadDoAn((int)cboDanhMuc.SelectedValue);
                }
            }
        }

        private void btnLuuDoAn_Click(object sender, EventArgs e)
        {
            string tenDoAn = txtTenDoAn.Text;
            int gia = (int)nudGia.Value;
            int danhMucID = (int)cboDanhMuc.SelectedValue;

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Trường hợp thêm mới Đồ Ăn
            if (txtDoAnID.Text == "")
            {
                if (tenDoAn != "")
                {
                    SqlCommand cmdInsertDoAn = new SqlCommand("SP_InsertDoAn", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdInsertDoAn.Parameters.AddWithValue("@TenDoAn", tenDoAn);
                    cmdInsertDoAn.Parameters.AddWithValue("@Gia", gia);
                    cmdInsertDoAn.Parameters.AddWithValue("@DanhMucID", danhMucID);
                    cmdInsertDoAn.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm " + tenDoAn + "!", "Thông báo");

                    LoadDoAn((int)cboDanhMuc.SelectedValue);
                }
            }
            // Trường hợp sửa thông tin Đồ Ăn
            else
            {
                int doAnID = Convert.ToInt32(txtDoAnID.Text);

                SqlCommand cmdUpdateDoAn = new SqlCommand("SP_UpdateDoAn", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdUpdateDoAn.Parameters.AddWithValue("@DoAnID", doAnID);
                cmdUpdateDoAn.Parameters.AddWithValue("@TenDoAn", tenDoAn);
                cmdUpdateDoAn.Parameters.AddWithValue("@Gia", gia);
                cmdUpdateDoAn.Parameters.AddWithValue("@DanhMucID", danhMucID);
                cmdUpdateDoAn.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");

                LoadDoAn((int)cboDanhMuc.SelectedValue);
            }

            Conn.Close();

        }

        private void btnHuyDoAn_Click(object sender, EventArgs e)
        {
            txtDoAnID.Text = "";
            txtTenDoAn.Text = "";
            nudGia.Value = nudGia.Minimum;
        }

        private void btnTimKiemDoAn_Click(object sender, EventArgs e)
        {
            string tenDoAn = txtTimKiemDoAn.Text;

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Đồ Ăn theo tên
            string query = "SELECT * FROM [DoAn] WHERE TenDoAn LIKE N'%" + tenDoAn + "%'";
            SqlCommand cmdGetDoAn = new SqlCommand(query, Conn);

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetDoAn.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvDoAn.DataSource = dt;

            Conn.Close();
        }

        private void dtgvDoAn_DoubleClick(object sender, EventArgs e)
        {
            AddDoAnBinding();
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoAn((int)(cboDanhMuc.SelectedValue));
        }
        #endregion

        #region Danh Mục
        public void LoadDanhMuc()
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Danh Mục
            SqlCommand cmdGetDanhMuc = new SqlCommand("SP_GetAllDanhMuc", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetDanhMuc.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvDanhMuc.DataSource = dt;

            // Gắn dữ liệu lên Combobox Danh Mục
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.DataSource = dt;

            // Binding Danh Mục
            AddDanhMucBinding();

            Conn.Close();
        }

        public void AddDanhMucBinding()
        {
            txtDanhMucID.DataBindings.Clear();
            txtDanhMucID.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dtgvDanhMuc.DataSource, "TenDanhMuc", true, DataSourceUpdateMode.Never));
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            txtDanhMucID.Text = "";
            txtTenDanhMuc.Text = "";
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (txtDanhMucID.Text != "")
            {
                if (MessageBox.Show("Xoá " + txtTenDanhMuc.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int danhMucID = Convert.ToInt32(txtDanhMucID.Text);

                    // Mở kết nối đến CSDL
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }

                    SqlCommand cmdDeleteDanhMuc = new SqlCommand("SP_DeleteDanhMuc", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdDeleteDanhMuc.Parameters.AddWithValue("@DanhMucID", danhMucID);
                    cmdDeleteDanhMuc.ExecuteNonQuery();    // Rằng buộc khoá ngoại

                    LoadDanhMuc();

                    Conn.Close();
                }
            }
        }

        private void btnLuuDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txtTenDanhMuc.Text;

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Trường hợp thêm mới Danh Mục
            if (txtDanhMucID.Text == "")
            {
                if (tenDanhMuc != "")
                {
                    SqlCommand cmdInsertDanhMuc = new SqlCommand("SP_InsertDanhMuc", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdInsertDanhMuc.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                    cmdInsertDanhMuc.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm " + tenDanhMuc + "!", "Thông báo");

                    LoadDanhMuc();
                }
            }
            // Trường hợp sửa thông tin Danh Mục
            else
            {
                int danhMucID = Convert.ToInt32(txtDanhMucID.Text);

                SqlCommand cmdUpdateDanhMuc = new SqlCommand("SP_UpdateDanhMuc", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdUpdateDanhMuc.Parameters.AddWithValue("@DanhMucID", danhMucID);
                cmdUpdateDanhMuc.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                cmdUpdateDanhMuc.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");

                LoadDanhMuc();
            }

            Conn.Close();
        }

        private void btnHuyDanhMuc_Click(object sender, EventArgs e)
        {
            txtDanhMucID.Text = "";
            txtTenDanhMuc.Text = "";
        }
        #endregion

        #region Bàn Ăn
        public void LoadBanAn()
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Bàn Ăn
            SqlCommand cmdGetBanAn = new SqlCommand("SP_GetAllBan", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetBanAn.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvBanAn.DataSource = dt;

            // Binding Bàn Ăn
            AddBanAnBinding();

            Conn.Close();
        }

        public void AddBanAnBinding()
        {
            txtBanAnID.DataBindings.Clear();
            txtBanAnID.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TenBan", true, DataSourceUpdateMode.Never));
            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            txtBanAnID.Text = "";
            txtTenBan.Text = "";
            txtTrangThai.Text = "";
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (txtBanAnID.Text != "")
            {
                if (MessageBox.Show("Xoá " + txtTenBan.Text + "?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int banAnID = Convert.ToInt32(txtBanAnID.Text);

                    // Mở kết nối đến CSDL
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }

                    SqlCommand cmdDeleteBanAn = new SqlCommand("SP_DeleteBanAn", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdDeleteBanAn.Parameters.AddWithValue("@BanAnID", banAnID);
                    cmdDeleteBanAn.ExecuteNonQuery();    // Rằng buộc khoá ngoại

                    LoadBanAn();

                    Conn.Close();
                }
            }
        }

        private void btnLuuBan_Click(object sender, EventArgs e)
        {
            string tenBan = txtTenBan.Text;

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Trường hợp thêm mới Bàn Ăn
            if (txtBanAnID.Text == "")
            {
                if (tenBan != "")
                {
                    SqlCommand cmdInsertBanAn = new SqlCommand("SP_InsertBanAn", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdInsertBanAn.Parameters.AddWithValue("@TenBan", tenBan);
                    cmdInsertBanAn.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm " + tenBan + "!", "Thông báo");

                    LoadBanAn();
                }
            }
            // Trường hợp sửa thông tin Bàn Ăn
            else
            {
                int banAnID = Convert.ToInt32(txtBanAnID.Text);

                SqlCommand cmdUpdateBanAn = new SqlCommand("SP_UpdateBanAn", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdUpdateBanAn.Parameters.AddWithValue("@BanAnID", banAnID);
                cmdUpdateBanAn.Parameters.AddWithValue("@TenBan", tenBan);
                cmdUpdateBanAn.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");

                LoadBanAn();
            }

            Conn.Close();
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            txtBanAnID.Text = "";
            txtTenBan.Text = "";
            txtTrangThai.Text = "";
        }
        #endregion

        #region Tài Khoản
        public void LoadTaiKhoan()
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Danh Mục
            SqlCommand cmdGetTaiKhoan = new SqlCommand("SP_GetTaiKhoan", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetTaiKhoan.ExecuteReader());

            // Gắn dữ liệu lên DataGridView
            dtgvTaiKhoan.DataSource = dt;

            // Bingding Tài Khoản
            AddTaiKhoanBinding();
        }

        public void AddTaiKhoanBinding()
        {
            txtTenTaiKhoan.DataBindings.Clear();
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TenTaiKhoan"));
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MatKhau"));
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

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
    public partial class fQuanLyBan : Form
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public fQuanLyBan(string tenTaiKhoan, string matKhau, int loai)
        {
            ConnStr = Properties.Settings.Default.CafeConnectionString;
            Conn = new SqlConnection(ConnStr);
            InitializeComponent();

            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;

            if (loai==1)
            {
                adminToolStripMenuItem.Enabled = true;
            }

            LoadBan();
            LoadDanhMuc();
            LoadDoAn((int)(cboDanhMuc.SelectedValue));
            LoadBanChuyen();
        }

        public void LoadBan()
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Bàn
            SqlCommand cmdGetBan = new SqlCommand("SP_GetAllBan", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetBan.ExecuteReader());

            // Load Bàn lên Form
            foreach (DataRow row in dt.Rows)
            {
                Ban ban = new Ban(row);
                Button btnBan = new Button
                {
                    Height = 90,
                    Width = 90
                };

                if (ban.TrangThai == "Trống")
                {
                    btnBan.BackColor = Color.Aqua;
                }
                else
                {
                    btnBan.BackColor = Color.Chocolate;
                }
                btnBan.Text = ban.TenBan + Environment.NewLine + ban.TrangThai;
                btnBan.Click += btnBan_Click;

                // Lưu dữ liệu đối tượng Bàn vào Button Bàn
                btnBan.Tag = ban;

                flpnlBan.Controls.Add(btnBan);
            }

            Conn.Close();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            btnThemMon.Enabled = true;

            Button btn = (Button)sender;
            Ban ban = (Ban)btn.Tag;

            // Gán thông tin Bàn lên Textbox
            txtBanID.Text = ban.ID.ToString();
            txtTenBan.Text = ban.TenBan;
            txtTrangThai.Text = ban.TrangThai;
            if (ban.TrangThai == "Trống")
            {
                btnChuyenBan.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            else
            {
                btnChuyenBan.Enabled = true;
                btnThanhToan.Enabled = true;
            }

            // Show Hoá Đơn
            ShowHoaDon(GetHoaDonID(ban.ID));
        }

        public void ShowHoaDon(int hoaDonID)
        {
            lvwHoaDon.Items.Clear();

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy dữ liệu Hoá Đơn theo ID
            SqlCommand cmdGetHoaDon = new SqlCommand("SP_GetThongTinHoaDon", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetHoaDon.Parameters.AddWithValue("@HoaDonID", hoaDonID);

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetHoaDon.ExecuteReader());

            // Show hoá đơn lên ListView Hoá Đơn
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem lviTenMon = new ListViewItem(row["TenDoAn"].ToString());
                lviTenMon.SubItems.Add(row["SoLuong"].ToString());
                lviTenMon.SubItems.Add(row["Gia"].ToString());
                lviTenMon.SubItems.Add(row["ThanhTien"].ToString());

                lvwHoaDon.Items.Add(lviTenMon);
            }

            // Tính Tiền Bàn
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            txtTienBan.Text = TinhTienBan().ToString("c", culture);

            Conn.Close();
        }

        public int TinhTienBan()
        {
            int tienBan = 0;
            foreach (ListViewItem item in lvwHoaDon.Items)
            {
                // Tiền Bàn += Thành tiền
                tienBan += Convert.ToInt32(item.SubItems[3].Text);
            }

            return tienBan;
        }

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

            // Gắn dữ liệu lên Combobox Danh Mục
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.DataSource = dt;

            Conn.Close();
        }

        public void LoadDoAn(int danhMucID)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy Đồ Ăn theo ID Danh Mục
            SqlCommand cmdGetDoAn = new SqlCommand("SP_GetDoAn", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetDoAn.Parameters.AddWithValue("@DanhMucID", danhMucID);

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetDoAn.ExecuteReader());

            // Gắn dữ liệu lên Combobox Đồ Ăn
            cboDoAn.ValueMember = "ID";
            cboDoAn.DisplayMember = "TenDoAn";
            cboDoAn.DataSource = dt;

            Conn.Close();
        }

        public void LoadBanChuyen()
        {
            // Mở kế nối đến CSDL
            SqlConnection Conn = new SqlConnection(ConnStr);
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy Bàn trống
            SqlCommand cmdGetBanTrong = new SqlCommand("SP_GetBanTrong", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Lưu dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(cmdGetBanTrong.ExecuteReader());

            // Gắn dữ liệu lên Combobox Bàn Chuyển
            cboBanChuyen.ValueMember = "ID";
            cboBanChuyen.DisplayMember = "TenBan";
            cboBanChuyen.DataSource = dt;
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoAn((int)(cboDanhMuc.SelectedValue));
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            int banID = Convert.ToInt32(txtBanID.Text);
            int doAnID = Convert.ToInt32(cboDoAn.SelectedValue);
            int soLuong = (int)nudSoLuong.Value;
            int hoaDonID = GetHoaDonID(banID);

            // Trường hợp Bàn trống
            if (hoaDonID == -1)
            {
                // Thêm Hoá Đơn
                ThemHoaDon(banID);

                // Cập nhật trạng thái Bàn
                flpnlBan.Controls.Clear();
                LoadBan();
                LoadBanChuyen();

                btnChuyenBan.Enabled = true;
                btnThanhToan.Enabled = true;

                // Lấy ID Hoá Đơn mới
                hoaDonID = GetHoaDonID(banID);
            }
            
            ThemChiTietHoaDon(hoaDonID, doAnID, soLuong);

            // Show Hoá Đơn lên ListView
            ShowHoaDon(hoaDonID);
        }

        public int GetHoaDonID(int banID)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Lấy ID Hoá Đơn theo Bàn
            SqlCommand cmdGetHoaDon = new SqlCommand("SP_GetHoaDonID", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdGetHoaDon.Parameters.AddWithValue("@BanID", banID);
            SqlParameter hoaDonID = cmdGetHoaDon.Parameters.Add("@HoaDonID", SqlDbType.Int);
            hoaDonID.Direction = ParameterDirection.ReturnValue;
            cmdGetHoaDon.ExecuteNonQuery();

            Conn.Close();

            return (int)hoaDonID.Value;
        }

        public void ThemHoaDon(int banID)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Thêm Hoá Đơn
            SqlCommand cmdInsertHoaDon = new SqlCommand("SP_InsertHoaDon", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdInsertHoaDon.Parameters.AddWithValue("@BanID", banID);
            cmdInsertHoaDon.ExecuteNonQuery();

            Conn.Close();
        }

        public void ThemChiTietHoaDon(int hoaDonID, int doAnID, int soLuong)
        {
            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Thêm Chi Tiết Hoá Đơn
            SqlCommand cmd = new SqlCommand("SP_InsertChiTietHoaDon", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
            cmd.Parameters.AddWithValue("@DoAnID", doAnID);
            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int banID = Convert.ToInt32(txtBanID.Text);
            int hoaDonID = GetHoaDonID(banID);
            int banChuyenID = (int)cboBanChuyen.SelectedValue;
            string tenBanChuyen = cboBanChuyen.GetItemText(cboBanChuyen.SelectedItem);

            // Mở kết nối đến CSDL
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }

            // Cập nhật Bàn
            SqlCommand cmdUpdateBanChuyen = new SqlCommand("SP_UpdateBanChuyen", Conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmdUpdateBanChuyen.Parameters.AddWithValue("@HoaDonID", hoaDonID);
            cmdUpdateBanChuyen.Parameters.AddWithValue("@BanID", banID);
            cmdUpdateBanChuyen.Parameters.AddWithValue("@BanChuyenID", banChuyenID);
            cmdUpdateBanChuyen.ExecuteNonQuery();

            // Cập nhật thông tin Bàn trên Form
            txtBanID.Text = banChuyenID.ToString();
            txtTenBan.Text = tenBanChuyen;
            flpnlBan.Controls.Clear();
            LoadBan();
            LoadBanChuyen();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int khuyenMai = (int)nudGiamGia.Value;
            int tienBan = TinhTienBan();
            int tienKhuyenMai = tienBan * khuyenMai / 100;
            int tongTien = tienBan - tienKhuyenMai;

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            string message = "Thanh toán hoá đơn cho " + txtTenBan.Text + "?" + Environment.NewLine;
            message += "Khuyến mãi: " + tienKhuyenMai + " (" + khuyenMai + "%)" + Environment.NewLine;
            message += "Tổng tiền = " + tienBan + " - " + tienKhuyenMai + " = " + tongTien.ToString("c", culture);

            if (MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int banID = Convert.ToInt32(txtBanID.Text);
                int hoaDonID = GetHoaDonID(banID);

                // Mở kết nối đến CSDL
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }

                // Cập nhật Hoá Đơn
                SqlCommand cmdUpdateHoaDon = new SqlCommand("SP_UpdateHoaDon", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdUpdateHoaDon.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmdUpdateHoaDon.Parameters.AddWithValue("@KhuyenMai", khuyenMai);
                cmdUpdateHoaDon.ExecuteNonQuery();
                lvwHoaDon.Items.Clear();

                // Cập nhật trạng thái Bàn
                flpnlBan.Controls.Clear();
                LoadBan();
                LoadBanChuyen();

                nudSoLuong.Value = nudSoLuong.Minimum;
                txtBanID.ResetText();
                txtTenBan.ResetText();
                txtTrangThai.ResetText();
                nudGiamGia.Value = nudGiamGia.Minimum;
                txtTienBan.Text = "0,00 ₫";

                btnThemMon.Enabled = false;
                btnChuyenBan.Enabled = false;
                btnThanhToan.Enabled = false;

                Conn.Close();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan fThongTinTaiKhoan = new fThongTinTaiKhoan(TenTaiKhoan,MatKhau);
            fThongTinTaiKhoan.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

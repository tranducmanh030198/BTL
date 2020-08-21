using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public class Ban
    {
        public int ID { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }

        public Ban(int iD, string tenBan, string trangThai)
        {
            ID = iD;
            TenBan = tenBan;
            TrangThai = trangThai;
        }

        public Ban(DataRow row)
        {
            ID = (int)row["ID"];
            TenBan = row["TenBan"].ToString();
            TrangThai = row["TrangThai"].ToString();
        }
    }
}

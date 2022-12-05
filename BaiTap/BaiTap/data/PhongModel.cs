using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.data
{
    public class PhongModel
    {
        public string MaPhong { get; set; }
        public int SoGiuong { get; set; }
        public decimal DonGia { get; set; }
        public string TinhTrang { get; set; }
    }
    public class PhieuModel
    {
        public int Id { get; set; }
        public string MaPhieu { get; set; }
        public string UserName { get; set; }
        public int Total { get; set; }
        public string Note { get; set; }
        public DateTime? NgayNhap { get; set; }
    }
    public class CmbTinhTrang
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }
    public class CmbMaPhongSearch
    {
        public string MaPhongName { get; set; }
        public string MaPhongText { get; set; }
    }
}

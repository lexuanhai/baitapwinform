using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.data
{
    public class OrderImportDetailModel
    {
        public int Id { get; set; }
        public string MaPhieu { get; set; }
        public int OrderImportId { get; set; }
        public int ProductId { get; set; }
        public string MaSanPham { get; set; }
        public int Total { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
        public DateTime? NgayNhap { get; set; }
    }
    public class OrderImportDetailExportModel
    {
        public string Name { get; set; }
        public PhieuModel PhieuNhap { get; set; } 
        public List<ProductModel> Products { get; set; }
    }


}

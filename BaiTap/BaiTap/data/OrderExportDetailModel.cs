using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.data
{
    public class OrderExportDetailModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AgentName { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public int OrderExportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
  
}

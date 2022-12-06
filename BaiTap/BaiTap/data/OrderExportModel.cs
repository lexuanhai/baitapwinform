using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.data
{
    public class OrderExportModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public string AgentName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Total { get; set; }
        public string TypePayment { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }       
    }
  
}

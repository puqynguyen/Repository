using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SalesInvoice
    {
        public int SalesInvoiceId { get; set; }  // Khóa chính
        public DateTime DateOfSale { get; set; } // Ngày bán
        public decimal TotalAmount { get; set; } // Tổng tiền

        // Khóa ngoại liên kết với khách hàng
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Khóa ngoại liên kết với xe
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}

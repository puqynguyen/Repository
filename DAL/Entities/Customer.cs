using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }  // Khóa chính
        public string Name { get; set; }      // Tên khách hàng
        public string PhoneNumber { get; set; }  // Số điện thoại
        public string Email { get; set; }        // Email
        public string Address { get; set; }      // Địa chỉ

        // Quan hệ: Mỗi khách hàng có thể có nhiều hóa đơn bán hàng
        public ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}

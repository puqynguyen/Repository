using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Car
    {
        public int CarId { get; set; }      // Khóa chính
        public string Brand { get; set; }   // Hãng xe
        public string Model { get; set; }   // Model xe
        public int Year { get; set; }       // Năm sản xuất
        public decimal Price { get; set; }  // Giá bán

        // Quan hệ: Một xe có thể liên kết với nhiều hóa đơn bán hàng
        public ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}

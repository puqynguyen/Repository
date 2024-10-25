using System.Collections.Generic;
using System.Data.Entity; // Thêm namespace cho Entity Framework
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class CarStoreContext : DbContext
    {
        // Bảng khách hàng
        public DbSet<Customer> Customers { get; set; }

        // Bảng xe
        public DbSet<Car> Cars { get; set; }

        // Bảng hóa đơn bán hàng
        public DbSet<SalesInvoice> SalesInvoices { get; set; }

        // Constructor chỉ định chuỗi kết nối
        public CarStoreContext() : base("name=CarStoreContext")
        {
        }

        // Tùy chỉnh mô hình cơ sở dữ liệu nếu cần
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Loại bỏ các quy ước đặt tên mặc định của Entity Framework (ví dụ như số nhiều hóa tên bảng)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();x
        }
    }
}

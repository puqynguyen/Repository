using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    internal class CustomerDAL
    {
        private readonly IGenericRepository<Customer> _repository;

        public CustomerDAL(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }

        // Lấy danh sách tất cả khách hàng
        public IEnumerable<Customer> GetCustomers()
        {
            return _repository.GetAll();
        }

        // Lấy một khách hàng theo ID
        public Customer GetCustomerById(int customerId)
        {
            return _repository.GetById(customerId);
        }

        // Thêm khách hàng mới
        public void AddCustomer(Customer customer)
        {
            _repository.Add(customer);
        }

        // Sửa thông tin khách hàng
        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }

        // Xóa khách hàng
        public void DeleteCustomer(int customerId)
        {
            _repository.Delete(_repository.GetById(customerId));
        }
    }
}

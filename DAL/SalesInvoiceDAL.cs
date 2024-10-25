using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class SalesInvoiceDAL
    {
        private readonly IGenericRepository<SalesInvoice> _repository;

        public SalesInvoiceDAL(IGenericRepository<SalesInvoice> repository)
        {
            _repository = repository;
        }

        // Lấy danh sách tất cả hóa đơn
        public IEnumerable<SalesInvoice> GetSalesInvoices()
        {
            return _repository.GetAll();
        }

        // Lấy một hóa đơn theo ID
        public SalesInvoice GetSalesInvoiceById(int invoiceId)
        {
            return _repository.GetById(invoiceId);
        }

        // Thêm hóa đơn bán hàng
        public void AddSalesInvoice(SalesInvoice invoice)
        {
            _repository.Add(invoice);
        }

        // Sửa thông tin hóa đơn
        public void UpdateSalesInvoice(SalesInvoice invoice)
        {
            _repository.Update(invoice);
        }

        // Xóa hóa đơn bán hàng
        public void DeleteSalesInvoice(int invoiceId)
        {
            _repository.Delete(GetSalesInvoiceById(invoiceId));
        }
    }
}


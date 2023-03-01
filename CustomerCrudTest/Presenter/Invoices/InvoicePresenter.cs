using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Model.Repository.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Presenter.Invoices
{
    public class InvoicePresenter
    {
        private readonly IInvoiceView _view;
        private readonly IInvoiceRepository _repository;

        public InvoicePresenter(IInvoiceView view, IInvoiceRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;
        }

        public void Save(Invoice oInvoice)
        {
            _repository.Save(oInvoice);
        }

        public void Remove(int invoiceId)
        {

            var oInvoice = _repository.GetById(invoiceId);

            _repository.Remove(oInvoice);
        }

        public List<Invoice> GetAll()
        {
            var invoiceList = (List<Invoice>)_repository.Get();

            return invoiceList;
        }
        public Invoice GetById(int id)
        {
            var invoice = (Invoice)_repository.GetById(id);

            return invoice;
        }

        public List<Customers> GetCustomer()
        {
            var customerLis = (List<Customers>)_repository.GetCustomers();

            return customerLis;
        }
        public List<InvoiceDetail> GetDetails(int id)
        {
            var invoiceDetail = (List<InvoiceDetail>)_repository.GetDetails(id);

            return invoiceDetail;
        }
    }
}

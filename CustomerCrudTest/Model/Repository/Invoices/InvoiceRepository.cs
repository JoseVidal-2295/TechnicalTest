using CustomerCrudTest.Model.Context;
using CustomerCrudTest.Model.Core;
using CustomerCrudTest.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Repository.Invoices
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        readonly CustomerContext context_;
        public InvoiceRepository(CustomerContext context) : base(context)
        {
            context_ = context;
        }

        public IEnumerable<Customers> GetCustomers()
        {
            try
            {
                return context_.Customers.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public IEnumerable<InvoiceDetail> GetDetails(int id)
        {
           return context_.InvoiceDetail.Where(detail => detail.InvoiceId == id).ToList();
        }
    }
}

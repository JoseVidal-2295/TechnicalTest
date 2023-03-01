using CustomerCrudTest.Model.Core;
using CustomerCrudTest.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Repository.Invoices
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
       IEnumerable<Customers> GetCustomers();
       IEnumerable<InvoiceDetail> GetDetails(int id);
    }
}

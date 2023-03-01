using CustomerCrudTest.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCrudTest.Model.Entity;

namespace CustomerCrudTest.Model.Repository.Customer
{
    public interface ICustomerRepository : IBaseRepository<Customers>
    {
        IEnumerable<CustomerTypes> GetCustomerType();
    }
}

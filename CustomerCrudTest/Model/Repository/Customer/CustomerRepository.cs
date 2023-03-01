using CustomerCrudTest.Model.Context;
using CustomerCrudTest.Model.Core;
using CustomerCrudTest.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Repository.Customer
{
    public class CustomerRepository : BaseRepository<Customers>, ICustomerRepository
    {
        readonly CustomerContext context_;
        public CustomerRepository(CustomerContext context) : base(context)
        {
            context_ = context;
        }
        
        public IEnumerable<CustomerTypes> GetCustomerType()
        {
            try
            {
                return context_.CustomerTypes.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}

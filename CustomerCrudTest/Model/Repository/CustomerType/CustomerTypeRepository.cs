using CustomerCrudTest.Model.Context;
using CustomerCrudTest.Model.Core;
using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Model.Repository.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Repository.CustomerType
{
    public class CustomerTypeRepository : BaseRepository<CustomerTypes>, ICustomerTypeRepository
    {
        public CustomerTypeRepository(CustomerContext context) : base(context)
        {

        }

        public void  Save(CustomerTypes entity)
        {
             base.Save(entity);
        }
        public void Update(CustomerTypes entity)
        {
             base.Update(entity);
        }

        public void Remove(CustomerTypes entity)
        {
            base.Remove(entity);
        }
    }
}

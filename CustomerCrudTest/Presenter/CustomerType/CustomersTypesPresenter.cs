using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Model.Repository.Customer;
using CustomerCrudTest.Model.Repository.CustomerType;
using CustomerCrudTest.View;
using CustomerCrudTest.View.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Presenter.CustomerType
{
    public class CustomersTypesPresenter
    {
        private readonly ICustomertypesView _view;
        private readonly ICustomerTypeRepository _repository;

        public CustomersTypesPresenter(ICustomertypesView view, ICustomerTypeRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;
            
        }
        public void Save(CustomerTypes oCustomerTypes)
        {
            _repository.Save(oCustomerTypes);
        }

        public void Remove(int customerId)
        {
            var oCustomer = _repository.GetById(customerId);

            _repository.Remove(oCustomer);
        }
        public void Update(CustomerTypes oCustomerTypes)
        {

            var updateData =  _repository.GetById(oCustomerTypes.Id);
            updateData.Description = oCustomerTypes.Description;
            
             _repository.Update(updateData);
        }

        public List<CustomerTypes> GetAll()
        {
            var customerLis = (List<CustomerTypes>) _repository.Get();

            return customerLis;
        }

        public CustomerTypes GetById(int id)
        {
            var customer = (CustomerTypes) _repository.GetById(id);

            return customer;
        }
    }
}

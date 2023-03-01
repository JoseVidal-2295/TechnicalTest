using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Model.Repository.Customer;
using CustomerCrudTest.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Presenter.Customer
{



    public class CustomerPresenter
    {
        private readonly ICustomerView _view;
        private readonly ICustomerRepository _repository;

        public CustomerPresenter(ICustomerView view,ICustomerRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;
        }
        
        public void SaveCustomer(Customers oCustomers)
        {
            _repository.Save(oCustomers);
        }

        public  void RemoveCustomer(int customerId)
        {

            var oCustomer =  _repository.GetById(customerId);

            _repository.Remove(oCustomer);
        }
        public void UpdateCustomer(Customers oCustomers)
        {

            var oCustomer =  _repository.GetById(oCustomers.Id);
            oCustomer.CustName = oCustomers.CustName;
            oCustomer.CustomerTypeId = oCustomers.CustomerTypeId;
            oCustomer.Adress = oCustomers.Adress;
            oCustomer.Status = oCustomers.Status;
            _repository.Update(oCustomer);
        }

        public List<Customers> GetAll()
        {
            var customerLis = (List<Customers>) _repository.Get();

            return customerLis;
        }
        public Customers GetById(int id)
        {
            var customer = (Customers)_repository.GetById(id);

            return customer;
        }

        public List<CustomerTypes> GetCustomerType()
        {
            var customerLis = (List<CustomerTypes>) _repository.GetCustomerType();

            return customerLis;
        }
    }
}

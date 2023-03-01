using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Presenter;
using CustomerCrudTest.Presenter.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Presenter.Customer
{
  public interface ICustomerView
    {
      
        CustomerPresenter Presenter {set; }
    }
}

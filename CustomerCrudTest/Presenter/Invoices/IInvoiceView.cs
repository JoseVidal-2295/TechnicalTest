using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Presenter.Invoices
{
    public interface IInvoiceView
    {
        InvoicePresenter Presenter { set; }
    }
}

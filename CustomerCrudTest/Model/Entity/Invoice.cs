using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Entity
{
    [Table("Invoice")]
    public class Invoice
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public decimal TotalItbis { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Total { get; set; }

        public List<InvoiceDetail>? InvoiceDetail { get; set; }
    }
}

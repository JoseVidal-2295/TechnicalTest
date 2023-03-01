using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Entity
{
    [Table("InvoiceDetail")]
    public class InvoiceDetail
    {
        public int Id { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal TotalItbis { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Total { get; set; }

        public string? ItemId { get; set; }
        public int InvoiceId { get; set; }

        public Invoice? Invoice { get; set; }
    }
}

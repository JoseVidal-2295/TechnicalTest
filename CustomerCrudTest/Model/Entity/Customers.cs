using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Entity
{
    [Table("Customers")]
    public class Customers
    {
        public int Id { get; set; }

        public string CustName { get; set; }

        public string Adress { get; set; }

        public Boolean Status { get; set; }

        public int CustomerTypeId { get; set; }

        [ForeignKey("CustomerTypeId")]
        public CustomerTypes CustomerType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Entity
{
    [Table("CustomerTypes")]
    public class CustomerTypes
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Customers> Customers { get; set; }
    }
}

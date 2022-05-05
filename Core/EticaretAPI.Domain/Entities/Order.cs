using EticaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Domain.Entities
{
    public class Order:BaseEntitiy
    {
        public Guid custumerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> products { get; set; }
        public Customer Customer { get; set; } 
    }
}

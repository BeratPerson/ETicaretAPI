using EticaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Domain.Entities
{
    public class Product:BaseEntitiy
    {
        public string Name { get; set; }
        public int stock { get; set; }
        public double Price { get; set; }
        public ICollection<Order> orders { get; set; }

    }
}

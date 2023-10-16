using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Entities
{
    public class Product
    {
        public Product( string title)
        {
            Id = Guid.NewGuid();
            Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

    }
}

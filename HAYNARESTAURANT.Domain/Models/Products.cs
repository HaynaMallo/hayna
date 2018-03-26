using HAYNARESTAURANT.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYNARESTAURANT.Domain.Models
{
    public class Products : BaseModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid? CategoryId { get; set; }
    }
}

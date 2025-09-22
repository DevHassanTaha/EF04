
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02_Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}

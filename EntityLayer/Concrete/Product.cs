using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(30)]
        public string ProductName { get; set; }
        public int Stock;
        public String Details { get; set; }


        public int? CategoryId { get; set; }
        public  Category Category { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

    }
}

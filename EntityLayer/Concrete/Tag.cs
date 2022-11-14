﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        [StringLength(30)]
        public string TagName { get; set; }

        public  ICollection<Product> Products { get; set; }



    }
}

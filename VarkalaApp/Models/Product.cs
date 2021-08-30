using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarkalaApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ProdcutTitle { get; set; }
        public decimal ProductPrice { get; set; }
    }
}

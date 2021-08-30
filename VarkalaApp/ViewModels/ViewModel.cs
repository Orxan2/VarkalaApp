using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarkalaApp.Models;

namespace VarkalaApp.ViewModels
{
    public class ViewModel
    {
        public List<Slider> Sliders { get; set; }
        
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarkalaApp.Models;

namespace VarkalaApp.DAL
{
    public class VarkalaContext:DbContext
    {
        public VarkalaContext(DbContextOptions<VarkalaContext> options) :base(options)
        {
        }

       public DbSet<Slider> Sliders { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}

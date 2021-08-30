using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarkalaApp.DAL;
using VarkalaApp.Models;
using VarkalaApp.ViewModels;

namespace VarkalaApp.Controllers
{
    public class HomeController : Controller
    {
        public VarkalaContext _context { get; }
        public HomeController(VarkalaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewModel VM = new ViewModel
            {
                Sliders =await _context.Sliders.ToListAsync(),
                Products = await _context.Products.ToListAsync()
            };
            return View(VM);
        }
    }
}

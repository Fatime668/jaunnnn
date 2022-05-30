using Juan.DAL;
using Juan.Models;
using Juan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Carts = await _context.Carts.ToListAsync(),
                Products = await _context.Products.ToListAsync()
              

            };
            return View(model);
        }
    }
}

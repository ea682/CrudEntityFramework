using CrudEntityFramework.Data;
using CrudEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _contex;

        public HomeController(ApplicationDbContext context)
        {
            _contex = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _contex.Usuario.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

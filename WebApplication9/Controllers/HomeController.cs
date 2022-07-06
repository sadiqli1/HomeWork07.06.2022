using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.DAL;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }
        public IActionResult ServiceDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                Service service = _context.Services.FirstOrDefault(s => s.Id == id);
                return View(service);
            }
        }
    }
}

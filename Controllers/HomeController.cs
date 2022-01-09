using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_Projects.DAL;
using MVC_Projects.Models;
using MVC_Projects.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Projects.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ImagesProducts> imagesProducts = _context.images.ToList();

            HomeVM home = new HomeVM();
            home.images = imagesProducts;
            return View(home);
        }
    }
}

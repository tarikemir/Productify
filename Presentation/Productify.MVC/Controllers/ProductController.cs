using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;
using Productify.Persistence.Contexts;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductifyDbContext _context;

        public ProductController()
        {
            _context = new();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return View(_context.Products.ToList());
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string productName)
        {
            _context.Products.Add(new Product(productName));
            _context.SaveChanges();
            return View();
        }
        public IActionResult GetProduct()
        {
            return View();
        }
    }
}

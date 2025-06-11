using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Data;

namespace MVC_Task1.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public ViewResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
        public ViewResult Create()
        {
            return View();
        }
        public ViewResult Details(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }
    }
}

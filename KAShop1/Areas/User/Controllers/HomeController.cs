using KAShop1.Data;
using KAShop1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KAShop1.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult IndexProduct()
        {
            var products = context.Products.ToList();
            var productVm = new List<ProductsViewModel>();
            foreach (var item in products)
            {
                var vm = new ProductsViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Image = $"/images/{item.Image}",
                    Price = item.Price
                };
                productVm.Add(vm);

            }
            return View("IndexProduct",productVm);
        }
    }
}

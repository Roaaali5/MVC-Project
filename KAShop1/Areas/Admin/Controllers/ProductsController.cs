using KAShop1.Data;
using KAShop1.Models;
using KAShop1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KAShop1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.Products.Include(p=>p.Category).ToList();
            var productVm = new List<ProductsViewModel>();
            foreach(var item in products)
            {
                var vm = new ProductsViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Image = $"/images/{item.Image}"
                };
                productVm.Add(vm);

            }
            return View(productVm);
        }
        public IActionResult Create()
        {
            ViewBag.category = context.Categories.ToList();
            return View(new Product() { });
        }
        public IActionResult Store(Product request, IFormFile Image)
        {
            if (Image != null && Image.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", fileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);
                }
                request.Image = fileName;
                context.Products.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
                
            }
            return Content("Ok");

        }
    }
}



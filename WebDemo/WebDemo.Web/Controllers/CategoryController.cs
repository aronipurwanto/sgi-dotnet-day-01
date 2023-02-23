using Microsoft.AspNetCore.Mvc;
using WebDemo.Web.Models;

namespace WebDemo.Web.Controllers;

public class CategoryController : Controller
{
    private static List<CategoryModel> _listCategory = new List<CategoryModel>();

    public CategoryController()
    {
        /*
        _listCategory.Add(new CategoryModel(1, "CT001","Food"));
        _listCategory.Add(new CategoryModel(2,"CT002","Drink"));
        _listCategory.Add(new CategoryModel()
        {
            Id = 3,
            Code = "CT003",
            Name = "Fashion"
        });
        */
    }
    
    // GET
    public IActionResult Index()
    {
        return View(_listCategory);
    }

    public IActionResult Detail()
    {
        CategoryModel data = new CategoryModel(1, "CT001", "Food");
        List<ProductModel> products = new List<ProductModel>();
        products.Add(new ProductModel()
        {
            Id = 1,
            Code = "P001",
            Name = "Mie Goreng"
        });
        products.Add(new ProductModel()
        {
            Id = 2,
            Code = "P002",
            Name = "Mie Ayam"
        });

        data.products = products;
        
        return View(data);
    }
    
    // display from
    public IActionResult Add()
    {
        return View();
    }
    
    // yang menerima Data
    [HttpPost]
    public IActionResult Save(CategoryModel categoryModel)
    {
        if (ModelState.IsValid)
        {
            _listCategory.Add(categoryModel);
            return RedirectToAction("Index");
        }

        return View("Add");
    }
}
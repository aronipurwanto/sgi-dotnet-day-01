using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazor.Web.Contexts;
using WebAppRazor.Web.Entities;
using WebAppRazor.Web.Models;

namespace WebAppRazor.Web.Pages.Category;

public class CategoryIndexModel : PageModel
{
    public List<CategoryModel> Categories = new List<CategoryModel>();
    private readonly DemoAppContext _db;

    public CategoryIndexModel(DemoAppContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Categories = _db.Categories
            .Select(ct => new CategoryModel(ct.Id, ct.Code, ct.Name))
            .ToList();
        /*
        Categories.Add(new CategoryModel(1,"CT001","Food"));
        Categories.Add(new CategoryModel(2,"CT002", "Drink"));
        Categories.Add(new CategoryModel(3,"CT003","Fashion"));
        */
    }
}
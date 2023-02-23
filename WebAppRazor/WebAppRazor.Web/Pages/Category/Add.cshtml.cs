using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazor.Web.Contexts;
using WebAppRazor.Web.Entities;
using WebAppRazor.Web.Models;

namespace WebAppRazor.Web.Pages.Category;

public class CategoryAddModel : PageModel
{
    public CategoryModel Category { get; set; }
    private readonly DemoAppContext _db;

    public CategoryAddModel(DemoAppContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPost(CategoryModel Category)
    {
        if (ModelState.IsValid)
        {
            //CategoryEntity entity = new CategoryEntity(model.Code, model.Name);
            // CategoryEntity entity = new CategoryEntity(model);
            // _db.Categories.Add(entity);
            
            _db.Categories.Add(new CategoryEntity(Category));
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        return Page();
    }
}
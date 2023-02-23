using System.ComponentModel.DataAnnotations;

namespace WebDemo.Web.Models;

public class CategoryModel
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Category Code")]
    public String Code { get; set; }
    
    [Required]
    [Display(Name = "Category Name")]
    public String Name { get; set; }
    public List<ProductModel> products { get; set; }

    public CategoryModel()
    {
        
    }
    public CategoryModel(int id, string code, string name)
    {
        Id = id;
        Code = code;
        Name = name;
    }
}
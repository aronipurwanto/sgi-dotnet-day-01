using System.ComponentModel.DataAnnotations;

namespace WebAppRazor.Web.Models;

public class CategoryModel
{
    public int Id { get; set; }
    
    [Required]
    [Display(Name = "Category Code")]
    [MinLength(5)]
    [MaxLength(10)]
    public String Code { get; set; }
    
    [Required]
    [Display(Name = "Category Name")]
    [MinLength(5)]
    [MaxLength(10)]
    public String Name { get; set; }

    public CategoryModel()
    {
    }

    public CategoryModel(int id, string code, string name)
    {
        Id = id;
        Code = code;
        Name = name;
    }

    public CategoryModel(string code, string name)
    {
        Code = code;
        Name = name;
    }
}
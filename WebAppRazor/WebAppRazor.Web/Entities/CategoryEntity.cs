using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppRazor.Web.Models;

namespace WebAppRazor.Web.Entities;

[Table("tbl_category")]
public class CategoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(10)]
    [Column("category_code")]
    public String Code { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(100)]
    [Column("category_name")]
    public String Name { get; set; }

    public CategoryEntity()
    {
    }

    public CategoryEntity(string code, string name)
    {
        Code = code;
        Name = name;
    }

    public CategoryEntity(CategoryModel model)
    {
        Code = model.Code;
        Name = model.Name;
    }
}
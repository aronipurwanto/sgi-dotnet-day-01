namespace WebDemo.Web.Models;

public class ProductModel
{
    public int Id { get; set; }
    public String Code { get; set; }
    public String Name { get; set; }
    private Double Price { get; set; }
    public CategoryModel category { get; set; }
}
using Microsoft.EntityFrameworkCore;
using WebAppRazor.Web.Entities;

namespace WebAppRazor.Web.Contexts;

public class DemoAppContext : DbContext
{
    public DemoAppContext(DbContextOptions<DemoAppContext> options): base(options)
    {
        
    }
    
    public DbSet<CategoryEntity> Categories { get; set; }
}
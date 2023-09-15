using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PetStore.Models;
public class PetStoreContext : DbContext  
{  
    public DbSet<Product> Products { get; set; }  
    public DbSet<CatFood> CatFoods { get; set; }  
    public DbSet<DryCatFood> DryCatFoods { get; set; }  
    public DbSet<CatFood> DogLeashes { get; set; }  

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlite("Data Source=blogging.db"); 
}
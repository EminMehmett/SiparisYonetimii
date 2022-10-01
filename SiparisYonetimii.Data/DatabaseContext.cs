using SiparisYonetimii.Entities;
using System.Data.Entity; // Bu kütüphane Entity Framework paketinden geliyor 

namespace SiparisYonetimii.Data
{
    public class DatabaseContext : DbContext // Burada Entity Framework sınıfından miras alıyoruz DatabaseContext sınıfında dbContext leri kullanabilmek için  
    {
        public DatabaseContext()
        {

        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}

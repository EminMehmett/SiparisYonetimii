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
/*
    Projeyi yaparken classları ve databaseContext i kurduktan sonra veritabanını otomatik oluşturmak yerine migrationla oluşturmamız gerekir çünkü (sonradan veritabanında değişiklik yaptığımızda hata vermesin)
    
    Migration u aktif etmek için PMC yi açıyoruz ve ilk önce Default Project bölmünden databaseContext imizin bulunduğu Data katmanını seçiyoruz 

    Sonra PMC kod alanına enable-migrations yazıp enter a basarak Initialcreate classının oluşturulmasını sağlıyoruz 

    oluşan Configration sınıfının içerisinde başlangıç verisi oluşturabileceğimiz Seed metodu oluşuyor bunu kullanarak veritabanı oluştuktan sonra örnek data oluşturabiliriz

    Eğer enable-migrations dan sonra initialCreate classı oluşmazsa add-migration InitialCreate yazıp enter a basarak kendimiz oluşturabilirz 
 */

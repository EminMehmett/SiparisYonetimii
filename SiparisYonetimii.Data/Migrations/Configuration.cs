namespace SiparisYonetimii.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik migration özelliğini aç
            AutomaticMigrationDataLossAllowed = true; // migration işlemlerinde data kayıplarına izin ver 
        }

        protected override void Seed(DatabaseContext context)
        {
            // Bu metot veritabanı oluşturulduktan sonra çalışır ve tablolara örnek kayıt ekleyebilmemizi sağlar 
            if (!context.Users.Any())
            {
                context.Users.Add(new Entities.User
                {
                    CreateDate = DateTime.Now,
                    Name = "Admin",
                    Email = "admin@SiparisYonetimii.com",
                    Id = 1,
                    IsActive = true,
                    IsAdmin = true,
                    Username = "Admin",
                    Password = "123"
                });
                context.SaveChanges(); // Değişiklikleri veritabanına işle 
            }
        }
    }
}

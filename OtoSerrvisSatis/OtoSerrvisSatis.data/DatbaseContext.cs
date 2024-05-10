using Microsoft.EntityFrameworkCore;
using OtoSerrvisSatis.Entities;
using OtoSerrvisSatis.library;
using System.Data;

namespace OtoSerrvisSatis.data
{
    public class DatabaseContext  : DbContext   //db context sınıfından miras alma
    {
        public DbSet<Arac> Araclar { get; set; } //bir veritabanında Arac adlı bir tabloyu temsil eden ve o tablo ile ilişkilendirilen bir DbSet koleksiyonudur
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@ = (LocalDB)\\MSSQLLocalDB;database=OtoServisSatisNetCore;integrated" +
                "security = True;MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API    
            modelBuilder.Entity<Marka>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                Adi = "Admin"
            });

            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 1,
                Adi = "Admin",
                Soyadi ="admin",
                AktifMi = true,
                EklenmeTarihi = DateTime.Now,
                Email ="admin@gmail.com",
                KullaniciAdi = "Admin",
                Sifre = "123456",
                //Rol = new Rol { Id = 1 },
                RolID = 1,
                Telefon = "0850",
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

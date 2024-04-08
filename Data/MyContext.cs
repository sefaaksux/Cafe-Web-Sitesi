using admin_panel.Entity;
using Microsoft.EntityFrameworkCore;

namespace admin_panel.Data
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=sherlock; TrustServerCertificate=True; Integrated Security = True ");
        }

        public DbSet<Kategori> kategoriler {get; set;}

        public DbSet<Tablo> tablolar {get; set;}

        public DbSet<Urun> urunler {get; set;}
        public DbSet<User> users {get; set;}

    } 
}
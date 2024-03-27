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

        public DbSet<Aperatif> aperatifler {get; set;}
        public DbSet<Corba> corbalar {get; set;}
        public DbSet<Et> etler {get; set;}
        public DbSet<Makarna> makarnalar {get; set;}
        public DbSet<Pizza> pizzalar {get; set;}
        public DbSet<Salata> salatalar {get; set;}
        public DbSet<Sandvic> sandvicler {get; set;}
        public DbSet<Tavuk> tavuklar {get; set;}

        public DbSet<Cin> cinler {get; set;}
        public DbSet<Ficibira> ficibiralar {get; set;}
        public DbSet<Kokteylshot> kokteylshotlar {get; set;}
        public DbSet<Likör> likörler {get; set;}
        public DbSet<Sarap> saraplar {get; set;}
        public DbSet<Sisebira> sisebiralar {get; set;}
        public DbSet<Vermut> vermutlar {get; set;}
        public DbSet<Viski> viskiler {get; set;}
        public DbSet<Vodka> vodkalar {get; set;}
       
        public DbSet<Sicakicecek> sicakicecekler {get; set;}
        public DbSet<Sogukicecek> sogukicecekler {get; set;}
        public DbSet<Cerez> cerezler {get; set;}
        public DbSet<Tatli> tatlilar {get; set;}

    } 
}
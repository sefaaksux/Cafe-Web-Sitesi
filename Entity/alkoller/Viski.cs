using System.ComponentModel.DataAnnotations.Schema;

namespace admin_panel.Entity
{
    public class Viski
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Amount { get; set; }

        public int kategoriId {get; set;}
        public Kategori Kategori {get; set;}= null!;
    }
    
}
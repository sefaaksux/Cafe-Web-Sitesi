using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace admin_panel.Entity
{
    public class Urun
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Tablo seçimi zorunludur.")]
        public int tabloId {get; set;}
        public Tablo Tablo {get; set;} = null!;

        [Required(ErrorMessage = "Kategori seçimi zorunludur.")]
        public int kategoriId {get; set;}
        public Kategori Kategori {get; set;}= null!;
    }
    
}
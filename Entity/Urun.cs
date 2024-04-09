using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace admin_panel.Entity
{
    public class Urun
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage ="Fiyat zorunludur.")]
        [Column(TypeName ="decimal(10,2)")]
        
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Geçerli bir fiyat giriniz.")]
        public decimal Amount { get; set; }

        
        public int tabloId {get; set;}
        public Tablo Tablo {get; set;} = null!;

        
        public int kategoriId {get; set;}
        public Kategori Kategori {get; set;}= null!;
    }
    
}
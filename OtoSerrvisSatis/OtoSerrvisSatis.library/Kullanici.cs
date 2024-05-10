using OtoSerrvisSatis.library;
using System.ComponentModel.DataAnnotations;

namespace OtoSerrvisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]  // 50 karakter sınrını koymak 
        public string Adi { get; set; }
        [StringLength(50)]
        public string Soyadi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Telefon { get; set; }
        [StringLength(20)]
        public string KullaniciAdi { get; set; }
        [StringLength(50)]
        public string Sifre { get; set; }
        [StringLength(50)]
        public bool AktifMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        
        public int RolID { get; set; }
        public virtual Rol? Rol { get; set; } // ? null olabileceğini söyler 

    }
}

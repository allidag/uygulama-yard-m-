using OtoSerrvisSatis.library;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoSerrvisSatis.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }
        public DateTime ServiseGelisTarihi { get; set; }
        public string AracSorunu { get; set; } 
        public decimal ServisUcreti { get; set; }
        public DateTime ServistenCıkısTarihi { get; set; }
        public string? Yapilanİslemler { get; set; }
        public bool GarantiKapsamindaMi { get; set; }
        [StringLength(15)]
        public string AracPlaka { get; set; }
        [StringLength(50)]
        public string Marka { get; set; }
        [StringLength(50)]
        public String? Model { get; set; }
        [StringLength(50)]
        public string? KasaTipi { get; set; }
        [StringLength(50)]
        public string? SaseNo { get; set; }
        public string Notlar { get; set; }
    }
}

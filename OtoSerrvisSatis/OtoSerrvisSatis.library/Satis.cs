using OtoSerrvisSatis.library;

namespace OtoSerrvisSatis.Entities
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public int MusteriId { get; set; }
        public decimal SatisFiyatı { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Arac? Arac { get; set; }
        public virtual Musteri? Musteri { get; set; }
    }
}

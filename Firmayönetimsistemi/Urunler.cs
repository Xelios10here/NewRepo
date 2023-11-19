namespace Firmayönetimsistemi
{
    public class Urunler
    {
        public int Id { get; set; }
        public string UrunAd { get; set; } = string.Empty;
        public int UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }
    }
}

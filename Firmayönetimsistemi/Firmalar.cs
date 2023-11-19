namespace Firmayönetimsistemi
{
    public class Firmalar
    {
        public int Id { get; set; }
        public string FirmaAd { get; set; } = string.Empty;
        public string FirmaDurum { get; set; } = string.Empty; //bool metodunu controller kısmında kullanamıyorum
        public string  Siparisbaslangic { get; set; } = string.Empty; //datetime yada timeonly metodları yine controller kısmında çalıştıramadım.
        public TimeOnly Siparisbitis { get; set; } 
    }
}

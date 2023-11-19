namespace Firmayönetimsistemi
{
    public class Siparis
    {
        public int Id { get; set; }
        public string müsteri { get; set; } = string.Empty;
        public string siparistarihi {  get; set; } = string.Empty; //datetime yada onlytime parametreleri hata veriyor.
    }
}

namespace SklepProjektC.Models
{
    // Model produktu
    public class Product
    {
        public int ID_Produktu { get; set; }
        public string Nazwa { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public decimal CenaBazowa { get; set; }
        public int ID_Kategorii { get; set; }
        public int ID_Marki { get; set; }
    }
}
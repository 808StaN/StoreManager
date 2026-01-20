namespace SklepProjektC.Models
{
    // Wariant produktu - konkretny rozmiar i kolor
    public class ProductVariant
    {
        public int ID_Wariantu { get; set; }
        public int ID_Produktu { get; set; }
        public int ID_Rozmiaru { get; set; }
        public int ID_Koloru { get; set; }
        public int StanMagazynowy { get; set; }
        public string KodEAN { get; set; } = string.Empty;
    }
}

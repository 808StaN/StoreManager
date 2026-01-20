namespace SklepProjektC.Models
{
    // Kategoria produktów
    public class Category
    {
        public int ID_Kategorii { get; set; }
        public int? ID_Rodzica { get; set; }
        public string Nazwa { get; set; } = string.Empty;
    }
}
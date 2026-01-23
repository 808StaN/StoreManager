namespace SklepProjektC.Models
{
    // Model zwrotu towaru
    public class Return
    {
        public int ID_Zwrotu { get; set; }
        public int ID_Zamowienia { get; set; }
        public string Powod { get; set; } = string.Empty;
        public string StatusZwrotu { get; set; } = string.Empty;
    }
}

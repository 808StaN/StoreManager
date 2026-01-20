namespace SklepProjektC.Models
{
    // U¿ytkownik systemu
    public class User
    {
        public int ID_Uzytkownika { get; set; }
        public string Imie { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public string Rola { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HasloHash { get; set; } = string.Empty;
    }
}
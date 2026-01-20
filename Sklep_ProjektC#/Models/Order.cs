namespace SklepProjektC.Models
{
    public class Order
    {
        public int ID_Zamowienia { get; set; }
        public int ID_Uzytkownika { get; set; }
        public DateTime DataZamowienia { get; set; }
        public int ID_Statusu { get; set; }
        public decimal WartoscCalkowita { get; set; }
        // Dodaj inne w³aœciwoœci zgodnie z tabel¹ dbo.Zamowienia
    }
}
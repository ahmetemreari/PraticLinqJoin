// Kitap sınıfı, kitapların bilgilerini tutar
public class Kitap
{
    public int KitapId { get; set; } // Kitap no
    public string Baslik { get; set; } // Kitap adı
    public int YazarId { get; set; } // Kitabın yazarının no (YazarId ile ilişkilidir)

    // Yapıcı metot, kitabın bilgilerini alır ve atar
    public Kitap(int kitapId, string baslik, int yazarId)
    {
        KitapId = kitapId;
        Baslik = baslik;
        YazarId = yazarId;
    }

    // Kitabın bilgilerini string olarak döndürür
    public override string ToString()
    {
        return $"KitapId: {KitapId}, Başlık: {Baslik}, YazarId: {YazarId}";
    }
}
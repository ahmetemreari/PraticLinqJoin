// Yazar sınıfı, yazarların bilgilerini tutar
public class Yazar
{
    public int YazarId { get; set; } // Yazar için no
    public string Ad { get; set; } // Yazarın adı

    // Yazarın bilgilerini alır ve atar
    public Yazar(int yazarId, string ad)
    {
        YazarId = yazarId;
        Ad = ad;
    }

    // Yazarın bilgilerini string olarak döndürür
    public override string ToString()
    {
        return $"YazarId: {YazarId}, Ad: {Ad}";
    }
}
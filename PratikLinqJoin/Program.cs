using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Yazarlar listesi oluştur ve örnek veri ekle
        List<Yazar> yazarlar = new List<Yazar>
        {
            new Yazar(1, "Ömer Seyfettin"),
            new Yazar(2, "David Burns"),
            new Yazar(3, "Recep Tayyip Erdoğan")
        };

        // Kitaplar listesi oluştur ve örnek veriler ekle
        List<Kitap> kitaplar = new List<Kitap>
        {
            new Kitap(1, "Kasagi", 1),
            new Kitap(2, "İyi Hissetmek", 2),
            new Kitap(3, "Daha Adil Bir Dünya Mümkün", 3),
            new Kitap(4, "A Fairer World is Possible", 3)
        };

        // LINQ sorgusu ile kitapları ve yazarlar birleştir
        var sorgu = from kitap in kitaplar
                    join yazar in yazarlar on kitap.YazarId equals yazar.YazarId
                    select new { kitap.Baslik, yazar.Ad };

        // cw ile yazdır
        Console.WriteLine("Kitaplar ve Yazarları:");
        foreach (var item in sorgu)
        {
            Console.WriteLine($"Kitap: {item.Baslik}, Yazar: {item.Ad}");
        }
    }
}

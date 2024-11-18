## İçindekiler

- Kurulum
- Kullanım
- Sınıflar
- Örnek Veriler
- LINQ Sorgusu
- Sonuçlar

## Kurulum

Bu projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. Projeyi klonlayın veya indirin.
2. Proje dizinine gidin.
3. Projeyi bir IDE (Visual Studio, VS Code vb.) ile açın.
4. `Program.cs`, `Author.cs` ve `Book.cs` dosyalarını oluşturun ve kodları ekleyin.
5. Projeyi çalıştırın.

## Kullanım

Proje çalıştırıldığında, yazarlar ve kitaplar listesi oluşturulur ve örnek veriler eklenir. LINQ sorgusu ile kitaplar ve yazarlar birleştirilir ve sonuçlar ekrana yazdırılır.

## Sınıflar

### Yazar Sınıfı (Author.cs)

```csharp
public class Yazar
{
    public int YazarId { get; set; }
    public string Ad { get; set; }

    public Yazar(int yazarId, string ad)
    {
        YazarId = yazarId;
        Ad = ad;
    }

    public override string ToString()
    {
        return $"YazarId: {YazarId}, Ad: {Ad}";
    }
}
```

### Kitap Sınıfı (Book.cs)

```csharp
public class Kitap
{
    public int KitapId { get; set; }
    public string Baslik { get; set; }
    public int YazarId { get; set; }

    public Kitap(int kitapId, string baslik, int yazarId)
    {
        KitapId = kitapId;
        Baslik = baslik;
        YazarId = yazarId;
    }

    public override string ToString()
    {
        return $"KitapId: {KitapId}, Başlık: {Baslik}, YazarId: {YazarId}";
    }
}
```

## Örnek Veriler

### Yazarlar Listesi

- Ömer Seyfettin
- David Burns
- Recep Tayyip Erdoğan

### Kitaplar Listesi

- Kasagi (Ömer Seyfettin)
- İyi Hissetmek (David Burns)
- Daha Adil Bir Dünya Mümkün (Recep Tayyip Erdoğan)
- A Fairer World is Possible (Recep Tayyip Erdoğan)

## LINQ Sorgusu

Kitaplar ve yazarlar arasındaki ilişkiyi birleştiren LINQ sorgusu:

```csharp
var sorgu = from kitap in kitaplar
            join yazar in yazarlar on kitap.YazarId equals yazar.YazarId
            select new { kitap.Baslik, yazar.Ad };
```

## Sonuçlar

Sorgu sonucunda her kitabın başlığı ve yazarının adı ekrana yazdırılır:

```
Kitaplar ve Yazarları:
Kitap: Kasagi, Yazar: Ömer Seyfettin
Kitap: İyi Hissetmek, Yazar: David Burns
Kitap: Daha Adil Bir Dünya Mümkün, Yazar: Recep Tayyip Erdoğan
Kitap: A Fairer World is Possible, Yazar: Recep Tayyip Erdoğan
```

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.
```

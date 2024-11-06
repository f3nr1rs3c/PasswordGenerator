using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Şifrenin uzunluğunu giriniz: "); // Kullanıcıya şifre uzunluğunu girmesi için bilgi mesajı giriliyor.
        int sifre_uzunlugu = int.Parse(Console.ReadLine()); // Kullanıcının girdiği değeri int olarak okuyup sifre_uzunlugu değişkenine atıyoruz.

        string sifre = OlusturulanSifre(sifre_uzunlugu); // Belirtilen uzunlukta rastgele bir şifre oluşturuluyor.
        Console.WriteLine("Oluşturulmuş sifre: " + sifre); // Oluşturulan şifre ekrana yazdırılıyor.
    }
    static string OlusturulanSifre(int length) // Belirtilen uzunlukta rastgele karakterlerden oluşan bir şifre oluşturan metod.
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijk1mnopqrstuvwxyz0123456789!@#$^&/(){}_+-*"; // Şifrede kullanılabilecek karakterleri içeren dizi.
        StringBuilder sb = new StringBuilder(); // Şifreyi oluşturmak için StringBuilder nesnesi.
        Random rastgele = new Random(); // Rastgele sayı üretmek için Random sınıfı.

        for (int i = 0; i < length; i++) // Belirtilen uzunlukta rastgele karakter seçme döngüsü.
        {
            int index = rastgele.Next(chars.Length); // chars dizisinden rastgele bir indeks seçiliyor.
            sb.Append(chars[index]); // Seçilen karakter StringBuilder nesnesine ekleniyor.
        }
        return sb.ToString(); // Oluşturulan şifreyi string olarak döndürüyoruz.
    }
}

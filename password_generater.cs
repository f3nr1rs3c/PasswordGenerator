using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Şifrenin uzunluğunu giriniz: ");
        int sifre_uzunlugu = int.Parse(Console.ReadLine());

        string sifre = OlusturulanSifre(sifre_uzunlugu);
        Console.WriteLine("Oluşturulmuş sifre: " + sifre);
    }
    static string OlusturulanSifre(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijk1mnopqrstuvwxyz0123456789!@#$^&/(){}_+-*";
        StringBuilder sb = new StringBuilder();
        Random rastgele = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rastgele.Next(chars.Length);
            sb.Append(chars[index]);
        }
        return sb.ToString();
    }
}

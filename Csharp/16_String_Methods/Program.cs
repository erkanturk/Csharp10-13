namespace _16_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Methods
            string metin = "Yazılım Dersleri";
            string[] metinler = { "Merhaba", "Ben", "C#" };
            string ad = "Erkan";
            string soyad = "Türk";
            string text = "    Merhaba String Methodlar    ";
            Console.WriteLine($"metin uzunluğu {metin.Length}");
            Console.WriteLine($"metin büyültme {metin.ToUpper()}");
            Console.WriteLine($"metin küçültme {metin.ToLower()}");
            Console.WriteLine(metinler.Contains("C#"));//True veya false olarak cevap verir.
            string degistirilmisMetin = metin.Replace("Yazılım", "C#");
            Console.WriteLine("metin değiştireme:" + degistirilmisMetin);
            string metinBirlestir = string.Join(" ", metinler);
            Console.WriteLine(metinBirlestir);

            foreach (var item in metinler)
            {
                Console.WriteLine(item);
            }

            string adSoyad = string.Concat(ad, " ", soyad);
            Console.WriteLine(adSoyad);
            Console.WriteLine(text);
            Console.WriteLine("Boşluk silme:" + text.Trim());//Başında ve sonunda olan boşlukları siler.

            string[] diziyeDonusmusMetin = metin.Split(' ');
            for (int i = 0; i < degistirilmisMetin.Length; i++)
            {
                Console.WriteLine(degistirilmisMetin[i] + " index: " + i);
            }
            string lang = "C# String Methodlar";
            string alinanMetin = lang.Substring(0, 6);
            Console.WriteLine(alinanMetin);
            Console.WriteLine(alinanMetin.StartsWith("C#"));//True veya false olarak cevap döner.

            string deger = "    ";
            string deger2 = "";
            string deger3 = null;
            string deger4;//undefined
            
            Console.WriteLine(string.IsNullOrEmpty(deger));
            Console.WriteLine(string.IsNullOrWhiteSpace(deger));
            Console.WriteLine(string.IsNullOrWhiteSpace(deger3));
            //Console.WriteLine(deger4); hata verir.
            //deger4 = Console.ReadLine();
             Console.WriteLine(string.Equals(deger2, deger3));
          
            #endregion
        }
    }
}

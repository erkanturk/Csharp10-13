namespace _11_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While 
             * Loops çeşididir bir işlemi birden fazla kez yaptırmak istediğimiz de döngüleri kullanırız
             * While yapısıda bir döngü yapısı olarak bizlere bu konuda yardımcı olur
             * Çalışma prensibi diğer döngülerde ki gibi true olduğu sürece çalışır.
             */
            //while (true)//Sonsuz döngü
            //{
            //    Console.WriteLine("test");
            //}
            ////for (int i = 0; i < 10;)
            ////{
            ////    Console.WriteLine("Sonsuz döngü");
            ////}
            //for (; ;)
            //{
            //    Console.WriteLine("Sonsuz döngü");
            //}
            #region Örnek 1
            //bool deger = true;
            //while (deger)
            //{
            //    Console.WriteLine("Devam etmek istiyor musunuz ?");
            //    string cevap = Console.ReadLine().ToUpper();
            //    if (cevap == "E")
            //    {
            //        deger = true;
            //    }
            //    else if (cevap == "H")
            //    {
            //        deger = false;//koşula bağlı olarak döngüyü sonlandıracak
            //    }

            //}
            //Console.WriteLine("Döngü bitti");
            #endregion
            #region Örnek 2 
            //1 den 10 a kadar sayıları ekrana yazdıralım fakat bu sayılardan 5 ve 6 ekrana yazılmasın
            //döngü 9 a geldiğinde sonlansın 10 değeri ekranda yazılmasın.
            //int i = 0;
            //while (i <= 10)
            //{


            //    if (i == 5 || i == 6)
            //    {
            //        i++;
            //        continue;//adımı atla

            //    }
            //    if (i == 10)
            //    {
            //        break;//Döngüyü sonlandır.
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine();
            #endregion
            #region Örnek 3
            //200 den başlayarak 0 a kadar 3 e tam bölünen sayıları ekrana yazın ve bu sayıların
            //toplamını ekrana getirin.
            //int sayi = 200;
            //int toplam = 0;
            //while (sayi > 0)
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        toplam += sayi;
            //    }
            //    sayi--;

            //}
            //Console.WriteLine($"200 den başlayarak 3 e tam bölünen sayıların toplamı:{toplam}");
            #endregion
            #region Örnek 4
            /* Kullanıcıdan sayı girmesini isteyeceğiz.
             * kulanıcının girdiği ilk  değer eğer  
             * 0 sa tekrardan uyarı verip sayı girmesini isteyeceğiz
             * Kullanıcı ilk değeri 0 dışında bir değer girdi ise 
             * 0 a basana kadar sayı girmeye devam edecek
             * Kullanıcı 0 a basarsa tekrardan ve 
             * bu 0 değeri ilk sayı değeri değilse
             * Kullanıcının girdiği sayılar toplanacak 
             * ve döngü sonlanıp toplam sayı ekrana yazdırılacak.
  
             */
            //int sayac = 0;
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayac == 0 && sayi == 0)
            //    {
            //        Console.WriteLine("İlk  değer 0 olamaz!!!");
            //        continue;
            //    }
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    if (sayi < 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir değer giriniz.");
            //        continue;
            //    }
            //    toplam += sayi;
            //    sayac++;

            //}
            //Console.WriteLine("Toplam:" + toplam);
            //Console.WriteLine("Ortalama" + (toplam / sayac));
            //Console.WriteLine("Sayaç:" + sayac);
            #endregion
            #region Ödev Emeklilik
            /*
        kullanıcıdan alınan cinsiyet bilgisine göre
     ==> ERKEK ise
        yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
       ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
       6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
        ==> KADIN ise
         yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
       yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
       maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
       altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
        ==> cinsiyet bilgisi switch-case ile sorgulanacak
            switch case if else
         */
            #endregion
            #region Modem yönetim sistemi
            /*Kullanıcıdan kullanıcı adı ve şifre isteyeceğiz
             * Toplamda 3 hakkı olacak 
             * Eğer 3 defa yanlış girerse sistem kitlenecek 5 saniye
             * Sonra hakları sıfırlanıp tekrardan girmesini isteyeceğiz
             * Eğer kullanıcı doğru kullanıcı adı ve şifre girerse 
             * Sisteme giriş başarılı diyelim.
             
             */
            //string userName = "admin";
            //string password = "A123";
            //int hak = 3;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kad = Console.ReadLine().ToLower();
            //    Console.WriteLine("Şifre");
            //    string sifre = Console.ReadLine().ToUpper();
            //    hak--;
            //    if (userName == kad && password == sifre)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız kalmadı");
            //        Console.WriteLine("Sistem kitlendi");
            //        //Thread.Sleep(5000);//Milisaniye cinsinden süre verilir ve bir bekleme süresi ekler. 
            //        for (int i = 15; i > 0; i--)
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            Console.WriteLine(i);
            //            Thread.Sleep(1000);
            //            Console.Clear();
            //            Console.ResetColor();

            //        }
            //        Console.Clear();//Consolda bulunan yazıları siler.
            //        Console.WriteLine("Sistem açıldı");
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş başarısız");
            //        Console.WriteLine("Tekrar deneyiniz");
            //    }


            //}

            #endregion
            #region Örnek 5
            ////Kullanıcıdan gelen her harfi ekrana yazdırma 
            Console.WriteLine("Bir kelime girin");
            string kelime = Console.ReadLine();
            int index = 0;
            while (index < kelime.Length)
            {
                Console.WriteLine($"{kelime[index]} => index:{index}");
                index++;
            }
            Console.WriteLine("***********************");
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine($"{kelime[i]} => index:{i}");

            }
            #endregion
        }
    }
}

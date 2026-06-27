namespace _09_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Loops (Döngüler) 
             Do while döngüsü c# a özel bir döngü türüdür.
            Bu döngünün mantığı koşulu kontrol etmeden önce do ifadesinin içerisine yazılmış olan kodu bir kere 
            çalıştırmak daha sonrasında koşulu kontrol etmek koşul doğru ise döngüyü devam ettirmektir. koşul yanlış ise 
            döngüyü sonlandırır.
             */


            //int sayi = 0;

            //do
            //{
            //    Console.WriteLine($"{sayi}-Erkan");
            //    sayi--;
            //}
            //while (sayi > 0);//koşul kontrolü 


            //int sayi2 = 5;
            //int sayi3 = 8;
            //do
            //{
            //    Console.WriteLine("Merhaba");
            //    sayi2++;
            //}
            //while (sayi3 > sayi2);//false


            //kullanıcıdan do while döngüsü ile 5 tane sayı alın. bu sayıların tek olanlarını ayrı çift olanlarını 
            //ayrı toplayarak iki farklı değişkene kaydedip ekrana yazın.

            //tektoplam: 20     - 1,5,7
            //çiftToplam: 22    - 4,8

            int sayi = 0;
            int tekToplam = 0;
            int ciftToplam = 0;

            //do
            //{
            //    Console.WriteLine("Bir sayı gir:");
            //    int kullanicidanAlinanSayi = Convert.ToInt32(Console.ReadLine());

            //    if (kullanicidanAlinanSayi % 2 == 0)
            //    {
            //        ciftToplam += kullanicidanAlinanSayi;
            //    }
            //    else
            //    {
            //        tekToplam += kullanicidanAlinanSayi;
            //    }

            //    sayi++;
            //}
            //while (sayi <5);

            //Console.WriteLine($"Tek Sayıların toplamı: {tekToplam}");
            //Console.WriteLine($"Çift Sayıların toplamı: {ciftToplam}");


            //int islem = 1;
            //int sayi;
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //do
            //{
            //    Console.Write(islem + ". sayiyi giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam = ciftToplam + sayi;
            //    }
            //    else
            //    {
            //        tekToplam = tekToplam + sayi;
            //    }

            //    islem++;
            //}
            //while (islem <= 5);

            //Console.WriteLine("Tek sayilarin toplami: " + tekToplam);
            //Console.WriteLine("Cift sayilarin toplami: " + ciftToplam);


            //int tektoplam = 0;
            //int çifttoplam = 0;
            //int sayac = 0;
            //do
            //{
            //    Console.WriteLine("bir sayı girin");
            //    int sayı = Convert.ToInt32(Console.ReadLine());
            //    if (sayı % 2 == 0)
            //    {
            //        çifttoplam += sayı;
            //    }
            //    else
            //    {
            //        tektoplam += sayı;
            //    }
            //    sayac++;
            //}
            //while (sayac < 5);
            //Console.WriteLine($"Çift sayılar toplamı: {çifttoplam}");
            //Console.WriteLine($"Tek sayılar toplamı: {tektoplam}");

            //==========================================================================================

            //kullanıcının her girdiği sayıyı toplayalım kullanıcı 0 a basarsa toplam ekrana yazılsın

            //int kullanicininGirdigiSayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı gir: ");
            //    kullanicininGirdigiSayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += kullanicininGirdigiSayi;
            //}
            //while (kullanicininGirdigiSayi != 0);

            //Console.WriteLine($"Girilen sayıların toplamı: {toplam}");

            //int x = 0;


            //do
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        continue;
            //    }
            //    if (num == 9)
            //    {
            //        break;
            //    }
            //    x++;
            //    Console.WriteLine(x);
            //} while (true);

            int x = 0;
            do
            {
               
                x++;
                if (x == 5|| x == 6)
                {
                    continue;
                }
                if (x == 9)
                {
                    Console.WriteLine(x);
                    break;
                }
              
                Console.WriteLine(x);
            } while (x<=10);

            //1-100 arasında rasgele üretilen sayıyı 5 hakta bulma oyunu

            Random random = new Random();
            int tutulanSayi = random.Next(1, 101);
            //Console.WriteLine(tutulanSayi);
            int girilenSayi = 0;
            int hak = 1;

            do
            {
                Console.WriteLine($"{hak}. hakkınız. lütfen sayı giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());

                if (girilenSayi > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                }
                else if (girilenSayi < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("Tebrikler Doğru tahmin!");
                }
                if (hak == 5)
                {
                    if (girilenSayi != tutulanSayi)
                    {
                        Console.WriteLine($"Hakkınız doldu aradığınız sayı {tutulanSayi}");
                    }
                    Console.WriteLine("Devam etmek istiyor musunuz? E/H");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        hak = 0;
                        tutulanSayi = random.Next(1, 101);
                    }
                    else if (cevap == "H")
                    {
                        Console.WriteLine("Oyun bitti");
                        break; //döngülerde de çalıştığı anda içinde bulunduğu döngüyü sonlandırıp döngüden çıkmayı sağlar.
                    }
                }
                hak++;

            }
            while (girilenSayi != tutulanSayi && hak <= 5);



        }
    }
}

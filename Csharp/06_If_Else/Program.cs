namespace _06_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             KOŞUL YAPILARI
            -IF ELSE Koşul yapısı
            -SWITCH CASE Koşul yapısı

            Bir programın akışı koşula göre hareket edecek ise if else yapısı kullanılır. 
            If else bloklarından birisi çalışır ise diğer bloklar kontrol edilmeden geçilir.
             */

            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 5) //koşul true olduğunda if bloğu çalışır.
            //{
            //    Console.WriteLine($"{sayi} 5'den büyüktür.");
            //}
            //else if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı 5 eşittir");
            //}
            //else //else bloğundan önceki koşullar çalışmazsa eğer else bloğu çalışır.
            //{
            //    Console.WriteLine($"{sayi} 5'den küçüktür.");
            //}


            //if (sayi > 5)
            //{
            //    Console.WriteLine("Sayı 5 den büyüktür.");
            //}
            //if (sayi == 10)
            //{
            //    Console.WriteLine("Sayı 5 e eşittir");
            //}
            //if (sayi < 5)
            //{
            //    Console.WriteLine("sayı 5 den küçüktür");
            //}

            //------------------------------------------------------------------

            //int sayi2 = -4;
            //if (sayi2 > 0)
            //{
            //    Console.WriteLine("Sayınız Pozitiftir.");
            //}
            //else if (sayi2 < 0)
            //{
            //    Console.WriteLine("Sayınız Negatiftir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız 0'dır.");
            //}
            //------------------------------------------------------------------


            //string sifre = "furkan123";
            //Console.WriteLine("Şifreyi Girin: ");
            //string kullanicigirisi = Console.ReadLine();
            //if (kullanicigirisi == sifre)
            //{
            //    Console.WriteLine("Giriş Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş başarısız");
            //}

            //Console.WriteLine("Program Bitti");


            //============================================================================================
            //Kullanıcıdan haftanın hangi günü olduğunu isteyelim
            //Kullanıcı 1 derse bize Pazartesi desin 2 salı olarak tüm günleri yazalım 
            //Kullanıcı 1 veya 7 dışında bir değer girerse 1 ila 7 arasında bir değer giriniz diye uyaralım.


            //Console.WriteLine("Haftanın hangi günü: ");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("1-7 arasında bir değer girin.");
            //}
            //============================================================================================

            //Kullanıcıdan bir sayı isteyin. sayı çift ise ekrana girdiğiniz sayı çift yazsın.
            //tek ise girdiğiniz sayı tek yazsın.

            //Console.WriteLine("Bir sayı girin: ");
            //int tekMiCiftMi = Convert.ToInt32(Console.ReadLine());

            //if (tekMiCiftMi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek sayıdır");
            //}
            //Kullanıcı bir sayı girecek bu sayının negatif mi pozitif mi olduğunu söyleyen if else yapısını yazın.
            //============================================================================================


            // Kullanıcıdan Aylık geliri istenecek ve Aylık geliri 40000 in üsünde ise %12 vergi kesilecek
            //40000 ve altıda ise %9 vergi kesimi yapılarak 
            //Kullanıcıya yeni geliri hesaplamalar sonucunda gösterilecek. 45000 * 0.88

            //Console.WriteLine("Aylık gelirinizi girin: ");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    Console.WriteLine($"%12 vergi kesilmiş maaşınız: {gelir * 0.88}");
            //}
            //else
            //{
            //    Console.WriteLine($"%9 vergi kesilmiş maaşınız: {gelir * 0.91}");
            //}


            //Console.WriteLine("Sınav notunuzu girin: ");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if (not >= 90 && not <= 100)
            //{
            //    Console.WriteLine("Harf Notunuz: AA");
            //}
            //else if (not >= 80 && not <= 89)
            //{
            //    Console.WriteLine("Harf Notunuz: BA");
            //}
            //else if (not >= 70 && not <= 79)
            //{
            //    Console.WriteLine("Harf Notunuz: BB");
            //}
            //else if (not >= 60 && not <= 69)
            //{
            //    Console.WriteLine("Harf Notunuz: CB");
            //}
            //else if (not >= 50 && not <= 59)
            //{
            //    Console.WriteLine("Harf Notunuz: CC");
            //}
            //else if (not >= 0 && not <= 49)
            //{
            //    Console.WriteLine("Harf Notunuz: FF");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Not girdiniz.");
            //}


            //string dogruKA = "admin";
            //string dogruSFR = "12345";
            //string dogruGuvenlikKodu = "2026";

            //Console.WriteLine("Kullanıcı adınızı girin: ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifre girin: ");
            //string sifre = Console.ReadLine();

            //Console.WriteLine("Güvenlik kodu: ");
            //string guvenlikKodu = Console.ReadLine();

            //if (kullaniciAdi == dogruKA && sifre == dogruSFR && guvenlikKodu == dogruGuvenlikKodu)
            //{
            //    Console.WriteLine("Sisteme giriş başarılı");
            //}
            //if (kullaniciAdi != dogruKA)
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}
            //if (sifre != dogruSFR)
            //{
            //    Console.WriteLine("Sifre hatalı");
            //}
            //if (guvenlikKodu != dogruGuvenlikKodu)
            //{
            //    Console.WriteLine("Güvenlik kodu hatalı");
            //}


            //yaş 18den büyük veya eşitse sinema bileti alabilir, eğer öğrenciyse bilet 100tl değilse 150tl


            //Console.WriteLine("Yaşınızı girin: ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Öğrenci misin? true/false ");
            //bool ogrenciMi = Convert.ToBoolean(Console.ReadLine());

            //if (yas >= 18)
            //{
            //    if (ogrenciMi == true)
            //    {
            //        Console.WriteLine("Bilet fiyatu 100tl");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bilet fiyatı 150tl");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Bu filme giriş yapamazsın");
            //}

            //Kullanıcıdan alışveriş tutarını isteyin ve üyelik durumunu isteyin.
            //1000tl ve üzerindeyse üyelik kontrolü yapsın.
            //kullanıcı üye ise %20 indirim uygulansın
            //üye değilse %10 indirim uygulansın
            //alışveriş tutarı 1000tlden az ise indirim uygulanmasın


            Console.WriteLine("Alışveriş tutarınızı girin: ");
            double tutar = Convert.ToDouble(Console.ReadLine());



            if (tutar >= 1000)
            {
                Console.WriteLine("Üye misiniz? true/false");
                bool uyeMi = Convert.ToBoolean(Console.ReadLine());

                if (uyeMi)
                {
                    double sonTutar = tutar * 0.80;
                    Console.WriteLine($"%20 indirim uygulandı. {sonTutar}TL ödenecek");
                }
                else
                {
                    double sonTutar = tutar * 0.90;
                    Console.WriteLine($"%10 indirim uygulandı. {sonTutar}TL ödenecek");
                }
            }
            else
            {
                Console.WriteLine("indirim uygulanmadı");
                Console.WriteLine($"Ödenecek tutar {tutar}");
            }

        }
    }
}

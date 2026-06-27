using System.ComponentModel.Design;

namespace _08_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case 

            /*
                switch(değer)
                {
                    case koşul: yapılacak işlemler;break; 
                    case kosul2:yapılacak işlemler;break;
                    case kosul3:yapılacak işlemler;break;
                    default: geriye kalan herşeyi kapsar ;break;
                }
                switch kısmı deger kısmını kontrol edecek değişken yazılır.
                ve bu değişken uygun case e yönlendirilir.
           */


            //Console.WriteLine("Şehir plakası bul, Şehir adı gir:");
            //string sehir = Console.ReadLine();

            //switch (sehir)
            //{
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "ankara": Console.WriteLine($"{sehir} plakası 06"); break;
            //    case "antalya": Console.WriteLine($"{sehir} plakası 07"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    default:
            //        Console.WriteLine("sistemde yoğunluk mevcut sonra tekrar deneyin.");
            //        break;
            //}
            //Console.WriteLine();
            //switch (sehir)
            //{
            //    case "istanbul":
            //    case "İstanbul":
            //    case "Istanbul":
            //        Console.WriteLine("İstanbul şehrinin plaka kodu: ");
            //        Console.WriteLine("34");
            //        break;
            //    case "ankara":
            //        Console.WriteLine("06");
            //        break;
            //    case "izmir": Console.WriteLine("35"); break;
            //    case "bursa": Console.WriteLine("16"); break;
            //    case "ısparta": Console.WriteLine("32"); break;
            //    case "adana": Console.WriteLine("01"); break;
            //    default:
            //        Console.WriteLine("Yanlış girdiniz.");
            //        break;
            //}


            //Console.WriteLine("yapmak istediğiniz işlemi yazın: ");
            //string islem = Console.ReadLine();
            ////ToLower = hepsini küçük harfe çevirir.
            ////Trim = başındaki ve sonundaki boşlukları temizler.

            //switch (islem)
            //{
            //    case "stok eksilt": Console.WriteLine("Stok eksiltme yapıldı."); break;
            //    case "ürün ekle": Console.WriteLine("ürün eklendi"); break;
            //    case "satış yap": Console.WriteLine("ürün satıldı"); goto case "stok eksilt";
            //    default: Console.WriteLine("hatalı seçim"); break;
            //}

            //Console.WriteLine("program bitti");




            //4 İŞLEM yapan hesap makinesi switch caase ile yapın.
            //bölme işleminde bölen syaının sıfır olmaması durumunu if-else yapısı
            //ile kontrol edin

            //Console.WriteLine("Birinci sayıyı girin: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İşlem seçiniz (+,-,*,/)");
            //char islem = Convert.ToChar(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+': Console.WriteLine($"Toplama işleminin sonucu {sayi1 + sayi2}"); break;
            //    case '-': Console.WriteLine($"Çıkarma işleminin sonucu {sayi1 - sayi2}"); break;
            //    case '*': Console.WriteLine($"Çarpma işleminin sonucu {sayi1 * sayi2}"); break;
            //    case '/':
            //        if (sayi2 != 0)
            //        {
            //            Console.WriteLine($"Bölme işleminin sonucu {sayi1 / sayi2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sıfıra bölme işlemi yapılamaz!");
            //        }
            //        break;
            //}
            //Console.WriteLine();

            //============================================================================================
            //Kullanıcıdan haftanın hangi günü olduğunu isteyelim
            //Kullanıcı 1 derse bize Pazartesi desin 2 salı olarak tüm günleri yazalım 
            //Kullanıcı 1 veya 7 dışında bir değer girerse 1 ila 7 arasında bir değer giriniz diye uyaralım.


            //Console.WriteLine("Bugün haftanın kaçıncı günü: ");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;
            //    default:
            //        Console.WriteLine("Hatalı seçim. 1-7 arasında bir değer gir");
            //        break;
            //}

            //Console.WriteLine("Cinsiyetinizi Girin: ");
            //string cinsiyet = Console.ReadLine();

            //switch (cinsiyet)
            //{
            //    case "erkek":
            //        Console.WriteLine("Askerliğini yaptın mı?");
            //        string cevap = Console.ReadLine();
            //        if (cevap =="e")
            //        {
            //            Console.WriteLine("Çalışmaya başla");
            //        }
            //        else
            //        {
            //            Console.WriteLine("askerliğini yap");
            //        }
            //        break;
            //    case "kadın":
            //        Console.WriteLine("Okudun mu?");
            //        string cevap2 = Console.ReadLine();
            //        if (cevap2 == "e")
            //        {
            //            Console.WriteLine("Hangi bölüm?");
            //            string cevap3 = Console.ReadLine();
            //            if (cevap3 == "tıp")
            //            {
            //                Console.WriteLine("doktorluk güzel");
            //            }
            //            else if (cevap3 == "mühendislik")
            //            {
            //                Console.WriteLine("mühendislik zor");
            //            }
            //            else
            //            {
            //                Console.WriteLine("duymadım o bölümü");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Okumalısın.");
            //        }
            //        break;
            //}




        }
    }
}

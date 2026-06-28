using _17_Void_Methods;

namespace _14_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Try Catch
             * Try yapısı çalıştırılmasını istediğimiz kod bloğunu kontrol eder eğer bir hata ile karşılaşır ise catch tarafına geçer ve kod tarafının hatalı çalışmasını
             * veya programın sonlanmasını engeller
             * Catch yapısı programın akışını bozmadan hatayı gösterir ve devam etmesini sağlar.
             
             */
            #region örnek 1
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz.");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayı değeri:" + sayi);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Hata:" + e.Message);//Hata mesajını bize göster.
            //}
            //Console.WriteLine("Program çalışmaya devam ediyor");
            #endregion

            #region Örnek2
            //try
            //{
            //    Console.WriteLine("sayi 1");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayi 2");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi / sayi2);
            //}
            ////catch (DivideByZeroException)
            ////{
            ////    Console.WriteLine("Sıfıra bölünme hatası");
            ////}
            ////catch (FormatException)//Format 
            ////{
            ////    Console.WriteLine("Veri tipi hatası");
            ////}
            ////catch (OverflowException)//veri aşımı
            ////{
            ////    Console.WriteLine("Veri tipi aşımı");
            ////}
            //catch (Exception ex)//Genel olarak tüm hataları kapsar
            //{

            //    Console.WriteLine("Genel tüm hatalar:"+ex.Message);
            //}

            #endregion

            #region örnek 3
            //try
            //{
            //    Console.WriteLine("Cinsiyet giriniz");
            //    string cinsiyet = Console.ReadLine().ToUpper().Trim();
            //    switch (cinsiyet)
            //    {
            //        case "ERKEK":
            //        case "E":
            //            Console.WriteLine("Yaşınız");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Prim gün sayısı");
            //            int prim = Convert.ToInt32(Console.ReadLine());
            //            if (yas > 60)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 10} emeklilik ikramiyeniz");
            //            }
            //            else if (prim >= 6000)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 11} emeklilik ikramiyeniz");

            //            }
            //            else
            //            {
            //                Console.WriteLine("Emekli olamadınız çalışmaya devam.");
            //            }
            //            break;
            //        case "KADIN":
            //        case "K":
            //            Console.WriteLine("Yaşınız");
            //            int yas2 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Prim gün sayısı");
            //            int prim2 = Convert.ToInt32(Console.ReadLine());
            //            if (yas2 > 58)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 10} emeklilik ikramiyeniz");
            //            }
            //            else if (prim2 >= 5600)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 11} emeklilik ikramiyeniz");

            //            }
            //            else
            //            {
            //                Console.WriteLine("Emekli olamadınız çalışmaya devam.");
            //            }
            //            break;
            //        default: Console.WriteLine("Hatalı seçim"); break;
            //    }
            // }
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Hata:"+ex.Message);
            //}
            #endregion
            #region Finaly
            ////finaly yapısı hata durumunda da hata olmama durumunda da çalışacak bir kısımdır.
            //string deger = "Open";

            //try
            //{

            //    if (deger == "Open")
            //    {
            //        Console.WriteLine("Sayı giriniz");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //    }



            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata");
            //}
            //finally
            //{
            //    //deger = "Closed";//Hatalı durumda da hata olmama durumundada çalışır.
            //    if (deger == "Open")
            //    {
            //        deger = "Closed";
            //    }
            //    else
            //    {
            //        deger = "Open";
            //    }
            //}
            //if (deger == "Open")
            //{
            //    Console.WriteLine("Bağlantı hala açık işlem yapılamaz");
            //}
            //else if(deger=="Closed")
            //{
            //    Console.WriteLine("işlem yapmaya devam edebilirsiniz.");
            //}

            #endregion
            Islemler islemler = new Islemler();
            islemler.Islem(1000,200,'*');

        }
    }
}

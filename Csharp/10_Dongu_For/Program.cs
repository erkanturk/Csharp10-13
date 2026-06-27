namespace _10_Dongu_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Tüm döngü yapıları koşul true olduğu sürece çalışır.

            for (veri tipi = deger; koşul; deger artışı veya azalışı)
            {
            
            }
             
             
             */


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i}.furkan");
            //}
            //Console.WriteLine();
            //for (int i = 0; i <=20;)
            //{
            //    if (i == 6 || i == 9)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 18)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;

            //}
            //Console.WriteLine();
            //for (string i = "A"; i < "z"; i++) //hata verir sadece sayısal ifadelerle çalışır.
            //{

            //}
            //for (char i = 'A'; i < 'z'; i++)
            //{
            //    Console.WriteLine($"{i}=>{(int)i}");
            //}
            //Console.WriteLine();
            //0dan başlayarak 100e kadar 2nin katlarını yazdırmak istersek
            //for (int i = 0; i < 101; i += 2)//altaki örnek daha doğru bir yöntemdir 0 yerine 1 yazarsam 3 ün katlarını getirir
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("****************");
            //for (int i = 0; i <=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine();

            //100den başlayarak 0a  kadar 2nin katlarını yazdırmak istersek

            //for (int i = 100; i >= 0; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("******************");
            //for (int i = 100; i > 0; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine();
            //300 den başlayarak 7 ye tam bölünenleri ekrana yazdır.


            //1 ile 20 arasındaki sayıları yazdıralım. 15 ve 16 sayısını ekrana yazmasın. 19 sayısına gelince bitirsin döngüyü

            //for (int i = 1; i < 21; i++)
            //{
            //    if (i == 12 || i == 14)
            //    {
            //        continue; //bulunduğu satırdan sonrakileri çalıştırmadan döngünün başına gider.
            //    }
            //    if (i == 17)
            //    {
            //        Console.WriteLine(i);
            //        break; //döngüyü kırar ve bitirir.
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Döngü bitti.");


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("İ döngüsü çalıştı");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("J döngüsü çalıştı");
            //    }
            //}


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)//iç de ki döngü ilk biten
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                   //break veya continue bu for döngüsünü kırar yada atlatır üst yapıya dokunamaz. 
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int sayi = 0; sayi <= 5; sayi++)
            {
                Console.WriteLine($"sayi döngüsü {sayi}");

                for (int i = 0; i <= 5; i++)
                {
                    if (i == 2 || i == 3)
                    {
                        continue;
                    }
                    if (i == 4)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    Console.WriteLine(i);
                }
            }


            //1'den 50'ye kadar olan sadece tek sayıları ekrana yazdıran bir for döngüsü yazınız.



            //1 ile 30 arasındaki sayıları ekrana yazdıran bir döngü kurun.
            //Ancak sayı 15 veya 20 olduğunda ekrana yazdırmadan atlasın, sayı 27'ye ulaştığında ise döngüyü tamamen bitirsin.

            for (int i = 1; i <= 30; i++)
            {
                if (i == 15 || i == 20)
                {
                    continue;
                }
                if (i == 27)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.WriteLine(i);
            }








            /*
             DÜZ ÜÇGEN YAPIMI
                *
                **
                ***
                ****
                *****
                ******
                *******
                ********
                *********
                **********
             
             TERS ÜÇGEN YAPIMI
                **********
                *********
                ********
                *******
                ******
                *****
                ****
                ***
                **
                *

             
             İÇİ BOŞ ÜÇGEN OLUŞTURMA
                                *
                              *   *
                            *       *
                          *           *
                        *               *
                      *                   *
                    *                       *
                  *                           *
                *                               *
              *                                   *
            * * * * * * * * * * * * * * * * * * * * *

             Yıldızlar İle Piramit Yapımı
                                    *
                                   * *
                                  * * *
                                 * * * *
                                * * * * *
                               * * * * * *
                              * * * * * * *
                             * * * * * * * *
                            * * * * * * * * *
                           * * * * * * * * * *
                     
             
             */








        }
    }
}

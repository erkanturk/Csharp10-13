namespace _12_Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays örnekler
            //string[] iller = new string[11];
            //iller[0] = "Adana";
            //iller[1] = "Amasya";
            //iller[2] = "Ankara";
            //iller[3] = "Zonguldak";
            //iller[4] = "Antalya";
            //iller[5] = "Ordu";
            //iller[6] = "Ankara";
            //iller[7] = "İstanbul";
            //iller[8] = "İzmir";
            //iller[9] = "Eskişehir";
            //iller[10] = "Bayburt";
            //for (int i = 0; i < iller.Length; i++)
            //{
            //    Console.WriteLine("For=>"+iller[i]);
            //}
            //int index = 0;
            //while (iller.Length > index)
            //{
            //    Console.WriteLine("While=>" + iller[index]);
            //    index++;
            //}
            //int x = 0;

            //do
            //{
            //    Console.WriteLine("Do While=>" + iller[x]);
            //    x++;
            //}
            //while (iller.Length>x);

            //foreach (string il in iller)
            //{
            //    Console.WriteLine("Foreach=>" + il);
            //}
            //foreach (var item in iller)//varsayılan olarak var veri
            //tipi ile gelir fakat biz yinede veri tipini biliyorsak string int gibi belirtmemiz daha sağlıklı olur
            //{

            //}
            #endregion
            #region Array Methods
            #region Clear
            // string[] adlar = { "Erkan", "Tahsin", "Emre", "Onur", "Enes", "Furkan", "Erkan" };
            //foreach (var ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            //Array.Clear(adlar);//Adlar dizisini temizler
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Copy
            //string[] adlar = { "Erkan", "Tahsin", "Emre", "Onur", "Enes", "Furkan", "Erkan" };
            //string[] adlar2 = new string[adlar.Length];//Yukarıda bulunan array yapısının uzunluğu kadar değer al
            // Array.Copy(adlar, adlar2, 4);
            //Array.Copy(adlar,1, adlar2, 3, 3);//adlar dizisinden 1. index değerinden itibaren 3 eleman alacaksın ve 3. indexten itibaren ekleyeceksin 
            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}
            //string metin = adlar[2];
            //Console.WriteLine(metin);


            #endregion
            #region IndexOf
            //string[] adlar = { "Erkan", "Onur", "Enes", "Furkan", "Erkan","Hamza","Damla","Tuğrul","Erkan","Orhun","Özlem","Erkan" };

            //int index = Array.IndexOf(adlar, "Erkan");
            //int index2 = Array.IndexOf(adlar, "Erkan", 5);//index değeri vererek aramak istediğimiz değeri koleksiyon yapısının içerisinde bulabiliriz.
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            //Console.WriteLine(adlar[index2]);

            #endregion
            #region LastIndexOf
            //string[] adlar = { "Erkan", "Onur", "Enes", "Furkan", "Erkan", "Hamza", "Damla", "Tuğrul", "Erkan", "Orhun", "Özlem", "Erkan" };

            //int index = Array.LastIndexOf(adlar, "Erkan");
            //int index2 = Array.LastIndexOf(adlar, "Erkan", 5);//index değeri vererek aramak istediğimiz değeri koleksiyon yapısının içerisinde bulabiliriz.
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            //Console.WriteLine(adlar[index2]);

            #endregion
            #region Revers&Sort
            //string[] Markalar = { "Bmw", "Togg", "Nissan", "Mercedes", "Toyota", "Alfa Romeo", "Aston Martin" };
            //int[] sayilar = { 10, 100, 99, 1, 3, 5, 50 };
            //Array.Sort( Markalar);//A Z ye sıralama yapar. Veya Küçükten büyüğe sıralama yapar.
            //Array.Reverse(Markalar);//Sort ile birlikte kullanılırsa büyükten küçüğe 
            ////tek kullanılırsa mevcut yapıyı tersine çevirir.
            //foreach (string item in Markalar)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            #endregion
            #region Resize
            //Resize işlemi hem boyut büyültme hem boyut küçültme işlemlerinde kullanılır.
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[2] = 75;
            ////sayilar[3] = 30;
            ////Array.Resize(ref sayilar, 5);
            //Array.Resize(ref sayilar, sayilar.Length + 1);
            //sayilar[sayilar.Length - 1] = 40;

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Resize(ref sayilar, sayilar.Length - 1);
            //Array.Resize(ref sayilar, sayilar.Length - 1);
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            #endregion
            #endregion

            #region Array Örnek
            //Kullanıcıdan kelime girmesini isteyelim
            //Kullanıcının girdiği her kelimenin harfinini tek tek diziye aktaralım 
            //Ve  aktarılan her harfi tersten yazdıralım

            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine();
            //char[] harfler = new char[metin.Length];
            //int i = 0;
            //foreach (char harf in harfler)
            //{
            //    harfler[i] = metin[i];
            //    Console.WriteLine(harfler[i]);
            //    i++;
            //}
            //Console.WriteLine("*************");
            //Console.WriteLine();
            //Array.Reverse(harfler);
            //for (int j = 0; j < harfler.Length; j++)
            //{
            //    Console.WriteLine(harfler[j]);
            //}
            #endregion
            #region Array örnek 2
            /*Kullanıcıdan 10 sayı girmesini isteyeceğiz
             * Kullanıcının girdiği değerler eğer 3 ün katları ise bu değerler diziye eklenecek 
             * eğer 3 katları değilse 10 eleman 3 katları olacak şekilde dizi tamamlanana kadar işlem devam edecek
             * 
             */
            //int[] sayilar = new int[10];
            //for (int i = 0; i < sayilar.Length; )
            //{
            //    Console.WriteLine("3 ün katı olan Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi % 3 == 0)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}
            //Console.WriteLine("*************");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion
            #region Array örnek 3
            //random yapısını kullanarak dizinin elemanlarını
            //oluşturalım ve bu dizideki her bir elemanı çift tek olarak toplamını alalım
            Random random = new Random();
            int randSayi = random.Next(1,100);
            int[] dizi = new int[randSayi];
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(1, 1001);

            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    ciftToplam += dizi[i];
                }
                else
                {
                    tekToplam += dizi[i];
                }
            }
            Console.WriteLine($"Dizide bulunan Tek sayıların Toplamı:{tekToplam}");
            Console.WriteLine($"Dizide bulunan Çift sayıların Toplamı:{ciftToplam}");
            Console.WriteLine($"Dizinin uzunluğu:{dizi.Length} randomda oluşturulan sayı:{randSayi}");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"dizi elemanları:{dizi[i]}");
            }
            #endregion

        }
    }
}

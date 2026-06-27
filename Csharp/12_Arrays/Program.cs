namespace _12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dizi(Array) string ifadeler aslında birer array yapısıdrı Erkan => içerisinde birden fazla eleman taşır
             * Dizilerde birden çok aynı tipde yapı bulunur.Bu sebeple koleksiyon yapısı olarak adlandırılırlar.
             * Dizilerin elemanlarını çağırırken index adlı bir değer ile bu elemanlara ulaşırız
             * İndex değeri daima 0 dan başlar  indexler 0 eleman değeri 1 olarak adlandırılır.
             * Dizi tanımlarken veri tipi belirtilir ve uzunluk belirtilmelidir.
             * Örnek
             * 
             * int[] sayılarDizi=new int[10]=>9 indexli 
             * 10. index değeri girilince  system.IndexOutOfRangeException. index aşım hatası
             
             */

            #region Dizi örnekleri 1
            string metin = "Erkan";
            Console.WriteLine(metin[1]);//koleksiyon yapısında 1. index de bulunan elemanı getirir.
            //E => 0 r => 1 k => 2 a => 3 n => 4 //index değeri
            //E => 1 r => 2 k => 3 a => 4 n => 5 //eleman değeri length değerinin -1 i index değeridir.

            //string[] adlar = new string[5];//5 değeri eleman değeridir.
            //adlar[0] = "Erkan";
            //adlar[1] = "Tahsin";
            //adlar[2] = "Onur";
            //adlar[3] = "Emre";
            //adlar[4] = "Ahmet";
            //////adlar[5] = "Furkan"; //hata
            ////Console.WriteLine(adlar[1]);
            ////Console.WriteLine(adlar[2]);
            ////Console.WriteLine(adlar[3]);
            ////Console.WriteLine(adlar[4]);
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"index değeri:{i} => {adlar[i]} Eleman sayısı => {i + 1}");
            //}

            int[] ucretler = { 200, 100, 50, 75, 45, 90 };
            string[] urunler = { "Kahve", "Kola", "Biskuvi", "Cips", "Çay", "Ayran" };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{urunler[i]} Fiyatı => {ucretler[i]}");
            }
            Console.WriteLine("**********");
            Console.WriteLine(urunler[3] + "=>" + ucretler[3]);
            Console.WriteLine("**********");
            int index = 0;
            while (index < ucretler.Length)
            {
                Console.WriteLine($"{urunler[index]} Fiyatı => {ucretler[index]}");
                index++;
            }
            Console.WriteLine("*********************");
            index = 0;
            do
            {
                Console.WriteLine($"{urunler[index]} Fiyatı => {ucretler[index]}");
                index++;
            }
            while (index < ucretler.Length);
            Console.WriteLine();
            #endregion
            #region dizi örnek2
            //boş bir sayılar dizisi oluşturalım bu dizinin elemanlarını 1 den 10 kadar 
            //sayılarla dolduralım

            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = i + 1;
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //20 değerinde 2 ye tam bölünen toplam 10 sayı var bu sayıları bir dizinin içerisine aktaran 
            //kodu yazınız.
            //int[] dizi = new int[11];
            //int index = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        dizi[index] = i;
            //        index++;

            //    }

            //}
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            #endregion

            #region Kullanıcıdan Personel sayısını isteyip diziye ekleyen kod

            //Console.WriteLine("Personel sayınız");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string[] personeller = new string[sayi];//kullanıcı dizinin uzunluğunu belirtecek.

            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Personel Adı.");
            //    //string ad = Console.ReadLine();
            //    //personeller[i] = ad;
            //    personeller[i] = Console.ReadLine();//Personellerin 0 . indexine kullanıcıdan gelen değeri ekle

            //}
            //Console.WriteLine("**********");
            //int ind = 0;
            //while (ind < personeller.Length)
            //{
            //    Console.WriteLine(personeller[ind]);
            //    ind++;
            //}
            Console.WriteLine();
            object[] nesneler = { 10, "Test", DateTime.Now, true, false, 123.456, 'A' };//Boxing
            for (int i = 0; i < nesneler.Length; i++)
            {
                Console.WriteLine(nesneler[i]);
            }
            #endregion
        }
    }
}

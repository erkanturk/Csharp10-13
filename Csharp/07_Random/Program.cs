namespace _07_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random sınıfı ram bellekte bize rastgele sayı üreten bir yapıdır. 
            //oyunlarda testlerde simülasyonlarda kullanılır.
           // Random random = new Random();//Sınıftan bir örnek oluşturma
            Random zar = new Random(); //Nesne oluşturduk
            int sansliSayi = zar.Next(1,11); //Random sınıfının Next metodu ile
                                             //min ve max değerleri vererek bu aralıkta
                                             //sayı üretmesini sağlayabiliriz.

        Tugrul:
            Console.WriteLine("Lütfen şanslı sayıyı tahmin edin: ");
            int kullaniciTahmin = Convert.ToInt32(Console.ReadLine());

            if (kullaniciTahmin == sansliSayi)
            {
                Console.WriteLine($"Tebrikler şanslı sayıyı bildiniz: {sansliSayi}");
            }
            else
            {
                Console.WriteLine("Bilemediniz lütfen tekrar oynayın.");
                Thread.Sleep(1000);
                Console.Clear();
                goto Tugrul;
            }

        }
    }
}

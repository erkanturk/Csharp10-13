namespace _15_Math_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Tanım
            /* Methodlar Fonksiyonlar
             * Methodlar yazılımcılar tarafından geliştirilen ve diğer yazılımcıların  kullanımına sunulan hazır kod yapılarıdır.
             * Methoda bir isim verilir ve o isim altında bir iş yapan
             * kod bloğu yazılır ve yazılımcılar o işi yapmak için methodu çağırır
             * bu sayede yazılımcı tanımlı bir iş yapısını tekrar tekrar yazmaktan kurtulur.
             * Methodlar ve fonksiyonlar '()' ile tanımlanır 
             * Method içerisinde yeni bir method yazılamaz.
             * Methodlar çağırılmadığı sürecede çalışmazlar.
             * Methodlar unique(benzersiz) olmalıdır aynı isime sahip bir methodun imza tipi farklı olmak zorundadır.
             * İmza tiplari (int string char bool vb.) yapılar 
             * Methodlar 2 ye ayrılır.
             * İş yapan (Parametreli/Parametresiz)
             * Geriye değer döndüren(Parametreli/Parametresiz)
             * Methodlar çağırılırken Methodİsim(); ile tanımlanır varsa parametre değerleri verilir.
             * Method oluştururken ise iş yapacak ise bu method void olarak belirtiriz.
             * Örneğin
             * Static void Yaz()
             * {
             *      Bu alanda yapmak istediğimiz işlemleri yaparız
             * }
             * Yaz(); olarak da çağırırız.
             * Daima void yapısı görünen bir method iş yapan method yapısıdır
             * Geriye değer döndüren methodlarda Şu veri yapıları kullanılır.
             * int string bool class  string[] list<> arraylist vb. gibi yapılar kullanılır.
             * 
             
             */
            #endregion

            #region Math Methods
            Console.WriteLine($"Pi Sayısı {Math.PI}");
            Console.WriteLine($"Karekök alma:{Math.Sqrt(100)}");
            Console.WriteLine($"Kuvvetini alma:{Math.Pow(2,3)}");
            Console.WriteLine($"Mutlak Değer:{Math.Abs(-30)}");
            Console.WriteLine($"Maksimum Değer:{Math.Max(100,199)}");
            Console.WriteLine($"Minimum Değer:{Math.Min(100,199)}");
            Console.WriteLine($"Tam yuvarlama:{Math.Round(3.49)}");//Tam yuvarlama yapar.
            Console.WriteLine($"Yukarı yuvarlama:{Math.Ceiling(3.01)}");
            Console.WriteLine($"Aşağı yuvarlama:{Math.Floor(3.99)}");
            int[] sayilar = { 1, 2, 3, 4, 5,51, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            Console.WriteLine(sayilar.Sum());//Array yapısının içinde bulunan sayıları toplar.
            Console.WriteLine(sayilar.Count());//Eleman sayısını bize verir.
            Console.WriteLine(sayilar.Length);//Eleman sayısını bize verir.
            Console.WriteLine(sayilar.Average());//Sayıların ortalamasını getirir.
            Console.WriteLine(sayilar.Max());//Dizideki maksimum değer
            Console.WriteLine(sayilar.Min());//Minimum değer.
            #endregion

        }


    }

}

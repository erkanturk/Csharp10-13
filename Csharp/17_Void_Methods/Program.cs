namespace _17_Void_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Void bir methodun iş yaptığını belirten bir keyword yapısıdır
             * Bu yapıyı kullandığımız methodların sadece verilen işleri yapmasını bekleriz 
             * Geriye değer dönderdikleri durumlar olabilir bunun için ref veya  out keywordlerini kullanırız.
             * İş yapan methodlar parametreli ve parametresiz olarak kullanım amacımıza göre şekillendire biliriz.
             */
            #region Method Örnek1
            //Yaz();
            //KullaniciKayit("Erkan", "Türk", 32);
            //Console.WriteLine("Ad");
            //string adiniz = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //string soyadiniz = Console.ReadLine();
            //Console.WriteLine("Yas");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //KullaniciKayit(adiniz, soyadiniz, yas);

            //Topla(20,30);
            #endregion
            #region Method örnek 2
            //Kullanıcıdan 2 adet sayı alacağız ve bu sayılarla ne işlem yapması gerektiğini soracağız
            //Örneğin + - * / şeklinde girilen sayılara işlem uygulayacağız.
            //Console.WriteLine("1.Sayı");
            //double sayi=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlem(+ *  / -)");
            //char islem = Convert.ToChar(Console.ReadLine());
            // Islem(sayi, sayi2,islem);
            #endregion
            #region Dizi elemanlarını Döndüren Method
            //int[] sayi = { 1, 2, 3 };
            //int[] degerler = { 1, 2, 3 , 4 ,5,6 };
            //double[] elemanlar = { 4, 5, 6, 7, 8 };
            //DiziDondur(sayi);
            //DiziDondur(degerler);
           // DiziDondur2(sayi,degerler);
            Sayilar(10,20,30,40,50,60);
            //DiziDondur(elemanlar);// parametrede bulunan veri tipi hangi türde ise o tipde veri gönderilmelidir.
            #endregion
        }
        #region Method Örnek1

        static void Yaz()//Parametresiz iş yapan method
        {
            Console.WriteLine("Adınızı Giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine(ad);
        }
        static void KullaniciKayit(string ad, string soyad, int yas)//Parametreli iş yapan method
        {
            Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad} Yaşınız{yas}");
        }
        static void Topla(int sayi, int sayi2)
        {
            int toplam = sayi + sayi2;
            Console.WriteLine(toplam);
            Console.WriteLine(sayi + sayi2);
        }
        #endregion
        #region Method örnek 2
        //static void Islem(double sayi1, double sayi2,char islem)
        //{
        //    //Console.WriteLine("Yapmak istediğiniz işlem(+ *  / -)");
        //    //char islem = Convert.ToChar(Console.ReadLine());
        //    if (islem == '+')
        //    {
        //        Console.WriteLine(sayi1+sayi2);
        //    }
        //    else if (islem == '*')
        //    {
        //        Console.WriteLine(sayi1*sayi2);
        //    }
        //    else if (islem == '-')
        //    {
        //        Console.WriteLine(sayi1-sayi2);
        //    }
        //    else if (islem == '/')
        //    {
        //        if (sayi2 != 0)
        //        {
        //            Console.WriteLine(sayi1 / sayi2);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Sayı sıfıra bölünemez");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı seçim");
        //    }
        //}
        #endregion
        #region Dizi elemanlarını Döndüren Method
        static void DiziDondur(int[] s)
        {
            foreach (int item in s)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziDondur2(int[] s,int[] s2)
        {
            foreach (int item in s)
            {
                Console.WriteLine(item);
            }
        }
        static void Sayilar(int s,int s2,int s3,int s4,int s5,int s6)
        {
            int[] num = {s,s2,s3,s4,s5,s6};
            DiziDondur(num);//Başka bir methoda yönlendirme.
           
        }
        #endregion
    }
}

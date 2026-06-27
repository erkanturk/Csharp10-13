namespace _02_Console_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
                1)Console.ReadLine(); satırına geldiğinde program duraklatılır ve imleç yanıp sönmeye başlar.
                2)Bilgisayar kullanıcının klavyeden bir şeyler yazıp enter a basmasını bekler.
                3)enter a basıldığında yazılan tüm veriyi hafızaya alır. Veriyi her zaman string olarak okur.
             */

            //Console.Write("Kullanıcı Adınızı Girin: ");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine($"Hoş Geldin"+kullaniciAdi);

            ////Tür dönüşümü - (Bir sonraki konuda detaylı anlatılacak.)
            //string yas = Console.ReadLine();
            //Console.WriteLine(yas + 10);
            //Console.WriteLine(yas.GetType());
            Console.WriteLine("Yaş giriniz");
            int yas2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yas2.GetType());
            Console.WriteLine(yas2 + 10);

            //string sayilar = "50";
            //int sayi = Convert.ToInt32(sayilar);
            //Console.WriteLine(sayi+10);
            //---------------------------------------------------------

            //Ad, soyad, yas, boy değişkenlerini kullanıcıdan alıp ekrana yazın.
            Console.WriteLine("Adınızı Girin:");
            string ad = Console.ReadLine();


            Console.WriteLine("Soyadınızı girin: ");
            string soyad = Console.ReadLine();


            Console.WriteLine("Yaşınızı Girin: ");
            string yas3 = Console.ReadLine();

            Console.WriteLine("Boyunuzu girin: ");
            string boy = Console.ReadLine();
            Console.Clear();// Terminal ekranını komple siler.

            Console.WriteLine("------ Kimlik ------");
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Soyad: {soyad}");
            Console.WriteLine($"Yaş: {yas3}");
            Console.WriteLine($"Boy: {boy}");
            Console.WriteLine("----------------------");
            //---------------------------------------------------------

            Console.Write("Adınızı ve Soyadınızı girin: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Nereden: ");
            string nereden = Console.ReadLine();

            Console.Write("Nereye: ");
            string nereye = Console.ReadLine();

            Console.Write("Uçuş Saati: ");
            string ucusSaati = Console.ReadLine();

            Console.Write("Koltuk Numarası: ");
            string koltukNumarasi = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("========== UÇUŞ BİLETİ ==========");
            Console.WriteLine($"Yolcu Adı Soyadı: {adSoyad}");
            Console.WriteLine($"From: {nereden} =====> To: {nereye}");
            Console.WriteLine($"Uçuş Saati: {ucusSaati}");
            Console.WriteLine($"Koltuk Numarası: {koltukNumarasi}");
            Console.WriteLine("==================================");


        }
    }
}

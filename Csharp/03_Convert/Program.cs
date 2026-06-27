using System.Text;
using System.Threading.Channels;

namespace _03_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aşağıdaki işlem girilen iki sayıyı toplamaz birleştirerek ekrana yazar. çünkü iki sayı da string olarak kaydedilmiştir.
            //ÖRN. s1 = 8, s2 = 7,  s1 + s2 = 87 sonucunu görürüz.
            //Console.WriteLine("Birinci Sayıyı Girin: ");
            //string s1 = Console.ReadLine();

            //Console.WriteLine("İkinci Sayıyı Girin: ");
            //string s2 = Console.ReadLine();

            //Console.WriteLine(s1 + s2);
            ////=========================================================================
            //Console.WriteLine("Birinci Sayıyı Girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());//Tür dönüşümü
            //Console.WriteLine("İkinci Sayıyı Girin: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi + sayi2);


            /*NEDEN DÖNÜŞÜME İHTİYACIMIZ VAR?
             Bilgisayar son derece düz mantıkla çalışır. 
            Klavyeden 25 yazıp Enter'a bassak bile, ReadLine() 
            komutu bunu bir sayı olarak değil, "İki ve Beş karakterlerinden 
            oluşan bir metin" olarak görür. Metin kutularındaki verileri,
            matematik yapabileceğimiz gerçek sayı kutularına aktarma işlemine Tip Dönüşümü diyoruz.
             */

            //Console.WriteLine("Double sayi gir: ");
            //double doubleSayi = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(doubleSayi + 1.1); //Eğer Convert işlemi yapmasaydık sonucumuz 8.31.1 şeklinde olurdu.

            //=========================================================

            //Console.WriteLine("--- KULLANICI PROFİLİ OLUŞTURMA ---");

            // 1. INT (Tam Sayı) Çevirimi
            //Console.Write("Yaşınızı giriniz (Örn: 25): ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            ////yas.ToString();//stringe dönüştürme

            //Console.Write("Yaşınızı giriniz (Örn: 25): ");
            //string yas2 = Console.ReadLine();

            //// 2. DOUBLE (Ondalıklı Sayı) Çevirimi
            //// Not: Türkiye bilgisayar ayarlarında ondalıklı sayı girerken konsolda virgül (,) kullanılır!
            //Console.Write("Boyunuzu giriniz (Örn: 1,75): ");
            //double boy = Convert.ToDouble(Console.ReadLine());

            //// 3. DECIMAL (Hassas Ondalıklı - Para) Çevirimi
            //Console.Write("Maaş beklentinizi giriniz (Örn: 45000,50): ");
            //decimal maas = Convert.ToDecimal(Console.ReadLine());

            //// 4. BOOL (Mantıksal) Çevirimi
            //// ÖNEMLİ: Kullanıcı klavyeden tam olarak "true" veya "false" yazmalıdır (küçük/büyük harf fark etmez).
            //Console.Write("Üniversite mezunu musunuz? (true veya false yazın): ");
            //bool mezunMu = Convert.ToBoolean(Console.ReadLine());

            //// TOPLU YAZDIRMA
            //Console.WriteLine("\n--- KAYDEDİLEN BİLGİLER ---");
            //Console.WriteLine($"Yaş: {yas} (Tipi: {yas.GetType()})");
            //Console.WriteLine($"Yaş2: {yas2} (Tipi: {yas2.GetType()})");
            //Console.WriteLine($"Boy: {boy} (Tipi: {boy.GetType()})");
            //Console.WriteLine($"Maaş: {maas} TL (Tipi: {maas.GetType()})");
            //Console.WriteLine($"Mezuniyet Durumu: {mezunMu} (Tipi: {mezunMu.GetType()})");



            //ÖDEV ÇÖZÜMLERİ:

            //Soru 1:

            //Console.WriteLine("Ad ve Soyad Giriniz: ");
            //string adSoyad = Console.ReadLine();

            //Console.WriteLine("Doğum Yılınızı Girin: ");
            //int dogumYili = Convert.ToInt32(Console.ReadLine());

            //int mevcutYil = 2026;
            //int yas = mevcutYil - dogumYili;
            //int onYilSonrakiYas = yas + 10;

            //Console.WriteLine($"Merhaba {adSoyad}! Şu anki yaşın: {yas}, 10 yıl sonraki yaşın: {onYilSonrakiYas} olacak!");


            //Soru 2:

            //Console.WriteLine("Ürün Adı:");
            //string urunAdi = Console.ReadLine();

            //Console.WriteLine("Birim Fiyatı girin: (150,50)");
            //decimal birimFiyati = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Kaç adet");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Poşet ister misiniz? (true/false)");
            //bool posetDurumu = Convert.ToBoolean(Console.ReadLine());

            //decimal toplamFiyat = birimFiyati * adet;
            //Console.Clear();

            //Console.WriteLine("----- Teknoloji Market Fişi ------");
            //Console.WriteLine($"Ürün: {urunAdi}");
            //Console.WriteLine($"Adet: {adet}");
            //Console.WriteLine($"Poşet Durumu: {posetDurumu}");
            //Console.WriteLine($"Ödenecek Toplam Tutar: {toplamFiyat}");


            //Soru 3:
            //Console.WriteLine("Karakter Adı: ");
            //string karakterAdi = Console.ReadLine();

            //Console.WriteLine("Başlangıç seviyesi: ");
            //int seviye = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Boyu: ");
            //double boy = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Karaterin sınıfı (B/S/O)");
            //char sinif = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Hardcore mode açık mı (true/false)");
            //bool hardcoreMod = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("Karakter Oluşturuldu");
            //Console.WriteLine($"Ad {karakterAdi} | Seviye {seviye} | Sınıf: {sinif}");
            //Console.WriteLine($"Boy {boy} | Hardcore Mod: {hardcoreMod}");
            //Console.WriteLine("Maceraya hazırsın!");
            //===================================================================================

            //double ondaliklisayisalDeger = 58.8;
            //double ondaliklisayisalDeger2 = 58.8;

            //Console.WriteLine(ondaliklisayisalDeger);
            //Console.WriteLine(ondaliklisayisalDeger2);

            //int sayisalDeger = Convert.ToInt32(ondaliklisayisalDeger);//Double veya farklı bir türü de dönüştürebiliriz.
            //Console.WriteLine(sayisalDeger);

            //int sayisalDeger2 = (int)ondaliklisayisalDeger; //(int) ifadesi ile verilen değişkenin direkt olarak int tipine dönüştürülmesi söylenir.
            //                                                //ekstra olarak koşul durum kontrolü yapmaz.
            //                                                //ondalıklı kısmı siler.
            //Console.WriteLine(sayisalDeger2);


            //string yasMetin = "25";
            //int yas = int.Parse(yasMetin); // Parse metotu sadece string tipini farklı türlere dönüştürebilir.
            //                               // Convert metodu int veya diğer sayısal veri tiplerini kendi arasında dönüştürebilirdi.

            //Console.WriteLine(yas + 26);

            //int yas2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(yas2 + 2);


            //string nullDeger = null;

            //int convertCevirme = Convert.ToInt32(nullDeger); // null değer gelirse 0 olarak çevirir. daha merhametlidir.
            //Console.WriteLine(convertCevirme);
            //int parseCevirme = int.Parse(nullDeger); // null değer gelirse direkt program çöker.
            //Console.WriteLine(parseCevirme);

            //string girilenDeger = "25.5";

            //double cevirme = double.Parse(girilenDeger);

            //Console.WriteLine(cevirme + 2.1);


            //boxing unboxing bilinçli tür dönüşümü bilinçsiz tür dönüşümü

            int sayi = 123;
            double n = sayi;//Bilinçsiz tür dönüşümü.
            Console.WriteLine(n);//123

            double deger = 123.50;
            int deger2 = (int)deger;//bilinçli tür dönüşümü.
            Console.WriteLine(deger2);
            //variable değişken nasıl bir değer gelceğini bilmiyorsak kullanılır.
            var num = 123;
            var text = "Test";
            var ondalik = 123.45;
            var karakter = 'A';

            object nesne = 123;
            object nesne1 = "test";
            object nesne2 = 'A';
            object nesne3 = 123.45;
            object nesne4 = true;
            double veri = (double)nesne3;//unboxing
            string metin = "Erkan";
            string test = (string)nesne1;
            metin = "Türk";
            
            Console.WriteLine(metin);


        }
    }
}

namespace _01_Degisken_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Furkan"); //Ekrana Yazar ve alt satıra geçer
            Console.Write("Damla"); //Ekrana Yazar ve alt satıra geçmez
            Console.Write("Rüzgar");
            Console.WriteLine("Elif");
            Console.Write("Emre");
            Console.WriteLine("Tahsin");

            /*
             Bu ise
            Çoklu yorum
            satırıdır.
            istediğiniz kadar yazabilirsiniz. 
             */

            //DEĞİŞKEN TANIMLAMA KURALI
            //degisken_tipi degiskenAdi = deger;
            //------------------------------------------------------
            int yas = 25;
            string isim = "Furkan";
            double boy = 1.87;

            ////Console.WriteLine(yas);
            ////Console.WriteLine(isim);
            ////Console.WriteLine(boy);

            ////cw + tab tuşu

            ////Console.WriteLine("Adım: " + isim + " Yaşım: " + yas + " Boy: " + boy);
            ////Console.WriteLine($"Adım: {isim} Yaşım: {yas} Boy: {boy}");

            ////Tam Sayı Veri Tipleri
            Console.WriteLine("Çıktılar");
            byte tamSayiByte = 255;
            short tamSayiShort = 32767;//Convert.ToInt16
            int tamSayiInt = 2147483647; //Convert.ToInt32
            long tamSayiLong = 9223372036854775807;//Convert.ToInt64

            Console.WriteLine(tamSayiByte);
            Console.WriteLine(tamSayiShort);
            Console.WriteLine(tamSayiInt);
            Console.WriteLine(tamSayiLong);
            Console.WriteLine("Int alabileceği en büyük değer: " + int.MaxValue);
            Console.WriteLine("Int alabileceği en küçük değer: " + int.MinValue);



            ////Ondalıklı Veri Tipleri
            float ondalikliSayiFloat = 1.0f;
            double ondalikliSayiDouble = 3.14159;
            decimal ondalikliSayiDecimal = 15500.50m;

            ////Metinsel Veri Tipleri
            //string metinselVeriString = "Furkan Uçan 25";
            //char metinselVeriChar = 'A';

            Console.WriteLine("10" + 10);
            Console.WriteLine('A' + 10);//Ascii karşılığı olduğu için sayısal bir karşılığı vardır.
            Console.WriteLine((int)'a');//Uyumluluk modunu kullanma

            Console.WriteLine((char)126);
            ////Mantıksal Veri Tipleri
            bool metinselVeriBool = false;//0
            bool metinselVeriBool2 = true;//1
            int sayi = 5;
            int n = 1;
            int i = 132;
            string test = "wqeqwe";
            //int sayi = 10;//hata verir zaten tanımlı olduğu için tanımlama yapamayız.
            sayi = 10;//var olan değeri güncelleriz.
            Console.WriteLine(sayi);
            /*
             Zorunlu Kurallar:

                Rakamla başlayamaz. (1sayi olmaz, sayi1 olur.)
                İçinde boşluk olamaz. (ogrenci yasi olmaz, ogrenciYasi olur.)
                C#'a özel anahtar kelimeler kullanılamaz. (int class = 5; diyemezsin.)
                Özel karakterler içeremez (@, ?, ! vb.), sadece alt çizgi (_) kullanılabilir.

            Genel Kabuller (Best Practices):

                camelCase: Değişken isimleri küçük harfle başlar, sonraki her kelimenin ilk harfi büyük olur. (Örn: kullaniciAdi, enYuksekNot)
                İsimler anlamlı olmalıdır. Sadece a, b, x gibi isimler yerine, değişkenin ne tuttuğunu belli eden isimler (örn: urunFiyati) seçilmelidir.
                Türkçe karakter (İ,ç, ş, ğ, ü, ı, ö) kullanmamak en güvenli yoldur.
             */

            //string karakterAdi = "Savaşçı";
            //int seviye = 42;
            //double canPuani = 89.7;
            //char cinsiyet = 'E';
            //bool yasiyorMu = true;
            //decimal altinMiktari = 1450.75m;

            //Console.WriteLine("Karakter: " + karakterAdi);//Metinsel bir işlemde + birleştirme görevi görür.
            //Console.WriteLine($"Karater: {karakterAdi}"); //string interpolation
            //Console.WriteLine("Karater: {karakterAdi}");


            /*
             Aşağıdaki bilgileri tutmak için en uygun veri tiplerini 
            seçerek değişkenler oluştur ve onlara kendi uydurduğun değerleri ata:
                Astronotun Adı ve Soyadı (Metin)
                Astronotun Yaşı (Tam sayı)
                Uzay giysisinin oksijen kapasitesi (Yüzdelik, küsuratlı bir değer, örn: 98.5) (Ondalıklı sayı)
                Görev Bölümü (Sadece tek harf: **'P'**ilot, **'M'**ühendis, **'D'**oktor gibi) (Karakter)
                Mars'a gitmeye hazır mı? (Mantıksal - true/false)
            */

            string astronotAdSoyad = "Furkan Uçan";
            int astronotYas = 25;
            double oksijenKapasitesi = 87.5;
            char gorevBolumu = 'M';
            bool hazirMi = true;
            const int sabit = 3;
            sabit = 4;//Hata verir
            const double pi = 3.14;


            Console.WriteLine("--- ASTRONOT KİMLİK KARTI ---");
            Console.WriteLine($"İsim: {astronotAdSoyad}");//String interpolation.
            Console.WriteLine("Yas: {0}", astronotYas);//index yazım biçimi
            Console.WriteLine("Oksijen Kapasitesi:" + oksijenKapasitesi);//string yazım biçimi
            Console.WriteLine($"Görev Bölümü: {gorevBolumu}");
            Console.WriteLine($"Göreve Hazırlık Durumu: {hazirMi}");
            Console.WriteLine("-----------------------------------");


            //string denemeAd = Console.ReadLine();
            //Console.WriteLine(denemeAd);


            Console.WriteLine($"byte max{byte.MaxValue} Min {byte.MinValue}");
            Console.WriteLine($"short max{short.MaxValue} Min {short.MinValue}");
            Console.WriteLine($"int max{int.MaxValue} Min {int.MinValue}");
            Console.WriteLine($"long max{long.MaxValue} Min {long.MinValue}");
            Console.WriteLine($"float max{float.MaxValue} Min {float.MinValue}");
            Console.WriteLine($"double max{double.MaxValue} Min {double.MinValue}");
            Console.WriteLine($"decimal max{decimal.MaxValue} Min {decimal.MinValue}");


            //






        }
    }
}

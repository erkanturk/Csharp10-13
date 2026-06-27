namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Aritmetik Operatörler (+, -, *, /, %)
             +  Toplama Operatörü
            -   Çıkarma
            *   Çarpma
            /   Bölme
            %   Mod Alma operatörü(Bölümden Kalanı bulma): bir sayının 2ye bölümünden kalanına bak.
             */

            //int urunFiyati = 150;
            //int kargoUcreti = 40;
            //int toplamTutar = urunFiyati + kargoUcreti;

            //int sayi = 10;
            //int kalan = sayi % 3; //10'un 3'e bölümünden kalan 1'dir.
            //Console.WriteLine(kalan);
            //double sayilar = 10.00/3.00;
            //Console.WriteLine(sayilar);
            //========================================================================================

            /* ATAMA OPERATÖRLERİ
             =      Atama işlemi yapar. sağdaki değeri soldaki değere atar.
            +=      Ekleme işlemi. sağdaki değeri soldakine ekler.
            -=      Çıkarma işlemi. soldaki değerden sağdaki değeri çıkarır
            *=      Çarpma atama. soldaki değeri sağdakiyle çarpıp sola atar.
            /=      bölme atama.
             
             */


            //int deger1 = 10;
            //int deger2 = 2;
            //int deger3 = 20;

            ////değişkeni çağırıp kullanacağımız başına değişken tipi yazılmaz (int)
            //deger3 += deger1;    //deger3 = deger3 + deger1;
            //Console.WriteLine($"1) {deger3}");
            //deger3 /= deger2;   //deger3 = deger3 / deger2;
            //Console.WriteLine($"2) {deger3}");
            //deger3 -= deger1;   //deger3 = deger3 - deger1;
            //Console.WriteLine($"3) {deger3}");
            //deger3 *= deger3;   //deger3 = deger3 * deger3;
            //Console.WriteLine($"4) {deger3}");

            //deger3++; // deger3 = deger3 + 1;
            //deger2--;
            //Console.WriteLine(deger3);
            //Console.WriteLine(deger2);


            //========================================================================================

            /*
            KARŞILAŞTIRMA OPERATÖRLERİ (==, !=, <, >, <=, >=) 
            "Karşılaştırma operatörlerinin sonucu her zaman, 
            istisnasız bool değer(true veya false) çıkar!

            ==      Eşit mi?
            !=      Farklı mı?
            <       Küçük mü?
            >       Büyük mü?
            <=      Küçük veya eşit mi? 20<=20
            >=      Büyük veya eşit mi?
            !       değili(tersi) - true ise tersini al false yap. false ise tersini al true yap
             */

            //bool tekMiCiftMi = (17 % 2) != 0;
            //Console.WriteLine(tekMiCiftMi);

            //int sayi = 10;
            //int sayi2 = 5;

            //bool sonuc = sayi > sayi2;
            //bool sonuc2 = sayi < sayi2;
            //bool sonuc3 = sayi >= sayi2;
            //bool sonuc4 = sayi <= sayi2;
            //bool sonuc5 = sayi == sayi2;
            //bool sonuc6 = sayi != sayi2;

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);
            //Console.WriteLine(sonuc5);
            //Console.WriteLine(sonuc6);

            //Console.WriteLine(!false);

            //string ad = "furkan";
            //string ad2 = "ARABA";

            //Console.WriteLine(ad == ad2);
            //Console.WriteLine(ad.ToUpper() == ad2);
            //Console.WriteLine(ad.ToUpper());
            //Console.WriteLine(ad2);
            //Console.WriteLine(ad2.ToLower());

            //========================================================================================

            //Mantıksal operatörler     VE(AND) &&      VEYA(OR) ||

            /*  AND &&
           --------------------------------   
            1.koşul     2.koşul     sonuç
            true        true        true
            true        false       false
            false       true        false
            false       false       false
           ---------------------------------
             
            OR ||
           ---------------------------------
            1.koşul     2.koşul     sonuç
            true        true        true
            true        false       true
            false       true        true
            false       false       false
           ---------------------------------

             5 == 5 && 4 > 3 || 8 != 8
             
             */

            int sayi = 10;
            int sayi2 = 5;

            //bool sonuc = sayi > sayi2 && sayi >= sayi2;
            //bool sonuc2 = sayi == sayi2 && sayi >= sayi2;
            //bool sonuc3 = sayi >= sayi2 && sayi <= sayi2;
            //bool sonuc4 = sayi < sayi2 && sayi == sayi2;

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);

            bool sonuc = sayi > sayi2 || sayi >= sayi2;
            bool sonuc2 = sayi == sayi2 || sayi >= sayi2;
            bool sonuc3 = sayi >= sayi2 || sayi <= sayi2;
            bool sonuc4 = sayi < sayi2 || sayi == sayi2;

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
        }
    }
}

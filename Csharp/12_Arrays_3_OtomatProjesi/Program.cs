namespace _12_Arrays_3_OtomatProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {//Gith Deneme

            #region proje
            /* 
            https://www.youtube.com/watch?v=g1j1VUmig1Q
          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise 
            ürün alındı, aksi durumda para ekle seçeneği
         ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
         satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
            var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek 
            aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek 
            hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion
            #region Otomat Projesi
            bool isAdmin = false;
            string password = "123";
            string adminPassword;
            int hataSayisi = 0;
            bool isLocked = false;
            string[] urunler = { "cips", "çikolata", "soda", "su", "kek" };
            double[] fiyatlar = { 50, 40, 30, 20, 25 };
            double para = 0;

            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün numaranızı giriniz (Admin Girişi için -1 e basınız)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo == -1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;//Konsol yazısını renklendirme.
                        if (!isLocked)
                        {
                            while (hataSayisi < 3)
                            {
                                Console.WriteLine("Admin Şifresi Giriniz");
                                adminPassword = Console.ReadLine();
                                if (adminPassword == password)
                                {
                                    isAdmin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hataSayisi++;
                                    Console.WriteLine("Yanlış Şifre Kalan Hak:" + (3 - hataSayisi));

                                }
                                if (hataSayisi == 3)
                                {
                                    Console.WriteLine("Yanlış giriş yapıldı hesap 10 saniye kitlendi.");
                                    isLocked = true;
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        Console.WriteLine(i);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                    }
                                    isLocked = false;
                                    hataSayisi = 0;
                                    Console.WriteLine("Hesap Tekrar aktif");
                                    Thread.Sleep(2000);

                                }
                            }
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hesap Kitli");
                            Thread.Sleep(10000);
                            isLocked = false;
                            hataSayisi = 0;
                        }
                        continue;

                    }
                    Console.WriteLine("Para Girişi Yapınız");
                    para = Convert.ToDouble(Console.ReadLine());
                    if (para >= fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız\nAfiyet Olsun.\nPara Üstünüz:" + (para - fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        para = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                            Console.WriteLine("Para Ekle 1\nPara İade 2");
                            string secim = Console.ReadLine().ToLower();
                            if (int.TryParse(secim, out int deger))//Metinsel bir ifade ise metinsel devam et sayısal ise sayıya çevir ve devam et.
                            {
                                if (deger == 1)
                                {
                                    Console.WriteLine("Para Ekle");
                                    para += Convert.ToDouble(Console.ReadLine());
                                    if (para >= fiyatlar[urunNo])
                                    {
                                        Console.WriteLine("Ürünü aldınız\nAfiyet Olsun.\nPara Üstünüz:" + (para - fiyatlar[urunNo]));
                                        Thread.Sleep(2000);
                                        para = 0;
                                        Console.Clear();
                                        break;
                                    }
                                }
                                else if (deger == 2)
                                {
                                    Console.WriteLine("Para iade edildi:" + para);
                                    para = 0;
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama");
                                    Thread.Sleep(2000);
                                }
                            }
                            else if (secim == "para ekle")
                            {
                                Console.WriteLine("Para Ekle");
                                para += Convert.ToDouble(Console.ReadLine());
                                if (para >= fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız\nAfiyet Olsun.\nPara Üstünüz:" + (para - fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    para = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim == "para iade")
                            {
                                Console.WriteLine("Para iade edildi:" + para);
                                para = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }


                        }
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hata:" + ex.Message);
                    Thread.Sleep(2000);
                }
            }
            if (isAdmin)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("***** Admin Panel *****");
                    Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Çıkış");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Ürün Adı");
                        string urunAdi = Console.ReadLine().ToLower();
                        bool kontrol = false;
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            if (urunler[i].ToLower() == urunAdi)
                            {
                                kontrol = true;
                                break;//Ürün benim dizimde zaten varsa eklemeye gerek yok.
                            }
                        }
                        if (kontrol)
                        {
                            Console.WriteLine("Ürün zaten mevcut.");
                            Thread.Sleep(2000);
                            continue;
                        }
                        Console.WriteLine("Ürün fiyatı");
                        double fiyat = Convert.ToDouble(Console.ReadLine());
                        Array.Resize(ref urunler, urunler.Length + 1);//Mevcut miktarın 1 fazlası
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                        urunler[urunler.Length - 1] = urunAdi;
                        fiyatlar[fiyatlar.Length - 1] = fiyat;
                        Console.WriteLine("Ürün Başarışla eklendi");
                        Thread.Sleep(2000);

                    }
                    else if (secim == 2)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                        }
                        Console.WriteLine("Güncellenecek ürün numarası veya adı");
                        string guncellenecekUrun = Console.ReadLine().ToLower();
                        int guncellenecekIndex;
                        if (int.TryParse(guncellenecekUrun, out guncellenecekIndex))
                        {
                            if (guncellenecekIndex >= 0 && guncellenecekIndex < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı");
                                string urunAdi = Console.ReadLine().ToLower();
                                Console.WriteLine("Fiyat");
                                double fiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[guncellenecekIndex] = urunAdi;
                                fiyatlar[guncellenecekIndex] = fiyat;
                                Console.WriteLine("Güncelleme işlemi başarılı");
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                                }
                                Thread.Sleep(5000);

                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            int index = Array.IndexOf(urunler, guncellenecekUrun);

                            if (index >= 0 && index < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı");
                                string urunAdi = Console.ReadLine().ToLower();
                                Console.WriteLine("Fiyat");
                                double fiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[index] = urunAdi;
                                fiyatlar[index] = fiyat;
                                Console.WriteLine("Güncelleme işlemi başarılı");
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                                }
                                Thread.Sleep(5000);

                            }
                            else
                            {
                                Console.WriteLine("Geçersiz ürün");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                    else if (secim == 3)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                        }
                        Console.WriteLine("Silmek istediğiniz ürün numarası");
                        int silinecekIndex = Convert.ToInt32(Console.ReadLine());
                        if (silinecekIndex >= 0 && silinecekIndex < urunler.Length)
                        {
                            for (int i = silinecekIndex; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }
                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                            Console.WriteLine("Ürün Başarı ile silindi");
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                            }
                            Thread.Sleep(2000);
                        }
                    }
                    else if (secim == 4)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} {urunler[i]}:{fiyatlar[i]}");
                        }
                        Thread.Sleep(2000);
                    }
                    else if (secim == 5)
                    {
                        Console.ResetColor();
                        Console.WriteLine("İyi Günler");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem.");
                    }
                }
            }
            #endregion

            //Console.WriteLine("Bir sayı giriniz");
            //string s = Console.ReadLine();


            //if (int.TryParse(s, out int s2))
            //{
            //    Console.WriteLine(s2 + 10);

            //}
            //else
            //{
            //    Console.WriteLine("Metinsel bir değer girildi birleştirme yapılır. "+s+10);
            //}

            


        }
    }
}

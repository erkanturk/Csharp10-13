namespace _13_Switch_Case_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev Emeklilik
            /*
        kullanıcıdan alınan cinsiyet bilgisine göre
     ==> ERKEK ise
        yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
       ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
       6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
        ==> KADIN ise
         yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
       yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
       maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
       altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
        ==> cinsiyet bilgisi switch-case ile sorgulanacak
            switch case if else
         */
            #endregion



            while (true)
            {
                Console.WriteLine("Cinsiyet giriniz");
                string cinsiyet = Console.ReadLine().ToUpper().Trim();
                switch (cinsiyet)
                {
                    case "ERKEK":
                    case "E":
                        Console.WriteLine("Yaşınız");
                        int yas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Prim gün sayısı");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (yas > 60)
                        {
                            Console.WriteLine("Maaş");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 10} emeklilik ikramiyeniz");
                        }
                        else if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 11} emeklilik ikramiyeniz");

                        }
                        else
                        {
                            Console.WriteLine("Emekli olamadınız çalışmaya devam.");
                        }
                        break;
                    case "KADIN":
                    case "K":
                        Console.WriteLine("Yaşınız");
                        int yas2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Prim gün sayısı");
                        int prim2 = Convert.ToInt32(Console.ReadLine());
                        if (yas2 > 58)
                        {
                            Console.WriteLine("Maaş");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 10} emeklilik ikramiyeniz");
                        }
                        else if (prim2 >= 5600)
                        {
                            Console.WriteLine("Maaş");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Tebrikler Emekli oldunuz. {maas * 11} emeklilik ikramiyeniz");

                        }
                        else
                        {
                            Console.WriteLine("Emekli olamadınız çalışmaya devam.");
                        }
                        break;
                    default: Console.WriteLine("Hatalı seçim"); break;
                }
                Console.WriteLine("Devam etmek istiyor musun");
                string cevap = Console.ReadLine();
                if (cevap == "e")
                {
                   
                }
                else
                {
                    break;
                }
              
            }


        }
    }
}

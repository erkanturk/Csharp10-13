namespace _05_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;
            Console.WriteLine(zaman);
            Console.WriteLine(zaman.Year);
            Console.WriteLine(zaman.Month);
            Console.WriteLine(zaman.Day);
            Console.WriteLine(zaman.Hour);
            Console.WriteLine(zaman.Minute);
            Console.WriteLine(zaman.Second);
            Console.WriteLine(zaman.Microsecond);
            Console.WriteLine(zaman.DayOfYear);

            Console.WriteLine("Tarih zaman gir");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(time);

            long sayi = Convert.ToInt64(Console.ReadLine());//Long değer

            short sayi2=Convert.ToInt16(Console.ReadLine());// Short değer.
        }
    }
}

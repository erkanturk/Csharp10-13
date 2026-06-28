using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Void_Methods
{
    public class Islemler
    {
        public void Islem(double sayi1, double sayi2, char islem)
        {
            //Console.WriteLine("Yapmak istediğiniz işlem(+ *  / -)");
            //char islem = Convert.ToChar(Console.ReadLine());
            if (islem == '+')
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            else if (islem == '*')
            {
                Console.WriteLine(sayi1 * sayi2);
            }
            else if (islem == '-')
            {
                Console.WriteLine(sayi1 - sayi2);
            }
            else if (islem == '/')
            {
                if (sayi2 != 0)
                {
                    Console.WriteLine(sayi1 / sayi2);
                }
                else
                {
                    Console.WriteLine("Sayı sıfıra bölünemez");
                }
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
            }
        }
    }
}

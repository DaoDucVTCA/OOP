using System;

namespace GiaiPhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 2: \n");

            int a, b, c;

            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                Quadratic ptb2 = new Quadratic(a, b, c);
                
                Roots r = ptb2.GiaiPhuongTrinh(a, b, c);

                if(r.RootsNumber == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if(r.RootsNumber == 1)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem kep x1 = x2 = {0}", r.Root1);
                }
                else
                {
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet: ");
                    Console.WriteLine("x1 = {0}", r.Root1);
                    Console.WriteLine("x2 = {0}", r.Root2);
                }

            }
        }
    }
}

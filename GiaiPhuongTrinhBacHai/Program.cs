using System;

namespace GiaiPhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 2: \n");

            int a, b, c;
            double x1, x2;

            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                Quadratic ptb2 = new Quadratic(a, b, c);

                if (ptb2.GetDiscriminant() < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else if (ptb2.GetDiscriminant() > 0)
                {
                    x1 = ptb2.GetRoot1();
                    x2 = ptb2.GetRoot2();
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", ptb2.GetDualRoots());
                }
            }
        }
    }
}

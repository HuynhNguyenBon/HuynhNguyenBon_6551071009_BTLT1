using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH BANG CUU CHUONG ===");

            int n;
            bool hopLe;

            do
            {
                Console.Write("Nhap so nguyen n (1 <= n <= 9): ");
                n = int.Parse(Console.ReadLine());

                hopLe = (n >= 1 && n <= 9);

                if (!hopLe)
                {
                    Console.WriteLine("Loi: n phai nam trong khoang 1 den 9. Vui long nhap lai!");
                }

            } while (!hopLe);

            Console.WriteLine($"\n--- BANG CUU CHUONG {n} ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
using System;

namespace TinhTongDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH TINH TONG DAY SO ===");

            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            // Tinh tong bang vong lap for
            long tong = 0;
            long tongChan = 0;
            long tongLe = 0;

            for (int i = 1; i <= n; i++)
            {
                tong += i;

                if (i % 2 == 0)
                {
                    tongChan += i;
                }
                else
                {
                    tongLe += i;
                }
            }

            // Tinh giai thua bang vong lap while, dung long de tranh tran so
            long giaiThua = 1;
            int j = 1;
            while (j <= n)
            {
                giaiThua *= j;
                j++;
            }

            Console.WriteLine($"\n--- KET QUA VOI n = {n} ---");
            Console.WriteLine($"Tong 1 + 2 + ... + {n} = {tong}");
            Console.WriteLine($"Tong cac so chan tu 1 den {n} = {tongChan}");
            Console.WriteLine($"Tong cac so le tu 1 den {n} = {tongLe}");
            Console.WriteLine($"Giai thua {n}! = {giaiThua}");
        }
    }
}
using System;

namespace DemSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH DEM SO NGUYEN TO ===");

            try
            {
                Console.Write("Nhap so nguyen duong n (n <= 1000): ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n--- CAC SO NGUYEN TO TU 2 DEN {n} ---");
                int demSoLuong = 0;

                for (int i = 2; i <= n; i++)
                {
                    bool laSoNguyenTo = true;

                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            laSoNguyenTo = false;
                            break;
                        }
                    }

                    if (laSoNguyenTo)
                    {
                        Console.Write(i + " ");
                        demSoLuong++;
                    }
                }

                Console.WriteLine($"\n\nTong so luong so nguyen to tim duoc: {demSoLuong}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen hop le!");
            }
        }
    }
}
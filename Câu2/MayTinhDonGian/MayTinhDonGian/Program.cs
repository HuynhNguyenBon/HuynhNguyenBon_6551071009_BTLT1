using System;

namespace MayTinhDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH MAY TINH DON GIAN ===");

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());

            double tong = a + b;
            double hieu = a - b;
            double tich = a * b;
            double thuong = a / b;
            int chiaNguyen = (int)a / (int)b;
            int chiaDu = (int)a % (int)b;
            double luyThua = Math.Pow(a, b);

            Console.WriteLine("\n--- KET QUA CAC PHEP TOAN ---");
            Console.WriteLine($"{a} + {b} = {tong}");
            Console.WriteLine($"{a} - {b} = {hieu}");
            Console.WriteLine($"{a} * {b} = {tich}");
            Console.WriteLine($"{a} / {b} = {thuong}");
            Console.WriteLine($"{(int)a} / {(int)b} (chia lay phan nguyen) = {chiaNguyen}");
            Console.WriteLine($"{(int)a} % {(int)b} (chia lay phan du) = {chiaDu}");
            Console.WriteLine($"{a} ^ {b} (luy thua) = {luyThua}");
        }
    }
}
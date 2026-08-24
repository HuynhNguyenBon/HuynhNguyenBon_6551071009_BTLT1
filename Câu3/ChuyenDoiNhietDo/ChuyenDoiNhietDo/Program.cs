using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH CHUYEN DOI NHIET DO ===");

            Console.Write("Nhap nhiet do (do C): ");
            decimal celsius = decimal.Parse(Console.ReadLine());

            decimal fahrenheit = celsius * 9 / 5 + 32;
            decimal kelvin = celsius + 273.15m;

            Console.WriteLine("\n--- KET QUA CHUYEN DOI ---");
            Console.WriteLine("Celsius    = {0:F2} C", celsius);
            Console.WriteLine("Fahrenheit = {0:F2} F", fahrenheit);
            Console.WriteLine("Kelvin     = {0:F2} K", kelvin);
        }
    }
}
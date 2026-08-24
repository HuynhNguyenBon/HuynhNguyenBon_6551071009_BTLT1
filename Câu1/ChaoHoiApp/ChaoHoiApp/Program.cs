using System;

namespace ChaoHoiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH CHAO HOI ===");

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap chieu cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Nhap can nang (kg): ");
            float canNang = float.Parse(Console.ReadLine());

            Console.Write("Da tot nghiep chua (true/false): ");
            bool daTotNghiep = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n--- THONG TIN CA NHAN ---");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Tuoi: {tuoi}");
            Console.WriteLine($"Chieu cao: {chieuCao} m");
            Console.WriteLine($"Can nang: {canNang} kg");
            Console.WriteLine($"Da tot nghiep: {daTotNghiep}");
        }
    }
}
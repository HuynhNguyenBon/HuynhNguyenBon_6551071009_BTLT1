using System;

namespace XepLoaiHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH XEP LOAI HOC SINH ===");
            Console.Write("Nhap diem trung binh: ");
            double diemTB = double.Parse(Console.ReadLine());
            string xepLoai;
            if (diemTB < 0 || diemTB > 10)
            {
                xepLoai = "Diem khong hop le!";
            }
            else if (diemTB >= 9.0)
            {
                xepLoai = "Xuat sac";
            }
            else if (diemTB >= 8.0)
            {
                xepLoai = "Gioi";
            }
            else if (diemTB >= 6.5)
            {
                xepLoai = "Kha";
            }
            else if (diemTB >= 5.0)
            {
                xepLoai = "Trung binh";
            }
            else
            {
                xepLoai = "Yeu";
            }
            Console.WriteLine($"\nDiem trung binh: {diemTB}");
            Console.WriteLine($"Xep loai: {xepLoai}");
        }
    }
}
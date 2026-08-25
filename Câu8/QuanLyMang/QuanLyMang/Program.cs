using System;

namespace QuanLyMang
{
    class Program
    {
        const int SIZE = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH QUAN LY MANG ===");

            int[] mang = new int[SIZE];

            // Nhap gia tri cho mang
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            // In toan bo mang bang foreach
            Console.WriteLine("\n--- TOAN BO MANG ---");
            foreach (int gt in mang)
            {
                Console.Write(gt + " ");
            }
            Console.WriteLine();

            // Tong va trung binh
            int tong = 0;
            foreach (int gt in mang)
            {
                tong += gt;
            }
            double trungBinh = (double)tong / SIZE;

            Console.WriteLine($"\nTong cac phan tu: {tong}");
            Console.WriteLine($"Trung binh: {trungBinh:F2}");

            // Gia tri lon nhat va nho nhat cung vi tri
            int max = mang[0], min = mang[0];
            int viTriMax = 0, viTriMin = 0;

            for (int i = 1; i < SIZE; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                    viTriMax = i;
                }
                if (mang[i] < min)
                {
                    min = mang[i];
                    viTriMin = i;
                }
            }

            Console.WriteLine($"\nGia tri lon nhat: {max} (vi tri {viTriMax})");
            Console.WriteLine($"Gia tri nho nhat: {min} (vi tri {viTriMin})");

            // Dem so luong phan tu chan va le
            int soChan = 0, soLe = 0;
            foreach (int gt in mang)
            {
                if (gt % 2 == 0)
                    soChan++;
                else
                    soLe++;
            }

            Console.WriteLine($"\nSo luong phan tu chan: {soChan}");
            Console.WriteLine($"So luong phan tu le: {soLe}");

            // Mang sau khi dao nguoc thu tu
            int[] mangDaoNguoc = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                mangDaoNguoc[i] = mang[SIZE - 1 - i];
            }

            Console.WriteLine("\n--- MANG SAU KHI DAO NGUOC ---");
            foreach (int gt in mangDaoNguoc)
            {
                Console.Write(gt + " ");
            }
            Console.WriteLine();
        }
    }
}
//c1
using System;
namespace nhaproxy
{
    class Program
    {
        static void Main(string[] args)
        {            
            int A;
            Console.WriteLine("Nhap So nguoi choi: ");
            A = int.Parse(Console.ReadLine());
            Random rd = new Random();
            int sorandom = rd.Next(1, A + 1);
            for (int i = 0; i < A; i++)
            {
                Console.WriteLine("Nhap Ten cua ban");
                string Ten = Console.ReadLine();

                Console.WriteLine("Nhap so ban chon");
                int sochon = int.Parse(Console.ReadLine());
                if (sochon == sorandom)
                {
                    Console.WriteLine($"{Ten}, chuc mung ban la nguoi rua chen!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{Ten}, chuc mung ban khong phai rua chen cho buoi nay.");
                }
            }
            Console.WriteLine($"\nSo ngau nhien duoc chon la: {sorandom}");
        }
    }
}

//c2
using System;
namespace nhaproxy
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Nhap So nguoi choi: ");
            A = int.Parse(Console.ReadLine());

            // Tạo mảng lưu tên và số của người chơi
            string[] tenNguoiChoi = new string[A];
            int[] soChonNguoiChoi = new int[A];

            Random rd = new Random();
            int sorandom = rd.Next(1, A + 1);

            // Nhập thông tin của từng người chơi
            for (int i = 0; i < A; i++)
            {
                Console.WriteLine($"Nhap Ten cua nguoi choi {i + 1}:");
                tenNguoiChoi[i] = Console.ReadLine();
                Console.WriteLine($"Nhap so nguoi choi {i + 1} chon (tu 1 den {A}):");
                soChonNguoiChoi[i] = int.Parse(Console.ReadLine());
            }

            // Kiểm tra ai là người rửa chén
            for (int i = 0; i < A; i++)
            {
                if (soChonNguoiChoi[i] == sorandom)
                {
                    Console.WriteLine($"{tenNguoiChoi[i]} chuc mung, ban la nguoi rua chen!");
                }
                else
                {
                    Console.WriteLine($"{tenNguoiChoi[i]} chuc mung, ban khong phai rua chen!");
                }
            }

            // Thông báo số ngẫu nhiên đã được chọn
            Console.WriteLine($"\nSo ngau nhien duoc chon la: {sorandom}");
        }
    }
}

using System;

namespace baitaptuan2_mang_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập số hàng và cột của mảng A và B
            Console.WriteLine("Nhập vào số dòng của mảng A và B:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số cột của mảng A và B:");
            int m = int.Parse(Console.ReadLine());

            // Khởi tạo mảng A, B và C (mảng kết quả)
            int[,] A = new int[n, m];
            int[,] B = new int[n, m];
            int[,] C = new int[n, m];

            // Nhập dữ liệu cho mảng A
            Console.WriteLine("Nhập các phần tử cho mảng A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Nhập dữ liệu cho mảng B
            Console.WriteLine("Nhập các phần tử cho mảng B:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"B[{i},{j}] = ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Cộng hai mảng A và B để tạo mảng C
            Console.WriteLine("Tổng của hai mảng A và B là mảng C:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + "\t"); // Hiển thị kết quả từng phần tử
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }

            // Hiển thị lại mảng A nếu cần
            Console.WriteLine("\nCác phần tử của mảng A là:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

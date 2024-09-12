// using System;
// namespace Baitap
// {
//     public class SoNguoichoi
//     {
//         string Name;
//         int Sochon;
//         int A; // Đưa biến A ra ngoài để có thể sử dụng ở các phương thức khác

//         // Constructor với tên chính xác
//         public SoNguoichoi(string name, int sochon)
//         {
//             Name = name;
//             Sochon = sochon;
//         }

//         // Phương thức sinh số ngẫu nhiên
//         public void Randome()
//         {
//             Random rd = new Random();
//             A = rd.Next(1, 6); // Lưu giá trị A để dùng trong phương thức Xuat
//         }

//         // Phương thức xuất kết quả
//         public void Xuat()
//         {
//             if (A == Sochon)
//             {
//                 Console.WriteLine($"{Name} xui qua, ban la nguoi duoc chon rua chen");
//             }
//             else
//             {
//                 Console.WriteLine($"{Name}, chuc mung ban khong rua chen");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Khởi tạo các đối tượng với số lựa chọn
//             SoNguoichoi nguoi1 = new SoNguoichoi("Quan", 1); 
//             SoNguoichoi nguoi2 = new SoNguoichoi("Oanh", 2); 
//             SoNguoichoi nguoi3 = new SoNguoichoi("Vy", 3); 
//             SoNguoichoi nguoi4 = new SoNguoichoi("Huyen", 4); 
//             SoNguoichoi nguoi5 = new SoNguoichoi("Dan", 5); 
//             SoNguoichoi nguoi6 = new SoNguoichoi("Co", 6); 

//             // Sinh số ngẫu nhiên và xuất kết quả cho mỗi người chơi
//             nguoi1.Randome();
//             nguoi1.Xuat();

//             nguoi2.Randome();
//             nguoi2.Xuat();

//             nguoi3.Randome();
//             nguoi3.Xuat();

//             nguoi4.Randome();
//             nguoi4.Xuat();

//             nguoi5.Randome();
//             nguoi5.Xuat();

//             nguoi6.Randome();
//             nguoi6.Xuat();
//         }
//     }
// }

using System;
namespace Baitap
{
    public class SoNguoichoi
    {
        string Name;
        int Sochon;

        // Constructor để khởi tạo người chơi
        public SoNguoichoi(string name, int sochon)
        {
            Name = name;
            Sochon = sochon;
        }

        // Phương thức xuất kết quả cho người chơi
        public void Xuat(int A)
        {
            if (A == Sochon)
            {
                Console.WriteLine($"{Name} xui qua, ban la nguoi duoc chon rua chen.");
            }
            else
            {
                Console.WriteLine($"{Name}, chuc mung ban khong rua chen.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách người chơi
            SoNguoichoi nguoi1 = new SoNguoichoi("Quan", 1); 
            SoNguoichoi nguoi2 = new SoNguoichoi("Oanh", 2); 
            SoNguoichoi nguoi3 = new SoNguoichoi("Vy", 3); 
            SoNguoichoi nguoi4 = new SoNguoichoi("Huyen", 4); 
            SoNguoichoi nguoi5 = new SoNguoichoi("Dan", 5); 
            SoNguoichoi nguoi6 = new SoNguoichoi("Co", 6); 

            // Sinh số ngẫu nhiên để chọn 1 người
            Random rd = new Random();
            int A = rd.Next(1, 7);
            Console.WriteLine(A); // Sinh số từ 1 đến 6

            // Xuất kết quả cho từng người chơi, dựa trên số được chọn
            nguoi1.Xuat(A);
            nguoi2.Xuat(A);
            nguoi3.Xuat(A);
            nguoi4.Xuat(A);
            nguoi5.Xuat(A);
            nguoi6.Xuat(A);
        }
    }
}

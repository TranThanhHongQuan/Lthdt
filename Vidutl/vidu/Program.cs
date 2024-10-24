using System;

namespace vidu
{
    public class Book
    {
        public string Name { get; set; }
        public static int SIZE = 10;
        string[] authors = new string[SIZE];

        public string[] Authors
        {
            get { return authors; }
            set { authors = value; }
        }

        public Book() { }

        public Book(string name, string[] authors)
        {
            this.Name = name;
            this.Authors = authors;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập tên của sách:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhập số lượng tác giả:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập danh sách tác giả:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Tác giả {0}: ", i + 1);
                Authors[i] = Console.ReadLine();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Tên sách: " + Name);
            Console.WriteLine("Danh sách tác giả:");
            for (int i = 0; i < Authors.Length && Authors[i] != null; i++)
            {
                Console.WriteLine(Authors[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book sach = new Book();
            sach.Nhap();
            sach.Xuat();
        }
    }
}

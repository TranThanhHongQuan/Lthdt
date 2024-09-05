namespace baitaptuan2_mang;
class Program
{
    
    static void Main(string[] args)
    {  
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap so luong phan tu mang A: ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i =0 ; i < n ; i++)
        {
            Console.Write("nhap phan tu mang A: " );
            A[i] = int.Parse(Console.ReadLine());
        }
        // câu 1f

        Array.Sort(A);
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }
        //Câu1b
        Console.WriteLine("Các phần tử mảng A:");
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }

        //câu1c
        int max_A = A[0];
        int min_A = A[0];
        foreach (int i in A)
        {
            if(i > max_A) max_A = i;
            if(i < min_A) min_A = i;
        }
        Console.WriteLine("Phần tử lớn nhất:" + max_A);
        Console.WriteLine("Phần tử nhỏ nhất:"+ min_A);
        // câu 1d
        int so_chan = 0;
        foreach (int i in A)
        {
            if (i % 2 == 0) so_chan++;
        }
        Console.WriteLine("Tổng số phần tử là số chẳn:" + so_chan);

        // câu 1e
        Console.WriteLine("Các số nguyên tố trong mảng A:");
            foreach (int i in A)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool LaSoNguyenTo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
            
    } 

}

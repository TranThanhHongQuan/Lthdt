namespace baitoandemso;
class Program
{
    static void Main(string[] args)
    {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int A;
            Random rd = new Random();
            A = rd.Next(1, 101);
            Console.WriteLine("Nhập vào 1 số B");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Bạn hảy nhập số đoán B: ");
                int B = int.Parse(Console.ReadLine());
                if (B != A)
                {
                    if (B>A)
                    {Console.WriteLine("Bạn đã đoán số lơn hơn giải thưởng :");}
                    else Console.WriteLine("Bạn đã đoán số nhỏ hơn giải thưởng");
                }
                
                else if (B==A)
                {
                    Console.WriteLine("Bạn Đã trúng thưởng: " + B);
                    break;              
                }
                if (i==7)
                {
                    Console.WriteLine("Chúc bạn may mắn lần sau");
                }
                
            }
            Console.WriteLine(A);
    }
}

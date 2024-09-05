Console.WriteLine("Nhap vao hai so nguyen a va b: ");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    TBP(a, b);

    int kq1 = 0;
    TBP2(a, b, ref kq1);
    Console.WriteLine("Ket qua tham so: " + kq1);

    int kq2 = TBP3(a, b);
    Console.WriteLine("Ket qua tra ve: " + kq2);

static void TBP(int a, int b)
{
    int bp = a * a + b * b;
    Console.WriteLine("Tong binh phuong cua " + a + " va " + b + " la: " + bp);
}
static void TBP2(int a, int b, ref int kq)
{
    kq = a * a + b * b;
}

static int TBP3(int a, int b)
{
    return a * a + b * b;
}


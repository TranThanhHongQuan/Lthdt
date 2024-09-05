//Bài 8
Console.OutputEncoding = System.Text.Encoding.UTF8;
int n;
do
{
    Console.Write("Nhập một số nguyên: ");
    n = int.Parse(Console.ReadLine());
} while (n <= 0);

Console.WriteLine("Số nguyên dương vừa nhập là: " + n);
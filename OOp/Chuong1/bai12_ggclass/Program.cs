//Bài 12
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập vào số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());
// a) In các số nguyên từ 1 đến n
Console.WriteLine("Các số nguyên từ 1 đến " + n + " là:");
for (int i = 1; i <= n; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();
// b) Tính tổng và trung bình cộng
int tong = 0;
for (int i = 1; i <= n; i++)
{
    tong += i;
}
double trungBinhCong = (double)tong / n;
Console.WriteLine("Tổng của " + n + " số nguyên dương là: " + tong);
Console.WriteLine("Trung bình cộng của " + n + " số nguyên dương là: " + trungBinhCong);
//Bài 11
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập vào số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());

// a) Tính S1 = 1 + 2 + 3 + ... + n
int S1 = 0;
for (int i = 1; i <= n; i++)
{
    S1 += i;
}
Console.WriteLine("Tổng S1 = 1 + 2 + ... + n là: " + S1);
// b) Tính S2 = 1 + 1/2 + 1/3 + ... + 1/n
double S2 = 0;
for (int i = 1; i <= n; i++)
{
    S2 += 1.0 / i;
}
Console.WriteLine("Tổng S2 = 1 + 1/2 + ... + 1/n là: " + S2);
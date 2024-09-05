//Bài 10
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập vào một năm dương lịch: ");
int n = int.Parse(Console.ReadLine());

bool laNamNhuan = (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);

if (laNamNhuan)
{
    Console.WriteLine(n + " là năm nhuận.");
}
else
{
    Console.WriteLine(n + " không phải là năm nhuận.");
}

//Bài 6
Console.OutputEncoding = System.Text.Encoding.UTF8;
 Console.Write("Nhập hệ số b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Nhập hệ số c: ");
double c = double.Parse(Console.ReadLine());

if (b != 0)
{
    double x = -c / b;
    Console.WriteLine("Nghiem cua phuong trinh la: x = " + x);
}
else
{
    Console.WriteLine(c == 0 ? "Phuong trinh vo so nghiem." : "Phuong trinh vo nghiem.");
}
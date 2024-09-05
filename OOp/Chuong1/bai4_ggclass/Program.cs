Console.WriteLine("Nhap Vao 3 so nguyen ABC");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int max =0;
if (A >= B && A >= C)
        {
            max = A;
        }
        else if (B >= C && B >= A)
        {
            max = B;
        }
        else
        {
            max = C;
        }
Console.WriteLine("Gia tri lon nhat la: " + max);
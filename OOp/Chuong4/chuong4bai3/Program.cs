class Tamgiac
{
    float a,b,c;
    public Tamgiac(float a,float b,float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public Tamgiac(){a = 0;b = 0;c =0;}
    public void Nhap()
    {
        Console.Write("Canh a = ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Canh b = ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Canh c = ");
        c = float.Parse(Console.ReadLine());
    }
   public void Kiemtra()
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Tam giac deu");
            else if (a == b || a == c || b == c)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    Console.WriteLine("Tam giac vuong can");
                else
                    Console.WriteLine("Tam giac can");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                Console.WriteLine("Tam giac vuong");
            else
                Console.WriteLine("Tam giac thuong");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    // public void Xuat()
    // {

    // }
}
class program
{
    static void Main (string[] args)
    {
        Tamgiac tg = new Tamgiac();
        tg.Nhap();
        tg.Kiemtra();
    }
}
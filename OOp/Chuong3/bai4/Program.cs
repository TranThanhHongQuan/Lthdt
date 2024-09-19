using System;

public class dtcv
{
    public float ChuVi { get; set; }
    public float DienTich { get; set; }
    public dtcv(float chuVi, float dienTich)
    {
        ChuVi = chuVi;
        DienTich = dienTich;
    }
}
class tamgiac
{
    public int a;
    public int b;
    public int c;

    public void Nhap()
    {
        Console.Write("a=");
        a=int.Parse(Console.ReadLine());
        Console.Write("b=");
        b=int.Parse(Console.ReadLine());
        Console.Write("c=");
        c=int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("a={0} b={1} c={2} ",a,b,c);
    }
    public dtcv Tinh()
    {
        if (a+b>c && a+c>b && b+c>a)
        {
            float chuvi = a + b + c ;
            float nuacv = chuvi / 2;
            float dientich =(float)Math.Sqrt(nuacv * (nuacv - a) * (nuacv - b) * (nuacv - c));
            return new dtcv(chuvi,dientich);
        }
        else 
        {   
            Console.WriteLine("khong hop le");
            return new dtcv(0f, 0f);
        }
    }
}
class program
{
    static void Main()
    {
        tamgiac tc = new tamgiac();
        bool thoat = true;
        while(thoat)
        {
            Console.WriteLine("Bam 1: Nhap cac canh a b c cua tam giac");
            Console.WriteLine("Bam 2: Tinh chu vi va dien tich cua tam giac");
            Console.WriteLine("Bam 3: Xuat ra gia tri cua a b c");
            Console.WriteLine("Bam 0: chet");
            Console.Write("Nhap menu: ");
            string nhapmenu = Console.ReadLine();
            switch(nhapmenu)
            {
                case 0:
                    thoat = false;
                    break;
                case 1:
                    tc.Nhap();
                    break;
                case 2:
                    dtcv ketqua = tc.Tinh();
                    Console.WriteLine("Dien tich= "+ ketqua.DienTich);
                    Console.WriteLine("Chu vi= "+ ketqua.ChuVi);
                    break;
                case 3:
                    tc.Xuat();
                    break;
            }
        }
    }
}
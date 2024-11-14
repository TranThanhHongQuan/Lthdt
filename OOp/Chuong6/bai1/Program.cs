class Hinhhoc
{

    public virtual void Nhap()
    {
        Console.WriteLine("Nhap thong tin hinh hoc:");
    }
     public virtual void Chuvi()
    {
        Console.Write("Chu vi ");
    }
    public virtual void Dientich()
    {

        
        Console.Write("Dien tich ");
    }
}
class HinhChuNhat:Hinhhoc
{
    public float chieudai;
    public float chieurong;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap chieu dai hcn:");
        chieudai = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong hcn:");
        chieurong= float.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        
        base.Chuvi();
        Console.WriteLine("cua hinh chu nhat la: "+(chieudai+chieurong)*2);
    }
    public new void Dientich()
    {

        Console.WriteLine("Dien tich cua hinh chu nhat la: "+chieudai*chieurong);
    }
}
class Hinhtron:Hinhhoc
{
    public float bankinh;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap ban kinh: ");
        bankinh = float.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
    
        base.Chuvi();
    Console.WriteLine("cua hinh tron la: "+2*bankinh*3.14);
    }
    public override void Dientich()
    {
        
        double dientich = bankinh*bankinh*3.14;
        base.Dientich();
        Console.WriteLine("cua hinh tron la: "+dientich);
    }
}
class Hinhtamgiac:Hinhhoc

{
    public float a;
    public float b;
    public float c;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap vao 3 canh tam giac: ");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        c=float.Parse(Console.ReadLine());

    }
    public override void Chuvi()
    {
    
        base.Chuvi();
    Console.WriteLine("cua hinh tam giac la: "+(a+b+c)/2);
    }
    public override void Dientich()
    {
        
        
        base.Dientich();
        Console.WriteLine("cua hinh tam giac la: "+(Math.Sqrt((a+b+c)/2*((a+b+c)/2-a)*((a+b+c)/2-b)*((a+b+c)/2-c))));
    }
}
class Hinhvuong:Hinhhoc
{
    public float dodaicanh;
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("Nhap canh hinh vuong:");
        dodaicanh = float.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        
        base.Chuvi();
    Console.WriteLine("cua hinh vuong la: "+dodaicanh*4);
    }
    public override void Dientich()
    {
        
        base.Dientich();
        Console.WriteLine("cua hinh vuong la: "+dodaicanh*dodaicanh);
    }
}
class Program
{
    static void Main()
    {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.Nhap();
        hcn.Chuvi();
        hcn.Dientich();
        Hinhtron ht = new Hinhtron();
        ht.Nhap();
        ht.Chuvi();
        ht.Dientich();
        Hinhtamgiac htg = new Hinhtamgiac();
        htg.Nhap();
        htg.Chuvi();
        htg.Dientich();
        Hinhvuong hv = new Hinhvuong();
        hv.Nhap();
        hv.Chuvi();
        hv.Dientich();
}
}
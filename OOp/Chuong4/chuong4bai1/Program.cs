class Phanso
{
    double tuso,mauso;
    public Phanso()
    {
        tuso = 0;
        mauso = 1;
    }
    public  Phanso(double tuso, double mauso)
    {
        this.mauso = mauso;
        this.tuso = tuso;
    }
    public void nhap()
    {
        Console.Write("tuso: ");
        tuso = double.Parse(Console.ReadLine());
        while(true)
        {
            Console.Write("mauso: ");
            mauso = double.Parse(Console.ReadLine());
            if (mauso == 0)
            {
                Console.WriteLine("ERROR!!!");
            }
            else break;
        }
    }
    public Phanso Cong(Phanso ps)
    {
        Phanso kq = new Phanso();
        kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
        kq.mauso = mauso * ps.mauso ;
        return kq;
    }
    public Phanso Tru(Phanso ps)
    {
        Phanso kq = new Phanso(); 
        kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
        kq.mauso = mauso * ps.mauso;
        return kq;
    }
    public Phanso Nhan(Phanso ps)
    {
        Phanso kq = new Phanso();
        kq.tuso= tuso * ps.mauso;
        kq.mauso = mauso * ps.mauso;
        return kq;
    }
    public Phanso Chia(Phanso ps)
    {
        Phanso kq = new Phanso();
        kq.tuso = tuso * ps.mauso;
        kq.mauso = mauso * ps.tuso;
        return kq;
    }
    public void Xuat()
    {
        if (tuso == mauso)
        {
            Console.WriteLine("Ket qua = 1");
        }
        else if (tuso == 0)
        {
            Console.WriteLine("Ket qua = 0");
        }
        else if (mauso == 1)
        {
            Console.WriteLine("Ket qua = {0}", tuso);
        }
        else Console.WriteLine("Ket qua = " + tuso + "/" + mauso);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ps A");
        Phanso phansoA = new Phanso();
        phansoA.nhap();

        Console.WriteLine("ps B");
        Phanso phansoB = new Phanso();
        phansoB.nhap();

        Phanso tong = phansoA.Cong(phansoB);
        Phanso tru = phansoA.Tru(phansoB);
        Phanso chia = phansoA.Chia(phansoB);
        Phanso nhan = phansoA.Nhan(phansoB);
        tong.Xuat();
        tru.Xuat();
        nhan.Xuat();
        chia.Xuat();
    }
}   
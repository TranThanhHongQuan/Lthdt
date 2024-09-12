using System;

class Phanso
{
    double tuso, mauso;

    public Phanso()
    {
        tuso = 0;
        mauso = 1;
    }

    public Phanso(double tuso, double mauso)
    {
        this.mauso = mauso;
        this.tuso = tuso;
    }

    public void Nhap()
    {
        Console.Write("Tử số: ");
        tuso = double.Parse(Console.ReadLine());
        while (true)
        {
            Console.Write("Mẫu số: ");
            mauso = double.Parse(Console.ReadLine());
            if (mauso == 0)
            {
                Console.WriteLine("ERROR: Mẫu số không thể bằng 0!");
            }
            else break;
        }
    }

    public Phanso Cong(Phanso ps)
    {
        Phanso kq = new Phanso();
        kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
        kq.mauso = mauso * ps.mauso;
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
        kq.tuso = tuso * ps.tuso;
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
        if (mauso == 1)
        {
            Console.WriteLine("Kết quả = " + tuso);
        }
        else if (tuso == 0)
        {
            Console.WriteLine("Kết quả = 0");
        }
        else
        {
            Console.WriteLine("Kết quả = " + tuso + "/" + mauso);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Phân số A:");
        Phanso phansoA = new Phanso();
        phansoA.Nhap();

        Console.WriteLine("Phân số B:");
        Phanso phansoB = new Phanso();
        phansoB.Nhap();

        Phanso tong = phansoA.Cong(phansoB);
        Phanso tru = phansoA.Tru(phansoB);
        Phanso nhan = phansoA.Nhan(phansoB);
        Phanso chia = phansoA.Chia(phansoB);

        Console.WriteLine("Tổng hai phân số:");
        tong.Xuat();

        Console.WriteLine("Hiệu hai phân số:");
        tru.Xuat();

        Console.WriteLine("Tích hai phân số:");
        nhan.Xuat();

        Console.WriteLine("Thương hai phân số:");
        chia.Xuat();

        Console.ReadLine(); // Để giữ cửa sổ console mở sau khi chạy
    }
}

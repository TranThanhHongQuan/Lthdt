namespace bai_ktra;
class PhanSo{
    double Tuso;
    double Mauso;
    public PhanSo()
    {
        Tuso = 0;
        Mauso = 1;
    }
    public PhanSo(double Tuso, double Mauso)
    {
        this.Mauso = Mauso;
        this.Tuso = Tuso;
    }

    public void Nhap()
    {
        Console.Write("Tử số: ");
        Tuso = double.Parse(Console.ReadLine());
        while (true)
        {
            Console.Write("Mẫu số: ");
            Mauso = double.Parse(Console.ReadLine());
            if (Mauso == 0)
            {
                Console.WriteLine("ERROR: Mẫu số không thể bằng 0!");
            }
            else break;
        }
    }
    public PhanSo Cong(PhanSo ps){
        PhanSo kq = new PhanSo();
        kq.Tuso = Tuso * ps.Mauso + ps.Tuso * Mauso;
        kq.Mauso = Mauso * ps.Mauso;
        return kq;
    }
    public void Xuat()
    {
        if (Mauso == 1)
        {
            Console.WriteLine("Kết quả = " + Tuso);
        }
        else if (Tuso == 0)
        {
            Console.WriteLine("Kết quả = 0");
        }
        else
        {
            Console.WriteLine("Kết quả = " + Tuso + "/" + Mauso);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Phân số 1:");
        PhanSo phanso1 = new PhanSo();
        phanso1.Nhap();
        
        Console.WriteLine("Phân số 2:");
        PhanSo phanso2 = new PhanSo();
        phanso2.Nhap();

        PhanSo tong = phanso1.Cong(phanso2);

        Console.WriteLine("Tổng hai phân số:");
        tong.Xuat();
    }
}

using System;

class HinhTron
{
    public double BanKinh { get; set; }
    public double DuongKinh => BanKinh * 2;
    public double DienTich => Math.PI * BanKinh * BanKinh;

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }
    public void Xuat()
    {
        Console.Write("Ban kinh: {0}, Duong kinh: {1}, Dien tich: {2}     ",BanKinh, DuongKinh, DienTich);
    }
}

class HinhCau : HinhTron
{
    public new double DienTich { get; set; }
    public double TheTich { get; set; }

    public HinhCau(double banKinh) : base(banKinh)
    {
        TinhDienTich();
        TinhTheTich();
    }

    private void TinhDienTich()
    {
        DienTich = 4 * Math.PI * BanKinh * BanKinh;
    }

    private void TinhTheTich()
    {
        TheTich = (4.0 / 3.0) * Math.PI * BanKinh * BanKinh * BanKinh;
    }
}

class HinhTruTron : HinhTron
{
    public double ChuViMatDay => 2 * Math.PI * BanKinh;
    public double DienTichMatDay => Math.PI * BanKinh * BanKinh;
    public double DienTichXungQuanh => ChuViMatDay * BanKinh;
    public double DienTichToanPhan => DienTichXungQuanh + 2 * DienTichMatDay;
    public double TheTich => DienTichMatDay * BanKinh;

    public HinhTruTron(double banKinh) : base(banKinh)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        HinhCau hinhCau = new HinhCau(3);
        Console.WriteLine("Hinh Cau - Ban Kinh: {0}, Dien Tich: {1}, The Tich: {2}", hinhCau.BanKinh, hinhCau.DienTich, hinhCau.TheTich);

        HinhTruTron hinhTruTron = new HinhTruTron(5);
        Console.WriteLine("Hinh Tru Tron - Ban Kinh: {0}, Chu Vi Mat Day: {1}, Dien Tich Mat Day: {2}, Dien Tich Xung Quanh: {3}, Dien Tich Toan Phan: {4}, The Tich: {5}",
            hinhTruTron.BanKinh, hinhTruTron.ChuViMatDay, hinhTruTron.DienTichMatDay, hinhTruTron.DienTichXungQuanh, hinhTruTron.DienTichToanPhan, hinhTruTron.TheTich);
    }
}
namespace bai1;
class Sach
{
    string TenSach;
    string TacGia;
    int NamXB;
    int SoLuong;
    public void Nhap()
    {
        Console.WriteLine("Nhap TenSach: ");
        TenSach = Console.ReadLine();
        Console.WriteLine("Nhap TacGia: ");
        TacGia = Console.ReadLine();
        Console.WriteLine("Nhap NamXB: ");
        NamXB = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap SoLuong: ");
        SoLuong = int.Parse(Console.ReadLine());
    }
    public void Xuat(){
        Console.WriteLine($"Sach nay co ten la {TenSach} \ttac gia la {TacGia} \tnam suat ban {NamXB} \tso luong {SoLuong}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sach sach1 = new Sach();
        sach1.Nhap();
        sach1.Xuat();
    }
}

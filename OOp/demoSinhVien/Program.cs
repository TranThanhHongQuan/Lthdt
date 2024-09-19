namespace demoSinhVien;
class SinhVien
{
    string MaSv { get; set; }
    string Ten{ get; set; }
    string Ho{ get; set; }
    string Lop{ get; set; }
    double DiemTB{ get; set; }
    public void Nhap()
    {
        Console.Write("Nhap Ma SinhVien: ");
        MaSv = Console.ReadLine();
        Console.Write("Nhap Ten SinhVien: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap Ho SinhVien: ");
        Ho = Console.ReadLine();
        Console.Write("Nhap Lop SinhVien: ");
        Lop = Console.ReadLine();
        Console.Write("Nhap DiemTB sinhVien: ");
        DiemTB = double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Sinh vien: co ma sinh vien {MaSv} ten {Ten} ho {Ho} lop {Lop} diemtb {DiemTB}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=System.Text.Encoding.Unicode;
        SinhVien sv1 = new SinhVien();
        sv1.Nhap();
        sv1.Xuat();
    }
}

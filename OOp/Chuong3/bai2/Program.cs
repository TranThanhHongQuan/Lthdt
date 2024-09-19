namespace bai2;
class Meo{
    string Ten;
    string Giong;
    string GioiTinh;
    float Tuoi;
    public static int Someo = 0;
    public Meo(string ten, string giong, string gioitinh, float tuoi)
    {
        Ten = ten;
        Giong = giong;
        GioiTinh = gioitinh;
        Tuoi = tuoi;
        Someo++;
    }
    public Meo(){
        string ten = "";
        string giong = "";
        string gioitinh = "";
        float tuoi ;
        Someo++;}
    public void nhap()
    {
        Console.Write("Ten: ");
        Ten = Console.ReadLine();
        Console.Write("Giong: ");
        Giong = Console.ReadLine();
        Console.Write("Gioitinh: ");
        GioiTinh = Console.ReadLine();
        Console.Write("Tuoi: ");
        Tuoi = float.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public void xuat()
    {
        Console.WriteLine("Ten: {0}, Giong: {1}, Gioi tinh: {2}, Tuoi:{3}",Ten,Giong,GioiTinh,Tuoi);
    }
    public static int Dem()
    {
        return Someo;
    }
}
class Meomeo
{
    static void Main()
    {
        Meo meo1 = new Meo("Cuco","mun","ducrua",100);
        meo1.xuat();
        Meo meo2 = new Meo();
        meo2.nhap();
        meo2.xuat();
        int dem = Meo.Dem();
        Console.Write("So luong meo la: "+ dem);
    }
}
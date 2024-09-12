namespace Bai_tap_tuan2_Dice;
class dice
{
    public int MatSucSat;
    public int A; // random mat suc sat
    public void Nhap()
    {
        Console.WriteLine("Moi ban nhap mat suc sat");
        MatSucSat = int.Parse(Console.ReadLine());
    }
    public void random()
    {
        Random rd = new Random();
        A = rd.Next(1, MatSucSat +1);
    }
    public void xuat()
    {
        Console.WriteLine("Mat suc sat la: " + A);
    }
}
class Program
{
    static void Main(string[] args)
    {
        dice Nguoi1 = new dice();
        Nguoi1.Nhap();
        Nguoi1.random();
        Nguoi1.xuat();
    }
}

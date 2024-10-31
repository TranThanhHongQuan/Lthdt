using System;
namespace tinhtoan
{
    public class TinhToan{
        public static int Cong2so(int x, int y)
        {
            return x + y;
        }
        public static int Cong3So(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Cong2SoThuc(double a, double b)
        {
            return a + b;
        }
        public static double Cong3SoThuc(double a, double b, double c){
            return a + b + c;
        }
        public static string Cong2Chuoi(string m, string n)
        {
            return m + n;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine($"5+3 = {TinhToan.Cong2so(5,3)}");
        }
    }
}
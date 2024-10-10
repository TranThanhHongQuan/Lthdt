using System;
class TTSV
{
    public string ID, Hoten, Group;
    public static int dem=0;
    public DTP DiemSV;
    public TTSV()
    {
        dem++;
        DiemSV = new DTP();
    }
    public void NhapTTSV()
    {
        
        Console.Write("Nhap Ma Sinh Vien = ");
        ID=Console.ReadLine();
        Console.Write("Nhap Ho Ten Sinh Vien = ");
        Hoten=Console.ReadLine();
        Console.Write("Nhap Lop Sinh Hoat = ");
        Group=Console.ReadLine();
        
    }
    public static void Xuatsoluong()
    {
       Console.WriteLine("so luong sinh vien co trong lop hoc phan OOP: {0}",dem);
        
    }
    public void XuatThongTinVaDiem()
    {
        Console.WriteLine("Ma Sinh Vien: {0}, Ho Ten: {1}, Lop: {2}",ID, Hoten, Group);
        Console.WriteLine("Diem trung binh mon OOP: {0}", DiemSV.TinhdiemTB());
    }
}
class DTP
{
    public double TP1, TP2, TP3;
    public void NhapDTP()
    {
        Console.Write("Nhap diem TP1 = ");
        TP1=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP2 = ");
        TP2=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP3 = ");
        TP3=double.Parse(Console.ReadLine());
    }
    public double TinhdiemTB()
    {
        return TP1*0.1+TP2*0.3+TP3*0.6;
        
    }
    
    
}
class QuanLy
{
    static void Main()
    {
        TTSV sv = new TTSV();
        TTSV sv1 = new TTSV();

        sv.NhapTTSV();
        sv.DiemSV.NhapDTP();
        sv1.NhapTTSV();
        sv1.DiemSV.NhapDTP();

        TTSV.Xuatsoluong();
        sv.XuatThongTinVaDiem();       
        
        sv1.XuatThongTinVaDiem();
    }
}
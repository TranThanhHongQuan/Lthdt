/*
Bài 5: Xây dựng lớp Doanhnghiep gồm các thuộc tính: TenDN,
MST, Diachi lần lượt là Tên doanh nghiệp, Mã số thuế, Địa chỉ
của doanh nghiệp đó.
Từ đó xây dựng lớp DanhsachDN (Danh sách doanh nghiệp)
với các phương thức:
 Nhập danh sách doanh nghiệp
 Xuất danh sách doanh nghiệp
 Tìm mã số thuế theo tên doanh nghiệp (chỉ mục )
 Tìm tên doanh nghiệp và địa chỉ doanh nghiệp theo mã số
thuế (chỉ mục )
*/

using System;
namespace Vidu{
    public class DoanhNgiep{
        public string TenDN { get; set; }
        public string MST { get; set; }
        public string DiaChi { get; set; }
        public DoanhNgiep(string TenDN, string MST, string DiaChi)
        {
            this.TenDN = TenDN;
            this.MST = MST;
            this.DiaChi = DiaChi;
        }
        
    }
    public class DanhsachDn
    {
            private List<DoanhNgiep> ListDanhNghiep = new List<DoanhNgiep>();
            public void Nhap(){
            System.Console.WriteLine("Nhap so luong doanh nghiep");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n;i++)
            {
                System.Console.WriteLine("Nhap Ten doanh nghiep " + i);
                string TenDN = Console.ReadLine();
                System.Console.WriteLine("Nhap MST doanh nghiep " +i);
                string MST = Console.ReadLine();
                System.Console.WriteLine("Nhap diachi doanh nghiep " +i);
                string DiaChi = Console.ReadLine();

                DoanhNgiep dn = new DoanhNgiep(TenDN, MST, DiaChi);
                ListDanhNghiep.Add(dn);
            }
            }
            public void In()
            {
                Console.WriteLine("\nDanh sách các doanh nghiệp:");
                foreach (var dn in ListDanhNghiep)
                {
                    Console.WriteLine($"Tên: {dn.TenDN}, MST: {dn.MST}, Địa chỉ: {dn.DiaChi}");
                }
            }
            public void TimMST(){
                Console.WriteLine("Nhap ten doanh nghiep ban muon tim: ");
                string a = Console.ReadLine();
                bool Check = false;
                foreach (var dn in ListDanhNghiep)
                {
                    if (dn.TenDN == a)
                    {
                        System.Console.WriteLine($"Doanh nghiep co ten la: {a} có ma so thue la: {dn.MST}");
                        Check = true;
                    }
                }
                if (!Check)
                {
                    System.Console.WriteLine("Khong tim thay doanh nghiep");
                }
            }
            public void TimTen(){
                Console.WriteLine("Nhap Ma so thue ban muon tim: ");
                string a = Console.ReadLine();
                bool Check = false;
                foreach (var dn in ListDanhNghiep )
                {
                    if (dn.MST== a)
                    {
                        System.Console.WriteLine($"Tim Thay doanh nghiep:{dn.TenDN}, MST: {dn.MST}, dai chi: {dn.DiaChi}");
                        Check = true;
                    }
                    
                }
                if (!Check)
                    {
                        System.Console.WriteLine("khong tim thay ten doanh nghiep qua ma so thue");
                    }
            }
        }
    
    class Program{
        static void Main(string[] args) {
            DanhsachDn dn1 = new DanhsachDn();
            dn1.Nhap();
            dn1.In();
            dn1.TimMST();
            dn1.TimTen();
        }
    }
}
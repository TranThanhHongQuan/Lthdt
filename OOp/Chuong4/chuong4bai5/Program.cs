using System;
using System.Collections.Generic;
using System.Linq;
namespace Bai5
{
    class DoanhNghiep
    {
        public string tendn{set;get;}
        public string diachi{set;get;}
        public string mst {set;get;}
        
        public DoanhNghiep (string Tendn,string Diachi,string Mst)
        {
            tendn = Tendn;
            diachi = Diachi;
            mst = Mst;
        }
        
    }
    class danhsachdn
    {
        private List<DoanhNghiep> danhsach = new List<DoanhNghiep>();
       public void Nhap()
       {
            Console.Write("Ten Doanh Nghiep: \t");
            string Tendn = Console.ReadLine();
            Console.Write("Dia Chi: \t");
            string Diachi = Console.ReadLine();
            Console.Write("Ma So Thue: \t");
            string Mst = (Console.ReadLine());
            DoanhNghiep dn = new DoanhNghiep(Tendn,Diachi,Mst);
            danhsach.Add(dn);
       }
        public void XuatDanhSach()
        {
        Console.WriteLine("Danh sach doanh nghiep:");
        foreach (var dn in danhsach)
            {
                Console.WriteLine("Ten Doanh Nghiep: \t" + dn.tendn);
                Console.WriteLine("Ma So Thue: \t\t" + dn.mst);
                Console.WriteLine("Dia Chi: \t\t" + dn.diachi);
                Console.WriteLine();
            }
        }
        public string TimmstTheoTendn(string Tendn)
        {
            var DN = danhsach.FirstOrDefault(dn => dn.tendn == Tendn);
            return DN != null ? DN.mst : "Khong tim thay";
        }
        public string Timtentheomst(string Mst)
        {
            var Dn = danhsach.FirstOrDefault(dn => dn.mst == Mst);
            return Dn != null ? Dn.tendn : "Khong tim thay";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            danhsachdn dn = new danhsachdn();
            dn.Nhap();
            dn.XuatDanhSach();
            var doanhNghiep = new List<DoanhNghiep>()
            {
                new DoanhNghiep ("Quan" , "dien nam bac", "1111"),
                new DoanhNghiep ("Cau" , "dien nam dong", "2222"),
                new DoanhNghiep ("Buoi" , "dien nam tay", "3333"),
                new DoanhNghiep ("Dau" , "dien nam trung", "4444"),
                new DoanhNghiep ("No" , "dien nam thang", "5555"),
                new DoanhNghiep ("Le" , "dien nam bac", "6666"),
                new DoanhNghiep ("Hoa" , "dien nam dong", "7777"),

            };
            Console.Write("Nhap ten Doanh Nghiep can tim MST: ");
            string tendn = Console.ReadLine();
            var DN = doanhNghiep.FirstOrDefault(dn => dn.tendn == tendn);

            if (DN != null)
            {
                Console.WriteLine("Ma So Thue: " + DN.mst);
            }
            else
            {
                string msth = dn.TimmstTheoTendn(tendn);

                if (!string.IsNullOrEmpty(msth))
                {
                    Console.WriteLine("Ma So Thue: " + msth);
                }
                else
                {
                    Console.WriteLine("Khong tim thay Doanh Nghiep co ten " + tendn);
                }
            }
            Console.Write("Nhap MST de tim ten doanh nghiep: ");
            string Mst = Console.ReadLine();
            var Dn = doanhNghiep.FirstOrDefault(dn => dn.mst == Mst);

            if (Dn != null)
            {
                Console.WriteLine("Ten Doanh Ngiep {0} Va Dia Chi {1}: " ,Dn.tendn, Dn.diachi);
            }
            else
            {
                string tendnn = dn.TimmstTheoTendn(Mst);

                if (!string.IsNullOrEmpty(tendnn))
                {
                    Console.WriteLine("Ten Doanh Ngiep {0} Va Dia Chi {1}: " ,tendnn, Dn.diachi);
                }
                else
                {
                    Console.WriteLine("Khong tim thay Doanh Nghiep co mst " + Mst);
                }
            }

        }
    
    }
}

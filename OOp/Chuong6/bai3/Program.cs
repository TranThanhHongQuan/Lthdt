using System;
using System.Collections.Generic;

namespace QuanLyBanIn
{
    abstract class BanIn : IComparable<BanIn>
    {
        public string TieuDe { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }

        public int CompareTo(BanIn khac)
        {
            return string.Compare(this.TacGia, khac.TacGia);
        }
    }

    class Sach : BanIn
    {
        public string NhaXuatBan { get; set; }
    }

    class BaiBao : BanIn
    {
        public string TapChi { get; set; }
    }

    class TaiNguyenTrucTuyen : BanIn
    {
        public string Link { get; set; }
        public string TomTat { get; set; }
    }

    class ChuongTrinh
    {
        static void Main(string[] args)
        {
            BanIn[] banIns = new BanIn[]
            {
                new Sach { TieuDe = "Sach bao cong", TacGia = "Tac Gia quan", NamXuatBan = 2023, NhaXuatBan = "Nha Xuat Ban" },
                new BaiBao { TieuDe = "Bai Bao vip", TacGia = "Tac Gia co", NamXuatBan = 2022, TapChi = "Tap Chi " },
                new TaiNguyenTrucTuyen { TieuDe = "Tai Nguyen Truc Tuyen ", TacGia = "Tac Gia dau to", NamXuatBan = 2021, Link = "Link facebook", TomTat = "Tom Tat" }
            };
            foreach (BanIn banIn in banIns)
            {
                Console.WriteLine($"Tieu de: {banIn.TieuDe}");
                Console.WriteLine($"Tac gia: {banIn.TacGia}");
                Console.WriteLine($"Nam xuat ban: {banIn.NamXuatBan}");

                if (banIn is Sach)
                {
                    Sach sach = (Sach)banIn;
                    Console.WriteLine($"Nha xuat ban: {sach.NhaXuatBan}");
                }
                else if (banIn is BaiBao)
                {
                    BaiBao baiBao = (BaiBao)banIn;
                    Console.WriteLine($"Tap chi: {baiBao.TapChi}");
                }
                else if (banIn is TaiNguyenTrucTuyen)
                {
                    TaiNguyenTrucTuyen taiNguyen = (TaiNguyenTrucTuyen)banIn;
                    Console.WriteLine($"Link: {taiNguyen.Link}");
                    Console.WriteLine($"Tom tat: {taiNguyen.TomTat}");
                }

                Console.WriteLine();
            }
            Array.Sort(banIns);
            Console.WriteLine("cac ban in da duoc sap xep theo tac gia:");
            foreach (BanIn banIn in banIns)
            {
                Console.WriteLine($"Tieu de: {banIn.TieuDe}");
                Console.WriteLine($"Tac gia: {banIn.TacGia}");
                Console.WriteLine($"Nam xuat ban: {banIn.NamXuatBan}");
                Console.WriteLine();
            }
            string tacGiaTimKiem = "Tac Gia quan";
            List<BanIn> banInsTimKiem = new List<BanIn>();
            foreach (BanIn banIn in banIns)
            {
                if (banIn.TacGia.Equals(tacGiaTimKiem))
                {
                    banInsTimKiem.Add(banIn);
                }
            }
            Console.WriteLine($"cac ban in duoc tim kiem theo tac gia <{tacGiaTimKiem }>:");
            foreach (BanIn banIn in banInsTimKiem)
            {
                Console.WriteLine($"Tieu de: {banIn.TieuDe}");
                Console.WriteLine($"Tac gia: {banIn.TacGia}");
                Console.WriteLine($"Nam xuat ban: {banIn.NamXuatBan}");
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTapNgay
{
    public abstract class PhongHoc
    {
        public string MaPhong { get; set; }
        public string DayNha { get; set; }
        public double DienTich { get; set; }
        public int SoBD { get; set; }

        public abstract string DanhGia();

        // Constructor mặc định và có tham số
        public PhongHoc() { }

        public PhongHoc(string MaPhong, string DayNha, double DienTich, int SoBD)
        {
            this.MaPhong = MaPhong;
            this.DayNha = DayNha;
            this.DienTich = DienTich;
            this.SoBD = SoBD;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập mã phòng: ");
            MaPhong = Console.ReadLine();
            Console.Write("Nhập tòa nhà: ");
            DayNha = Console.ReadLine();
            Console.Write("Nhập diện tích: ");
            DienTich = double.Parse(Console.ReadLine());
            Console.Write("Nhập số bóng đèn: ");
            SoBD = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Mã phòng: {MaPhong}, Tòa nhà: {DayNha}, Diện tích: {DienTich} m², Số bóng đèn: {SoBD}";
        }
    }

    public class PhongLyThuyet : PhongHoc
    {
        public int MayChieu { get; set; }

        public PhongLyThuyet() { }

        public PhongLyThuyet(string MaPhong, string DayNha, double DienTich, int SoBD, int MayChieu)
            : base(MaPhong, DayNha, DienTich, SoBD)
        {
            this.MayChieu = MayChieu;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số máy chiếu: ");
            MayChieu = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $", Số máy chiếu: {MayChieu}, Đánh giá: {DanhGia()}";
        }

        public override string DanhGia()
        {
            if (DienTich < 0 || SoBD < 0)
            {
                return "Dữ liệu không hợp lệ";
            }
            bool Asang = (DienTich / SoBD) <= 10;
            bool Maychieu = MayChieu > 0;
            return Asang && Maychieu ? "Đạt chuẩn" : "Không đạt chuẩn";
        }
    }

    public class PhongThucHanh : PhongHoc
    {
        public int MayTinh { get; set; }

        public PhongThucHanh() { }

        public PhongThucHanh(string MaPhong, string DayNha, double DienTich, int SoBD, int MayTinh)
            : base(MaPhong, DayNha, DienTich, SoBD)
        {
            this.MayTinh = MayTinh;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số máy tính: ");
            MayTinh = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $", Số máy tính: {MayTinh}, Đánh giá: {DanhGia()}";
        }

        public override string DanhGia()
        {
            if (DienTich < 0 || MayTinh < 0)
            {
                return "Dữ liệu không hợp lệ";
            }
            bool KiemTraDienTich = (DienTich / MayTinh) >= 1.5;
            return KiemTraDienTich ? "Đạt chuẩn" : "Không đạt chuẩn";
        }
    }

    public class DaiHoc
    {
        public List<PhongHoc> DsPhongHoc { get; set; } = new List<PhongHoc>();

        public void AddPh(PhongHoc ph)
        {
            DsPhongHoc.Add(ph);
        }

        public void HienThiThongTin()
        {
            foreach (var ph in DsPhongHoc)
            {
                Console.WriteLine(ph);
            }
        }

        public PhongHoc TimKiem(string maPhong)
        {
            foreach (var ph in DsPhongHoc)
            {
                if (ph.MaPhong == maPhong)
                {
                    return ph;
                }
            }
            return null;
        }

        public int TongSoPhong()
        {
            return DsPhongHoc.Count();
        }

        public double TongDTPTH()
        {
            double Tongdt = 0;
            foreach (var ph in DsPhongHoc.OfType<PhongThucHanh>())
            {
                Tongdt += ph.DienTich;
            }
            return Tongdt;
        }

        public void InPhongDatChuan()
        {
            var DsPhongDatchuan = DsPhongHoc.Where(ph => ph.DanhGia() == "Đạt chuẩn");
            foreach (var phonghoc in DsPhongDatchuan)
            {
                Console.WriteLine(phonghoc);
            }
        }

        public void InDsPhongTren40()
        {
            var DsPhongTren40may = DsPhongHoc.OfType<PhongThucHanh>().Where(ph => ph.MayTinh > 40);
            foreach (var phonghoc in DsPhongTren40may)
            {
                Console.WriteLine(phonghoc);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DaiHoc daihoc1 = new DaiHoc();
            daihoc1.AddPh(new PhongThucHanh("P101", "A", 50, 10, 45));
            daihoc1.AddPh(new PhongThucHanh("P102", "A", 60, 12, 30));  
            daihoc1.AddPh(new PhongLyThuyet("P103", "B", 45, 8, 2));    
            daihoc1.AddPh(new PhongThucHanh("P104", "B", 70, 15, 50));  
            daihoc1.AddPh(new PhongLyThuyet("P105", "C", 40, 7, 1));    
            daihoc1.AddPh(new PhongThucHanh("P106", "C", 55, 11, 40));  
            daihoc1.AddPh(new PhongThucHanh("P107", "D", 65, 13, 35));  
            daihoc1.AddPh(new PhongLyThuyet("P108", "D", 50, 10, 3));   
            daihoc1.AddPh(new PhongThucHanh("P109", "E", 75, 14, 60));  
            daihoc1.AddPh(new PhongLyThuyet("P110", "E", 35, 6, 0));
            int chon = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("======== MENU ========");
                Console.WriteLine("1. Thêm phòng học vào danh sách phòng học.");
                Console.WriteLine("2. Hiển thị tất cả thông tin trong danh sách phòng học.");
                Console.WriteLine("3. Tìm kiếm phòng học theo mã phòng học được chỉ định có trong danh sách phòng học.");
                Console.WriteLine("4. Tính tổng số phòng học.");
                Console.WriteLine("5. Tính tổng diện tích của các phòng thực hành.");
                Console.WriteLine("6. In danh sách các phòng học đạt chuẩn.");
                Console.WriteLine("7. In danh sách phòng thực hành có số máy trên 40.");
                Console.WriteLine("8. Thoát.");
                Console.WriteLine("======================");
                Console.Write("Nhập lựa chọn của bạn: ");
                // Nhập lựa chọn
                while (!int.TryParse(Console.ReadLine(), out chon) || chon < 1 || chon > 8)
                {
                    Console.Write("Lựa chọn không hợp lệ. Vui lòng nhập lại: ");
                }

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1. Phòng lý thuyết");
                        Console.WriteLine("2. Phòng thực hành");
                        int type;
                        while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2))
                        {
                            Console.Write("Lựa chọn không hợp lệ. Nhập lại: ");
                        }
                        PhongHoc ph;
                        if (type == 1)
                            ph = new PhongLyThuyet();
                        else
                            ph = new PhongThucHanh();
                        ph.Nhap();
                        daihoc1.AddPh(ph);
                        break;

                    case 2:
                        daihoc1.HienThiThongTin();
                        break;

                    case 3:
                        Console.Write("Nhập mã phòng cần tìm: ");
                        string maPhong = Console.ReadLine();
                        var found = daihoc1.TimKiem(maPhong);
                        if (found != null)
                        {
                            Console.WriteLine(found);
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phòng.");
                        }
                        break;

                    case 4:
                        int totalRooms = daihoc1.TongSoPhong();
                        Console.WriteLine($"Tổng số phòng học: {totalRooms}");
                        break;

                    case 5:
                        double totalArea = daihoc1.TongDTPTH();
                        Console.WriteLine($"Tổng diện tích phòng thực hành: {totalArea}");
                        break;

                    case 6:
                        daihoc1.InPhongDatChuan();
                        break;

                    case 7:
                        daihoc1.InDsPhongTren40();
                        break;

                    case 8:
                        return; // Dừng chương trình và thoát khỏi vòng lặp
                }

                // Đợi người dùng nhấn Enter để quay lại menu
                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
            }
        }
    }
}


namespace thigk
{
    public class BenhNhan
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public double TienThuoc { get; set; }

        public BenhNhan(string Ma, string HoTen, double TienThuoc)
        {
            this.Ma = Ma;
            this.HoTen = HoTen;
            this.TienThuoc = TienThuoc;
        }

        public BenhNhan() {}
        public virtual void Nhap()
        {
            System.Console.WriteLine("Nhập mã bệnh nhân:");
            Ma = System.Console.ReadLine();

            System.Console.WriteLine("Nhập tên bệnh nhân:");
            HoTen = System.Console.ReadLine();
            while (true)
            {
                System.Console.WriteLine("Nhập tiền thuốc bệnh nhân:");
                string input = Console.ReadLine();
                
                if (double.TryParse(input, out double tienThuoc) && tienThuoc >= 0)
                {
                    TienThuoc = tienThuoc;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Tiền thuốc không hợp lệ vui lòng nhập lại! Vui lòng nhập một số lớn hơn hoặc bằng 0.");
                }
            }
        }

        public override string ToString()
        {
            return $"Mã bệnh nhân: {Ma}, Họ tên: {HoTen}, Tiền thuốc: {TienThuoc} VNĐ";
        }

        public virtual double TinhVienPhi()
        {
            return TienThuoc;
        }
    }

    public class BNNgoaiTru : BenhNhan
    {
        public double PhiKham { get; set; }
        public double PhiXetNghiem { get; set; }

        public BNNgoaiTru(string Ma, string HoTen, double TienThuoc, double phiKham, double phiXetNghiem)
            : base(Ma, HoTen, TienThuoc)
        {
            this.PhiKham = phiKham;
            this.PhiXetNghiem = phiXetNghiem;
        }

        public BNNgoaiTru() {}

        public override void Nhap()
        {
            base.Nhap();
            System.Console.WriteLine("Nhập phí khám:");
            PhiKham = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Nhập phí xét nghiệm:");
            PhiXetNghiem = double.Parse(System.Console.ReadLine());
        }

        public override double TinhVienPhi()
        {
            return TienThuoc + PhiKham + PhiXetNghiem;
        }
        public override string ToString()
        {
            return base.ToString() + $", Viện phí: {TinhVienPhi()} VNĐ";
        }
    }

    public class BNNoiTru : BenhNhan
    {
        public double PhiNgay { get; set; }
        public double SoNgayNamVien { get; set; }
        
        public BNNoiTru(string Ma, string HoTen, double TienThuoc, double phiNgay, double soNgayNamVien)
            : base(Ma, HoTen, TienThuoc)
        {
            this.PhiNgay = phiNgay;
            this.SoNgayNamVien = soNgayNamVien;
        }

        public BNNoiTru() {}

        public override void Nhap()
        {
            base.Nhap();
            System.Console.WriteLine("Nhập phí ngày:");
            PhiNgay = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Nhập số ngày nằm viện:");
            SoNgayNamVien = double.Parse(System.Console.ReadLine());
        }

        public override double TinhVienPhi()
        {
            double phuPhi = SoNgayNamVien < 10 ? 50 : 100;
            return (TienThuoc * SoNgayNamVien) + (PhiNgay * SoNgayNamVien) + phuPhi;
        }
        public override string ToString()
        {
            return base.ToString() + $", Viện phí: {TinhVienPhi()} VNĐ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BenhNhan bn1 = new BenhNhan();
            BenhNhan benhNhan = new BenhNhan("2200", "Trần Thành Hồng Quân", 500000);
            System.Console.WriteLine(benhNhan.ToString());
            bn1.Nhap();
            System.Console.WriteLine(bn1.ToString());

            BNNgoaiTru bn2 = new BNNgoaiTru();
            bn2.Nhap();
            System.Console.WriteLine(bn2.ToString());

            BNNoiTru bn3 = new BNNoiTru();
            bn3.Nhap();
            System.Console.WriteLine(bn3.ToString());      
        }
    }
}


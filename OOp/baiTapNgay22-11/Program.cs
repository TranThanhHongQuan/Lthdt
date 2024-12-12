namespace BenhVien{

    public interface IBenhNhan
    {
        double VienPhi();// phương thức trừu tượng
        
    }
    public class BenhNhan : IBenhNhan
    {
        public int Ma{ get; set; }
        public string HoTen{ get; set; }
        public double TienThuoc{ get; set; }
        public virtual double VienPhi(){
            return TienThuoc;
        }
        public BenhNhan(int Ma, string HoTen, double TienThuoc)
        {
            this.Ma = Ma;
            this.HoTen = HoTen;
            this.TienThuoc = TienThuoc;
        }
        public BenhNhan(){}

        public virtual void Nhap(){
            Console.WriteLine("Nhập mã bệnh nhân");
            Ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ và tên bệnh nhân");
            HoTen = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("Nhập tiền thuốc bệnh nhân");
                TienThuoc = double.Parse(Console.ReadLine());
                if(TienThuoc > 0)
                {
                    break;
                }
                else Console.WriteLine("Nhập lại tiền thuốc");
            }
            
        }
        public override string ToString(){
            return $"\nBệnh nhân có mã: {Ma}\n"+
            $"Họ tên: {HoTen}\n"+
            $"Tiền thuốc: {TienThuoc}";
        }
    }



    public class BNNgoaiTru : BenhNhan
    {
        public double phiXetNghiem{ get; set; }
        public double PhiKham{ get; set; }
        public BNNgoaiTru(int Ma, string HoTen, double TienThuoc, double PhiKham,double phiXetNghiem) : base (Ma,HoTen,TienThuoc) {
            this.phiXetNghiem = phiXetNghiem;
            this.PhiKham = PhiKham;
        }
        public BNNgoaiTru(){}
        public override void Nhap(){
            base.Nhap ();
            while(true)
            {
                Console.Write("Nhập Phí Khám:");
                PhiKham = double.Parse(Console.ReadLine());
                if(PhiKham > 0){
                    break;
                }
                else
                {
                    Console.WriteLine("Phí khám không hợp lệ đề nghị nhập lại");
                }
            }
            Console.Write("Nhập phí xét nghiệm");
            phiXetNghiem = double.Parse(Console.ReadLine());
        }
        public override double VienPhi()
        {
            return base.VienPhi() + phiXetNghiem + PhiKham;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nViện phí là: {VienPhi()}";
        }
    }
    public class BNNoiTru : BenhNhan{
        public double PhiNgay { get; set; }
        public double SoNgayNamVien{ get; set;}
        double PhuPhi{ get; set;}


        public BNNoiTru(int Ma,string HoTen,double TienThuoc,double PhiNgay,double SoNgayNamVien):base(Ma,HoTen,TienThuoc)
        {
            this.PhiNgay = PhiNgay;
            this.SoNgayNamVien = SoNgayNamVien;
            if (SoNgayNamVien > 0 && SoNgayNamVien < 10)
                {
                    PhuPhi = 50;
                }
                else
                {
                    PhuPhi = 100;
                }
        }
        public BNNoiTru(){}
        public override double VienPhi(){
            return base.VienPhi() * SoNgayNamVien + PhiNgay * SoNgayNamVien + PhuPhi;
        }
        public override string ToString(){
            return base.ToString() +
               $"\nPhí ngày: {PhiNgay}" +
               $"\nSố ngày nằm viện: {SoNgayNamVien}" +
               $"\nPhụ phí: {PhuPhi}" +
               $"\nViện phí: {VienPhi()}";
        }
    }
    public class BenhVienn{
        public List<BenhNhan> DSBenhNhan { get; set; }
        public BenhVienn()
        {
            DSBenhNhan = new List<BenhNhan>();
        }
        //thêm bệnh nhân
        public void ThemBN(BenhNhan bn)
        {
            DSBenhNhan.Add(bn);
        }
        //in bệnh nhân
        public void In()
        {
            foreach (var bn in DSBenhNhan)
            {
                System.Console.WriteLine(bn);
            }
        }
        // tổng tiền viện phí
        public void TongVienPhi(){
            double Tong = 0;
            foreach (var bn in DSBenhNhan)
            {
                Tong = Tong + bn.VienPhi();
            }
            System.Console.WriteLine("\nTổng viện phí tất cả bệnh nhân là: "+Tong);
        }
    }
    
    class Program{
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            BenhNhan bn1 = new BenhNhan();


            BNNgoaiTru bnnt1 = new BNNgoaiTru(101,"Trần Thành Hồng Quân",100,100,100);
            System.Console.WriteLine(bnnt1.ToString());

            BNNoiTru b2 = new BNNoiTru(102,"Trần Thành Hồng Quân",100,100,100);
            System.Console.WriteLine(b2.ToString());

            BenhVienn bv1 = new BenhVienn();
            bv1.ThemBN(b2);
            bv1.ThemBN(bnnt1);
            bv1.ThemBN(new BNNoiTru(103,"Thải Độc",100,100,100));
            bv1.In();
            bv1.TongVienPhi();
            
        }
    }
}

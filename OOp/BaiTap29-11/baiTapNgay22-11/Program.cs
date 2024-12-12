/*
Trường Đại học ABC xây dựng một chương trình quản lý phòng học với các lớp
được mô tả như bên dưới. Các lớp tạo ra phải chứa property, phương thức khởi tạo (có
đối số và không đối số), ghi đè phương thức ToString() để trả về tất cả thông tin của lớp.
Câu 1 (1.0 điểm): Định nghĩa lớp trừu tượng PhongHoc với thuộc tính là mã phòng
(String), dãy nhà (String), diện tích (double), số bóng đèn (int). Lớp này chứa phương
thức trừu tượng String DanhGia() và phương thức Nhap() để nhập các thuộc tính của
lớp từ bàn phím.
Câu 2 (1.5 điểm): Định nghĩa lớp PhongLyThuyet kế thừa từ lớp PhongHoc và có
thêm thuộc tính máy chiếu (int). Phương thức String DanhGia() được cài đặt như sau:
Nếu đủ ánh sáng (trung bình <=10m2/ bóng đèn) và có máy chiếu thì ghi là “Đạt chuẩn”,
ngược lại “Không đạt chuẩn”. Thực hiện ghi đè phương thức Nhap() để nhập các thuộc
tính của lớp từ bàn phím.
Câu 3 (1.5 điểm): Định nghĩa lớp PhongThucHanh kế thừa từ lớp PhongHoc với các
thuộc tính số lượng máy tính (int). Phương thức String DanhGia() được cài đặt theo
hướng dẫn sau: nếu trung bình>=1.5m2

/ máy thì ghi là “Đạt chuẩn”, ngược lại
“Không đạt chuẩn”. Thực hiện ghi đè phương thức Nhap() để nhập các thuộc tính của
lớp từ bàn phím.
Câu 4 (4 điểm): Định nghĩa lớp DaiHoc có thuộc tính là danh sách phòng học
(DSPhongHoc) và có các chức năng sau:
a. Thêm phòng học vào danh sách phòng học.
b. Hiển thị tất cả thông tin trong danh sách phòng học.
c. Tìm kiếm phòng học theo mã phòng học được chỉ định có trong danh sách phòng
học.
d. Tính tổng số phòng học.
e. Tính tổng diện tích của các phòng thực hành.
f. In danh sách các phòng học đạt chuẩn.
g. In danh sách phòng thực hành có số máy trên 40.

h. Sắp xếp danh sách tăng dần theo diện tích, nếu cùng diện tích thì xếp giảm dần
theo số bóng đèn.
Câu 5 (2.0 điểm): Tạo lớp Program.cs chứa phương thức Main() thực hiện tạo một đối
tượng cho lớp DaiHoc. Khởi tạo thuộc tính DSPhongHoc và gọi thực thi các các phương
thức của lớp này thông qua menu.
*/
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class PhongHoc{
    public string MaPhong { get; set; }
    public string DayNha {get; set;}
    public double DienTich {get; set; }
    public int BongDen {get; set;}
    public PhongHoc(string MaPhong, string DayNha, double DienTich, int BongDen){
        this.MaPhong = MaPhong;
        this.DayNha = DayNha;
        this.BongDen = BongDen;
        this.DienTich = DienTich;
    }
    public PhongHoc(){}
    public abstract string DanhGia();
    public virtual void  Nhap(){
        System.Console.WriteLine("Nhập Mã Phòng");
        MaPhong = Console.ReadLine();
        System.Console.WriteLine("Nhập dãy nhà");
        DayNha = Console.ReadLine();
        System.Console.WriteLine("Nhập diện tích");
        DienTich = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhập bóng đèn");
        BongDen = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return $"Mã phòng là {MaPhong}, có dãy nhà {DayNha},  có diện tích là {DienTich},có bóng đèn {BongDen}";
    }
}
class PhongLyThuyet : PhongHoc {
    public int Maychieu { get; set; }
    public PhongLyThuyet(){}
    public PhongLyThuyet(string MaPhong, string DayNha, double DienTich, int BongDen,int Maychieu ): base (MaPhong,DayNha,DienTich,BongDen){
        this.Maychieu = Maychieu;
    }
    public override string DanhGia()
    {
        bool duAnhSang = (DienTich / BongDen) <= 10;
        return duAnhSang && Maychieu > 0 ? "đạt chuẩn" : "không đạt chuẩn";
    }
    public override void Nhap(){
        base.Nhap();
        System.Console.WriteLine("Nhập số lượng máy chiếu");
        Maychieu = int.Parse(Console.ReadLine());
    }
   public override string ToString()
    {
        return base.ToString() + $" Số lượng máy chiếu: {Maychieu}, Đánh giá: {DanhGia()}";
    }

}
public class PhongThucHanh : PhongHoc{
    public int SoLuongMayTinh { get; set; }
    public PhongThucHanh(){}
    public PhongThucHanh(string MaPhong, string DayNha, double DienTich, int BongDen,int SoLuongMayTinh ): base (MaPhong,DayNha,DienTich,BongDen){
        this.SoLuongMayTinh = SoLuongMayTinh;
    }
    public override string DanhGia()
    {
        bool danhGia = (DienTich/SoLuongMayTinh) >= 1.52;
        return danhGia && SoLuongMayTinh > 0 ? "Đạt chuẩn" : "Không Đạt chuẩn";
    }
    public override void Nhap()
    {
        base.Nhap();
        System.Console.WriteLine( "Nhập Số lượng máy tính:");
        SoLuongMayTinh = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
        return base.ToString() + $" Số lượng máy tính: {SoLuongMayTinh}, Đánh giá: {DanhGia()}";
    }

}
public class DaiHoc{
    public List<PhongHoc> DSPhongHoc{get;set;} = new List<PhongHoc>();
    public void AddPhongHoc(PhongHoc ph)
    {
        DSPhongHoc.Add(ph);
    }
    public void HienThiThongTin()
    {
        foreach(var ph in DSPhongHoc)
        {
            System.Console.WriteLine(ph);
        }
    }
    public PhongHoc TimKiem(string maPhong)
    {
        foreach(var ph in DSPhongHoc){
            if(ph.MaPhong == maPhong) return ph;
        }
        return null;
    }
    public int TongSoPhongHoc()
    {
        return DSPhongHoc.Count();
    }

    public double TongDienTichPhongThucHanh()
    {        
        double TongDt = 0;
        foreach (var ph in DSPhongHoc.OfType<PhongThucHanh>()) 
        {
            TongDt += ph.DienTich;
        }
        return TongDt;
    }
    public void InPhongHocDatChuan()
    {
        var dsDatChuan = DSPhongHoc.Where(ph => ph.DanhGia() == "Đạt chuẩn");
        foreach (var phongHoc in dsDatChuan)
        {
            Console.WriteLine(phongHoc);
        }
    }
    public void InPhongThucHanhTren40May()
    {
        var dsPhong = DSPhongHoc.OfType<PhongThucHanh>().Where(ph => ph.SoLuongMayTinh > 40);
        foreach (var phongHoc in dsPhong)
        {
            Console.WriteLine(phongHoc);
        }
        
    }
    public void SapXep()
    {
        DSPhongHoc = DSPhongHoc.OrderBy(ph => ph.DienTich).ThenByDescending(ph => ph.BongDen).ToList();
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        DaiHoc daiHoc = new DaiHoc();

        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Thêm phòng học");
            Console.WriteLine("2. Hiển thị danh sách phòng học");
            Console.WriteLine("3. Tìm kiếm phòng học");
            Console.WriteLine("4. Tính tổng số phòng học");
            Console.WriteLine("5. Tính tổng diện tích phòng thực hành");
            Console.WriteLine("6. In danh sách phòng học đạt chuẩn");
            Console.WriteLine("7. In danh sách phòng thực hành trên 40 máy");
            Console.WriteLine("8. Sắp xếp danh sách phòng học");
            Console.WriteLine("9. Thoát");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Phòng lý thuyết");
                    Console.WriteLine("2. Phòng thực hành");
                    int type = int.Parse(Console.ReadLine());
                    PhongHoc ph;
                    if (type == 1)
                        ph = new PhongLyThuyet();
                    else
                        ph = new PhongThucHanh();
                    ph.Nhap();
                    daiHoc.AddPhongHoc(ph);
                    break;

                case 2:
                    daiHoc.HienThiThongTin();
                    break;

                case 3:
                    Console.Write("Nhập mã phòng cần tìm: ");
                    string maPhong = Console.ReadLine();
                    var found = daiHoc.TimKiem(maPhong);
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
                    Console.WriteLine($"Tổng số phòng học: {daiHoc.TongSoPhongHoc()}");
                    break;

                case 5:
                    Console.WriteLine($"Tổng diện tích phòng thực hành: {daiHoc.TongDienTichPhongThucHanh()} m²");
                    break;
                case 6:
                    daiHoc.InPhongHocDatChuan();
                    break;

                case 7:
                    daiHoc.InPhongThucHanhTren40May();
                    break;

                case 8:
                    daiHoc.SapXep();
                    daiHoc.HienThiThongTin();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}

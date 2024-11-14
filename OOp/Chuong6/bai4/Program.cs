using System;
using System.Collections.Generic;
public abstract class Phong
{
    public string TenKhachHang { get; set; }
    public string CMND { get; set; }
    public int SoNgayThue { get; set; }

    public abstract decimal TinhPhiThue();
}
public class PhongStandard : Phong
{
    public override decimal TinhPhiThue()   
    {
        decimal phiThue;
        if (SoNgayThue < 5)
        {
            phiThue = 500 * SoNgayThue;
        }
        else
        {
            phiThue = 400 * SoNgayThue;
        }
        return phiThue;
    }
}

public class PhongVIP : Phong
{
    public string LoaiPhong { get; set; }

    public override decimal TinhPhiThue()
    {
        decimal phiThue;
        if (SoNgayThue < 5)
        {
            if (LoaiPhong == "Luxury")
            {
                phiThue = 1100 * SoNgayThue;
            }
            else if (LoaiPhong == "President")
            {
                phiThue = 1300 * SoNgayThue;
            }
            else
            {
                throw new ArgumentException("loai phong khong hop le");
            }
        }
        else
        {
            phiThue = 1000 * SoNgayThue;
        }
        return phiThue;
    }
}

public class KhachSan
{
    public List<Phong> Phong { get; set; }

    public KhachSan()
    {
        Phong = new List<Phong>();
    }

    public decimal TinhTongPhiThue()
    {
        decimal tongPhiThue = 0;
        foreach (var phong in Phong)
        {
            tongPhiThue += phong.TinhPhiThue();
        }
        return tongPhiThue;
    }

    public void InThongTinTatCaPhong()
    {
        if (Phong.Count == 0)
        {
            Console.WriteLine("khong co phong nao duoc thue");
            return;
        }

        foreach (var phong in Phong)
        {
            Console.WriteLine("Ten khach hang: " + phong.TenKhachHang);
            Console.WriteLine("CMND: " + phong.CMND);
            Console.WriteLine("So ngay thue: " + phong.SoNgayThue);
            Console.WriteLine("Phi thue: $" + phong.TinhPhiThue());
            Console.WriteLine();
        }
    }

    public void InThongTinPhongStandard()
    {
        foreach (var phong in Phong)
        {
            if (phong.GetType() == typeof(PhongStandard))
            {
                Console.WriteLine("Ten khach hang: " + phong.TenKhachHang);
                Console.WriteLine("CMND: " + phong.CMND);
                Console.WriteLine("So ngay thue: " + phong.SoNgayThue);
                Console.WriteLine("Phi thue: $" + phong.TinhPhiThue());
                Console.WriteLine();
            }
        }
    }

    public decimal TinhTongPhiThuePhongLuxury()
    {
        decimal tongPhiThuePhongLuxury = 0;
        foreach (var phong in Phong)
        {
            if (phong.GetType() == typeof(PhongVIP) && ((PhongVIP)phong).LoaiPhong == "Luxury")
            {
                tongPhiThuePhongLuxury += phong.TinhPhiThue();
            }
        }
        return tongPhiThuePhongLuxury;
    }
}

public class ChuongTrinh
{
    public static void Main(string[] args)
    {
        KhachSan khachSan = new KhachSan();
        PhongStandard phongStandard = new PhongStandard
        {
            TenKhachHang = "Co thao",
            CMND = "123456789",
            SoNgayThue = 3
        };
        khachSan.Phong.Add(phongStandard);
        PhongVIP phongVIP1 = new PhongVIP
        {
            TenKhachHang = "hong Quan",
            CMND = "987654321",
            SoNgayThue = 5,
            LoaiPhong = "Luxury"
        };
        khachSan.Phong.Add(phongVIP1);
        PhongVIP phongVIP2 = new PhongVIP
        {
            TenKhachHang = "Thao Huyen",
            CMND = "456789123",
            SoNgayThue = 7,
            LoaiPhong = "President"
        };
        khachSan.Phong.Add(phongVIP2);
        khachSan.InThongTinTatCaPhong();
        decimal tongPhiThue = khachSan.TinhTongPhiThue();
        Console.WriteLine("Tong phi thue: $" + tongPhiThue);
        khachSan.InThongTinPhongStandard();
        decimal tongPhiThuePhongLuxury = khachSan.TinhTongPhiThuePhongLuxury();
        Console.WriteLine("Tong phi thue phong Luxury: $" + tongPhiThuePhongLuxury);
    }
}

class People 
{
    public string id { get; set; }
    public string hoten { get; set; }
    public string tuoi { get; set; }
    public string diachi { get; set; }
    public People()
    {
    }
    public void nhap()
    {
        Console.WriteLine("Nhap id");
        id = Console.ReadLine();
        Console.WriteLine("Nhap ho ten");
        hoten = Console.ReadLine();
        Console.WriteLine("Nhap tuoi");
        tuoi = Console.ReadLine();
        Console.WriteLine("Nhap dia chi");
        diachi = Console.ReadLine();
    }
    public void xuat()
    {
        Console.WriteLine(id, hoten, tuoi, diachi);
    }
}
class Students : People
{
    public string Term;
    public double TP1;
    public double TP2;
    public double TP3;
    public new void nhap()
    {
        base.nhap();
        Console.WriteLine("Nhap ten hoc phan: ");
        Term = Console.ReadLine();
        Console.WriteLine("Nhap diem tp1: ");
        TP1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap diem tp2: ");
        TP2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap diem tp3: ");
        TP3 = double.Parse(Console.ReadLine());

    }
    public void GPA()
    {
        double GPA = TP1*10/100+TP2*30/100+TP3*60/100;

        if((GPA>=8.5) & (GPA<=10.0))
        {
            Console.WriteLine("Sinh vien co GPA "+GPA+" xep loai A"); 
        }
        else if((GPA >= 7.0) && (GPA<=8.4))
        {
            Console.WriteLine("Sinh vien co GPA "+GPA+" xep loai B");
        }
        else if ((GPA>=5.5) && (GPA<=6.9))
        {
            Console.WriteLine("Sinh vien co GPA "+GPA+" xep loai C");
        }
        else if ((GPA >=4.0) && (GPA <=5.4))
        {
            Console.WriteLine("Sinh vien co GPA "+GPA+" xep loai D");
        }
        
    }
    
    public new void xuat()
    {

        base.xuat();
        Console.WriteLine("Hoc phan {0} cua sinh vien co tp1 la {1}, tp2 la {2}, tp3 la {3}",Term, TP1,TP2,TP3);
        GPA();

    }
}
/*public class Lecture:People
{
    public int Kinhnghiem;
    public string Hocvi;
    public string Chucvu;
    public List<Lecture> DS = new List<Lecture>(); 
            
    public new void Nhap()
    {
        
        base.Nhap();
        Console.WriteLine("Nhap vao so nam kinh nghiem: ");
        Kinhnghiem = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao hoc vi: ");
        Hocvi=Console.ReadLine();
        Console.WriteLine("Nhap vao chuc vu: ");
        Chucvu = Console.ReadLine();
    }
    public new void Xuat()

    {
        base.Xuat();
        Console.WriteLine(Kinhnghiem);
        Console.WriteLine(Hocvi);
        Console.WriteLine(Chucvu);
    }
    public void XuatDSSX()
    {
        for(int i=0;i<DS.Count;i++)

        {
            DS[i].Xuat();
        }

    }
    
    public void DSGiangVien()
    {
        int i=0;
    
        Lecture A = new Lecture();
        while (true)
        {
        int n;
        Console.WriteLine("Nhan 1 de nhap thong tin giang vien / Nhan 2 de dung");
        n = Convert.ToInt32(Console.ReadLine());
        if (n==1)
        {
            A.Nhap();
            DS.Add(A);
            
        }
        if(n==2) break;

        }

    }
    public void Sapxep()
    {
        Lecture temp;
        for(int i=0; i<DS.Count;i++)
        {
            for(int j=i+1;j<DS.Count;j++)
            {
            if (DS[i].Kinhnghiem < DS[j].Kinhnghiem)
            {
                temp = DS[i];
                DS[i]=DS[j];
                DS[j]=temp;
            }
        }

    }

}*/

class program
{   
    static void Main()
    {
        Students a=new Students();
        a.nhap();
        a.GPA();
        a.xuat(); 
    }
}
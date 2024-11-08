namespace B2;
class Zoo
{
    public class Animal{
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Animal(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        public Animal(){}
        public virtual void Nhap(){
            System.Console.WriteLine("Nhập Tên động vật");
            Name = Console.ReadLine();
            System.Console.WriteLine("Nhap tuoi dong vat");
            Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap gioi tinh cua dong vat");
            Sex = Console.ReadLine();
        }
        public virtual void In(){
            System.Console.WriteLine($"Dong vat có ten: {Name}, co tuoi {Age} va gioi tinh {Sex}");
        }
    }
    public class Reptile : Animal{
        public string NoiSong { get; set; }
        public Reptile(string name, int age, string sex, string noiSong) : base(name, age, sex)
        {
            NoiSong = noiSong;
        }
        public Reptile(){}

        public override void Nhap(){
            System.Console.WriteLine("Nhap ten dong vat Reptile");
            Name = Console.ReadLine();

            System.Console.WriteLine("Nhap tuoi dong vat Reptile");
            Age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Nhap gioi tinh cua dong vat Reptile");
            Sex = Console.ReadLine();

            System.Console.WriteLine("Nhap noi song cua dong vat co vu.(Tren Can)-(Duoi Nuoc)");
            NoiSong = Console.ReadLine();
        }
        public override void In(){
            base.In();
            System.Console.WriteLine($"{Name} song o {NoiSong}");
        }
    

    }
    public class Lizard : Reptile{
        string ThucAn { get; set; }
        public Lizard (string name,int age,string sex,string NoiSong,string ThucAn):base(name,age ,sex,NoiSong){
            this.ThucAn = ThucAn;
        }
            public override void In()
            {
                base.In();
                System.Console.WriteLine($"{Name} thuc an la {ThucAn}");
            }
    }
    public class Snake : Reptile{
        string HoatDong { get; set; }
        string ThucAn { get; set; }
        public Snake (string name,int age, string sex,string noiSong,string HoatDong,string ThucAn):base(name,age,sex,noiSong){
            this.HoatDong = HoatDong;
            this.ThucAn = ThucAn;
        }
        public override void In()
        {
            base.In();
            System.Console.WriteLine($"Con {Name} hoat dong vao {HoatDong}");
        }
    }
    public class Mammal : Animal{
        public int Chan{ get; set; }
        public string NoiSong { get; set; }
        public Mammal (string name,int age,string sex,int Chan,string NoiSong) : base(name,age,sex){
            this.Chan = Chan;
            this.NoiSong = NoiSong;
        }
        public override void In(){
            base.In();
            System.Console.WriteLine($"Con {Name} co {Chan} chan va song o {NoiSong} ");
        }
    }
    public class Gorilla : Mammal{
        string ThuocTinh{ get; set; }
        public Gorilla (string name,int age,string sex,int Chan,string noiSong,string ThuocTinh) : base(name,age,sex,Chan,noiSong){
            this.ThuocTinh =ThuocTinh;
        }
        public override void In(){
            base.In();
            System.Console.WriteLine($"Con {Name} co tinh cach {ThuocTinh}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Animal dv1 = new Animal();
            dv1.Nhap();
            dv1.In();
            Reptile dv2 = new Reptile();
            dv2.Nhap();
            dv2.In();
            Lizard dv3 = new Lizard("Than Lan",10,"luong tinh","Tren Can","Con trung");
            dv3.In();
            Snake dv4 = new Snake("Ran 7 Mau",10,"luong tinh","Tren can va duoi nuoc","Ban dem","Chuot");
            dv4.In();
            Mammal dv5 = new Mammal("Bo",10,"Duc",4,"Tren Can");
            dv5.In();
            Gorilla dv6 = new Gorilla("Khi",10,"Duc",2,"Tren Can","Vui Nhon");
            dv6.In();
        }
    }
}


namespace B1;
public class Person{
    public string Name{ get; set; }
    private int age;
    public int Age{ get{ return age;} set{
        if (value < 0) {throw new ArgumentException("Loiii");};
        if (this is Child && value > 15) { 
            throw new ArgumentException("Tuoi cua tre phai nho hon 15.");
        }
        age = value;
    }}
    public Person(string name,int age) {
        Name = name;
        Age = age;
    }
    public Person(){}
    public virtual  void Nhap(){
        System.Console.WriteLine("Nhap ten: ");
        Name = Console.ReadLine();
        System.Console.WriteLine("Nhap tuoi:");
        age = int.Parse(Console.ReadLine());
    }
    public virtual void In(){
        System.Console.WriteLine($"Ten la: {Name} va tuoi la: {age}");
    } 
}
public class Child : Person{
    string School{ get; set; }
    public Child(){}
    public override void Nhap(){
        System.Console.WriteLine("Nhap ten cua tre:");
        Name = Console.ReadLine();
        System.Console.WriteLine("Nhap tuoi cua tre:");

        int ChildAge = int.Parse(Console.ReadLine());
        if (ChildAge > 15) { throw new ArgumentException("Tuoi cua tre phai nho hon 15"); }
        Age = ChildAge;
        System.Console.WriteLine("Nhap truong cua tre:");
        School = Console.ReadLine();
    }
    public override void In()
    {
        System.Console.WriteLine($"Ten cua tre la: {Name} va tuoi la: {Age}, truong cua tre la:{School} ");
    }
}

class Program
{
    static void Main(string[] args)
    {   
        try {
            Person p1 = new Person("Co Let", -1);
            p1.In();
        } catch (ArgumentException ex) {
            Console.WriteLine(ex.Message); 
        } 
        
        try {
            Child c1 = new Child();
            c1.Nhap();
            c1.In();
        } catch (ArgumentException ex) {
            Console.WriteLine(ex.Message);
        } 
    }
}

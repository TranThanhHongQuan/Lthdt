class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    public void Nhap()
    {
        while (true)
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            if (Name.Length > 0)
            {break;}
            else 
            {
                Console.WriteLine("Nhap thong tin loi.");
            }
        }
        Console.Write("Country: ");
        Country = Console.ReadLine();
        Console.Write("City: ");
        City = Console.ReadLine();
        Console.Write("Address: ");
        Address = Console.ReadLine();
        while(true)
        {
            Console.Write("Telephone: ");
            Telephone = Console.ReadLine();

            if (Telephone.Length != 10 || !Telephone.All(char.IsDigit))
                Console.WriteLine("Nhap thong tin sai");
            else
                break;
        }
        
    }
    public void Xuat()
    {
        Console.WriteLine("Doanh Nghiep: "+ Name);
        Console.WriteLine("Quoc Gia: "+ Country);
        Console.WriteLine("Thanh Pho: "+ City);
        Console.WriteLine("Dia Chi:"+Address);
        Console.WriteLine("So Dien Thoai: "+Telephone);
    }
}
class Program
{
    static void Main()
    {
        Organization dn = new Organization();
        dn.Nhap();    
        dn.Xuat();
    }
}
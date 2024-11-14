using System;
public interface maymoc
{
    bool DangBat { get; set; }

    void Bat();
    void Tat();
}
public class MayQuat : maymoc
{
    public bool DangBat { get; set; }

    public void Bat()
    {
        DangBat = true;
        Console.WriteLine("May quat da bat");
    }

    public void Tat()
    {
        DangBat = false;
        Console.WriteLine("May quat da tat");
    }
}
public class DieuHoa : maymoc
{
    public bool DangBat { get; set; }

    public void Bat()
    {
        DangBat = true;
        Console.WriteLine("Đieu hoa da bat");
    }

    public void Tat()
    {
        DangBat = false;
        Console.WriteLine("Đieu hoa đa tat");
    }
}
public class Tivi : maymoc
{
    public bool DangBat { get; set; }

    public void Bat()
    {
        DangBat = true;
        Console.WriteLine("Tivi đa bat");
    }

    public void Tat()
    {
        DangBat = false;
        Console.WriteLine("Tivi đa tat");
    }
}

class Program
{
    static void Main()
    {
        MayQuat quat = new MayQuat();
        quat.Tat();
        Console.WriteLine($"May quat đang bat {quat.DangBat}");

        DieuHoa dieuhoa = new DieuHoa();
        dieuhoa.Tat();
        Console.WriteLine($"Đieu hoa đang bat {dieuhoa.DangBat}");

        Tivi tivi = new Tivi();
        tivi.Tat();
        Console.WriteLine($"Tivi đang bat {tivi.DangBat}");
    }
}

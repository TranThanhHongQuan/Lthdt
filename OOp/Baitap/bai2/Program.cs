using System;

public class Student
{
    public string CodeID { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double TestMark1 { get; set; }
    public double TestMark2 { get; set; }
    public double FinalTestMark { get; set; }


    public double ComputeAverageMark()
    {
        return (((TestMark1 + TestMark2) / 2) + (FinalTestMark * 2)) / 3;
    }


    public string ComputeRank()
    {
        double avgMark = ComputeAverageMark();

        if (avgMark >= 8) return "Good";
        if (avgMark >= 7) return "Fairly Good";
        if (avgMark >= 5) return "Average";
        return "Fail";
    }


    public void InputStudent()
    {
        Console.Write("Enter CodeID: ");
        CodeID = Console.ReadLine();

        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
        DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Enter Test Mark 1: ");
        TestMark1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Test Mark 2: ");
        TestMark2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Final Test Mark: ");
        FinalTestMark = double.Parse(Console.ReadLine());
    }


    public void DisplayStudent()
    {
        Console.WriteLine($"CodeID: {CodeID}, Name: {Name}, DOB: {DateOfBirth.ToShortDateString()}, " +
                          $"Average Mark: {ComputeAverageMark():F2}, Rank: {ComputeRank()}");
    }

    public bool IsPass()
    {
        return ComputeAverageMark() >= 5;
    }
}

class TestStudent
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Console.WriteLine("Input 5 students:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter information for student {i + 1}:");
            Student student = new Student();
            student.InputStudent();
            students.Add(student);
        }


        Console.WriteLine("\nStudents who pass:");
        var passingStudents = students.Where(s => s.IsPass()).ToList();
        passingStudents.ForEach(s => s.DisplayStudent());


        students = students.OrderBy(s => s.Name).ToList();


        Console.WriteLine("\nSorted List of Students:");
        students.ForEach(s => s.DisplayStudent());


        int passingCount = passingStudents.Count;
        Console.WriteLine($"\nNumber of students who pass: {passingCount}");
    }
}
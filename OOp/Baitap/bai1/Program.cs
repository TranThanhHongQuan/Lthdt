using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Constructor không đối số
    public Student() { }

    // Constructor có đối số
    public Student(int id, string name, DateTime dateOfBirth)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    // Nhập thông tin từ bàn phím
    public void InputInfo()
    {
        Console.Write("Nhập ID: ");
        Id = int.Parse(Console.ReadLine());
        
        Console.Write("Nhập tên: ");
        Name = Console.ReadLine();
        
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
        DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    }

    // Hiển thị thông tin học sinh
    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Date of Birth: {DateOfBirth.ToShortDateString()}");
    }

    // Override phương thức ToString
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Date of Birth: {DateOfBirth.ToShortDateString()}";
    }
}


public class ClassRoom
{
    private List<Student> students = new List<Student>();

    // Thêm học sinh
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    // Xóa học sinh theo ID
    public void RemoveStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Đã xóa học sinh có ID {id}.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy học sinh có ID {id}.");
        }
    }

    // Hiển thị danh sách học sinh
    public void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Danh sách học sinh trống.");
            return;
        }
        
        Console.WriteLine("Danh sách học sinh:");
        foreach (var student in students)
        {
            student.DisplayInfo();
        }
    }

    // Tìm học sinh theo ID
    public Student FindStudentById(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    // Sắp xếp danh sách theo thứ tự tăng dần của Name
    public void SortByName()
    {
        students = students.OrderBy(s => s.Name).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ClassRoom classRoom = new ClassRoom();

        // Thêm học sinh vào danh sách
        Console.WriteLine("Thêm học sinh:");
        for (int i = 0; i < 2; i++) // Có thể thay đổi số lượng học sinh nhập vào
        {
            Student student = new Student();
            student.InputInfo();
            classRoom.AddStudent(student);
        }

        // Hiển thị danh sách học sinh
        classRoom.DisplayStudents();

        // Tìm học sinh theo ID
        Console.Write("Nhập ID học sinh cần tìm: ");
        int searchId = int.Parse(Console.ReadLine());
        var foundStudent = classRoom.FindStudentById(searchId);
        if (foundStudent != null)
        {
            Console.WriteLine("Thông tin học sinh tìm thấy:");
            foundStudent.DisplayInfo();
        }
        else
        {
            Console.WriteLine($"Không tìm thấy học sinh có ID {searchId}.");
        }

        // Sắp xếp danh sách theo Name
        Console.WriteLine("Danh sách sau khi sắp xếp theo tên:");
        classRoom.SortByName();
        classRoom.DisplayStudents();

        // Xóa học sinh theo ID
        Console.Write("Nhập ID học sinh cần xóa: ");
        int deleteId = int.Parse(Console.ReadLine());
        classRoom.RemoveStudent(deleteId);

        // Hiển thị danh sách sau khi xóa
        Console.WriteLine("Danh sách sau khi xóa:");
        classRoom.DisplayStudents();
    }
}

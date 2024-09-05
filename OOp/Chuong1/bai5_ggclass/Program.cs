//Bài 5
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập họ tên học sinh: ");
string hoTen = Console.ReadLine().ToUpper();


Console.Write("Nhập điểm thi cuối kỳ: ");
double diem = double.Parse(Console.ReadLine());

string xepLoai;
if (diem >= 8)
    {
        xepLoai = "Giỏi";
    }
    else if (diem >= 6.5)
    {
        xepLoai = "Khá";
    }
    else if (diem >= 5)
    {
        xepLoai = "Trung bình";
    }
    else
    {
        xepLoai = "Yếu";
    }
Console.WriteLine("Họ tên học sinh: " + hoTen);
Console.WriteLine("Xếp loại: " + xepLoai);

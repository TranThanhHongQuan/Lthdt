using System;

namespace vidu1
{
    public class Xe
    {
        public string HangXe { get; set; }
        public string ThuocTinh { get; set; }
        private int tocDo;
        public int TocDo
        {
            get { return tocDo; }
            set { tocDo = value; }
        }
    }

    public class XeHoi : Xe
    {

        public XeHoi(string hangXe, string thuocTinh, int tocDo)
        {
            this.HangXe = hangXe;
            this.ThuocTinh = thuocTinh; 
            this.TocDo = tocDo;        
        }

        public void Xuat()
        {
            Console.WriteLine($"Xe hơi có hãng là {HangXe}, thuộc tính {ThuocTinh}, tốc độ {TocDo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XeHoi xeHoi1 = new XeHoi("Mec", "Mạnh", 500);
            xeHoi1.Xuat();
        }
    }
}

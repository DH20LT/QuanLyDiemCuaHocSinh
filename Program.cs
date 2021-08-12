using System;
using System.Text;

namespace DiemSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phần Mềm");
            SinhVien hs1 = new SinhVien();
            SinhVien hs2 = new SinhVien();
            hs1.Nhap();
            hs2.Nhap();
            Console.WriteLine("Điểm Trung Bình của học sinh: " + hs1);
            
            hs1.XepLoai();
            // hs2.Nhap();
        }
    }
}

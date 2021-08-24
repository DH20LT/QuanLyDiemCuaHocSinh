using System;
using System.Text;

namespace DiemSinhVien
{
    class Program
    {
        static int LuongHS = 0;
        static void Programming(HocSinh[] arrHS)
        {
            Console.Clear();
            Console.WriteLine("Chương trình Điểm Học Sinh");
            Console.WriteLine("1. Nhập Một Học Sinh Mới");
            Console.WriteLine("2. Hiện Tất Cả Học Sinh");
            int iChucNang = int.Parse(Console.ReadLine());
            do{
                switch (iChucNang)
                {
                    case 0: // Thoát
                        Environment.Exit(0);
                        break;
                    case 1: {// Tạo Học Sinh và Nhập Thông Tin
                        LuongHS++;
                        arrHS[LuongHS] = new HocSinh();
                        arrHS[LuongHS].NhapThongTin();
                        Program.Programming(arrHS);
                        break;
                    }
                    case 2: {// Hiện tất cả Học Sinh
                        Console.WriteLine("Điểm Của Học Sinh");
                        Console.WriteLine(LuongHS);
                        for (int i = 1; i <= LuongHS; i++)
                        {
                            arrHS[i].XuatThongTin();
                        }
                        Console.ReadKey();
                        Program.Programming(arrHS);
                        break;
                    }
                    default:
                        Console.WriteLine("Sai Chức Năng");
                        break;
                }
            }while(true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập Lượng Học Sinh");
            int n = int.Parse(Console.ReadLine());
            
            HocSinh[] arrHS = new HocSinh[n];
            Programming(arrHS);
        }
    }
}

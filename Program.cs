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
                        //create an object of class HocSinh
                        HocSinh hs1 = new HocSinh();
                        arrHS[LuongHS] = hs1;
                        hs1.NhapThongTin();
                        Program.Programming(arrHS);
                        break;
                    }
                    case 2: {// Hiện tất cả Học Sinh
                        for (int i = 0; i < LuongHS; i++)
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
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Lượng Học Sinh");
            int n = int.Parse(Console.ReadLine());
            HocSinh[] arrHS = new HocSinh[n];
            
            Programming(arrHS);
        }
    }
}

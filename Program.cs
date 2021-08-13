using System;
using System.Text;

namespace DiemSinhVien
{
    class Program
    {
        static void Programming()
        {
            int iChucNang = int.Parse(Console.ReadLine());
            do{
                switch (iChucNang)
                {
                    case 0: //Thoát
                        Environment.Exit(0);
                        break;
                    case 1:
                    {
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
            Programming();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemSinhVien
{
    class SinhVien
    {
        string HoTen;
        float DiemVan, DiemToan;
        public static string Truong = "BVU";
        public SinhVien() // Hàm khởi tạo mặc định
        {
            HoTen = "NoName";
            DiemVan = 0;
            DiemToan= 0;
        }
        public SinhVien(string HoTen)
        {
            this.HoTen = HoTen;
        }
        public SinhVien(float DiemVan)
        {
            this.DiemVan = DiemVan;
        }
        public SinhVien(float DiemToan, int a = 1)
        {
            this.DiemToan = DiemToan;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập điểm Văn: ");
            DiemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Toán: ");
            DiemToan = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("Tên: " + HoTen);
            Console.Write("Điểm Văn: " + DiemVan);
            Console.Write("Điểm Toán: " + DiemToan);
            Console.Write("Trường: " + Truong);
        }
        public string LayTen()
        {
            return HoTen;
        }
        public float LayVan()
        {
            return DiemVan;
        }
        public float LayToan()
        {
            return DiemToan;
        }
        public void GanTen()
        {

        }
        public float DiemTrungBinh()
        {
            float diemTB = (DiemVan + DiemToan) / 2;
            return diemTB; // quyết định kiểu dữ liệu của phương thức..
        }
        public void XepLoai()
        {
            if (DiemTrungBinh() >= 8)
            {
                Console.Write("Sinh viên xếp loại: Giỏi");
            }
            else if (DiemTrungBinh() >= 7)
            {
                Console.Write("Sinh viên xếp loại: Khá");
            }
            else if (DiemTrungBinh() >= 5)
            {
                Console.Write("Sinh viên xếp loại: Trung Bình");
            }
            else
            {
                Console.Write("Sinh viên xếp loại: Yếu");
            }
        }
    }
}

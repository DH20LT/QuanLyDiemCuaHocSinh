using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemSinhVien
{
    class HocSinh
    {   
        
        string HoTen;
        public void setHoTen(string HoTen) { this.HoTen = HoTen; }
        public string getHoTen() { return this.HoTen; }
        double DiemVan, 
        DiemToan,
        DiemTiengAnh;
        public void setDiemVan(double DiemVan) { this.DiemVan = DiemVan; }
        public void setDiemToan(double DiemToan) { this.DiemToan = DiemToan; }
        public void setDiemTiengAnh(double DiemTiengAnh) { this.DiemTiengAnh = DiemTiengAnh; }
        public double getDiemVan() { return this.DiemVan; }
        public double getDiemToan() { return this.DiemToan; }
        public double getDiemTiengAnh() { return this.DiemTiengAnh; }

        public static string Truong = "BVU";
        public string getTruong() { return Truong; }
        public HocSinh() {// Hàm khởi tạo mặc định
            HoTen = "NoName";
            DiemVan = 0;
            DiemToan= 0;
            DiemTiengAnh = 0;
        }
        public HocSinh(
            string HoTen, float DiemVan, float DiemToan, float DiemTiengAnh){
            this.HoTen = HoTen;
            this.DiemVan = DiemVan;
            this.DiemToan = DiemToan;
            this.DiemTiengAnh = DiemTiengAnh;
        }
        public HocSinh(string HoTen){
            this.HoTen = HoTen;
        }
        public HocSinh(float DiemVan){
            this.DiemVan = DiemVan;
        }
        public HocSinh(float DiemToan, int i = 1){
            this.DiemToan = DiemToan;
        }
        public void NhapThongTin()        {
            Console.WriteLine("Nhập tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập điểm Văn: ");
            DiemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Toán: ");
            DiemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm Tiếng Anh: ");
            DiemTiengAnh = float.Parse(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Tên: " + HoTen);
            Console.WriteLine("Điểm Văn: " + DiemVan);
            Console.WriteLine("Điểm Toán: " + DiemToan);
            Console.WriteLine("Điểm Tiếng Anh: " + DiemTiengAnh);
            Console.WriteLine("Điểm Trung Bình: " + this.DiemTrungBinh());
            Console.WriteLine("Trường: " + Truong);
            XepLoai();
            Console.WriteLine("----------------------------------");
        }
        
        public double DiemTrungBinh()
        {
            double diemTB = (DiemVan + DiemToan + DiemTiengAnh) / 3;
            return Math.Round(diemTB, 2);
        }
        public void XepLoai()
        {
            if (DiemTrungBinh() >= 8)
            {
                Console.WriteLine("Sinh viên xếp loại: Giỏi");
            }
            else if (DiemTrungBinh() >= 7)
            {
                Console.WriteLine("Sinh viên xếp loại: Khá");
            }
            else if (DiemTrungBinh() >= 5)
            {
                Console.WriteLine("Sinh viên xếp loại: Trung Bình");
            }
            else
            {
                Console.WriteLine("Sinh viên xếp loại: Yếu");
            }
        }
    }
}

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
        float DiemVan, 
        DiemToan,
        DiemTiengAnh;
        public void setDiemVan(float DiemVan) { this.DiemVan = DiemVan; }
        public void setDiemToan(float DiemToan) { this.DiemToan = DiemToan; }
        public void setDiemTiengAnh(float DiemTiengAnh) { this.DiemTiengAnh = DiemTiengAnh; }
        public float getDiemVan() { return this.DiemVan; }
        public float getDiemToan() { return this.DiemToan; }
        public float getDiemTiengAnh() { return this.DiemTiengAnh; }

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
        }
        public void XuatThongTin()
        {
            Console.Write("Tên: " + HoTen);
            Console.Write("Điểm Văn: " + DiemVan);
            Console.Write("Điểm Toán: " + DiemToan);
            Console.Write("Trường: " + Truong);
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

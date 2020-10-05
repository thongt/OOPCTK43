using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7___Lop__Doi_Tuong
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinhVien a = new SinhVien();
            //a.maSV = "001";
            //a.hoTen = "Nguyen Van Quang";
            //a.Xuat();
            ////Tao moi doi tuong b thuoc kieu sinh vien
            ////SinhVien b = new SinhVien();
            ////b.Xuat();
            //SinhVien c = a;
            //c.Xuat();
            //c.maSV = "002";
            //c.hoTen ="Nguyen Thi Hoa";
            //c.Xuat();
            //a.Xuat();
            //SinhVien a = new SinhVien();
            //Console.WriteLine(a);
            //SinhVien b = new SinhVien("002", "Nguyen Thi Hoa");
            //Console.WriteLine(b);
            //b.Nhap();
            //Console.WriteLine(b);
            DanhSachSinhVien ctk43 = new DanhSachSinhVien();
            ctk43.NhapTuFile();
            Console.WriteLine(ctk43);

            Console.WriteLine("----Danh sach sinh vien co dtb cao nhat ");
            Console.WriteLine(ctk43.TimDSSVCoDTBCaoNhat());

            Console.ReadKey();

        }
    }
}

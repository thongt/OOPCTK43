﻿using System;
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
            //DanhSachSinhVien cntt = new DanhSachSinhVien();
            //cntt.NhapTuFile();
            //Console.WriteLine(cntt);

            //cntt.ThongKeSinhVienNamNu();

            //Console.WriteLine(" Sv Nam "+ cntt.DemSoLuongSVNam());
            //Console.WriteLine(" Sv Nu " + cntt.DemSoLuongSVNu());
            //Console.WriteLine("----Danh sach sinh vien co dtb cao nhat ");
            //Console.WriteLine(ctk43.TimDSSVCoDTBCaoNhat());


            QuanLySinhVien ql = new QuanLySinhVien();
            ql.QuanLy();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7___Lop__Doi_Tuong
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public float dTB;
        //phuong thuc tao lap mac dinh
        public SinhVien()
        {
            maSV = "1";
            hoTen = "a";
        }
        public SinhVien(string ma, string ho, float dtb)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
        }
        //public SinhVien(string ma)
        //{
        //    maSV = ma;
        //}

        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ho ten ");
            hoTen = Console.ReadLine();
        }
        //public void Xuat()
        //{
        //    Console.WriteLine("Ma so: {0}  Ho ten: {1}",maSV,hoTen);
        //}
        public override string ToString()
        {
            return string.Format("Ma so: {0},  Ho ten: {1}, Diem: {2}", maSV, hoTen, dTB);
        }
    }
}

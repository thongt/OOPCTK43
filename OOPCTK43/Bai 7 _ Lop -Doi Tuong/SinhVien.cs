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
        public Boolean gioiTinh;
        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value.Trim(); }
        }

        //phuong thuc tao lap mac dinh
        public SinhVien()
        {
            maSV = "1";
            hoTen = "a";
        }
        public SinhVien(string ma, string ho, float dtb, bool gt, string lop)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            gioiTinh = gt;
            this.lop = lop;
        }
        public SinhVien(string line)
        {
            //001,Nguyen Van A, 8.0, Nam, CTK43
            string[] str = line.Split(',');
            maSV = str[0];
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false;
            lop = str[4];
        }

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
            return string.Format("{0, 2} {1, 10} {2,5} {3, 6} {4, 10}", maSV, hoTen, dTB, gioiTinh==true?"Nam":"Nu", lop);
        }
    }
}

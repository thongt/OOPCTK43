using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuV2
{
    class Program
    {
        static List<int> a = new List<int>();
        static void Main(string[] args)
        {
            //NhapMang();
            //NhapMangNgauNhien();
            NhapTuFileV2();
            XuatMang();
            //List <int> kq = TimDanhSachCacPhanTuLonHonX(4);
            //XuatMang(kq);
            // Console.WriteLine("\nTong cac phan tu " + TinhTong());
            Console.WriteLine("Gia tri lon nhat la " + TimMax());
            Console.ReadKey();
        }
        static int TinhTong()
        {
            int tong = 0;
            foreach (var x in a)
            {
                tong += x;
            }
            return tong;
        }
        static int DemSoPhanTuMax()
        {
            var max = TimMax();
            var dem = 0;
            foreach (var item in a)
            {
                if (item == max)
                    dem++;
            }
            return dem;
        }
        static int TimMax()
        {
            int max = int.MinValue;
            foreach (var item in a)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        static void XoaTaiViTri(int vt)
        {
            //for (int i = vt; i < a.Count-1; i++)
            //    a[i] = a[i + 1];
            //a.Count
            a.RemoveAt(vt);
        }
        static int TimViTriCuaPhanTuX(int x)
        {
            for (int i = 0; i < a.Count; i++)
                if (a[i] == x) return i;
            return -1;
        }
        static void XoaPhanTuX(int x)
        {
            int vt = 0;
            while ((vt = TimViTriCuaPhanTuX(x)) != -1)
            {
                XoaTaiViTri(vt);
            }

            //int vt = 0;
            //while(vt!=-1)
            //{
            //    vt = -1;
            //    for (int i = 0; i < a.Count; i++)
            //        if (a[i] == x)
            //        {
            //            vt = i;
            //            break;
            //        }
            //    if(vt>=0)
            //    XoaTaiViTri(vt);
            //}
        }
        static List<int> TimCacSoDuong()
        {
            return TimDanhSachCacPhanTuLonHonX(0);
        }
        static List<int> TimDanhSachCacPhanTuLonHonX(int x)
        {
            List<int> kq = new List<int>();
            foreach(int i in a)
                if (i >= x)
                    kq.Add(i);
            return kq;
        }
        static void NhapMang()
        {
            Console.Write("Nhap chieu dai mang ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a.Add(int.Parse(Console.ReadLine()));
            }
        }
        static void NhapTuFile()
        {
            //tap tin data.txt phai nam trong thu muc Debug cua Project
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            //Ket thuc file thi gia tri cua line = null
            while ((line = sr.ReadLine()) != null)
            {
                a.Add(int.Parse(line));
            }
        }
        static void NhapTuFileV2()
        {
            //tap tin data.txt phai nam trong thu muc Debug cua Project
            //duong dan tuyet doi
            //var fileName = @"C: \Users\Thong Tran\Source\Repos\OOPCTK43\OOPCTK43\Mang1Chieu\bin\Debug\data.txt";
            var fileName = "data1.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            string[] s = line.Split(' ');
            foreach (var c in s)
                a.Add(int.Parse(c));
            
        }
        static void NhapMangNgauNhien()
        {
            Console.Write("Nhap chieu dai mang ");
            int length = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                a.Add(rand.Next(10));
            }
        }
        static void XuatMang()
        {
            Console.WriteLine("Danh sach cac phan tu ");
            foreach(int i in a)
            {
                Console.Write(" {0} ", i);
            }
        }
        static void XuatMang(List<int> a)
        {
            Console.WriteLine("\nDanh sach cac phan tu ");
            foreach(int i in a)
            {
                Console.Write(" {0} ", i);
            }
        }

    }
}

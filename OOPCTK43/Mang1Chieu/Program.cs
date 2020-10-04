using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace Mang1Chieu
{
    class Program
    {
        static int[] a = new int[100];
        static int length = 0;
        static void Main(string[] args)
        {
            //NhapMang();
            //NhapMangNgauNhien();
            NhapTuFileV2();
            XuatMang();
            int[] kq = new int[100];
            int lenkq = 0;
            kq = TimDanhSachCacPhanTuLonHonX(ref lenkq, 4);
            XuatMang(kq, lenkq);
            Console.ReadKey();
        }
        static int[] TimDanhSachCacPhanTuLonHonX( ref int len, int x)
        {
            int[] kq = new int[100];
            len = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] >= x)
                {
                    kq[len++] = a[i];
                    //len++;
                }
            }
            return kq;
        }
        static void NhapMang()
        {
            Console.Write("Nhap chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void NhapTuFile()
        {
            //tap tin data.txt phai nam trong thu muc Debug cua Project
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            //Ket thuc file thi gia tri cua line = null
            while((line = sr.ReadLine())!=null)
            {
                a[length++]= int.Parse(line);
            }
        }
        static void NhapTuFileV2()
        {
            //tap tin data.txt phai nam trong thu muc Debug cua Project
            //duong dan tuyet doi
            var fileName = @"C: \Users\Thong Tran\Source\Repos\OOPCTK43\OOPCTK43\Mang1Chieu\bin\Debug\data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            string[] s = line.Split(' ');
            foreach(var c in s)
            {
                a[length++] = int.Parse(c);
            }
        }
        static void NhapMangNgauNhien()
        {
            Console.Write("Nhap chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = rand.Next(10);
            }
        }
        static void XuatMang()
        {
            Console.WriteLine("Danh sach cac phan tu ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
        }
        static void XuatMang(int []a, int length)
        {
            Console.WriteLine("\nDanh sach cac phan tu ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
        }

    }
}

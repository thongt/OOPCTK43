



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao mot bien nguyen i va khoi gan 10
            int i = 0;
            string b = "Xin chao lop CTK43";
            //Hien thi dong nhap vao so nguyen
            Console.Write("Nhap vao so nguyên: ");
            //Chuyen chuoi vua nhap sang so nguyen va gan cho bien i
            //i = int.Parse(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Gia tri vua nhap la " + i);
            Console.WriteLine(" Gia {1} tri i= {0} va b la {1} {2}", i, b, i);
            Console.ReadKey();

        }
    }
}
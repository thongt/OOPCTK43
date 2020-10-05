using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_QuanLyPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PhanSo a = new PhanSo(10, 32);
            // PhanSo b = new PhanSo(3, 0);
            //// PhanSo c = a.Cong(a, b);
            // PhanSo c = a + b;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // c.RutGon();
            // Console.WriteLine(c);

            MangPhanSo m = new MangPhanSo();
            m.Nhap();
            Console.WriteLine(" Mang phan so la " + m);
            Console.WriteLine(" Tong cac phan so la " + m.TinhTong());
            Console.ReadKey();
        }
    }
}

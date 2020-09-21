using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3__Kieu_chuoi
{
    class Program
    {
        static void Main(string[] args)

        { 
            string hoVaTen = "Tran Thi Hoang Anh";
            //Ham xoa khoang trang dau va cuoi
            Console.WriteLine(hoVaTen);
            //Xoa khoang trang o cuoi
            Console.WriteLine(hoVaTen.TrimEnd());
            Console.WriteLine(hoVaTen.Trim());
            //Chieu dai cua chuoi
            Console.WriteLine(hoVaTen.Length);
            //Ham lay vi tri cua mot chuoi con trong chuoi cha, khong co tra ve -1
            Console.WriteLine(hoVaTen.IndexOf("Vang"));
            //Lay chuoi con trong chuoi cha
            Console.WriteLine(hoVaTen.Substring(7));
            Console.WriteLine(hoVaTen.Substring(7,3));
            //Lay ho cua chuoi hoVaTen
            hoVaTen = hoVaTen.TrimStart();
            int vt = hoVaTen.IndexOf(" ");
            string ho = hoVaTen.Substring(0, vt);
            Console.WriteLine(ho);

            int vt1 = hoVaTen.IndexOf(" ");
            int vt2 = hoVaTen.LastIndexOf(" ");
            string hoDem = hoVaTen.Substring(vt1, vt2 - vt1);
            Console.WriteLine("Ho dem " + hoDem);

            Console.WriteLine("Ho dem " + hoVaTen.Substring(hoVaTen.IndexOf(" "), hoVaTen.LastIndexOf(" ") - hoVaTen.IndexOf(" ")));

            //Ham kiem tra mot chuoi cho chua trong chuoi cha hay khong
            Console.WriteLine(hoVaTen.Contains("Thong"));

            ///Ham viet hoa
            Console.WriteLine(hoVaTen.ToUpper());
            Console.WriteLine(hoVaTen.ToLower());

            Console.ReadKey();


        }
    }
}

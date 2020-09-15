//Khai báo thư viện sử dụng  giống như iostream
/* chú thích block*/

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Xuat mot chuoi ra man hinh giong cout

            //System.Console.WriteLine("Chuong trinh dau tien"); //dong lệnh

            //Console.WriteLine("Dung khai bao thu vien thi ngan hon");

            float tam = 7000000000;

            int danso = (int)tam; // khai bao mot bien i kieu integer va khoi gan = 10
            Console.WriteLine(" Dan so the gioi la: " + tam);
            Console.ReadKey();
        }
    }
}
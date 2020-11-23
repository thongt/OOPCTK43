using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_KeThua_DaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cha cha1 = new Cha();
            //cha1.


            //Con c1 = new Con(4, 5);
            //c1.Xuat();

            //Cha cha = c1;
            //cha.Xuat();

            //Cha cha2 = new Cha(10);
            //Con c2 = (Con)cha2;
            //c2.Xuat();

            List<Cha> ds = new List<Cha>();
            ds.Add(new Cha(1));
            ds.Add(new Cha(2));
            ds.Add(new Cha(3));
            ds.Add(new Con(1,5));
            ds.Add(new Con(2,6));
            foreach (var item in ds)
            {
                if (item is Con)
                    ((Con)item).Xuat();
                else
                    item.Xuat();
            }

            Console.ReadKey();
        }
    }
}

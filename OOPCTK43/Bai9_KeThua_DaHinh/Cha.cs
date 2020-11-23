using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_KeThua_DaHinh
{
   public class Cha
    {
        int data;
        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        public Cha()
        {
        }
        public Cha(int data)
        {
            Data = data;
        }
        public void Xuat()
        {
            Console.WriteLine(" Data cua cha la " + data);
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class Con : Cha
    {
        public int y;
        public Con()
        {
        }
        public Con(int data, int y1):base(data)
        {
            //Data = data;
            y = y1;
        }
        public void Xuat()
        {
            Console.WriteLine("Data cua con la data = {0} va y = {1}", Data,y );
        }
    }
}

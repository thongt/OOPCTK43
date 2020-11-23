using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Quan_Ly_Hinh_Hoc1
{
    class HinhCN:HinhVuong
    {
        public float rong;
        public float Dai
        {
            get { return canh; }
        }
        public HinhCN()
        {
        }
        public HinhCN(float c, float r):base(c)
        {
            rong = r;
        }
        public override string ToString()
        {
            return string.Format("HCN co cd la {0}, rong la {1}, dien tich la {2}", Dai, rong, TinhDT());
           // return "Hinh chu nhat co cd la " + canh + " dien tich " + TinhDT();
        }

        //public override float TinhDT()
        //{
        //    return Dai * rong;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Quan_Ly_Hinh_Hoc1
{
    class HinhTron:HinhHoc
    {
        public float bk;
       public static int dem = 0;
        public HinhTron()
        {
            dem++;
        }
        public HinhTron(float bk)
        {
            this.bk = bk;
            dem++;
        }
        public override string ToString()
        {
            return "Hinh tron co ban kinh la " +bk + " dien tich " + TinhDT(); ;
        }

        public  override float TinhDT()
        {
            return bk*bk * (float)Math.PI;
        }
        //public static void TinhCV()
        //{
        //    canh
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Quan_Ly_Hinh_Hoc1
{
    class HinhVuong : HinhHoc
    {
        public float canh;
        public HinhVuong()
        {
        }
        public HinhVuong(float c)
        {
            canh = c;
        }
        public override string ToString()
        {
            return "Hinh vuong co canh la " + canh + " dien tich " + TinhDT();
        }

        public override float TinhDT()
        {
            return canh * canh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_QuanLyPhanSo
{
    class PhanSo
    {
        public int tu;
        private int mau;
        public int Mau
        {
            get
            {
                return mau;
            }

            set
            {
                if (value == 0)
                {
                    throw new Exception("Mau so khong duoc bang 0");
                }
                mau = value;
            }
        }

        public PhanSo()
        {

        }
        public PhanSo(int t, int m)
        {
            tu = t;
            Mau = m;
        }
        public PhanSo Cong(PhanSo b)
        {
            //PhanSo kq = new PhanSo();
            //kq.tu = this.tu * b.mau + this.mau * b.tu;
            //kq.mau = this.mau * b.mau;
            //return kq;
            return Cong(this, b);

        }
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            return a.Cong(b);
        }
        public static implicit  operator PhanSo(int x)
        {
            return new PhanSo(x, 1);
        }
        public void RutGon()
        {
            int ucln = TimUSCLN(this.tu, this.Mau);
            this.tu = this.tu / ucln;
            this.Mau = this.Mau / ucln;
        }
        private int TimUSCLN(int a, int b)
        {
            while(a!=b)
            {
                if (a > b) a = a - b;
                else
                    if (b > a) b = b - a;
            }
            return a;
        }
        private PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.Mau + a.Mau * b.tu;
            kq.Mau = a.Mau * b.Mau;
            return kq;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", tu, Mau);
        }
    }
}

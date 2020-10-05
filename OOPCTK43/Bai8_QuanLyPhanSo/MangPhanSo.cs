using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_QuanLyPhanSo
{
    class MangPhanSo
    {
        List<PhanSo> collection = new List<PhanSo>();
        public void Nhap()
        {
            collection.Add(new PhanSo(1, 2));
            collection.Add(new PhanSo(3, 2));
            collection.Add(new PhanSo(4, 2));
            collection.Add(new PhanSo(5, 2));
            collection.Add(new PhanSo(6, 2));
        }
        public PhanSo TinhTong()
        {
            PhanSo kq = new PhanSo(0, 1);
            foreach (var item in collection)
            {
                kq = kq + item;
            }
            return kq;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += item + " ";
            }
            return s;
        }
    }
}

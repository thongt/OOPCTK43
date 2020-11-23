using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Quan_Ly_Hinh_Hoc1
{
    class DanhSachHinhHoc:Object
    {
        List<HinhHoc> ds = new List<HinhHoc>();
        public void Them(HinhHoc h)
        {
            ds.Add(h);
        }
        public void Nhap()
        {
            ds.Add(new HinhTron(5));
            ds.Add(new HinhVuong(6));
            Them(new HinhCN(7, 5));
            ds.Add(new HinhTron(1));
            ds.Add(new HinhVuong(2));
            ds.Add(new HinhTron(7));
            ds.Add(new HinhVuong(8));
        }
        public DanhSachHinhHoc TimHinhCoDTLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimMaxDT();
            foreach (var item in ds)
            {
                if ( max == item.TinhDT())
                    kq.Them(item);
            }
            return kq;
        }
        public float TimMaxDT()
        {
            return ds.Max(x => x.TinhDT());
            //float max = 0;
            //foreach (var item in ds)
            //{
            //    if (max < item.TinhDT())
            //        max = item.TinhDT();
            //}
            //return max;
        }
        //public DanhSachHinhHoc TimHinhCoDTLonNhat()
        //{
        //    DanhSachHinhHoc kq = new DanhSachHinhHoc();
        //    float max = TimMaxDT();
        //    foreach (var item in ds)
        //    {
        //        float tam = 0;
        //        if (item is HinhTron)
        //            tam = ((HinhTron)item).TinhDT();
        //        if (item is HinhVuong)
        //            tam = ((HinhVuong)item).TinhDT();
        //        if (tam == max)
        //            kq.Them(item);
        //    }
        //    return kq;
        //}
        //public float TimMaxDT()
        //{
        //    float max = 0;
        //    foreach (var item in ds)
        //    {
        //        float tam = 0;
        //        if (item is HinhTron)
        //            tam = ((HinhTron)item).TinhDT();
        //        if (item is HinhVuong)
        //            tam = ((HinhVuong)item).TinhDT();
        //        if (max < tam)
        //            max = tam;
        //    }
        //    return max;
        //}
        public void Xuat()
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }

    }
}

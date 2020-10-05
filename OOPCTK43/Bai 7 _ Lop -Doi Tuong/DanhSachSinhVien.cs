using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7___Lop__Doi_Tuong
{
    class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }
        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                ds.Add(new SinhVien(str[0], str[1], float.Parse(str[2])));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }
        public float TimDTBCaoNhat()
        {
           return  ds.Min(x => x.dTB);  
            //float max= 0;
            //foreach (var item in ds)
            //{
            //    if (item.dTB > max)
            //        max = item.dTB;

            //}
            //return max;

        }
        public DanhSachSinhVien  TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max)
                    kq.Them(item);
            }
            return kq;
        }
    }
}

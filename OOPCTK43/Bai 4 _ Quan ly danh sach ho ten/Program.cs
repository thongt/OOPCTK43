using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4___Quan_ly_danh_sach_ho_ten
{
    class Program
    {
        enum ThucDon
        {
            ThemSinhVien,
            XuatDanhSach,
            HienThiTheoChieuGiamCuaTen,
            HienThiTheoChieuTangCuaTen,
            Thoat =10
        }
        static int vt = 0;
      static  string[] ds = new string[] { "nguyen Duc Anh",
                "Hoang Thi Phuong",
                "Bui Tien Dung",
                "Nguyen Cong Binh",
                "Nguyen Van Toan" };
        static void Main(string[] args)
        {
            //string[] ds = new string[100];
            //int len = 0;
            string[] ds = new string[] { "nguyen Duc Anh",
                "Hoang Thi Phuong",
                "Bui Tien Dung",
                "Nguyen Cong Binh",
                "Nguyen Van Toan" };
            //Xuat danh sach

            //Console.WriteLine(ds[0]);
            //Console.WriteLine(ds[1]);
            //Console.WriteLine(ds[2]);
            //Console.WriteLine(ds[3]);
            //int dem = 0;
            //for (int i = 0; i < ds.Length; i++)
            //{
            //    string hoVaTen = ds[i].TrimStart();
            //    int vt = hoVaTen.IndexOf(" ");
            //    string ho = hoVaTen.Substring(0, vt);
            //    if (ho.ToLower() == "nguyen")
            //        dem++;
            //}
            //dem = 0;
            //for (int i = 0; i < ds.Length; i++)
            //{
            //    string hoVaTen = ds[i].TrimStart();
            //    int vt = hoVaTen.IndexOf(" ");
            //    string ho = hoVaTen.Substring(0, vt);
            //    if (ho.ToLower() == "tran")
            //        dem++;
            //}
            //Console.WriteLine(DemHoTrongDanhSach(ds,"nguyen"));
            //Console.WriteLine(DemHoTrongDanhSach(ds, "bui"));
            //XuatDanhSach(ds);
            //Console.WriteLine("-------------------------------");
            //HienThiDanhSachTheoChieuTangCuaTen(ds);
            //Console.WriteLine("-------------------------------");
            //HienThiDanhSachTheoChieuGiamCuaTen(ds);
            //Console.WriteLine(dem);
            //while (true)
            //{
            //    Console.Clear();

            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine("Nhap 1 de them 1 sinh vien ");
            //    Console.WriteLine("Nhap 2 de hien thi danh sach");
            //    Console.WriteLine("Nhap 3 de hien thi theo chieu tang cua ten ");
            //    Console.WriteLine("Nhap 4 de hien thi theo chieu giamm cua ten");
            //    Console.WriteLine("Nhap 5 de thoat");
            //    int nhap = int.Parse(Console.ReadLine());
            //    switch (nhap)
            //    {
            //        case 1: break;
            //        case 2:
            //            XuatDanhSach(ds);
            //            break;
            //        case 3: 
            //            HienThiDanhSachTheoChieuTangCuaTen(ds);
            //            break;
            //        case 4:
            //            HienThiDanhSachTheoChieuGiamCuaTen(ds);
            //            break;

            //        case 5: return;
            //    }
            //    Console.ReadKey();
            //}

            while (true)
            {
                Console.Clear();

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Nhap {0} de them 1 sinh vien ", (int)ThucDon.ThemSinhVien);
                Console.WriteLine("Nhap {0} de hien thi danh sach", (int)ThucDon.XuatDanhSach);
                Console.WriteLine("Nhap {0} de hien thi theo chieu tang cua ten ", (int)ThucDon.HienThiTheoChieuTangCuaTen);
                Console.WriteLine("Nhap {0} de hien thi theo chieu giamm cua ten", (int)ThucDon.HienThiTheoChieuGiamCuaTen);
                Console.WriteLine("Nhap {0} de thoat", (int)ThucDon.Thoat);
                ThucDon nhap = (ThucDon)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case ThucDon.ThemSinhVien :
                        //Console.Write("Nhap mot ho ten moi ");
                        //string ht = Console.ReadLine();
                        //ds.
                        break;
                    case ThucDon.XuatDanhSach:
                        XuatDanhSach(ds);
                        break;
                    case ThucDon.HienThiTheoChieuTangCuaTen:
                        HienThiDanhSachTheoChieuTangCuaTen(ds);
                        break;
                    case ThucDon.HienThiTheoChieuGiamCuaTen:
                        HienThiDanhSachTheoChieuGiamCuaTen(ds);
                        break;

                    case ThucDon.Thoat: return;
                }
                Console.ReadKey();
            }

        }
        static int DemHoTrongDanhSach(string hoCanDem)
        {
            int dem = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                string hoVaTen = ds[i].TrimStart();
                int vt = hoVaTen.IndexOf(" ");
                string ho = hoVaTen.Substring(0, vt);
                if (ho.ToLower() == hoCanDem.ToLower())
                    dem++;
            }
            Console.WriteLine(vt);
            return dem;
        }
        static int DemHoTrongDanhSach(string[] ds )
        {
            int dem = 0;
            string hoCanDem = "";
            Console.WriteLine("Nhap ho can dem");
            hoCanDem = Console.ReadLine();
            for (int i = 0; i < ds.Length; i++)
            {
                string hoVaTen = ds[i].TrimStart();
                int vt = hoVaTen.IndexOf(" ");
                string ho = hoVaTen.Substring(0, vt);
                if (ho.ToLower() == hoCanDem.ToLower())
                    dem++;
            }
            return dem;
        }

        enum KieuSapXep
        {
            TangTheoTen,
            GiamTheoTen,
            TangTheoHo,
            GiamTheoHo
        }
        static int SoSanh(string a, string b, KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoTen)
            {
                return LayTen(a).CompareTo(LayTen(b));
            }
            return -LayTen(a).CompareTo(LayTen(b));
        }
        static void SapXep(string[] ds, KieuSapXep kieu)
        {
            for (int i = 0; i < ds.Length - 1; i++)
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if (SoSanh(ds[i], ds[j], kieu) == 1)
                    {
                        string tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }

        }
        //static void SapXepTheoTen(string[] ds)
        //{
        //    for (int i = 0; i < ds.Length - 1; i++)
        //        for (int j = i + 1; j < ds.Length; j++)
        //        {
        //            if (LayTen(ds[i]).CompareTo(LayTen(ds[j])) == -1)
        //            {
        //                string tam = ds[i];
        //                ds[i] = ds[j];
        //                ds[j] = tam;
        //            }
        //        }

        //}
        static string LayTen(string hoVaTen)
        {
            hoVaTen = hoVaTen.Trim();
            int vt = hoVaTen.LastIndexOf(' ');
            return hoVaTen.Substring(vt, hoVaTen.Length - vt);
        }
        static void HienThiDanhSachTheoChieuTangCuaTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.TangTheoTen);
            XuatDanhSach(ds);

        }
        static void HienThiDanhSachTheoChieuGiamCuaTen(string[] ds)
        {
            SapXep(ds, KieuSapXep.GiamTheoTen);
            XuatDanhSach(ds);

        }
        static int DemSoLanXuatHienTheoHo(string ho)
        {

        }
        static List<string> LayDanhSachHo(string[] ds)
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                string ho = LayTen(item);
                if (!kq.Contains(ho))
                    kq.Add(ho);
            }
            return kq;
        }
        static List <string> TimHoCoSoLanXuatHienLaX(string[] ds, int solan)
        {
            List<string> kq = new List<string>();
            List<string> dsHo = LayDanhSachHo(ds);
            foreach (var ho  in dsHo)
            {
                if (DemSoLanXuatHienTheoHo(ho) == solan)
                    kq.Add(ho);
            }
            return kq;
        }
        static void XuatDanhSach(string[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);
        }
    }
}

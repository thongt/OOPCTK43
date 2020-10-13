using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7___Lop__Doi_Tuong
{
    class QuanLySinhVien
    {
        DanhSachSinhVien cntt = new DanhSachSinhVien();
        public void QuanLy()
        {
            cntt.NhapTuFile();
            Console.WriteLine(cntt);
            //ThongKeSinhVienNamNu();
            cntt.SapXepTangTheoDTB();
            Console.WriteLine(cntt);
        }
        public void ThongKeSinhVienNamNu()
        {
            List<string> dslop = cntt.LayDanhSachLop();
            foreach (var lop in dslop)
            {
                Console.WriteLine(lop + " Nam: " + cntt.DemSoLuongSVNam(lop) + " Nu: " + cntt.DemSoLuongSVNu(lop));
            }
        }
      

    }
}

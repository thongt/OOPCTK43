using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_Quan_Ly_Hinh_Hoc1
{
    //public class HinhHoc
    //{
    //    public virtual float TinhDT()
    //    {
    //        return 0;
    //    }
    //    public float TinhCV()
    //    {
    //        return 0;
    //    }
    //}
    public abstract class HinhHoc
    {
        public virtual float TinhDT()
        {
            return 0;
        }
        public float TinhCV()
        {
            return 0;
        }
    }
}

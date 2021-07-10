using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager.MainClass
{
    public class ThuNgan : NhanVien
    {
        int DoanhThu;

        public ThuNgan() { }

        public int DOANHTHU
        {
            get { return DoanhThu; }
            set { this.DoanhThu = value; }
        }
    }
}

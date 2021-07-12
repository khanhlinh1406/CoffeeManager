using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class NhaCungCap
    {
        string MaNCC;
        string TenNCC;
        string sdt;

        public NhaCungCap() {
            this.MaNCC = this.TenNCC = this.sdt = ""; 
        }

        public NhaCungCap(string MaNCC, string TenNCC, string sdt)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.sdt = sdt;
        }

        public string MA_NCC
        {
            get
            {
                return MaNCC;
            }
            set
            {
                this.MaNCC = value;
            }
        }

        public string TEN_NCC
        {
            get
            {
                return TenNCC;
            }
            set
            {
                this.TenNCC = value;
            }
        }

        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                this.sdt = value;
            }
        }
    }
}

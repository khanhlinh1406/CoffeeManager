using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager.MainClass
{
    public class TaiKhoan
    {
        string MaTK;
        string MatKhau;

        public TaiKhoan() { this.MaTK = this.MatKhau = ""; }

        public TaiKhoan(string MaTK, string MatKhau) 
        {
            this.MaTK = MaTK;
            this.MatKhau = MatKhau;
        }

        public string MA_TK
        {
            get { return this.MaTK; }
            set { this.MaTK = value; }
        }

        public string MATKHAU
        {
            get { return this.MatKhau; }
            set { this.MatKhau = value; }
        }
    }
}

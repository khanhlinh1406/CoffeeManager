using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class Mon
    {
        string MaMon;
        string TenMon;
        string MaTT;
        string Anh;

        public Mon()
        {
            MaMon = TenMon = MaTT = Anh = "";
        }
    
        public Mon(string MaMon, string TenMon, string MaTT, string Anh)
        {
            this.MaMon = MaMon;
            this.TenMon = TenMon;
            this.MaTT = MaTT;
            this.Anh = Anh;
        }

        public string MA_MON
        {
            get { return this.MaMon; }
            set { this.MaMon = value; }
        }

        public string TEN_MON
        {
            get { return this.TenMon; }
            set { this.TenMon = value; }
        }

        public string ANH
        {
            get { return this.Anh; }
            set { this.Anh = value; }
        }

        public string MA_TT
        {
            get { return this.MaTT; }
            set { this.MaTT = value; }
        }

        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
    }
}

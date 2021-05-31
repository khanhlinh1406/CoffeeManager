using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class TinhTrang
    {
        string MaTT;
        string TenTT;

        public TinhTrang()
        {
            MaTT = TenTT = "";
        }

        public TinhTrang(string MaTT, string TenTT)
        {
            this.MaTT = MaTT;
            this.TenTT = TenTT;
        }

        public string MA_TT
        {
            get { return this.MaTT; }
            set { this.MaTT = value; }
        }

        public string TEN_TT
        {
            get { return this.TenTT; }
            set { this.TenTT = value; }
        }

        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
    }
}

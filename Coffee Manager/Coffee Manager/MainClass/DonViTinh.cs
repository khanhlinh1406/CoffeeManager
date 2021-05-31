using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class DonViTinh
    {
        string MaDVT;
        string TenDVT;

        public DonViTinh()
        {
            MaDVT = TenDVT = "";
        }

        public DonViTinh(string MaDVT, string TenDVT)
        {
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
        }

        public string MA_DVT
        {
            get { return this.MaDVT; }
            set { this.MaDVT = value; }
        }

        public string TEN_DVT
        {
            get { return this.TenDVT; }
            set { this.TenDVT = value; }
        }
        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
    }
}

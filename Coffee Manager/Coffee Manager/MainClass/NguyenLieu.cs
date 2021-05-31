using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class NguyenLieu
    {
        string MaNL;
        string TenNL;
        int TriGia;

        public NguyenLieu()
        {
            MaNL = TenNL = "";
            TriGia = 0;
        }

        public NguyenLieu(string MaNL, string TenNL, int TriGia)
        {
            this.MaNL = MaNL;
            this.TenNL = TenNL;
            this.TriGia = TriGia;
        }

        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public string TEN_NL
        {
            get { return this.TenNL; }
            set { this.TenNL = value; }
        }
        public string MA_NL
        {
            get { return this.MaNL; }
            set { this.MaNL = value; }
        }

        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
        //public void Save(){};

    }
}

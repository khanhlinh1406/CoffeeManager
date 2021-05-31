using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager.Class
{
    class ChucVu
    {
        string MaCV;
        string TenCV;

        public ChucVu()
        {
            MaCV = TenCV = "";
        }

        public ChucVu(string MaCV, string TenCV)
        {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }

        public string MA_CV
        {
            get { return this.MaCV; }
            set { this.MaCV = value; }
        }

        public string TEN_CV
        {
            get { return this.TenCV; }
            set { this.TenCV = value; }
        }
        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
        //public void Save(){};
    }
}

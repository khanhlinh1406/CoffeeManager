using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class NhanVien
    {
        string MaNV;
        string TenNV;
        DateTime NgSinh;
        string SoDT;
        string DiaChi;
        DateTime NgVaoLam;
        string MaCV;
        string MaTK;

        public NhanVien()
        {
            MaNV = TenNV = SoDT = DiaChi = MaCV = MaTK = "";
            NgSinh = NgVaoLam = DateTime.Now;
        }

        public NhanVien(string MaNV, string TenNV, string SoDT, string DiaChi, string MaCV, string MaTK,
            DateTime NgSinh, DateTime NgVaoLam)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
            this.NgSinh = NgSinh;
            this.NgVaoLam = NgVaoLam;
        }

        public string MA_NV
        {
            get { return this.MaNV; }
            set { this.MaNV = value; }
        }
        public string TEN_NV
        {
            get { return this.TenNV; }
            set { this.TenNV = value; }
        }
        public string SO_DT
        {
            get { return this.SoDT; }
            set { this.SoDT = value; }
        }
        public string DIA_CHI
        {
            get { return this.DiaChi; }
            set { this.DiaChi = value; }
        }
        public string MA_CV
        {
            get { return this.MaCV; }
            set { this.MaCV = value; }
        }
        public string MA_TK
        {
            get { return this.MaTK; }
            set { this.MaTK = value; }
        }
        public DateTime NG_VAOLAM
        {
            get { return this.NgVaoLam; }
            set { this.NgVaoLam = value; }
        }
        public DateTime NG_SINH
        {
            get { return this.NgSinh; }
            set { this.NgSinh = value; }
        }
        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
        //public void Save(){};


    }
}

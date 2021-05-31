using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class PhieuNhap
    {
        string MaPN;
        List<NguyenLieu> DSPhieuNhap = new List<NguyenLieu>();
        List<int> DSSoLuong = new List<int>();
        DateTime NgNhap;
        int TriGia;

        public PhieuNhap()
        {
            MaPN = "";
            TriGia = 0;
            NgNhap = DateTime.Now;
        }
        public PhieuNhap(string MaPN, List<NguyenLieu> DSPhieuNhap, List<int>DSSoLuong,
            DateTime NgNhap, int TriGia)
        {
            this.MaPN = MaPN;
            this.DSPhieuNhap = DSPhieuNhap;
            this.DSSoLuong = DSSoLuong;
            this.NgNhap = NgNhap;
            this.TriGia = TriGia;
        }
        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public DateTime NG_NHAP
        {
            get { return this.NgNhap; }
            set { this.NgNhap = value; }
        }
        public List<int> DS_SOLUONG
        {
            get { return this.DSSoLuong; }
            set { this.DSSoLuong = value; }
        }
        public List<NguyenLieu> DS_PHIEUNHAP
        {
            get { return this.DSPhieuNhap; }
            set { this.DSPhieuNhap = value; }
        }
        public string MA_PN
        {
            get { return this.MaPN; }
            set { this.MaPN = value; }
        }
        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };
        //public void Save(){};


    }
}

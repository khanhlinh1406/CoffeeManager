using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager.MainClass
{
    public class LoaiKH
    {
        string MaLoaiKH;
        string TenLoaiKH;
        double TLTichDiem;
        double TLGiamGia;
        int DiemLenHang;

        public LoaiKH() { }

        public LoaiKH(string MaLoaiKH, string TenLoaiKH, double TLTichDiem, double TLGiamGia, int DiemLenHang)
        {
            this.MaLoaiKH = MaLoaiKH;
            this.TenLoaiKH = TenLoaiKH;
            this.TLTichDiem = TLTichDiem;
            this.TLGiamGia = TLGiamGia;
            this.DiemLenHang = DiemLenHang;
        }

        public string MA_LOAIKH
        {
            get { return MaLoaiKH; }
            set { this.MaLoaiKH = value; }
        }
        public string TEN_LOAIKH
        {
            get { return TenLoaiKH; }
            set { this.TenLoaiKH = value; }
        }
        public double TL_TICHDIEM
        {
            get { return TLTichDiem; }
            set { this.TLTichDiem = value; }
        }
        public double TL_GIAMGIA
        {
            get { return TLGiamGia; }
            set { this.TLGiamGia = value; }
        }
        public int DIEMLENHANG
        {
            get { return DiemLenHang; }
            set { this.DiemLenHang = value; }
        }
    }
}

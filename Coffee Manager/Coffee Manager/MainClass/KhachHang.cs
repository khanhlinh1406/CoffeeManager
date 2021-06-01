using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class KhachHang
    {
        string MaKH;
        DateTime NgSinh;
        string SoDT;
        string DiaChi;
        DateTime NgDK;
        int Diem;

        public KhachHang()
        {
            MaKH = SoDT = DiaChi = "";
            NgDK = NgSinh = DateTime.Now;
            Diem = 0;
        }

        public KhachHang(string MaKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem)
        {
            this.MaKH = MaKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
        }

        public int DIEM
        {
            get { return this.Diem; }
            set { this.Diem = value; }
        }
        public string DIA_CHI
        {
            get { return this.DiaChi; }
            set { this.DiaChi = value; }
        }
        public string SO_DT
        {
            get { return this.SoDT; }
            set { this.SoDT = value; }
        }
        public DateTime NG_DK
        {
            get { return this.NgDK; }
            set { this.NgDK = value; }
        }
        public DateTime NG_SINH
        {
            get { return this.NgSinh; }
            set { this.NgSinh = value; }
        }
        public string MA_KH
        {
            get { return this.MaKH; }
            set { this.MaKH = value; }
        }


    }
}

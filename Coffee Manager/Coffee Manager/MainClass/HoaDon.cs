using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager
{
    public class HoaDon
    {
        string MaHD;
        string MaNVLap;
        DateTime NgLap;
        List<Mon> DSMon = new List<Mon>();
        List<int> SoLuong = new List<int>();
        int TriGia;

        public HoaDon()
        {
            MaHD = MaNVLap = "";
            NgLap = DateTime.Now;
            TriGia = 0; 
        }

        public HoaDon(string MaHD, string MaNVLap, DateTime NgLap,
            List<Mon>DSMon, List<int>SoLuong, int TriGia)
        {
            this.MaHD = MaHD;
            this.MaNVLap = MaNVLap;
            this.NgLap = NgLap;
            this.DSMon = DSMon;
            this.SoLuong = SoLuong;
            this.TriGia = TriGia;
        }
        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public List<int> SO_LUONG
        {
            get { return this.SoLuong; }
            set { this.SoLuong = value; }
        }
        public List<Mon> DS_MON
        {
            get { return this.DSMon; }
            set { this.DSMon = value; }
        }
        public DateTime NG_LAP
        {
            get { return this.NgLap; }
            set { this.NgLap = value; }
        }
        public string MA_NV_LAP
        {
            get { return this.MaNVLap; }
            set { this.MaNVLap = value; }
        }
        public string MA_HD
        {
            get { return this.MaHD; }
            set { this.MaHD = value; }
        }
    }
}

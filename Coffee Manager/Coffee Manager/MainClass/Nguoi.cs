using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Manager.MainClass
{
    public class Nguoi
    {
        protected string HoTen;
        protected DateTime NgSinh;
        protected string SoDT;
        protected string DiaChi;
        public string HO_TEN
        {
            get { return this.HoTen; }
            set { this.HoTen = value; }
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
        public DateTime NG_SINH
        {
            get { return this.NgSinh; }
            set { this.NgSinh = value; }
        }
    }
}

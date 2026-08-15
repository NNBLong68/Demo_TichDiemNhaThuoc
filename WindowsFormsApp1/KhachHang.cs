using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class KhachHang
    {
        public string sdt {  get; set; }
        public string HoTen {  get; set; }
        public int TongDiemTichLuy { get; set; }

        public KhachHang() { } 
        public KhachHang(string sdt, string hoTen, int tongDiemTichLuy = 0)
        {
            this.sdt = sdt;
            this.HoTen = hoTen;
            this.TongDiemTichLuy = tongDiemTichLuy;
        }
        public int TinhDiemTichLuy(int dc)
        {
            return this.TongDiemTichLuy += dc;
        }
    }
}

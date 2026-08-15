using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GiaoDich
    {
        public KhachHang Khach {  get; set; }
        public long GTHoaDon {  get; set; }
        public int DiemCong {  get; set; }

        public GiaoDich() { }

        public GiaoDich(KhachHang khach, long gTHoaDon, int diemCong)
        {
            Khach = khach;
            GTHoaDon = gTHoaDon;
            DiemCong = diemCong;
        }
    }
}

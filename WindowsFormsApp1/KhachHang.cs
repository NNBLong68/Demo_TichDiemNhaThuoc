using System;
using System.Collections.Generic;
using System.IO;
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

        public void NhapTuFile(string filename, List<KhachHang> dsKhachHang)
        {
            StreamReader sr = new StreamReader(filename);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                string sdt = data[0];
                string hoTen = data[1];
                int tongDiemTichLuy = int.Parse(data[2]);

                KhachHang kh = new KhachHang(sdt, hoTen, tongDiemTichLuy);

                dsKhachHang.Add(kh);
            }
            sr.Close();
        }
    }

}

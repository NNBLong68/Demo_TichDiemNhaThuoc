using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GiaoDich
    {
        public KhachHang Khach {  get; set; }
        public DateTime NgayMua { get; set; }
        public long GTHoaDon {  get; set; }
        public int DiemCong {  get; set; }

        public GiaoDich() { }

        public GiaoDich(KhachHang khach, long gTHoaDon, int diemCong)
        {
            Khach = khach;
            GTHoaDon = gTHoaDon;
            DiemCong = diemCong;
            NgayMua = DateTime.Now;
        }

        public void NhapTuFile(string filename, List<GiaoDich> dsGiaoDich, List<KhachHang> dsKhachHang)
        {
            StreamReader sr = new StreamReader(filename);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                string sdt = data[0];

                DateTime ngayMua = DateTime.ParseExact(
                    data[1],
                    "dd/MM/yyyy HH:mm:ss",
                    null
                );

                long gtHoaDon = long.Parse(data[2]);
                int diemCong = int.Parse(data[3]);

                KhachHang kh = dsKhachHang.FirstOrDefault(x => x.sdt == sdt);

                if (kh != null)
                {
                    GiaoDich gd = new GiaoDich(kh, gtHoaDon, diemCong);

                    gd.NgayMua = ngayMua;

                    dsGiaoDich.Add(gd);
                }
            }

            sr.Close();
        }

        public void LuuVaoFile(string filename, List<GiaoDich> dsGiaoDich)
        {
            StreamWriter sw = new StreamWriter(filename);

            foreach (GiaoDich gd in dsGiaoDich)
            {
                sw.WriteLine(
                    gd.Khach.sdt + "," +
                    gd.NgayMua.ToString("dd/MM/yyyy HH:mm:ss") + "," +
                    gd.GTHoaDon + "," +
                    gd.DiemCong
                );
            }
            sw.Close();

        }
    }
}

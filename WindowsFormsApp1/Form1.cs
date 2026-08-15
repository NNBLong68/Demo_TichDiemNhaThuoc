using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        List<KhachHang> dsKhachHang = new List<KhachHang>();
        List<GiaoDich> dsGiaoDich = new List<GiaoDich>();
        public MainForm()
        {
            InitializeComponent();
        }

        void ThemKhachHang(string sdt, string ten)
        {
            dsKhachHang.Add(new KhachHang(sdt, ten));
        }
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string sdt = txtSDTKhachHang.Text;
            string ten = txtTenKH.Text;

            if (sdt.Length != 10 || sdt[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDTKhachHang.Focus(); //Focus: đưa con trỏ chuột vào control đó
                return;
            }

            long hoaDon = long.Parse(txtHoaDon.Text);
            int dc = ((int)hoaDon / 1000);

            KhachHang kh = dsKhachHang.FirstOrDefault(x => x.sdt == sdt);

            if (kh == null)
            {
                ThemKhachHang(sdt, ten);
                kh = dsKhachHang[dsKhachHang.Count - 1];
                kh.TongDiemTichLuy = kh.TinhDiemTichLuy(dc);
                ThemListViewKhachHang(kh);
            }
            else
            {
                kh.TongDiemTichLuy = kh.TinhDiemTichLuy(dc);
                CapNhatListViewKhachHang(kh);
            }
        }

        void ThemListViewKhachHang(KhachHang kh)
        {
            ListViewItem item = new ListViewItem(kh.sdt);
            item.SubItems.Add(kh.HoTen);
            item.SubItems.Add(kh.TongDiemTichLuy.ToString());

            lVTimKiem.Items.Add(item);
        }

        void CapNhatListViewKhachHang(KhachHang kh)
        {
            foreach (ListViewItem item in lVTimKiem.Items)
            {
                if (item.SubItems[0].Text == kh.sdt)
                {
                    item.SubItems[1].Text = kh.HoTen;
                    item.SubItems[2].Text =
                        kh.TongDiemTichLuy.ToString();

                    return;
                }
            }
        }

        private void txtSDTKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) //số 8 là mã phím backspace, cho phép backspace
            {
                e.Handled = true;
            }
        }
/* Hàm kiểm tra số -chữ:
- e là thông tin phím vừa bấm
- e.Keychar là thông tin ký tự phím vừa bấm
-IsDigit là ký tự đó có phải số không?
-e.Handle là đã xử lý phím này rồi, không cho textbox nhập nữa
*/

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) 
            {
                e.Handled = true;
            }
        }

        private void txtHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtHoaDon.Text, out long hoaDon))
            {
                int diem = (int)(hoaDon / 1000);
                txtDiemCong.Text = diem.ToString();
            }
            else
            {
                txtDiemCong.Text = "0";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDTKhachHang.Clear();
            txtTenKH.Clear();
            txtHoaDon.Clear();
            txtDiemCong.Clear();

            txtSDTKhachHang.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.ToLower();

            lVTimKiem.Items.Clear();

            foreach (KhachHang kh in dsKhachHang)
            {
                if (kh.sdt.Contains(tuKhoa) ||
                    kh.HoTen.ToLower().Contains(tuKhoa))
                {
                    ThemListViewKhachHang(kh);
                }
            }
        }

        private void txtSDTKhachHang_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDTKhachHang.Text;

            foreach (KhachHang kh in dsKhachHang)
            {
                if (kh.sdt == sdt)
                {
                    txtTenKH.Text = kh.HoTen;
                    txtDiemTichLuy.Text = kh.TongDiemTichLuy.ToString();
                    return;
                }
            }

            txtTenKH.Clear();
            txtDiemTichLuy.Clear();
        }

        private void txtHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //nếu key down là Enter
            {
                btnLuuThongTin.PerformClick(); //bấm nút này bằng code
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class Main : Form
    {
        public static Main instance;
        public static Main Instance
        {
            get
            {
                if (instance == null)
                    instance = new Main();
                return instance;
            }
        }


        public Main()
        {
            InitializeComponent();
            //quanLyBanHang1.BringToFront();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            lblDisplayName.Text = Login.disPlayName + " - " + Login.Type;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }







        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            //quanLyBanHang1.BringToFront();

            if (!panelMain.Controls.Contains(f_QuanLyBanHang.Instance))
            {
                f_QuanLyBanHang.Instance.Dock = DockStyle.Fill;
                f_QuanLyBanHang.Instance.TopLevel = false;
                f_QuanLyBanHang.Instance.TopMost = true;
                panelMain.Controls.Add(f_QuanLyBanHang.Instance);
                f_QuanLyBanHang.Instance.Show();
                f_QuanLyBanHang.Instance.BringToFront();

            }
            else
            {
                f_QuanLyBanHang.Instance.Show();
                f_QuanLyBanHang.Instance.BringToFront();
            }
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            
            if (Login.Type != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
            else
            {
                //baoCao_ThongKe1.BringToFront();

                if (!panelMain.Controls.Contains(f_BaoCao_ThongKe.Instance))
                {

                    f_BaoCao_ThongKe.Instance.Dock = DockStyle.Fill;
                    f_BaoCao_ThongKe.Instance.TopLevel = false;
                    f_BaoCao_ThongKe.Instance.TopMost = true;
                    panelMain.Controls.Add(f_BaoCao_ThongKe.Instance);
                    f_BaoCao_ThongKe.Instance.Show();
                    f_BaoCao_ThongKe.Instance.BringToFront();
                }
                else
                {
                    f_BaoCao_ThongKe.Instance.Show();
                    f_BaoCao_ThongKe.Instance.BringToFront();
                }
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            instance = null;
            Login fLogin = new Login();
            fLogin.Show();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            
            if (Login.Type != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
            else
            {
                //quanLyNhanVien1.BringToFront();

                if (!panelMain.Controls.Contains(f_QuanLyNhanVien.Instance))
                {

                    f_QuanLyNhanVien.Instance.Dock = DockStyle.Fill;
                    f_QuanLyNhanVien.Instance.TopLevel = false;
                    f_QuanLyNhanVien.Instance.TopMost = true;
                    panelMain.Controls.Add(f_QuanLyNhanVien.Instance);
                    f_QuanLyNhanVien.Instance.Show();
                    f_QuanLyNhanVien.Instance.BringToFront();
                }
                else
                {
                    f_QuanLyNhanVien.Instance.Show();
                    f_QuanLyNhanVien.Instance.BringToFront();
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            
            if (Login.Type != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
            else
            {
                //quanLySanPham1.BringToFront();

                if (!panelMain.Controls.Contains(f_QuanLySanPham.Instance))
                {

                    f_QuanLySanPham.Instance.Dock = DockStyle.Fill;
                    f_QuanLySanPham.Instance.TopLevel = false;
                    f_QuanLySanPham.Instance.TopMost = true;
                    panelMain.Controls.Add(f_QuanLySanPham.Instance);
                    f_QuanLySanPham.Instance.Show();
                    f_QuanLySanPham.Instance.BringToFront();
                }
                else
                {
                    f_QuanLySanPham.Instance.Show();
                    f_QuanLySanPham.Instance.BringToFront();
                }
            }
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            
            if (Login.Type != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
            else
            {
                //danhMuc1.BringToFront();

                if (!panelMain.Controls.Contains(f_DanhMuc.Instance))
                {

                    f_DanhMuc.Instance.Dock = DockStyle.Fill;
                    f_DanhMuc.Instance.TopLevel = false;
                    f_DanhMuc.Instance.TopMost = true;
                    panelMain.Controls.Add(f_DanhMuc.Instance);
                    f_DanhMuc.Instance.Show();
                    f_DanhMuc.Instance.BringToFront();
                }
                else
                {
                    f_DanhMuc.Instance.Show();
                    f_DanhMuc.Instance.BringToFront();
                }
            }
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            

            if (Login.Type != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
            else
            {
                //quanLyban1.BringToFront();


                if (!panelMain.Controls.Contains(f_QuanLyBan.Instance))
                {

                    f_QuanLyBan.Instance.Dock = DockStyle.Fill;
                    f_QuanLyBan.Instance.TopLevel = false;
                    f_QuanLyBan.Instance.TopMost = true;
                    panelMain.Controls.Add(f_QuanLyBan.Instance);
                    f_QuanLyBan.Instance.Show();
                    f_QuanLyBan.Instance.BringToFront();
                }
                else
                {
                    f_QuanLyBan.Instance.Show();
                    f_QuanLyBan.Instance.BringToFront();
                }
            }
        }
    }
}

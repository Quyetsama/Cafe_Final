using QuanLyQuanCafe_Nhom14.Class;
using QuanLyQuanCafe_Nhom14.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe_Nhom14
{
    public partial class f_BaoCao_ThongKe : Form
    {
        DataTable dataExportExcel;

        public static f_BaoCao_ThongKe instance;
        public static f_BaoCao_ThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new f_BaoCao_ThongKe();
                return instance;
            }
        }

        public f_BaoCao_ThongKe()
        {
            InitializeComponent();
        }

        private void f_BaoCao_ThongKe_Load(object sender, EventArgs e)
        {
            DateTimeTu.Value = DateTime.Now.AddDays(-7);
            DateTimeDen.Value = DateTime.Now;
            DateTimeDen.CustomFormat = "yyyy-MM-dd";
            DateTimeDen.Format = DateTimePickerFormat.Custom;
            DateTimeTu.CustomFormat = "yyyy-MM-dd";
            DateTimeTu.Format = DateTimePickerFormat.Custom;


            label6.Text = label7.Text = label10.Text = "Báo cáo ngày hôm nay " + DateTime.Now.ToString("dd-MM-yyyy");


            cbbThongKe.Items.Add("Doanh Thu");
            cbbThongKe.Items.Add("Sản Phẩm");

            cbbThongKe.SelectedIndex = 0;

            ThongKe();
        }

        void ThongKe()
        {

            chart1.Series[0].Points.Clear();

            if (cbbThongKe.Text.ToString() == "Doanh Thu")
            {
                // Hien thi danh sach hoa don
                DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_ThongKeBill @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });
                dtgThongKe.DataSource = data;


                // lay doanh thu theo ngay va ve bieu do
                List<DoanhThuNgay> listDoanhThu = new List<DoanhThuNgay>();
                DataTable dataDoanhThu = DataProvider.Instance.ExecuteQuery("exec USP_BieuDoThongKeDoanhThu @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });

                foreach (DataRow row in dataDoanhThu.Rows)
                {
                    DoanhThuNgay doanhThu = new DoanhThuNgay(row);
                    listDoanhThu.Add(doanhThu);
                }

                chart1.Series[0].Name = "Doanh Thu (VNĐ)";

                foreach (DoanhThuNgay item in listDoanhThu)
                {
                    chart1.Series[0].Points.AddXY(item.Date.Value.ToString("yyyy-MM-dd"), (float)item.TotalPrice);
                }


                dataExportExcel = data;
            }
            else
            {
                List<ThongKeSanPham> listSanPham = new List<ThongKeSanPham>();
                DataTable dataSanPham = DataProvider.Instance.ExecuteQuery("exec USP_ThongKeSanPham @Date1 , @Date2", new object[] { DateTimeTu.Value.ToString("yyyy-MM-dd"), DateTimeDen.Value.ToString("yyyy-MM-dd") });

                dtgThongKe.DataSource = dataSanPham;

                foreach (DataRow row in dataSanPham.Rows)
                {
                    ThongKeSanPham tkSanPham = new ThongKeSanPham(row);
                    listSanPham.Add(tkSanPham);
                }

                chart1.Series[0].Name = "Số Lượng Đã Bán";

                foreach (ThongKeSanPham item in listSanPham)
                {
                    chart1.Series[0].Points.AddXY(item.TenSP.ToString(), item.DaBan);
                }


                dataExportExcel = dataSanPham;
            }


            try
            {
                string doanhThuNow = "0", hoaDonNow = "0", daBanNow = "0";

                doanhThuNow = DataProvider.Instance.ExecuteScalar("select sum(totalPrice) from Bill where DateCheckIn = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' group by DateCheckIn").ToString();
                lblDoanhThu.Text = doanhThuNow.ToString() + " ₫";

                hoaDonNow = DataProvider.Instance.ExecuteScalar("select count(DateCheckIn) from Bill where DateCheckIn = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'").ToString();
                lblSLHoaDon.Text = hoaDonNow.ToString();

                daBanNow = DataProvider.Instance.ExecuteScalar("select sum(bi.count) from BillInfo as bi, Bill as b where DateCheckIn = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and bi.idBill = b.id group by b.DateCheckIn").ToString();
                lblSLDaBan.Text = daBanNow.ToString();
            }
            catch (Exception)
            {

            }





        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel obj = new ExportExcel();
                if (cbbThongKe.Text.ToString() == "Doanh Thu")
                {
                    obj.WriteDataTableToExcel(dataExportExcel, "Doanh Thu", folderBrowserDialog.SelectedPath + "\\" + "thongKeDoanhThu.xlsx", "");
                }
                else
                {
                    obj.WriteDataTableToExcel(dataExportExcel, "Sản Phẩm Đã Bán", folderBrowserDialog.SelectedPath + "\\" + "thongKeSPDaBan.xlsx", "");
                }


                MessageBox.Show("Xuất file thống kê thành công!", "Thông Báo");
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            instance = null;
        }
    }
}

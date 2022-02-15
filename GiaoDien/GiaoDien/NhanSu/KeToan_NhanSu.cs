using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace GiaoDien.NhanSu
{
    public partial class KeToan_NhanSu : Form
    {
        public KeToan_NhanSu()
        {
            InitializeComponent();
        }

        public string username;
        public string password;

        string strTemp;
        public string Message
        {
            get { return strTemp; }
            set
            {
                strTemp = value;
            }
        }
        public void displayData_In4()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.NHANVIEN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_NhanSu.DataSource = dtbl;
                dgv_NhanSu.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_manv.Text = dgv_NhanSu.Rows[0].Cells[0].Value.ToString();
                txt_TenNhanVien.Text = dgv_NhanSu.Rows[0].Cells[1].Value.ToString();
                txt_DiaChi.Text = dgv_NhanSu.Rows[0].Cells[2].Value.ToString();
                txt_NgaySinh.Text = dgv_NhanSu.Rows[0].Cells[3].Value.ToString();

                txt_CMND.Text = dgv_NhanSu.Rows[0].Cells[4].Value.ToString();
                lb_Luong.Text = dgv_NhanSu.Rows[0].Cells[5].Value.ToString();
                txt_GioiTinh.Text = dgv_NhanSu.Rows[0].Cells[6].Value.ToString();
                lb_PhuCap.Text = dgv_NhanSu.Rows[0].Cells[7].Value.ToString();
                lbDonVi.Text = dgv_NhanSu.Rows[0].Cells[8].Value.ToString();
               
                
                conn.Close();
            }
        }

        private void KeToan_NhanSu_Load(object sender, EventArgs e)
        {
            displayData_In4();
        }

        private void dgv_NhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_NhanSu.CurrentRow.Index;
            lb_manv.Text = dgv_NhanSu.Rows[i].Cells[0].Value.ToString();
            txt_TenNhanVien.Text = dgv_NhanSu.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dgv_NhanSu.Rows[i].Cells[2].Value.ToString();
            txt_NgaySinh.Text = dgv_NhanSu.Rows[i].Cells[3].Value.ToString();
            txt_CMND.Text = dgv_NhanSu.Rows[i].Cells[4].Value.ToString();
            lb_Luong.Text = dgv_NhanSu.Rows[i].Cells[5].Value.ToString();
            txt_GioiTinh.Text = dgv_NhanSu.Rows[i].Cells[6].Value.ToString();
            lb_PhuCap.Text = dgv_NhanSu.Rows[i].Cells[7].Value.ToString();
            lbDonVi.Text = dgv_NhanSu.Rows[i].Cells[8].Value.ToString();
        }
    }
}

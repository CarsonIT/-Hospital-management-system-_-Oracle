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

namespace GiaoDien.HoSoBenhAn
{
    public partial class BacSi_HoSoBenhAn : Form
    {
        public BacSi_HoSoBenhAn()
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

        public void displayData_HoSoBenhAn()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.HOSOBENHAN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_HoSoBenhAn.DataSource = dtbl;
                dgv_HoSoBenhAn.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_makb.Text = dgv_HoSoBenhAn.Rows[0].Cells[0].Value.ToString();
                txt_NKham.Text = dgv_HoSoBenhAn.Rows[0].Cells[1].Value.ToString();
                lb_tinhtrangbd.Text = dgv_HoSoBenhAn.Rows[0].Cells[2].Value.ToString();
                lb_KLuanBs.Text = dgv_HoSoBenhAn.Rows[0].Cells[3].Value.ToString();
                lbMaBenhNhan.Text = dgv_HoSoBenhAn.Rows[0].Cells[4].Value.ToString();
                lb_NhanVienDieuPhoi.Text = dgv_HoSoBenhAn.Rows[0].Cells[5].Value.ToString();
                lb_BacSiDieuTri.Text = dgv_HoSoBenhAn.Rows[0].Cells[6].Value.ToString();
                conn.Close();
            }
        }

        private void txt_NKham_TextChanged(object sender, EventArgs e)
        {

        }

        private void BacSi_HoSoBenhAn_Load(object sender, EventArgs e)
        {
            displayData_HoSoBenhAn();
        }

        private void dgv_HoSoBenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoSoBenhAn.CurrentRow.Index;
            lb_makb.Text = dgv_HoSoBenhAn.Rows[i].Cells[0].Value.ToString();
            txt_NKham.Text = dgv_HoSoBenhAn.Rows[i].Cells[1].Value.ToString();
            lb_tinhtrangbd.Text = dgv_HoSoBenhAn.Rows[i].Cells[2].Value.ToString();
            lb_KLuanBs.Text = dgv_HoSoBenhAn.Rows[i].Cells[3].Value.ToString();
            lbMaBenhNhan.Text = dgv_HoSoBenhAn.Rows[i].Cells[4].Value.ToString();
            lb_NhanVienDieuPhoi.Text = dgv_HoSoBenhAn.Rows[i].Cells[5].Value.ToString();
            lb_BacSiDieuTri.Text = dgv_HoSoBenhAn.Rows[i].Cells[6].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = " Update ADMINBV.HOSOBENHAN SET KetLuanCuaBacSi = '"
                        + lb_KLuanBs.Text
                        + "'  where MaKhamBenh = '" + lb_makb.Text + "' ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    displayData_HoSoBenhAn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

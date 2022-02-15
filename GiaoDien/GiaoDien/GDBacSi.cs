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
namespace GiaoDien
{
    public partial class GDBacSi : Form
    {
        public GDBacSi()
        {
            InitializeComponent();
        }
        public string username;
        public string password;

        //public void displayData()
        //{

        //    using (OracleConnection conn = DBConnection.GetConnection(username, password))
        //    {
        //        conn.Open();
        //        OracleDataAdapter orcData = new OracleDataAdapter("select * from ADQLBV.NHANVIEN ", conn);
        //        DataTable dtbl = new DataTable();
        //        orcData.Fill(dtbl);
        //        dgv_bs.DataSource = dtbl;
        //        dgv_bs.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        //        conn.Close();
        //    }
        //}
        public void Alert_GDBacSi(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void displayData_In4_Bacsi()
        {

            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.NHANVIEN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                lb_manv.Text = dtbl.Rows[0][0].ToString();
                txt_TenNhanVien.Text = dtbl.Rows[0][1].ToString();
                txt_DiaChi.Text = dtbl.Rows[0][2].ToString();
                txt_NgaySinh.Text = dtbl.Rows[0][3].ToString();
                txt_CMND.Text = dtbl.Rows[0][4].ToString();
                lb_Luong.Text = dtbl.Rows[0][5].ToString();
                txt_GioiTinh.Text = dtbl.Rows[0][6].ToString();
                lb_PhuCap.Text = dtbl.Rows[0][7].ToString();
                lbDonVi.Text = dtbl.Rows[0][8].ToString();

                lbWelcome.Text = dtbl.Rows[0][1].ToString();
                conn.Close();
            }
        }

        public void displayData_ChamCong()
        {

            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.CHAMCONG ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_ChamCong.DataSource = dtbl;
                dgv_ChamCong.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_MaNV_CC.Text = dgv_ChamCong.Rows[0].Cells[0].Value.ToString();
                lb_Thang_CC.Text = dgv_ChamCong.Rows[0].Cells[1].Value.ToString();
                lb_Nam_CC.Text = dgv_ChamCong.Rows[0].Cells[2].Value.ToString();
                lb_SoNgayCong_CC.Text = dgv_ChamCong.Rows[0].Cells[3].Value.ToString();

                conn.Close();
            }
        }

        private void GDBacSi_Load(object sender, EventArgs e)
        {
            //displayData();
            displayData_In4_Bacsi();
            displayData_ChamCong();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logout = new Login();
            logout.ShowDialog();
            this.Close();
        }

        private void topdashboard_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //OracleConnection conn = DBConnection.GetConnection(username, password);
            //using (OracleConnection conn = DBConnection.GetConnection(username, password))
            //{
            //    conn.Open();
            //    string queryUpdate1 = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" + txt_TenNhanVien.Text + "' WHERE MANHANVIEN " + lb_manv.Text;
            //    OracleCommand cmdMain = new OracleCommand(queryUpdate1, conn);
            //    cmdMain.ExecuteNonQuery();
            //    conn.Close();

            //}
            OracleConnection conn = DBConnection.GetConnection(username, password);
            try
            {
                conn.Open();
                //string sql = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" + txt_TenNhanVien.Text + "', DiaChi = '" + txt_DiaChi.Text +"' WHERE MANHANVIEN = '" + lb_manv.Text+"'";
                string sql = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" + txt_TenNhanVien.Text + "', DiaChi = '" + txt_DiaChi.Text + "', GioiTinh = '" + txt_GioiTinh.Text + "', CMND = '" + txt_CMND.Text + "' WHERE MANHANVIEN = '" + lb_manv.Text + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully !!!");
                //this.Alert_GDBacSi("Updated successfully !!!", Form_Alert.enmType.Success);
                displayData_In4_Bacsi();

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

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_PhuCap_Click(object sender, EventArgs e)
        {

        }

        private void lb_Luong_Click(object sender, EventArgs e)
        {

        }

        private void lb_manv_Click(object sender, EventArgs e)
        {

        }

        private void label_mnv_Click(object sender, EventArgs e)
        {

        }

        private void lbDonVi_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbVaiTro_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_GioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_ChamCong.CurrentRow.Index;
            lb_MaNV_CC.Text = dgv_ChamCong.Rows[i].Cells[0].Value.ToString();
            lb_Thang_CC.Text = dgv_ChamCong.Rows[i].Cells[1].Value.ToString();
            lb_Nam_CC.Text = dgv_ChamCong.Rows[i].Cells[2].Value.ToString();
            lb_SoNgayCong_CC.Text = dgv_ChamCong.Rows[i].Cells[3].Value.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoSoBA_Click(object sender, EventArgs e)
        {
            GiaoDien.HoSoBenhAn.BacSi_HoSoBenhAn hsba = new GiaoDien.HoSoBenhAn.BacSi_HoSoBenhAn();
            hsba.Message = lb_manv.Text;
            hsba.ShowDialog();
        }

        private void btn_HoSoDichVu_Click(object sender, EventArgs e)
        {
            GiaoDien.HoSoDichVu.BacSi_HS_DichVu hsdv = new GiaoDien.HoSoDichVu.BacSi_HS_DichVu();
            hsdv.Message = lb_manv.Text;
            hsdv.ShowDialog();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            GiaoDien.DichVu.DichVu_View_BS_KTV dv = new GiaoDien.DichVu.DichVu_View_BS_KTV();
            dv.Message = lb_manv.Text;
            dv.ShowDialog();
        }
    }
}

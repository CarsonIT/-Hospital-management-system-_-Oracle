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
    public partial class GDQuanlyTNNS : Form
    {
        public GDQuanlyTNNS()
        {
            InitializeComponent();
        }

        public string username;
        public string password;

        public string Message
        {
            get { return username; }
            set
            {
                username = value;
            }
        }

        public void displayData_In4()
        {
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.NHANVIEN where MaNhanVien = 'QLTNNS1' ", conn);
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
                lbName.Text = dtbl.Rows[0][1].ToString();
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

                txt_MaNhanVien.Text = dgv_ChamCong.Rows[0].Cells[0].Value.ToString();
                txtThang.Text = dgv_ChamCong.Rows[0].Cells[1].Value.ToString();
                txtNam.Text = dgv_ChamCong.Rows[0].Cells[2].Value.ToString();
                txt_SoNgayCong.Text = dgv_ChamCong.Rows[0].Cells[3].Value.ToString();

                conn.Close();
            }
        }

        public void displayData_ThongBao()
        {
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select NoiDung, label_to_char(label_tb) as Label from ADMINBV.THONGBAO", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_ThongBao.DataSource = dtbl;
                dgv_ThongBao.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                lb_Tb.Text = dgv_ThongBao.Rows[0].Cells[0].Value.ToString();
                conn.Close();
            }
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logout = new Login();
            logout.ShowDialog();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
             OracleConnection conn = DBConnection.GetConnection(username, password);
            try
            {
                conn.Open();
                string sql = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" + txt_TenNhanVien.Text + "', DiaChi = '" + txt_DiaChi.Text + "', GioiTinh = '" + txt_GioiTinh.Text + "', CMND = '" + txt_CMND.Text + "' WHERE MANHANVIEN = '" + lb_manv.Text + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully !!!");
                //this.Alert_GDBacSi("Updated successfully !!!", Form_Alert.enmType.Success);
                displayData_In4();

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

        private void GDQuanlyTNNS_Load(object sender, EventArgs e)
        {
            displayData_In4();
            displayData_ChamCong();
            displayData_ThongBao();
        }

        private void dgv_ChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_ChamCong.CurrentRow.Index;
            txt_MaNhanVien.Text = dgv_ChamCong.Rows[i].Cells[0].Value.ToString();
            txtThang.Text = dgv_ChamCong.Rows[i].Cells[1].Value.ToString();
            txtNam.Text = dgv_ChamCong.Rows[i].Cells[2].Value.ToString();
            txt_SoNgayCong.Text = dgv_ChamCong.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            GiaoDien.ChamCongCaNhan.ChamCongQLTNNS CCQLTNNS = new GiaoDien.ChamCongCaNhan.ChamCongQLTNNS();
            CCQLTNNS.Message = lb_manv.Text;
            CCQLTNNS.ShowDialog();
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            GiaoDien.NhanSu.QuanLyTNNS_NhanSu ns = new GiaoDien.NhanSu.QuanLyTNNS_NhanSu();
            ns.Message = lb_manv.Text;
            ns.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = "Insert into ADMINBV.CHAMCONG( MaNhanVien , Thang , Nam , SoNgayCong) "
                                                         + " values( '" + txt_MaNhanVien.Text + "' , '"
                                                         + txtThang.Text + "' , '"
                                                         + txtNam.Text + "' , '"
                                                         + txt_SoNgayCong.Text + "')";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    displayData_ChamCong();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = " DELETE FROM ADMINBV.CHAMCONG WHERE MaNhanVien = '" + txt_MaNhanVien.Text + "' and Thang = " + txtThang.Text + " and Nam = "+ txtNam.Text;

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    displayData_ChamCong();

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

        private void btn_Update_ChamCong_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    
                    string sql = " Update ADMINBV.CHAMCONG SET SoNgayCong = "
                        + txt_SoNgayCong.Text
                        + "  where MaNhanVien = '" + txt_MaNhanVien.Text + "' and Thang = " + txtThang.Text + " and Nam = " + txtNam.Text;

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    displayData_ChamCong();
                    
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

        private void btn_QuanLyDonVi_Click(object sender, EventArgs e)
        {
            GiaoDien.DonVi.QuanLyDonVi dv = new GiaoDien.DonVi.QuanLyDonVi();
            dv.Message = lb_manv.Text;
            dv.ShowDialog();
        }

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            GiaoDien.BenhNhan.BenhNhan bn = new GiaoDien.BenhNhan.BenhNhan();
            bn.Message = lb_manv.Text;
            bn.ShowDialog();
        }

        private void btn_HoSoBA_Click(object sender, EventArgs e)
        {
            GiaoDien.HoSoBenhAn.HoSoBA hsba = new GiaoDien.HoSoBenhAn.HoSoBA();
            hsba.Message = lb_manv.Text;
            hsba.ShowDialog();
        }

        private void btn_HoSoDichVu_Click(object sender, EventArgs e)
        {
            GiaoDien.HoSoDichVu.HS_DichVu hsdv = new GiaoDien.HoSoDichVu.HS_DichVu();
            hsdv.Message = lb_manv.Text;
            hsdv.ShowDialog();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            GiaoDien.DichVu.DichVu_View DV = new GiaoDien.DichVu.DichVu_View();
            DV.Message = lb_manv.Text;
            DV.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_ThongBao.CurrentRow.Index;
            lb_Tb.Text = dgv_ThongBao.Rows[i].Cells[0].Value.ToString();
        }
    }
}

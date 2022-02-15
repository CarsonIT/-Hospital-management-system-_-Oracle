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
    public partial class QuanLyTNNS_NhanSu : Form
    {
        public QuanLyTNNS_NhanSu()
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
                txt_manv.Text = dtbl.Rows[0][0].ToString();
                txt_TenNhanVien.Text = dtbl.Rows[0][1].ToString();
                txt_DiaChi.Text = dtbl.Rows[0][2].ToString();
                txt_NgaySinh.Text = dtbl.Rows[0][3].ToString();
                txt_CMND.Text = dtbl.Rows[0][4].ToString();
                txt_Luong.Text = dtbl.Rows[0][5].ToString();
                txt_GioiTinh.Text = dtbl.Rows[0][6].ToString();
                txt_PhuCap.Text = dtbl.Rows[0][7].ToString();
                txt_DonVi.Text = dtbl.Rows[0][8].ToString();
                
                conn.Close();
            }
        }

        private void QuanLyTNNS_NhanSu_Load(object sender, EventArgs e)
        {
            displayData_In4();
        }

        private void dgv_NhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_NhanSu.CurrentRow.Index;
            txt_manv.Text = dgv_NhanSu.Rows[i].Cells[0].Value.ToString();
            txt_TenNhanVien.Text = dgv_NhanSu.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dgv_NhanSu.Rows[i].Cells[2].Value.ToString();
            txt_NgaySinh.Text = dgv_NhanSu.Rows[i].Cells[3].Value.ToString();
            txt_CMND.Text = dgv_NhanSu.Rows[i].Cells[4].Value.ToString();
            txt_Luong.Text = dgv_NhanSu.Rows[i].Cells[5].Value.ToString();
            txt_GioiTinh.Text = dgv_NhanSu.Rows[i].Cells[6].Value.ToString();
            txt_PhuCap.Text = dgv_NhanSu.Rows[i].Cells[7].Value.ToString();
            txt_DonVi.Text = dgv_NhanSu.Rows[i].Cells[8].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = "Insert into ADMINBV.NHANVIEN( MaNhanVien , HoTen , DiaChi , NgaySinh , CMND , Luong , GioiTinh, PhuCap, DonVi) "
                                                         + " values( '" + txt_manv.Text + "' , '"
                                                         + txt_TenNhanVien.Text + "' , '"
                                                         + txt_DiaChi.Text
                                                         + "' , to_date('" + txt_NgaySinh.Text + "', 'DD-MM-YYYY'), '"
                                                         + txt_CMND.Text + "' , "
                                                         + int.Parse(txt_Luong.Text) + " , '"
                                                         + txt_GioiTinh.Text + "' , "
                                                         + int.Parse(txt_PhuCap.Text) + ", '"
                                                         + txt_DonVi.Text + "')";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
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
                    //string sql = "UPDATE ADMINBV.NHANVIEN SET HoTen = '" 
                    //    + txt_TenNhanVien.Text + "', DiaChi = '" 
                    //    + txt_DiaChi.Text + "', GioiTinh = '" 
                    //    + txt_GioiTinh.Text + "', CMND = '" 
                    //    + txt_CMND.Text + "', VaiTro = '"
                    //    + txt_VaiTro.Text + "', DonVi ='"
                    //    + txt_DonVi.Text
                    //    + "' WHERE MANHANVIEN = '" 
                    //    + txt_manv.Text + "'";
                    string sql = " Update ADMINBV.NHANVIEN SET HoTen = '" 
                        + txt_TenNhanVien.Text + "' , DiaChi = '" 
                        + txt_DiaChi.Text + "' , CMND = '" 
                        + txt_CMND.Text + "' , NgaySinh = to_date('" + txt_NgaySinh.Text + "', 'DD-MM-YYYY')  , Luong = '" 
                        + txt_Luong.Text + "' , PhuCap = '" 
                        + txt_PhuCap.Text + "' , DonVi = '"
                        + txt_DonVi.Text + "', GioiTinh = '"
                        + txt_GioiTinh.Text
                        + "'  where MaNhanVien = '" + txt_manv.Text + "' ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
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
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = " Delete from ADMINBV.NHANVIEN where MaNhanVien = '" + txt_manv.Text + "' ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
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
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

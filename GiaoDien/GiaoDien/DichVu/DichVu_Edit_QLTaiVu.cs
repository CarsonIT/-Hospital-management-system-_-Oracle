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

namespace GiaoDien.DichVu
{
    public partial class DichVu_Edit_QLTaiVu : Form
    {
        public DichVu_Edit_QLTaiVu()
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

        public void displayData_HoSoDichVu()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.DICHVU ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_DichVu.DataSource = dtbl;
                dgv_DichVu.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_MaDichVu.Text = dgv_DichVu.Rows[0].Cells[0].Value.ToString();
                lb_TenDichVu.Text = dgv_DichVu.Rows[0].Cells[1].Value.ToString();
                lb_DonGia.Text = dgv_DichVu.Rows[0].Cells[2].Value.ToString();
                conn.Close();
            }
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
                    string sql = "Insert into ADMINBV.DICHVU(MaDichVu,TenDichVu,DonGia) "
                                                         + " values('" + lb_MaDichVu.Text + "', '"
                                                         + lb_TenDichVu.Text + "',"
                                                         + lb_DonGia.Text
                                                         + ")";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    displayData_HoSoDichVu();
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
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                try
                {
                    conn.Open();
                    string sql = " Update ADMINBV.DICHVU SET TenDichVu = '"
                        + lb_TenDichVu.Text + "', DonGia = "
                        + lb_DonGia.Text
                        + " where MaDichVu = '" + lb_MaDichVu.Text + "' ";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    displayData_HoSoDichVu();
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
                    string sql = " Delete from ADMINBV.DICHVU where MaDichVu = '" + lb_MaDichVu.Text + "' ";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    displayData_HoSoDichVu();
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

        private void DichVu_Edit_QLTaiVu_Load(object sender, EventArgs e)
        {
            displayData_HoSoDichVu();
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DichVu.CurrentRow.Index;
            lb_MaDichVu.Text = dgv_DichVu.Rows[i].Cells[0].Value.ToString();
            lb_TenDichVu.Text = dgv_DichVu.Rows[i].Cells[1].Value.ToString();
            lb_DonGia.Text = dgv_DichVu.Rows[i].Cells[2].Value.ToString();
        }
    }
}

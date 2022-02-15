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

namespace GiaoDien.DonVi
{
    public partial class QuanLyDonVi : Form
    {
        public QuanLyDonVi()
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

        public void displayData_DonVi()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.DONVI ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_DonVi.DataSource = dtbl;
                dgv_DonVi.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                txt_MaDonVi.Text = dgv_DonVi.Rows[0].Cells[0].Value.ToString();
                txt_TenDonVi.Text = dgv_DonVi.Rows[0].Cells[1].Value.ToString();

                conn.Close();
            }
        }

        private void QuanLyDonVi_Load(object sender, EventArgs e)
        {
            displayData_DonVi();
        }

        private void dgv_DonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DonVi.CurrentRow.Index;
            txt_MaDonVi.Text = dgv_DonVi.Rows[i].Cells[0].Value.ToString();
            txt_TenDonVi.Text = dgv_DonVi.Rows[i].Cells[1].Value.ToString();
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
                    string sql = "Insert into ADMINBV.DONVI( MaDonVi , TenDonVi) "
                                                         + " values('" + txt_MaDonVi.Text + "' , '"
                                                         + txt_TenDonVi.Text + "')";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    displayData_DonVi();
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
                    string sql = " Update ADMINBV.DONVI SET TenDonVi = '"
                        + txt_TenDonVi.Text
                        + "'  where MaDonVi = '" + txt_MaDonVi.Text + "' ";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    displayData_DonVi();
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
                    string sql = " Delete from ADMINBV.DONVI where MaDonVi = '" + txt_MaDonVi.Text + "' ";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    displayData_DonVi();
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
    }
}

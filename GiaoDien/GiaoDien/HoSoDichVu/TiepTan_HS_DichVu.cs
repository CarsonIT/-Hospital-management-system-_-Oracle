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

namespace GiaoDien.HoSoDichVu
{
    public partial class TiepTan_HS_DichVu : Form
    {
        public TiepTan_HS_DichVu()
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
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.HOSODICHVU ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_HoSoDichVu.DataSource = dtbl;
                dgv_HoSoDichVu.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_MaKham.Text = dgv_HoSoDichVu.Rows[0].Cells[0].Value.ToString();
                lb_MaDV.Text = dgv_HoSoDichVu.Rows[0].Cells[1].Value.ToString();
                txt_NgayGio.Text = dgv_HoSoDichVu.Rows[0].Cells[2].Value.ToString();
                lb_KetLuan.Text = dgv_HoSoDichVu.Rows[0].Cells[3].Value.ToString();
                lb_KTV.Text = dgv_HoSoDichVu.Rows[0].Cells[4].Value.ToString();
                conn.Close();
            }
        }

        private void TiepTan_HS_DichVu_Load(object sender, EventArgs e)
        {
            displayData_HoSoDichVu();
        }

        private void dgv_HoSoDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoSoDichVu.CurrentRow.Index;
            lb_MaKham.Text = dgv_HoSoDichVu.Rows[i].Cells[0].Value.ToString();
            lb_MaDV.Text = dgv_HoSoDichVu.Rows[i].Cells[1].Value.ToString();
            txt_NgayGio.Text = dgv_HoSoDichVu.Rows[i].Cells[2].Value.ToString();
            lb_KetLuan.Text = dgv_HoSoDichVu.Rows[i].Cells[3].Value.ToString();
            lb_KTV.Text = dgv_HoSoDichVu.Rows[i].Cells[4].Value.ToString();
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
                    string sql = " Update ADMINBV.HOSODICHVU SET KYTHUATVIEN = '"
                        + lb_KTV.Text
                        + "'  where MAKHAMBENH = '" + lb_MaKham.Text + "' and MADICHVU = '" + lb_MaDV.Text +"'";

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
    }
}

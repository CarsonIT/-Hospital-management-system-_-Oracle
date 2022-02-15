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

namespace GiaoDien.BenhNhan
{
    public partial class TiepTan_BenhNhan : Form
    {
        public TiepTan_BenhNhan()
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

        public void displayData_BenhNhan()
        {
            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.BENHNHAN ", conn);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);

                dgv_BenhNhan.DataSource = dtbl;
                dgv_BenhNhan.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                lb_mabn.Text = dgv_BenhNhan.Rows[0].Cells[0].Value.ToString();
                lb_TenBN.Text = dgv_BenhNhan.Rows[0].Cells[1].Value.ToString();
                txt_NSinh.Text = dgv_BenhNhan.Rows[0].Cells[2].Value.ToString();
                lbDiaChi.Text = dgv_BenhNhan.Rows[0].Cells[3].Value.ToString();
                lb_SDT.Text = dgv_BenhNhan.Rows[0].Cells[4].Value.ToString();
                lb_CMND.Text = dgv_BenhNhan.Rows[0].Cells[5].Value.ToString();
                lb_BHYT.Text = dgv_BenhNhan.Rows[0].Cells[6].Value.ToString();
                conn.Close();
            }
        }
        private void txt_NSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void TiepTan_BenhNhan_Load(object sender, EventArgs e)
        {
            displayData_BenhNhan();
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
                    string sql = "Insert into ADMINBV.BENHNHAN( MaBenhNhan , NgaySinh, HoTen, DiaChi, SoDienThoai, CMND, BHYT) "
                                                         + " values( '" + lb_mabn.Text
                                                         + "' , to_date('" + txt_NSinh.Text + "', 'DD-MM-YYYY'), '"
                                                         + lb_TenBN.Text + "' , '"
                                                         + lbDiaChi.Text + "' , '"
                                                         + lb_SDT.Text + "' , '"
                                                         + lb_CMND.Text + "' , '"
                                                         + lb_BHYT.Text + "')";


                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    displayData_BenhNhan();
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

        private void dgv_BenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_BenhNhan.CurrentRow.Index;
            lb_mabn.Text = dgv_BenhNhan.Rows[i].Cells[0].Value.ToString();
            lb_TenBN.Text = dgv_BenhNhan.Rows[i].Cells[1].Value.ToString();
            txt_NSinh.Text = dgv_BenhNhan.Rows[i].Cells[2].Value.ToString();
            lbDiaChi.Text = dgv_BenhNhan.Rows[i].Cells[3].Value.ToString();
            lb_SDT.Text = dgv_BenhNhan.Rows[i].Cells[4].Value.ToString();
            lb_CMND.Text = dgv_BenhNhan.Rows[i].Cells[5].Value.ToString();
            lb_BHYT.Text = dgv_BenhNhan.Rows[i].Cells[6].Value.ToString();
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
                    string sql = " Update ADMINBV.BENHNHAN SET HoTen = '"
                        + lb_TenBN.Text + "' , DiaChi = '"
                        + lbDiaChi.Text + "' , SoDienThoai = '"
                        + lb_SDT.Text + "' , NgaySinh = to_date('" + txt_NSinh.Text + "', 'DD-MM-YYYY')  , CMND = '"
                        + lb_CMND.Text + "' , BHYT = '"
                        + lb_BHYT.Text
                        + "'  where MaBenhNhan = '" + lb_mabn.Text + "' ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    displayData_BenhNhan();
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
                    string sql = " Delete from ADMINBV.BENHNHAN where MaBenhNhan = '" + lb_mabn.Text + "' ";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    displayData_BenhNhan();
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

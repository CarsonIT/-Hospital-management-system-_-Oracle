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
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select NoiDung, label_to_char(label_tb) as Label from ADMINBV.THONGBAO  ", connect);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_ThongBao.DataSource = dtbl;
                dgv_ThongBao.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                txt_NoiDung.Text = dtbl.Rows[0][0].ToString();
                txt_Nhan.Text = dtbl.Rows[0][1].ToString();
                connect.Close();
            }
        }
        private void ThongBao_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_ThongBao.CurrentRow.Index;
            txt_NoiDung.Text = dgv_ThongBao.Rows[i].Cells[0].Value.ToString();
            txt_Nhan.Text = dgv_ThongBao.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                try
                {
                    connect.Open();
                    string sql = "INSERT INTO ADMINBV.THONGBAO VALUES('" + txt_NoiDung.Text +"',char_to_label('xemthongbao', '"+ txt_Nhan.Text +"'))";
                    OracleCommand cmd = new OracleCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gửi thành công");
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE  FROM THONGBAO WHERE NOIDUNG = '"+ txt_NoiDung.Text + "'";
                    OracleCommand cmd = new OracleCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}

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

namespace GiaoDien.ChamCongCaNhan
{
    public partial class ChamCongQLCM : Form
    {
        public ChamCongQLCM()
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

        public void displayData_ChamCong()
        {

            username = strTemp;
            password = strTemp;
            using (OracleConnection conn = DBConnection.GetConnection(username, password))
            {
                conn.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from ADMINBV.CHAMCONG where MaNhanVien = '" + username + "'", conn);
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

        private void ChamCongQLCM_Load(object sender, EventArgs e)
        {
            displayData_ChamCong();
        }

        private void dgv_ChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_ChamCong.CurrentRow.Index;
            lb_MaNV_CC.Text = dgv_ChamCong.Rows[i].Cells[0].Value.ToString();
            lb_Thang_CC.Text = dgv_ChamCong.Rows[i].Cells[1].Value.ToString();
            lb_Nam_CC.Text = dgv_ChamCong.Rows[i].Cells[2].Value.ToString();
            lb_SoNgayCong_CC.Text = dgv_ChamCong.Rows[i].Cells[3].Value.ToString();
        }
    }
}

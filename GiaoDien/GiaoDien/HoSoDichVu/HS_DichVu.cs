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
    public partial class HS_DichVu : Form
    {
        public HS_DichVu()
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

        private void HS_DichVu_Load(object sender, EventArgs e)
        {
            displayData_HoSoDichVu();
        }

        private void dgv_HoSoBenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_HoSoDichVu.CurrentRow.Index;
            lb_MaKham.Text = dgv_HoSoDichVu.Rows[i].Cells[0].Value.ToString();
            lb_MaDV.Text = dgv_HoSoDichVu.Rows[i].Cells[1].Value.ToString();
            txt_NgayGio.Text = dgv_HoSoDichVu.Rows[i].Cells[2].Value.ToString();
            lb_KetLuan.Text = dgv_HoSoDichVu.Rows[i].Cells[3].Value.ToString();
            lb_KTV.Text = dgv_HoSoDichVu.Rows[i].Cells[4].Value.ToString();
        }
    }
}

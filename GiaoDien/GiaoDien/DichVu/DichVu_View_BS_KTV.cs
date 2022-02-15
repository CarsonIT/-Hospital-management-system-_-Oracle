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
    public partial class DichVu_View_BS_KTV : Form
    {
        public DichVu_View_BS_KTV()
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
                conn.Close();
            }
        }

        private void DichVu_View_BS_KTV_Load(object sender, EventArgs e)
        {
            displayData_HoSoDichVu();
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DichVu.CurrentRow.Index;
            lb_MaDichVu.Text = dgv_DichVu.Rows[i].Cells[0].Value.ToString();
            lb_TenDichVu.Text = dgv_DichVu.Rows[i].Cells[1].Value.ToString();
        }
    }
}

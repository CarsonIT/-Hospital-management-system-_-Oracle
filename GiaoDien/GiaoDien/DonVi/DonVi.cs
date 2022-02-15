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
    public partial class DonVi : Form
    {
        public DonVi()
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

                lb_MaDonVi.Text = dgv_DonVi.Rows[0].Cells[0].Value.ToString();
                lb_TenDonVi.Text = dgv_DonVi.Rows[0].Cells[1].Value.ToString();

                conn.Close();
            }
        }

        private void DonVi_Load(object sender, EventArgs e)
        {
            displayData_DonVi();
        }

        private void dgv_DonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DonVi.CurrentRow.Index;
            lb_MaDonVi.Text = dgv_DonVi.Rows[i].Cells[0].Value.ToString();
            lb_TenDonVi.Text = dgv_DonVi.Rows[i].Cells[1].Value.ToString();
        }
    }
}

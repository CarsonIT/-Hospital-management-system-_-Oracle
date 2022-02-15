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
    public partial class Audit : Form
    {
        public Audit()
        {
            InitializeComponent();
        }

        private void Audit_Load(object sender, EventArgs e)
        {

        }

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter1 = new OracleDataAdapter("select username, owner, obj_name, action_name, timestamp from dba_audit_trail where owner = 'ADMINBV'", KetNoi.AdminConnect);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                dgv_Audit.DataSource = table1;
                dgv_Audit.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter1 = new OracleDataAdapter("select db_user,sql_text,timestamp from dba_fga_audit_trail", KetNoi.AdminConnect);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                dgv_Audit.DataSource = table1;
                dgv_Audit.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}

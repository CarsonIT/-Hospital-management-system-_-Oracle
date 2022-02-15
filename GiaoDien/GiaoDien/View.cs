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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void grbXB_Enter(object sender, EventArgs e)
        {

        }
        public void DisplayData()
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter1 = new OracleDataAdapter("select view_name as name from all_views where owner = 'ADMINBV'", KetNoi.AdminConnect);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                cbbCB.ValueMember = "name";
                cbbCB.DisplayMember = "name";
                cbbCB.DataSource = table1;


                OracleDataAdapter adapter2 = new OracleDataAdapter("select view_name as name from all_views where owner = 'ADMINBV'", KetNoi.AdminConnect);
                DataTable table2 = new DataTable();
                adapter1.Fill(table2);

                cbbXB.ValueMember = "name";
                cbbXB.DisplayMember = "name";
                cbbXB.DataSource = table2;

                connect.Close();
            }

        }

        public void DisplayData_FirsrRow()
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM " + cbbCB.Text + "", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvTable.DataSource = table;
                dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dgvTable.Show();
                connect.Close();
            }

        }
        private void btnXDL_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM " + cbbCB.Text + "", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvTable.DataSource = table;
                dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dgvTable.Show();
            }
        }
        private void View_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayData_FirsrRow();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete View:  " + cbbXB.Text, "Drop View", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = "";
                        connect.Open();
                        sql = "DROP VIEW " + cbbXB.Text.ToString();
                        OracleCommand cmd = new OracleCommand(sql, connect);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Drop view: " + cbbXB.Text + " Successfully !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else return;
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

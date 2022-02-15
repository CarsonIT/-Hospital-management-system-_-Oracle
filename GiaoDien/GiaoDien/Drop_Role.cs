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
    public partial class Drop_Role : Form
    {
        public Drop_Role()
        {
            InitializeComponent();
            displayData();
        }


        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT * FROM DBA_ROLES ORDER BY role ASC", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_DropRole.DataSource = dtbl;
                orcCont.Close();
            }
        }

        public void Alert_DropRole(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnReturn_InDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role rolea = new Role();
            rolea.ShowDialog();
            this.Close();
        }

        private void btnCancelDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role rolea = new Role();
            rolea.ShowDialog();
            this.Close();
        }

        private void dgv_in_DropRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_in_DropRole.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_drop_namerole.Text = v;
        }

        private void btnSaveDrop_Click(object sender, EventArgs e)
        {
            string rolename = txt_drop_namerole.Text;
            if (rolename == "")
            {
                this.Alert_DropRole("Please input the username", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
                {
                    connect.Open();
                    string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                    OracleCommand cmd = new OracleCommand(queryNeed, connect);
                    cmd.ExecuteNonQuery();
                    string queryMain = "DROP ROLE " + rolename;
                    OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                    try
                    {
                        cmdMain.ExecuteNonQuery();
                        connect.Close();
                        this.Alert_DropRole("The ROLE has been DROPPED\n successfully", Form_Alert.enmType.Success);
                        displayData();
                    }
                    catch
                    {
                        this.Alert_DropRole("ROLE does not exist in the system.", Form_Alert.enmType.Failed);
                    }
                }
            }
        }
    }
}

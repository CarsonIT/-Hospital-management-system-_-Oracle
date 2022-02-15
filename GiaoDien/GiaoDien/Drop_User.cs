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
    public partial class Drop_User : Form
    {
        
        public Drop_User()
        {
            InitializeComponent();
            displayData();
        }
        public void Alert_DropUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_DropUser.DataSource = dtbl;
                orcCont.Close();
            }
        }

        private void Drop_User_Load(object sender, EventArgs e)
        {

        }

        private void dgv_in_DropUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string v = dgv_in_DropUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_drop_nameuser.Text = v;
        }

        private void btnReturn_InDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void btnCancelDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void btnSaveDrop_Click(object sender, EventArgs e)
        {
            string username = txt_drop_nameuser.Text;
            if (username == "")
            {
                this.Alert_DropUser("Please input the username", Form_Alert.enmType.Failed);
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
                    string queryMain = "Drop USER " + username;
                    OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                    try
                    {
                        cmdMain.ExecuteNonQuery();
                        connect.Close();
                        this.Alert_DropUser("The User has been DROPPED\n successfully", Form_Alert.enmType.Success);
                        displayData(); 
                    }
                    catch
                    {
                        this.Alert_DropUser("User does not exist in the system.", Form_Alert.enmType.Failed);
                    }


                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select * from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_DropUser.DataSource = dtbl;
                orcCont.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = txt_drop_nameuser.Text;
            if (username == "")
            {
                this.Alert_DropUser("Please input the username", Form_Alert.enmType.Failed);
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
                    string queryMain = "Drop USER " + username;
                    OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                    try
                    {
                        cmdMain.ExecuteNonQuery();
                        connect.Close();
                        this.Alert_DropUser("The User has been DROPPED\n successfully", Form_Alert.enmType.Success);
                    }
                    catch
                    {
                        this.Alert_DropUser("User does not exist in the system.", Form_Alert.enmType.Failed);
                    }


                }
            }
        }

        private void dgv_in_DropUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

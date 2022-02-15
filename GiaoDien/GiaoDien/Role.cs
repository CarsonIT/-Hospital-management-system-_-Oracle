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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
            
        }
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES ORDER BY role ASC", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_in_Role.DataSource = dtbl;
                dgv_in_Role.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                orcCont.Close();
            }
        }
        public void Alert_DropUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanHe1 p = new PhanHe1();
            p.ShowDialog();
            this.Close();
        }

        private void add_role_btn_Click(object sender, EventArgs e)
        {

            CreateRoles createR = new CreateRoles();
            createR.ShowDialog();

        }

        private void btn_Drop_Role_Click(object sender, EventArgs e)
        {
            string username = txtRolename.Text;
            if (username == "")
            {
                this.Alert_DropUser("Please input the rolename", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this role", "Drop Role", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    OracleConnection con = new OracleConnection(KetNoi.AdminConnect);//Kết nối chuỗi dữ liệu
                    try
                    {
                        con.Open();//Mở chuỗi kết nối
                        string queryMain = "Drop ROLE " + username;
                        OracleCommand cmdMain = new OracleCommand(queryMain, con);
                        cmdMain.ExecuteNonQuery();
                        MessageBox.Show("Drop Role Successfully !!!");
                        displayData();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            View_Detail_Role vdr = new View_Detail_Role();
            vdr.Message = txtRolename.Text;
            vdr.ShowDialog();

            
        }

        private void dgv_in_Role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Role_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void txtRolename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_username_add_Click(object sender, EventArgs e)
        {

        }

        private void dgv_in_Role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_in_Role.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRolename.Text = v;
        }
    }
}

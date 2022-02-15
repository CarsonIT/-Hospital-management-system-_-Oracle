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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            
        }

        public void Alert_DropUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

            //Nut Show nhưng khỏi cần vì đã có hàm DisplayData rồi
            private void buttom_in_User_Click(object sender, EventArgs e)
        {
            
           
        }
        //Hàm displayData
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("select USERNAME,CREATED from all_users order by created desc ", orcCont);
                DataTable dtbl = new DataTable();
                orcData.Fill(dtbl);
                dgv_UserList.DataSource = dtbl;
                dgv_UserList.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                orcCont.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {

            CreateUser addU = new CreateUser();
            addU.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanHe1 p = new PhanHe1();
            p.ShowDialog();
            this.Close();
        }


        private void btn_Drop_Click(object sender, EventArgs e)
        {
            string username = txtUsname.Text;
            if (username == "")
            {
                this.Alert_DropUser("Please input the username", Form_Alert.enmType.Failed);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this user","Drop User", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    OracleConnection con = new OracleConnection(KetNoi.AdminConnect);//Kết nối chuỗi dữ liệu
                    try
                    {
                        con.Open();//Mở chuỗi kết nối
                        string queryMain = "Drop USER " + username;
                        OracleCommand cmdMain = new OracleCommand(queryMain, con);
                        cmdMain.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
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
                    //using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
                    //{
                    //    connect.Open();
                    //    string queryNeed = "alter session set\"_ORACLE_SCRIPT\"=true";
                    //    OracleCommand cmd = new OracleCommand(queryNeed, connect);
                    //    cmd.ExecuteNonQuery();
                    //    string queryMain = "Drop USER " + username;
                    //    OracleCommand cmdMain = new OracleCommand(queryMain, connect);
                    //    try
                    //    {
                    //        cmdMain.ExecuteNonQuery();
                    //        connect.Close();
                    //        this.Alert_DropUser("The User has been DROPPED\n successfully", Form_Alert.enmType.Success);
                    //        displayData();
                    //    }
                    //    catch
                    //    {
                    //        this.Alert_DropUser("User does not exist in the system.", Form_Alert.enmType.Failed);
                    //    }
                    //}
                }
                else return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            View_Detail vdt = new View_Detail();
            vdt.Message = txtUsname.Text;
            vdt.ShowDialog();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void User_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void dgv_UserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgv_UserList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsname.Text = v;
        }
    }
}

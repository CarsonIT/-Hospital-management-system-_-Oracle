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
    public partial class GrantUser : Form
    {
        List<string> listupdate = new List<string>();
        List<string> listview = new List<string>();

        string strTemp;

        public GrantUser()
        {
            InitializeComponent();

            loadform();

            
        }
        public string Message
        {
            get
            {
                return strTemp;
            }
            set
            {
                strTemp = value;

            }
        }

        public void Alert_GrantUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void loadform()
        {

            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData = new OracleDataAdapter("SELECT DISTINCT ROLE FROM DBA_ROLES ORDER BY ROLE ASC ", orcCont);
                DataTable dtbl = new DataTable();
                DataRow row = dtbl.NewRow();
                orcData.Fill(dtbl);
                dgvRole.DataSource = dtbl;
                dgvRole.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                // add check box column
                DataGridViewCheckBoxColumn chkgrant = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn chkadmin = new DataGridViewCheckBoxColumn();

                chkgrant.HeaderText = "Granted";
                chkgrant.Name = "Granted";
                chkadmin.HeaderText = "Admin";
                chkadmin.Name = "Admin";
                dgvRole.Columns.Add(chkgrant);
                dgvRole.Columns.Add(chkadmin);

                // TAB SYSTEM PRIVILEGES
                OracleDataAdapter orcData2 = new OracleDataAdapter("SELECT distinct PRIVILEGE FROM DBA_SYS_PRIVS order by  PRIVILEGE asc", orcCont);
                DataTable dtbl2 = new DataTable();
                orcData2.Fill(dtbl2);
                dgvSysPri.DataSource = dtbl2;
                dgvSysPri.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                // add check box column
                DataGridViewCheckBoxColumn chkgrant2 = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn chkadmin2 = new DataGridViewCheckBoxColumn();

                chkgrant2.HeaderText = "Granted";
                chkadmin2.HeaderText = "Admin Option";
                dgvSysPri.Columns.Add(chkgrant2);
                dgvSysPri.Columns.Add(chkadmin2);

                // TAB OBJECT PRIVILEGE
                OracleDataAdapter orcData3 = new OracleDataAdapter("SELECT table_name FROM all_tables where owner='ADMINBV'", orcCont); // hiện các bảng
                DataTable dtbl3 = new DataTable();
                orcData3.Fill(dtbl3);
                dgvTable.DataSource = dtbl3;
                dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                // add check box column
                DataGridViewCheckBoxColumn all = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn insert = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn update = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn delete = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn option = new DataGridViewCheckBoxColumn();
                option.Width = 50;
                all.Width = 50;
                select.Width = 50;
                update.Width = 50;
                insert.Width = 50;
                delete.Width = 50;
                all.HeaderText = "All";
                select.HeaderText = "Select";
                update.HeaderText = "Update";
                insert.HeaderText = "Insert";
                delete.HeaderText = "Delete";
                option.HeaderText = "Grant Option";
                dgvTable.Columns.Add(all);
                dgvTable.Columns.Add(select);
                dgvTable.Columns.Add(insert);
                dgvTable.Columns.Add(update);
                dgvTable.Columns.Add(delete);
                dgvTable.Columns.Add(option);

                // add check box column in dgvCol
                
                DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();

                chk2.HeaderText = "Granted";
                dgvCol.Columns.Add(chk2);
                chk2.Width = 60;
                dgvCol.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                orcCont.Close();
            }
        }
        //private void dgvTable_SelectionChanged(object sender, EventArgs e)
        //{
        //    int id = dgvTable.CurrentCell.RowIndex;
        //    loadCol(id);
        //}
        //private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        int index = e.RowIndex;
        //        //Đưa dữ liệu vào textbox
        //        txtTable.Text = dgvTable.Rows[index].Cells[4].Value.ToString();
               

        //        //Không cho phép sửa  table
        //        txtTable.Enabled = false;
        //        //load dgvCol
        //        using (OracleConnection orcCont1 = new OracleConnection("USER ID = ADMIN;Password=123;DATA SOURCE = localhost:1521/xe;"))
        //        {

        //            //load dgvCol - hiện các column để chọn Grant Update
        //            OracleDataAdapter orcData4 = new OracleDataAdapter("SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = " + txtTable.Text, orcCont1);// hiện các cột
        //            DataTable dtbl4 = new DataTable();
        //            orcData4.Fill(dtbl4);
        //            dgvCol.DataSource = dtbl4;


        //            // add check box column
        //            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();

        //            chk2.HeaderText = "Granted";
        //            dgvCol.Columns.Add(chk2);
        //        }
        //    }
        //}

        //private void loadCol(int id)
        //{
        //    txtTable.Text = dgvTable.Rows[id].Cells[4].Value.ToString().Trim();

        //    using (OracleConnection orcCont = new OracleConnection("USER ID = ADMIN;Password=123;DATA SOURCE = localhost:1521/xe;"))
        //    {

        //        //load dgvCol - hiện các column để chọn Grant Update
        //        OracleDataAdapter orcData4 = new OracleDataAdapter("SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = "+txtTable.Text, orcCont);// hiện các cột
        //        DataTable dtbl4 = new DataTable();
        //        orcData4.Fill(dtbl4);
        //        dgvCol.DataSource = dtbl4;


        //        // add check box column
        //        DataGridViewCheckBoxColumn chk2= new DataGridViewCheckBoxColumn();

        //        chk2.HeaderText = "Granted";
        //        dgvCol.Columns.Add(chk2);
        //    }



       // }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabGrantRole_MouseDown(object sender, MouseEventArgs e)
        {
        //    using (OracleConnection orcCont = new OracleConnection("USER ID = ADMIN;Password=123;DATA SOURCE = localhost:1521/xe;"))
        //    {
        //        orcCont.Open();
        //        OracleDataAdapter orcData = new OracleDataAdapter("SELECT distinct (Grantee) FROM DBA_TAB_PRIVS order by grantee asc ", orcCont);
        //        DataTable dtbl = new DataTable();      
        //        DataRow row = dtbl.NewRow();
        //        orcData.Fill(dtbl);
        //        row["grantee"]= "CONNECT";
        //        dtbl.Rows.Add(row);
        //        dtbl.DefaultView.Sort = "grantee asc";
        //        dgvRole.DataSource = dtbl;


        //        // add check box column
        //        DataGridViewCheckBoxColumn chkgrant = new DataGridViewCheckBoxColumn();
        //        DataGridViewCheckBoxColumn chkadmin = new DataGridViewCheckBoxColumn();

        //        chkgrant.HeaderText = "Granted";
        //        chkgrant.Name = "CheckGrant";
        //        chkadmin.HeaderText = "Admin";
        //        chkadmin.Name = "CheckAdmin";
        //        dgvRole.Columns.Add(chkgrant);
        //        dgvRole.Columns.Add(chkadmin);

        //        // TAB SYSTEM PRIVILEGES
        //        OracleDataAdapter orcData2 = new OracleDataAdapter("SELECT distinct PRIVILEGE FROM DBA_SYS_PRIVS order by  PRIVILEGE asc", orcCont);
        //        DataTable dtbl2 = new DataTable();            
        //        orcData2.Fill(dtbl2);           
        //        dgvSysPri.DataSource = dtbl2;


        //        // add check box column
        //        DataGridViewCheckBoxColumn chkgrant2 = new DataGridViewCheckBoxColumn();
        //        DataGridViewCheckBoxColumn chkadmin2 = new DataGridViewCheckBoxColumn();

        //        chkgrant2.HeaderText = "Granted";
        //        chkadmin2.HeaderText = "Admin Option";
        //        dgvSysPri.Columns.Add(chkgrant2);
        //        dgvSysPri.Columns.Add(chkadmin2);




        //    }
    }

        

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string sql;
            OracleConnection con = new OracleConnection(KetNoi.AdminConnect);//Kết nối chuỗi dữ liệu
            try
            {
                con.Open();//Mở chuỗi kết nối
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                foreach (DataGridViewRow r in dgvRole.Rows)
                {

                    if (Convert.ToBoolean(r.Cells[1].Value) == true || Convert.ToBoolean(r.Cells[0].Value) == true)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true)

                            sql = "GRANT \"" + r.Cells[2].Value.ToString() + "\" TO \"" + strTemp + "\" WITH ADMIN OPTION ";
                        else
                            sql = "GRANT \"" + r.Cells[2].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
                //grant system privilege
                foreach (DataGridViewRow r1 in dgvSysPri.Rows)
                {
                    if (Convert.ToBoolean(r1.Cells[1].Value) == true || Convert.ToBoolean(r1.Cells[0].Value) == true)
                    {
                        if (Convert.ToBoolean(r1.Cells[0].Value) == true)
                            sql = "GRANT " + r1.Cells[2].Value.ToString() + " TO \"" + strTemp + "\" WITH ADMIN OPTION ";
                        else
                            sql = "GRANT " + r1.Cells[2].Value.ToString() + " TO \"" + strTemp + "\" ";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
                // grant table
                foreach (DataGridViewRow r2 in dgvTable.Rows)
                {
                    if (Convert.ToBoolean(r2.Cells[0].Value) == true)
                    {
                        if (Convert.ToBoolean(r2.Cells[5].Value) == true)
                            sql = "GRANT ALL ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" WITH GRANT OPTION ";
                        else
                            sql = "GRANT ALL ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Convert.ToBoolean(r2.Cells[1].Value) == true)
                        {
                            if (Convert.ToBoolean(r2.Cells[5].Value) == true)
                                sql = "GRANT SELECT ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" WITH GRANT OPTION ";
                            else
                                sql = "GRANT SELECT ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                        if (Convert.ToBoolean(r2.Cells[2].Value) == true)
                        {
                            if (Convert.ToBoolean(r2.Cells[5].Value) == true)
                                sql = "GRANT INSERT ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" WITH GRANT OPTION ";
                            else
                                sql = "GRANT INSERT ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                        if (Convert.ToBoolean(r2.Cells[3].Value) == true)
                        {
                            if (Convert.ToBoolean(r2.Cells[5].Value) == true)
                                sql = "GRANT UPDATE ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" WITH GRANT OPTION ";
                            else
                                sql = "GRANT UPDATE ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                        if (Convert.ToBoolean(r2.Cells[4].Value) == true)
                        {
                            if (Convert.ToBoolean(r2.Cells[5].Value) == true)
                                sql = "GRANT DELETE ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" WITH GRANT OPTION ";
                            else
                                sql = "GRANT DELETE ON \"" + r2.Cells[6].Value.ToString() + "\" TO \"" + strTemp + "\" ";
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }

                }
                // grant update column 
                foreach (string s in listupdate)
                {
                    command.CommandText = s;
                    command.ExecuteNonQuery();
                }

                // grant select column 
                foreach (string s in listview)
                {
                    // tạo view
                    command.CommandText = s;
                    command.ExecuteNonQuery();
                    // grant view cho user
                    // command.CommandText="GRANT SELECT ON "
                }
                MessageBox.Show("Granted Successfully !!!");


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

        private void checkPassExpired_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGrantUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            bool fi = false; // biến kt  có dùng dấu phẩy giữa các thuộc tính k)
            sql = "GRANT UPDATE (";
            foreach (DataGridViewRow r1 in dgvCol.Rows)
            {
                if (Convert.ToBoolean(r1.Cells[0].Value) == true)
                {
                    if (fi)
                        sql = sql + ",";
                    sql = sql + r1.Cells[1].Value.ToString();
                    fi = true;
                    
                    
                }
            }
            sql = sql + ") ON " + txtTable.Text + " TO \"" + strTemp + "\"";
            listupdate.Add(sql);
            this.Alert_GrantUser("Granted update successfully", Form_Alert.enmType.Success);
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                //Đưa dữ liệu vào textbox
                txtTable.Text = dgvTable.Rows[index].Cells[6].Value.ToString();


                //Không cho phép sửa  table
                txtTable.Enabled = false;
                //load dgvCol
                using (OracleConnection orcCont1 = new OracleConnection(KetNoi.AdminConnect))
                {

                    //load dgvCol - hiện các column để chọn Grant Update
                    OracleDataAdapter orcData4 = new OracleDataAdapter("SELECT DISTINCT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '" +txtTable.Text+"'", orcCont1);// hiện các cột
                    DataTable dtbl4 = new DataTable();
                    orcData4.Fill(dtbl4);
                    dgvCol.DataSource = dtbl4;


                    //// add check box column
                    //DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();

                    //chk2.HeaderText = "Granted";
                    //dgvCol.Columns.Add(chk2);
                    //chk2.Width = 60;
                    orcCont1.Close();
                }
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonGrantSelect_Click(object sender, EventArgs e)
        { // Tạo view với cấu trúc tên: VIEW_[tên bảng]_[tên user/role]
            string sql;
            string nameview = "VIEW_"+txtTable.Text+"_"+strTemp;
            bool fi = false; // biến kt  có dùng dấu phẩy giữa các thuộc tính k)
            sql = "CREATE OR REPLACE VIEW " +nameview+" AS SELECT ";
            foreach (DataGridViewRow r1 in dgvCol.Rows)
            {
                if (Convert.ToBoolean(r1.Cells[0].Value) == true)
                {
                    if (fi)
                        sql = sql + ",";
                    sql = sql + r1.Cells[1].Value.ToString();
                    fi = true;


                }
            }
            sql = sql + " FROM " + txtTable.Text;
            listview.Add(sql);

            string grant = "GRANT SELECT ON " + nameview + " TO " + strTemp;
            listview.Add(grant);
            this.Alert_GrantUser("Granted select successfully", Form_Alert.enmType.Success);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User usera = new User();
            usera.ShowDialog();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }
    }
}

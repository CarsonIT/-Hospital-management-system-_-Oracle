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
    public partial class Revoke_User : Form
    {
        public Revoke_User()
        {
            InitializeComponent();

        }
        string strTemp;

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
        public void displayData()
        {
            using (OracleConnection orcCont = new OracleConnection(KetNoi.AdminConnect))
            {
                orcCont.Open();
                OracleDataAdapter orcData1 = new OracleDataAdapter("select GRANTED_ROLE from DBA_ROLE_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtbl = new DataTable();
                orcData1.Fill(dtbl);
                dgvRole.DataSource = dtbl;
                dgvRole.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke1 = new DataGridViewCheckBoxColumn();
                revoke1.HeaderText = "Revoke";
                dgvRole.Columns.Add(revoke1);
                //


                OracleDataAdapter orcData2 = new OracleDataAdapter("select PRIVILEGE from DBA_SYS_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtb2 = new DataTable();
                orcData2.Fill(dtb2);
                dgvSys.DataSource = dtb2;
                dgvSys.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke2 = new DataGridViewCheckBoxColumn();
                revoke2.HeaderText = "Revoke";
                dgvSys.Columns.Add(revoke2);
                //

                OracleDataAdapter orcData3 = new OracleDataAdapter("select TABLE_NAME, PRIVILEGE from USER_TAB_PRIVS WHERE GRANTEE = '" + strTemp + "' AND TYPE = 'TABLE'", orcCont);
                DataTable dtb3 = new DataTable();
                orcData3.Fill(dtb3);
                dgvTbl.DataSource = dtb3;
                dgvTbl.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke3 = new DataGridViewCheckBoxColumn();
                revoke3.HeaderText = "Revoke";
                dgvTbl.Columns.Add(revoke3);
                //

                OracleDataAdapter orcData4 = new OracleDataAdapter("select TABLE_NAME, COLUMN_NAME, PRIVILEGE from USER_COL_PRIVS WHERE GRANTEE = '" + strTemp + "'", orcCont);
                DataTable dtb4 = new DataTable();
                orcData4.Fill(dtb4);
                dgvCol.DataSource = dtb4;

                DataGridViewCheckBoxColumn revoke4 = new DataGridViewCheckBoxColumn();
                revoke4.HeaderText = "Revoke";
                dgvCol.Columns.Add(revoke4);
                dgvCol.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //

                OracleDataAdapter orcData5 = new OracleDataAdapter("select TABLE_NAME AS VIEW_NAME, PRIVILEGE from USER_TAB_PRIVS WHERE GRANTEE = '" + strTemp + "' AND TYPE = 'VIEW'", orcCont);
                DataTable dtb5 = new DataTable();
                orcData5.Fill(dtb5);
                dgv_View.DataSource = dtb5;
                dgv_View.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn revoke5 = new DataGridViewCheckBoxColumn();
                revoke5.HeaderText = "Revoke";
                dgv_View.Columns.Add(revoke5);

                orcCont.Close();
            }
        }
        public void Alert_GrantUser(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
                try
                {
                    // revoke role
                    foreach (DataGridViewRow r in dgvRole.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[1].Value) == true)
                        {
                            sql = "REVOKE " + r.Cells[0].Value.ToString() + " FROM " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }
                    // revoke system privilege
                    foreach (DataGridViewRow r in dgvSys.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true) // sửa đổi giữa 2 cái cell 0 và 1
                        {
                            sql = "REVOKE " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }

                    // revoke level table
                    foreach (DataGridViewRow r in dgvTbl.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true)
                        {
                            sql = "REVOKE " + r.Cells[2].Value.ToString() + " ON " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }

                    }

                    foreach (DataGridViewRow r in dgv_View.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true)
                        {
                            sql = "REVOKE " + r.Cells[2].Value.ToString() + " ON " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }

                    //revoke level column
                    foreach (DataGridViewRow r in dgvCol.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true)
                        {
                            sql = "REVOKE " + r.Cells[3].Value.ToString() + " ON " + r.Cells[1].Value.ToString() + " FROM " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }
                    // NOTE: Không thể revoke quyền trên cột. Ví dụ ta grant update(ten,sdt) on NHANVIEN, nếu muốn 
                    // revoke quyền update trên cột ten, thì phải revoke update on NhanVien rồi grant (sdt) on Nhanvien

                    //grant lại các quyền trên cột mà không bị revoke
                    foreach (DataGridViewRow r in dgvCol.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value) == true && Convert.ToBoolean(r.Cells[1].Value) == true)
                        {
                            sql = "GRANT " + r.Cells[3].Value.ToString() + " (" + r.Cells[2].Value.ToString() + ") ON " + r.Cells[1].Value.ToString() + " TO " + strTemp;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Revoked Successfully !!!");
                }
                catch
                {
                    MessageBox.Show("Revoked Successfully !!!");
                }



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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Revoke_User_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

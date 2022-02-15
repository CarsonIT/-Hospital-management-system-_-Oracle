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
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            string sql;
            OracleConnection con = new OracleConnection(KetNoi.AdminConnect);//Kết nối chuỗi dữ liệu
            try
            {
                con.Open();//Mở chuỗi kết nối
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                sql = "Create table " + txtTableName.Text.ToUpper() + " (";
                bool t = false;
                foreach (DataGridViewRow r in dgvCol.Rows)
                {
                    if ((string)r.Cells[0].Value != null)
                    {

                        if (!t)
                        {
                            t = true;
                        }
                        else
                        {
                            sql = sql + ",";
                        }

                        sql = sql + r.Cells[0].Value.ToString() + " " + r.Cells[1].Value.ToString();
                        if ((string)r.Cells[2].Value != null)
                            sql = sql + "(" + r.Cells[2].Value.ToString() + ") ";
                        if (Convert.ToBoolean(r.Cells[3].Value) == true)
                            sql = sql + " NOT NULL ";

                    }
                }
                string pk = "";
                bool bd = false;
                foreach (DataGridViewRow r in dgvCol.Rows)
                {

                    if (Convert.ToBoolean(r.Cells[4].Value) == true)
                    {
                        if (!bd)
                        {
                            bd = true;
                        }
                        else
                        {
                            pk = pk + ",";
                        }
                        pk = pk + r.Cells[0].Value.ToString();
                    }
                }
                if (pk != "")
                    sql = sql + ", CONSTRAINT " + txtTableName.Text.ToUpper() + "_PK PRIMARY KEY (" + pk + ")";
                sql = sql + ")";
                command.CommandText = sql;
                command.ExecuteNonQuery();
                MessageBox.Show("Create table successfully");


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

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

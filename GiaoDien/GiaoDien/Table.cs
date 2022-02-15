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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }


        public void DisplayData()
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter1 = new OracleDataAdapter("select table_name as name from all_tables where owner = 'ADMINBV'", KetNoi.AdminConnect);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                cbbCB.ValueMember = "name";
                cbbCB.DisplayMember = "name";
                cbbCB.DataSource = table1;


                OracleDataAdapter adapter2 = new OracleDataAdapter("select table_name as name from all_tables where owner = 'ADMINBV'", KetNoi.AdminConnect);
                DataTable table2 = new DataTable();
                adapter1.Fill(table2);

                cbbXB.ValueMember = "name";
                cbbXB.DisplayMember = "name";
                cbbXB.DataSource = table2;

                connect.Close();


            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayTableName();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CreateTable tbl = new CreateTable();
            tbl.ShowDialog();
            this.Close();

        }

        public void DisplayTableName()
        {
            cbbXB.Text = "";
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                if (cbbCB.Text == "BENHNHAN")
                {
                    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM BENHNHAN_ENC", connect);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvTable.DataSource = table;
                    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                    dgvTable.Show();
                }
                connect.Close();


            }
        }
        private void btnXDL_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM "+ cbbCB.Text + "", connect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvTable.DataSource = table;
                dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dgvTable.Show();
                //if (cbbCB.Text == "BENHNHAN")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM BENHNHAN_ENC", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "CHAMCONG")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM CHAMCONG", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "CT_DONTHUOC")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM CT_DONTHUOC", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "CT_HOADONDICHVU")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM CT_HOADONDICHVU", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "DICHVU")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM DICHVU", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "DONTHUOC")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM DONTHUOC", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "DONVI")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM DONVI", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "HOADONDICHVU")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM HOADONDICHVU", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "HOADONTIENTHUOC")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM HOADONTIENTHUOC", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "HOSOBENHAN")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM HOSOBENHAN", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "HOSODICHVU")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM HOSODICHVU", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "PHIEULUONG")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM PHIEULUONG", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "NHANVIEN")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM NHANVIEN", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}
                //if (cbbCB.Text == "THUOC")
                //{
                //    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM THUOC", connect);
                //    DataTable table = new DataTable();
                //    adapter.Fill(table);
                //    dgvTable.DataSource = table;
                //    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                //    dgvTable.Show();
                //}



                connect.Close();

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete table "+cbbXB.Text, "Drop Table", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = "";
                        connect.Open();
                        sql = "DROP TABLE " + cbbXB.Text.ToString();
                        OracleCommand cmd = new OracleCommand(sql, connect);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa bảng: " + cbbXB.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        DisplayTableName();
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

        private void btn_GiaiMa_Click(object sender, EventArgs e)
        {
            using (OracleConnection connect = new OracleConnection(KetNoi.AdminConnect))
            {
                connect.Open();
                if (cbbCB.Text == "BENHNHAN")
                {
                    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM view_BENHNHAN", connect);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvTable.DataSource = table;
                    dgvTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                    dgvTable.Show();
                }
                connect.Close();


            }
        }
    }
}

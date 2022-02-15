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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsname.Text;
            string password = txtPsw.Text;
            OracleConnection conn = DBConnection.GetConnection(username, password);
            try
            {
                conn.Open();
                if (username == "QLTNNS1")
                {
                    //MessageBox.Show("Tài khoản thuộc role:Quanly Tai nguyen va nhan su . \n", "Thông báo", MessageBoxButtons.OK);

                    GDQuanlyTNNS gd = new GDQuanlyTNNS();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }

                if (username == "QLTV1")
                {
                    //MessageBox.Show("Tài khoản thuộc role:Quanly Tai nguyen va nhan su . \n", "Thông báo", MessageBoxButtons.OK);

                    GDQuanLyTaiVu gd = new GDQuanLyTaiVu();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }

                if (username == "QLCM1")
                {
                    //MessageBox.Show("Tài khoản thuộc role:Quanly Tai nguyen va nhan su . \n", "Thông báo", MessageBoxButtons.OK);

                    GDQuanLyCM gd = new GDQuanLyCM();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }

                if (username == "BS1" || username == "BS2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: BACSI . \n", "Thông báo", MessageBoxButtons.OK);
                    
                    GDBacSi gd = new GDBacSi();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }
                if (username == "TT1" || username == "TT2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: TiepTan . \n", "Thông báo", MessageBoxButtons.OK);

                    GDTiepTan gd = new GDTiepTan();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }
                if (username == "TV1" || username == "TV2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: TaiVu . \n", "Thông báo", MessageBoxButtons.OK);

                    GDTaiVu gd = new GDTaiVu();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }
                if (username == "BT1" || username == "BT2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: BanThuoc . \n", "Thông báo", MessageBoxButtons.OK);

                    GDBanThuoc gd = new GDBanThuoc();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }
                if (username == "KT1" || username == "KT2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: KeToan . \n", "Thông báo", MessageBoxButtons.OK);

                    GDKeToan gd = new GDKeToan();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }
                if (username == "KTV1" || username == "KTV2")
                {
                    //MessageBox.Show("Tài khoản thuộc role: KeToan . \n", "Thông báo", MessageBoxButtons.OK);

                    GDKyThuatVien gd = new GDKyThuatVien();
                    gd.username = username;
                    gd.password = password;
                    this.Hide();
                    gd.ShowDialog();
                    gd.Close();
                }

                if (username == "ADMINBV" && password == "123")
                {
                    this.Hide();
                    PhanHe1 phanhe1 = new PhanHe1();
                    phanhe1.ShowDialog();
                    this.Close();
                }
                
               
                    //this.Alert("Login Failed", Form_Alert.enmType.Failed);
                
            }
            catch
            {
                MessageBox.Show("Login failed\n", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

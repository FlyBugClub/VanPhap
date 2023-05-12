using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VanPhap
{

    public partial class Login : Form
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Git\\VanPhap\\VanPhap\\VanPhap\\bin\\Debug\\Demo.accdb";
        OleDbConnection sqlCon = null;
        //Hàm mở kết nối db
        public void OpenConection()
        {
            if (sqlCon == null)
            {
                sqlCon = new OleDbConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }
        public void CloseConection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            /////////////////

            if (txt_Account.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else
            {
                string taiKHoan = txt_Account.Text;
                string matKhau = txt_Password.Text;
                /*   string id = txt_nguyenquan.Text;
                   string phapdanh1 = txt_nickname.Text;*/

                string query = "SELECT mat_khau, tai_khoan FROM tblAccount where tai_khoan = @id";
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", taiKHoan);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Lấy dữ liệu từ các cột của bảng
                            
                                string matkhau = (string)reader["mat_khau"];
                                txt_sosanhmatkhau.Text = matkhau;
                                // Xử lý dữ liệu tại đây

                                string taikhoan = (string)reader["tai_khoan"];
                                txt_taikhoan.Text = taikhoan;
                            }
                        }
                    }
                }

                string KTTaiKhoan = txt_taikhoan.Text;

                string kiemtraMatKhau = txt_sosanhmatkhau.Text;
                if (KTTaiKhoan.Equals(""))
                {
                    MessageBox.Show("Sai tài khoản!");
                }
                else if (kiemtraMatKhau.Equals(matKhau))
                {
                    form_manage m = new form_manage();
                    /*this.Close();*/
                    m.Show();
                }
                
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
            }
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, new EventArgs());
                form_manage Mform = new form_manage();
                Mform.Show();
                Mform.BringToFront();
            }
        }

        private void txt_Account_TextChanged(object sender, EventArgs e)
        { 

        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_Login_Click(sender, e);
            }
        }

        private void txt_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                txt_Password.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

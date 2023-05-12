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

namespace VanPhap.View
{
    public partial class ChangePassword : Form
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
        public ChangePassword()
        {
            InitializeComponent();
            MaximizeBox= false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            string matKHoanHT = txt_matkhauhientai.Text;
            string matKhauMoi = txt_matkhaumoi.Text;
            string xacNhanMatKhauMoi = txt_xacnhanmatkhau.Text;
            if (matKHoanHT.Equals("") || matKhauMoi.Equals("") || xacNhanMatKhauMoi.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống thông tin!");
            }
            else
            {
                string query = "SELECT tai_khoan, mat_khau FROM tblAccount where mat_khau = @id AND tai_khoan = \"phapvan\"";
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", matKHoanHT);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Lấy dữ liệu từ các cột của bảng

                                string name = (string)reader["mat_khau"];
                                txt_IdMatKhauHT.Text = name;
                                // Xử lý dữ liệu tại đây
                            }
                        }
                    }
                }//đóng
                 //////
                 /////
                string kiemTraMatKhau = txt_IdMatKhauHT.Text;
                if (kiemTraMatKhau.Equals(matKHoanHT))
                {
                    if (xacNhanMatKhauMoi.Equals(matKhauMoi))
                    {
                        string queryString = "UPDATE tblAccount SET mat_khau = @matkhau WHERE tai_khoan = \"phapvan\"";
                        using (OleDbConnection connection = new OleDbConnection(strCon))
                        {
                            OleDbCommand command = new OleDbCommand(queryString, connection);
                            command.Parameters.AddWithValue("@matkhau", xacNhanMatKhauMoi);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        Application.Restart();
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu phải trùng với mật khẩu mới!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại chưa hợp lý!");
                }//else
            }
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCoSoApp
{
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void DangKyBt_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản, mật khẩu, nhập lại mật khẩu, chức vụ và gmail từ các TextBox
            string taiKhoan = TaiKhoanTxt.Text.Trim();
            string matKhau = MatKhauTxt.Text;
            string nhapLaiMK = NhapLaiMkTxt.Text;
            string chucVu = "user";
            string gmail = GmailTxt.Text;
            

            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (taiKhoan == "" || matKhau == "" || nhapLaiMK == "" || gmail == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (matKhau != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            // Thực hiện thêm mới tài khoản vào cơ sở dữ liệu
            string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [User] (Name, MK, ChucVu, Gmail) VALUES (@Name, @MK, @ChucVu, @Gmail); SELECT SCOPE_IDENTITY();";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        ;
                        command.Parameters.AddWithValue("@Name", taiKhoan);
                        command.Parameters.AddWithValue("@MK", matKhau);
                        command.Parameters.AddWithValue("@ChucVu", chucVu);
                        command.Parameters.AddWithValue("@Gmail", gmail);
                        int newUserId = Convert.ToInt32(command.ExecuteScalar());
                        MessageBox.Show("Đăng ký thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void DangNhapBt_Click(object sender, EventArgs e)
        {
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.Show();
            this.Hide();
        }

        private void MatKhauTxt_TextChanged(object sender, EventArgs e)
        {
            MatKhauTxt.PasswordChar = '*';
        }

        private void NhapLaiMkTxt_TextChanged(object sender, EventArgs e)
        {
            NhapLaiMkTxt.PasswordChar = '*';
        }

        private void ThoatBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

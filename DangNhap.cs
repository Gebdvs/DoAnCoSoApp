using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCoSoApp
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM [User] WHERE Name=@Name AND MK=@MK";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", TaiKhoanTxt.Text.Trim());
                command.Parameters.AddWithValue("@MK", MatKhauTxt.Text.Trim());
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    string chucVuQuery = "SELECT ChucVu FROM [User] WHERE Name=@Name AND MK=@MK";
                    SqlCommand chucVuCommand = new SqlCommand(chucVuQuery, connection);
                    chucVuCommand.Parameters.AddWithValue("@Name", TaiKhoanTxt.Text.Trim());
                    chucVuCommand.Parameters.AddWithValue("@MK", MatKhauTxt.Text.Trim());
                    string chucVu = chucVuCommand.ExecuteScalar()?.ToString();

                    MenuForm.quyen = chucVu;
                    MessageBox.Show("Đăng nhập thành công!");
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                    this.Hide();
                    // Mở form chính ở đây

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
        }

        private void MatKhauTxt_TextChanged(object sender, EventArgs e)
        {
            MatKhauTxt.PasswordChar = '*';
        }

        private void DangKyBt_Click(object sender, EventArgs e)
        {
            DangKyForm dangKyForm = new DangKyForm();
            dangKyForm.Show();
            this.Hide();
        }

        private void ThoatBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCoSoApp
{
    public partial class XemGiaForm : Form
    {
        public XemGiaForm()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";
        public static string quyen;
        private void TinhCongNo_Load(object sender, EventArgs e)
        {
            if (quyen == "user")
            {
                EditBt.Enabled = false;
            }
            // Kết nối tới cơ sở dữ liệu
            connection = new SqlConnection(connectionString);
            connection.Open();

            // Lấy dữ liệu từ cơ sở dữ liệu
            string query = "SELECT TenHH FROM HangHoa";
            command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenHH = reader.GetString(0);
                comboBox1.Items.Add(tenHH);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            reader.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng kết nối cơ sở dữ liệu khi form đóng
            connection.Close();
        }
        private void DateXem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void XemGiaBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdHHLabel.Text))
            {
                MessageBox.Show("Chưa chọn mặt hàng.");
                return;
            }
            // Lấy giá trị ngày từ DateTimePicker
            DateTime selectedDate = DateXem.Value.Date;
            int selectedID = Convert.ToInt32(IdHHLabel.Text);

            // Kiểm tra nếu dữ liệu không tồn tại trong bảng
            if (!CheckDataExists(selectedDate,selectedID))
            {
                // Thực hiện thêm dữ liệu vào bảng
                InsertData(selectedDate, selectedID);
                
            }
            
            // Lấy giá trị IDHangHoa từ IdHHLabel
            string selectedHH = IdHHLabel.Text;

            // Thực hiện truy vấn SQL để lấy dữ liệu từ bảng ThongTinHH
            string query = "SELECT GiaLoai1, GiaLoai2, GiaLoai3 FROM ThongTinHH WHERE GiaNgay = @GiaNgay AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GiaNgay", selectedDate);
            command.Parameters.AddWithValue("@IDHangHoa", selectedHH);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Lấy giá trị từ các cột tương ứng trong dữ liệu đọc được
                string giaL1 = reader["GiaLoai1"] is DBNull ? null : reader["GiaLoai1"].ToString();
                string giaL2 = reader["GiaLoai2"] is DBNull ? null : reader["GiaLoai2"].ToString();
                string giaL3 = reader["GiaLoai3"] is DBNull ? null : reader["GiaLoai3"].ToString();

                // Hiển thị giá trị trong các textbox và kiểm tra giá trị null
                GiaL1Txt.Text = giaL1;
                GiaL2Txt.Text = giaL2;
                GiaL3Txt.Text = giaL3;

                // Kiểm tra và in ra thông báo nếu các textbox chứa giá trị null
                if (giaL1 == null || giaL2 == null || giaL3 == null)
                {
                    MessageBox.Show("Không có dữ liệu.");
                }
            }
            else
            {
                // Không có dữ liệu
                MessageBox.Show("Không có dữ liệu.");
            }

            reader.Close();

            
        }

        private bool CheckDataExists(DateTime date, int idHangHoa)
        {
            // Kiểm tra dữ liệu đã tồn tại trong bảng
            string query = "SELECT COUNT(*) FROM ThongTinHH WHERE GiaNgay = @GiaNgay AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GiaNgay", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void InsertData(DateTime date, int idHangHoa)
        {
            // Thêm dữ liệu vào bảng
            string query = "INSERT INTO ThongTinHH (GiaNgay, IDHangHoa) VALUES (@GiaNgay, @IDHangHoa)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GiaNgay", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            command.ExecuteNonQuery();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHH = comboBox1.SelectedItem.ToString();

            // Thực hiện truy vấn SQL để lấy IDHangHoa từ bảng HangHoa dựa trên selectedHH
            string query = "SELECT IDHangHoa FROM HangHoa WHERE TenHH = @TenHH";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenHH", selectedHH);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Lấy giá trị IDHangHoa từ cột đầu tiên (index 0)
                string idHH = reader[0].ToString();
                IdHHLabel.Text = idHH;
            }
            reader.Close();

        }

        private void GiaL1Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các textbox
            string giaL1 = GiaL1Txt.Text;
            string giaL2 = GiaL2Txt.Text;
            string giaL3 = GiaL3Txt.Text;

            // Kiểm tra giá trị không được để trống
            if (string.IsNullOrEmpty(giaL1) || string.IsNullOrEmpty(giaL2) || string.IsNullOrEmpty(giaL3))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giá.");
                return;
            }

            // Kiểm tra giá trị là kiểu int
            int giaLoai1;
            if (!int.TryParse(giaL1, out giaLoai1))
            {
                MessageBox.Show("Giá Loại 1 không hợp lệ. Vui lòng nhập giá tiền hợp lệ.");
                return;
            }

            int giaLoai2;
            if (!int.TryParse(giaL2, out giaLoai2))
            {
                MessageBox.Show("Giá Loại 2 không hợp lệ. Vui lòng nhập giá tiền hợp lệ.");
                return;
            }

            int giaLoai3;
            if (!int.TryParse(giaL3, out giaLoai3))
            {
                MessageBox.Show("Giá Loại 3 không hợp lệ. Vui lòng nhập giá tiền hợp lệ.");
                return;
            }

            // Thực hiện câu truy vấn cập nhật dữ liệu
            string query = "UPDATE ThongTinHH SET GiaLoai1 = @GiaLoai1, GiaLoai2 = @GiaLoai2, GiaLoai3 = @GiaLoai3 WHERE GiaNgay = @GiaNgay AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GiaLoai1", giaLoai1);
            command.Parameters.AddWithValue("@GiaLoai2", giaLoai2);
            command.Parameters.AddWithValue("@GiaLoai3", giaLoai3);
            command.Parameters.AddWithValue("@GiaNgay", DateXem.Value.Date);
            command.Parameters.AddWithValue("@IDHangHoa", int.Parse(IdHHLabel.Text));

            // Thực hiện câu truy vấn cập nhật
            int rowsAffected = command.ExecuteNonQuery();

            // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc chỉnh sửa dữ liệu
            if (rowsAffected > 0)
            {
                MessageBox.Show("Chỉnh sửa dữ liệu thành công.");
            }
            else
            {
                MessageBox.Show("Không thành công. Kiểm tra lại thông tin.");
            }
        }

        private void GiaL2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

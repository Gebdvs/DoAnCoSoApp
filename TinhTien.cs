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
    public partial class TinhTienForm : Form
    {
        public TinhTienForm()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";
        private void TinhTienForm_Load(object sender, EventArgs e)
        {
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
        private bool CheckDataExists(DateTime date, int idHangHoa)
        {
            // Kiểm tra dữ liệu đã tồn tại trong bảng
            string query = "SELECT COUNT(*) FROM TinhTien WHERE NgayTT = @NgayTT AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayTT", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void InsertData(DateTime date, int idHangHoa)
        {
            // Thêm dữ liệu vào bảng
            string query = "INSERT INTO TinhTien (NgayTT, IDHangHoa) VALUES (@NgayTT, @IDHangHoa)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayTT", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            command.ExecuteNonQuery();
        }

        private void TinhTienBT_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn mặt hàng
            if (string.IsNullOrEmpty(IdHHLabel.Text))
            {
                MessageBox.Show("Chưa chọn mặt hàng.");
                return;
            }
            DateTime selectedDate = DateXem.Value.Date;
            int selectedID = Convert.ToInt32(IdHHLabel.Text);

            

            // Kiểm tra nếu dữ liệu không tồn tại trong bảng
            if (!CheckDataExists(selectedDate, selectedID))
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

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Lấy giá trị từ các cột tương ứng trong dữ liệu đọc được
                    string giaL1 = reader["GiaLoai1"] is DBNull ? null : reader["GiaLoai1"].ToString();
                    string giaL2 = reader["GiaLoai2"] is DBNull ? null : reader["GiaLoai2"].ToString();
                    string giaL3 = reader["GiaLoai3"] is DBNull ? null : reader["GiaLoai3"].ToString();

                    // Hiển thị giá trị trong các label và kiểm tra giá trị null
                    GiaL1Label.Text = giaL1;
                    GiaL2Label.Text = giaL2;
                    GiaL3Label.Text = giaL3;

                    // Kiểm tra và hiển thị thông báo nếu các giá trị là null
                    if (giaL1 == null || giaL2 == null || giaL3 == null)
                    {
                        MessageBox.Show("Chưa có giá của ngày hôm nay.");
                    }
                    else
                    {
                        // Kiểm tra nếu các textbox số lượng chưa nhập
                        if (string.IsNullOrEmpty(SL1Txt.Text) || string.IsNullOrEmpty(SL2Txt.Text) || string.IsNullOrEmpty(SL3Txt.Text))
                        {
                            MessageBox.Show("Chưa nhập số lượng.");
                            return;
                        }
                        // Tính tổng các giá trị
                        int sl1 = int.Parse(SL1Txt.Text);
                        int sl2 = int.Parse(SL2Txt.Text);
                        int sl3 = int.Parse(SL3Txt.Text);

                        int giaLoai1 = int.Parse(giaL1);
                        int giaLoai2 = int.Parse(giaL2);
                        int giaLoai3 = int.Parse(giaL3);

                        int tong = (sl1 * giaLoai1) + (sl2 * giaLoai2) + (sl3 * giaLoai3);

                        // Hiển thị kết quả trong một label (ví dụ: TongLabel)
                        TinhTienLable.Text = tong.ToString();
                    }
                }
                else
                {
                    // Không có dữ liệu
                    MessageBox.Show("Chưa có giá của ngày hôm nay.");
                }
            }
        }

        private void LuuBT_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn mặt hàng
            if (string.IsNullOrEmpty(IdHHLabel.Text))
            {
                MessageBox.Show("Chưa có kết quả.");
                return;
            }
            // Lấy giá trị IDHangHoa từ IdHHLabel
            string selectedHH = IdHHLabel.Text;

            // Lấy giá trị ngày từ DatePicker
            DateTime selectedDate = DateXem.Value.Date;

            // Lấy giá trị tổng từ TinhTienLabel
            int tong = int.Parse(TinhTienLable.Text);

            // Thực hiện câu truy vấn SQL để cập nhật kết quả
            string query = "UPDATE TinhTien SET SoTien = @SoTien WHERE NgayTT = @NgayTT AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SoTien", tong);
            command.Parameters.AddWithValue("@NgayTT", selectedDate);
            command.Parameters.AddWithValue("@IDHangHoa", selectedHH);

            // Thực hiện câu truy vấn cập nhật
            float rowsAffected = command.ExecuteNonQuery();

            // Kiểm tra số dòng bị ảnh hưởng để xác nhận việc lưu kết quả
            if (rowsAffected > 0)
            {
                MessageBox.Show("Lưu kết quả thành công.");
            }
            else
            {
                MessageBox.Show("Không thành công. Kiểm tra lại thông tin.");
            }
        }
    }
}

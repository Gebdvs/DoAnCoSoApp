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
    public partial class TienBanRaForm : Form
    {
        public TienBanRaForm()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";
        public static string quyen;
        private void TienBanRaForm_Load(object sender, EventArgs e)
        {
            if (quyen =="user")
            {
                EditBt.Enabled = false;
            }
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
        private bool CheckDataExists(DateTime date, int idHangHoa)
        {
            // Kiểm tra dữ liệu đã tồn tại trong bảng
            string query = "SELECT COUNT(*) FROM TienBanRa WHERE NgayBan = @NgayBan AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayBan", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void InsertData(DateTime date, int idHangHoa)
        {
            // Thêm dữ liệu vào bảng
            string query = "INSERT INTO TienBanRa (NgayBan, IDHangHoa) VALUES (@NgayBan, @IDHangHoa)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayBan", date);
            command.Parameters.AddWithValue("@IDHangHoa", idHangHoa);

            command.ExecuteNonQuery();
        }
        private void DateXem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHH = comboBox1.SelectedItem.ToString();

            
            string query = "SELECT IDHangHoa FROM HangHoa WHERE TenHH = @TenHH";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenHH", selectedHH);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                
                string idHH = reader[0].ToString();
                IdHHLabel.Text = idHH;
            }
            reader.Close();
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
            if (!CheckDataExists(selectedDate, selectedID))
            {
                // Thực hiện thêm dữ liệu vào bảng
                InsertData(selectedDate, selectedID);

            }
            string selectedHH = IdHHLabel.Text;
            string query = "SELECT SoTienBanRa, TienVatLieu FROM TienBanRa WHERE NgayBan = @NgayBan AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayBan", selectedDate);
            command.Parameters.AddWithValue("@IDHangHoa", selectedHH);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Lấy giá trị từ các cột tương ứng trong dữ liệu đọc được
                string giaL1 = reader["SoTienBanRa"] is DBNull ? null : reader["SoTienBanRa"].ToString();
                string giaL2 = reader["TienVatLieu"] is DBNull ? null : reader["TienVatLieu"].ToString();
                

                // Hiển thị giá trị trong các textbox và kiểm tra giá trị null
                TienBanRaTxt.Text = giaL1;
                TienVatTuTxt.Text = giaL2;
                

                // Kiểm tra và in ra thông báo nếu các textbox chứa giá trị null
                if (giaL1 == null)
                {
                    MessageBox.Show("Chưa nhập số tiền bán ra.");
                    

                    if (giaL2 == null)
                    {
                        MessageBox.Show("Chưa nhập số tiền dùng để mua vật tư.");
                        
                    }
                }
            }
            else
            {
                // Không có dữ liệu
                MessageBox.Show("Không có dữ liệu.");
            }

            reader.Close();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            string giaL1 = TienBanRaTxt.Text;
            string giaL2 = TienVatTuTxt.Text;
            if (string.IsNullOrEmpty(giaL1) || string.IsNullOrEmpty(giaL2) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giá.");
                return;
            }
            // Kiểm tra giá trị là kiểu int
            int giaLoai1;
            if (!int.TryParse(giaL1, out giaLoai1))
            {
                MessageBox.Show("Số tiền bán ra không hợp lệ. Vui lòng nhập giá tiền hợp lệ.");
                return;
            }

            int giaLoai2;
            if (!int.TryParse(giaL2, out giaLoai2))
            {
                MessageBox.Show("Số tiền mua vật liệu không hợp lệ. Vui lòng nhập giá tiền hợp lệ.");
                return;
            }
            string query = "UPDATE TienBanRa SET SoTienBanRa = @SoTienBanRa, TienVatLieu = @TienVatLieu WHERE NgayBan = @NgayBan AND IDHangHoa = @IDHangHoa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SoTienBanRa", giaLoai1);
            command.Parameters.AddWithValue("@TienVatLieu", giaLoai2);
            command.Parameters.AddWithValue("@NgayBan", DateXem.Value.Date);
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
    }
}

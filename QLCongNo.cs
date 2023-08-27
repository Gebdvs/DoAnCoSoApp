using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCoSoApp
{
    public partial class QLCongNoForm : Form
    {
        public QLCongNoForm()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString = @"Data Source=GEBDVS;Initial Catalog=DoAnCoSo;Integrated Security=True";
        private void QLCongNoForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

        }

        private bool CheckDataExists(DateTime date)
        {
            // Kiểm tra dữ liệu đã tồn tại trong bảng
            string query = "SELECT COUNT(*) FROM CongNo WHERE Ngay = @Ngay";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ngay", date);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void InsertData(DateTime date)
        {
            // Thêm dữ liệu vào bảng
            string query = "INSERT INTO CongNo (Ngay) VALUES (@Ngay)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ngay", date);


            command.ExecuteNonQuery();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DangNhapBt_Click(object sender, EventArgs e)
        {

        }



        private void DateXem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XemGiaBt_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateXem.Value.Date;

            if (!CheckDataExists(selectedDate))
            {
                InsertData(selectedDate);
            }

            string sumQuery = "SELECT SUM(SoTien) FROM TinhTien WHERE NgayTT = @NgayTT";
            string updateSoLuongMuaQuery = "UPDATE CongNo SET SoLuongMua = @SoLuongMua WHERE Ngay = @Ngay";
            string sumSoLuongBanQuery = "SELECT SUM(SoTienBanRa) FROM TienBanRa WHERE NgayBan = @NgayBan";
            string updateSoLuongBanQuery = "UPDATE CongNo SET SoLuongBan = @SoLuongBan WHERE Ngay = @Ngay";
            string sumTienVatLieuQuery = "SELECT SUM(TienVatLieu) FROM TienBanRa WHERE NgayBan = @NgayBan";
            string updateTongKetQuery = "UPDATE CongNo SET TongKetNgay = @TongKetNgay WHERE Ngay = @Ngay";
            string updateSoLuongVatTuQuery = "UPDATE CongNo SET SoLuongVatTu = @SoLuongVatTu WHERE Ngay = @Ngay";

            using (SqlCommand sumCommand = new SqlCommand(sumQuery, connection))
            using (SqlCommand updateSoLuongMuaCommand = new SqlCommand(updateSoLuongMuaQuery, connection))
            using (SqlCommand sumSoLuongBanCommand = new SqlCommand(sumSoLuongBanQuery, connection))
            using (SqlCommand updateSoLuongBanCommand = new SqlCommand(updateSoLuongBanQuery, connection))
            using (SqlCommand sumTienVatTuCommand = new SqlCommand(sumTienVatLieuQuery, connection))
            {
                sumCommand.Parameters.AddWithValue("@NgayTT", selectedDate);
                object result = sumCommand.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    TongTienMuaTxt.Text = result.ToString();

                    updateSoLuongMuaCommand.Parameters.AddWithValue("@SoLuongMua", result);
                    updateSoLuongMuaCommand.Parameters.AddWithValue("@Ngay", selectedDate);
                    updateSoLuongMuaCommand.ExecuteNonQuery();

                    sumSoLuongBanCommand.Parameters.AddWithValue("@NgayBan", selectedDate);
                    object sumResult = sumSoLuongBanCommand.ExecuteScalar();

                    if (sumResult != null && sumResult != DBNull.Value)
                    {
                        int soLuongBan = Convert.ToInt32(sumResult);
                        TienBanRaTxt.Text = soLuongBan.ToString();

                        updateSoLuongBanCommand.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                        updateSoLuongBanCommand.Parameters.AddWithValue("@Ngay", selectedDate);
                        updateSoLuongBanCommand.ExecuteNonQuery();

                        sumTienVatTuCommand.Parameters.AddWithValue("@NgayBan", selectedDate);
                        object sumTienVatTuResult = sumTienVatTuCommand.ExecuteScalar();

                        if (sumTienVatTuResult != null && sumTienVatTuResult != DBNull.Value)
                        {
                            decimal tienVatTu = Convert.ToDecimal(sumTienVatTuResult);
                            TienVatTuTxt.Text = tienVatTu.ToString();
                            using (SqlCommand updateVatTuCommand = new SqlCommand(updateSoLuongVatTuQuery, connection))
                            {
                                updateVatTuCommand.Parameters.AddWithValue("@SoLuongVatTu", tienVatTu);
                                updateVatTuCommand.Parameters.AddWithValue("@Ngay", selectedDate);
                                updateVatTuCommand.ExecuteNonQuery();
                            }


                            // Tính kết quả và in ra TextBox TongKetTxt
                            decimal tongKet = soLuongBan - Convert.ToDecimal(result) - tienVatTu;
                            TongKetTxt.Text = tongKet.ToString();
                            using (SqlCommand updateTongKetCommand = new SqlCommand(updateTongKetQuery, connection))
                            {
                                updateTongKetCommand.Parameters.AddWithValue("@TongKetNgay", tongKet);
                                updateTongKetCommand.Parameters.AddWithValue("@Ngay", selectedDate);
                                updateTongKetCommand.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            TienVatTuTxt.Text = "0";
                            TongKetTxt.Text = "Thông báo: Giá trị TienVatTu là null hoặc bằng 0.";
                        }
                    }
                    else
                    {
                        TienBanRaTxt.Text = "0";
                        TienVatTuTxt.Text = "0";
                        TongKetTxt.Text = "Thông báo: Giá trị TienBanRa là null hoặc bằng 0.";
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu.");
                }
            }
        }

        private void TongTienMuaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






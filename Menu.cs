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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        public static string quyen;
        
        private void DangNhapBt_Click(object sender, EventArgs e)
        {

        }

        private void ThoatBt_Click(object sender, EventArgs e)
        {

        }

        private void QLCongNoBt_Click(object sender, EventArgs e)
        {
            

            
                QLCongNoForm qLCongNoForm = new QLCongNoForm();
                qLCongNoForm.Show();
                this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XemGiaForm xemGiaForm = new XemGiaForm();
            xemGiaForm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (quyen=="user")
            {
                QLCongNoBt.Enabled = false;

            }
        }
        

        private void QLSanPhamBt_Click(object sender, EventArgs e)
        {

        }

        private void TinhTienBt_Click(object sender, EventArgs e)
        {
            TinhTienForm tinhTienForm = new TinhTienForm();
            tinhTienForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TienBanRaForm tienBanRaForm = new TienBanRaForm();
            tienBanRaForm.Show();
        }
    }
}

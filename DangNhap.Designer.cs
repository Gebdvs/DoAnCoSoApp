namespace DoAnCoSoApp
{
    partial class DangNhapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DangNhapBt = new System.Windows.Forms.Button();
            this.DangKyBt = new System.Windows.Forms.Button();
            this.ThoatBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaiKhoanTxt = new System.Windows.Forms.TextBox();
            this.MatKhauTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DangNhapBt
            // 
            this.DangNhapBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapBt.Location = new System.Drawing.Point(225, 308);
            this.DangNhapBt.Margin = new System.Windows.Forms.Padding(4);
            this.DangNhapBt.Name = "DangNhapBt";
            this.DangNhapBt.Size = new System.Drawing.Size(132, 42);
            this.DangNhapBt.TabIndex = 0;
            this.DangNhapBt.Text = "Đăng Nhập";
            this.DangNhapBt.UseVisualStyleBackColor = true;
            this.DangNhapBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangKyBt
            // 
            this.DangKyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKyBt.Location = new System.Drawing.Point(376, 308);
            this.DangKyBt.Margin = new System.Windows.Forms.Padding(4);
            this.DangKyBt.Name = "DangKyBt";
            this.DangKyBt.Size = new System.Drawing.Size(132, 42);
            this.DangKyBt.TabIndex = 1;
            this.DangKyBt.Text = "Đăng Ký";
            this.DangKyBt.UseVisualStyleBackColor = true;
            this.DangKyBt.Click += new System.EventHandler(this.DangKyBt_Click);
            // 
            // ThoatBt
            // 
            this.ThoatBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatBt.Location = new System.Drawing.Point(539, 308);
            this.ThoatBt.Margin = new System.Windows.Forms.Padding(4);
            this.ThoatBt.Name = "ThoatBt";
            this.ThoatBt.Size = new System.Drawing.Size(132, 42);
            this.ThoatBt.TabIndex = 2;
            this.ThoatBt.Text = "Thoát";
            this.ThoatBt.UseVisualStyleBackColor = true;
            this.ThoatBt.Click += new System.EventHandler(this.ThoatBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // TaiKhoanTxt
            // 
            this.TaiKhoanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanTxt.Location = new System.Drawing.Point(225, 128);
            this.TaiKhoanTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TaiKhoanTxt.Name = "TaiKhoanTxt";
            this.TaiKhoanTxt.Size = new System.Drawing.Size(446, 31);
            this.TaiKhoanTxt.TabIndex = 5;
            // 
            // MatKhauTxt
            // 
            this.MatKhauTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauTxt.Location = new System.Drawing.Point(225, 193);
            this.MatKhauTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MatKhauTxt.Name = "MatKhauTxt";
            this.MatKhauTxt.Size = new System.Drawing.Size(446, 31);
            this.MatKhauTxt.TabIndex = 6;
            this.MatKhauTxt.TextChanged += new System.EventHandler(this.MatKhauTxt_TextChanged);
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.MatKhauTxt);
            this.Controls.Add(this.TaiKhoanTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThoatBt);
            this.Controls.Add(this.DangKyBt);
            this.Controls.Add(this.DangNhapBt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhapForm";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DangNhapBt;
        private System.Windows.Forms.Button DangKyBt;
        private System.Windows.Forms.Button ThoatBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TaiKhoanTxt;
        private System.Windows.Forms.TextBox MatKhauTxt;
    }
}


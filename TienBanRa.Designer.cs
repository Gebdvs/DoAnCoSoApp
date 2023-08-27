namespace DoAnCoSoApp
{
    partial class TienBanRaForm
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
            this.XemGiaBt = new System.Windows.Forms.Button();
            this.IdHHLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateXem = new System.Windows.Forms.DateTimePicker();
            this.TienVatTuTxt = new System.Windows.Forms.TextBox();
            this.TienBanRaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XemGiaBt
            // 
            this.XemGiaBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemGiaBt.Location = new System.Drawing.Point(282, 86);
            this.XemGiaBt.Name = "XemGiaBt";
            this.XemGiaBt.Size = new System.Drawing.Size(127, 33);
            this.XemGiaBt.TabIndex = 39;
            this.XemGiaBt.Text = "Xem";
            this.XemGiaBt.UseVisualStyleBackColor = true;
            this.XemGiaBt.Click += new System.EventHandler(this.XemGiaBt_Click);
            // 
            // IdHHLabel
            // 
            this.IdHHLabel.AutoSize = true;
            this.IdHHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdHHLabel.Location = new System.Drawing.Point(111, 143);
            this.IdHHLabel.Name = "IdHHLabel";
            this.IdHHLabel.Size = new System.Drawing.Size(0, 25);
            this.IdHHLabel.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Có ID là:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 33);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DateXem
            // 
            this.DateXem.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateXem.Location = new System.Drawing.Point(12, 26);
            this.DateXem.Name = "DateXem";
            this.DateXem.Size = new System.Drawing.Size(445, 31);
            this.DateXem.TabIndex = 35;
            this.DateXem.ValueChanged += new System.EventHandler(this.DateXem_ValueChanged);
            // 
            // TienVatTuTxt
            // 
            this.TienVatTuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienVatTuTxt.Location = new System.Drawing.Point(213, 278);
            this.TienVatTuTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TienVatTuTxt.Name = "TienVatTuTxt";
            this.TienVatTuTxt.Size = new System.Drawing.Size(177, 31);
            this.TienVatTuTxt.TabIndex = 43;
            // 
            // TienBanRaTxt
            // 
            this.TienBanRaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienBanRaTxt.Location = new System.Drawing.Point(213, 213);
            this.TienBanRaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TienBanRaTxt.Name = "TienBanRaTxt";
            this.TienBanRaTxt.Size = new System.Drawing.Size(177, 31);
            this.TienBanRaTxt.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số tiền vật liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Số tiền bán được";
            // 
            // EditBt
            // 
            this.EditBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBt.Location = new System.Drawing.Point(263, 359);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(127, 33);
            this.EditBt.TabIndex = 44;
            this.EditBt.Text = "Chỉnh sửa";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // TienBanRaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 557);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.TienVatTuTxt);
            this.Controls.Add(this.TienBanRaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XemGiaBt);
            this.Controls.Add(this.IdHHLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DateXem);
            this.Name = "TienBanRaForm";
            this.Text = "TienBanRa";
            this.Load += new System.EventHandler(this.TienBanRaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XemGiaBt;
        private System.Windows.Forms.Label IdHHLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker DateXem;
        private System.Windows.Forms.TextBox TienVatTuTxt;
        private System.Windows.Forms.TextBox TienBanRaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBt;
    }
}
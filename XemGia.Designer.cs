namespace DoAnCoSoApp
{
    partial class XemGiaForm
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
            this.components = new System.ComponentModel.Container();
            this.XemGiaBt = new System.Windows.Forms.Button();
            this.IdHHLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateXem = new System.Windows.Forms.DateTimePicker();
            this.GiaL3Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GiaL2Txt = new System.Windows.Forms.TextBox();
            this.GiaL1Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBt = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // XemGiaBt
            // 
            this.XemGiaBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemGiaBt.Location = new System.Drawing.Point(256, 88);
            this.XemGiaBt.Name = "XemGiaBt";
            this.XemGiaBt.Size = new System.Drawing.Size(127, 33);
            this.XemGiaBt.TabIndex = 34;
            this.XemGiaBt.Text = "Xem giá";
            this.XemGiaBt.UseVisualStyleBackColor = true;
            this.XemGiaBt.Click += new System.EventHandler(this.XemGiaBt_Click);
            // 
            // IdHHLabel
            // 
            this.IdHHLabel.AutoSize = true;
            this.IdHHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdHHLabel.Location = new System.Drawing.Point(163, 145);
            this.IdHHLabel.Name = "IdHHLabel";
            this.IdHHLabel.Size = new System.Drawing.Size(0, 25);
            this.IdHHLabel.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Có ID là:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 33);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DateXem
            // 
            this.DateXem.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateXem.Location = new System.Drawing.Point(12, 27);
            this.DateXem.Name = "DateXem";
            this.DateXem.Size = new System.Drawing.Size(371, 31);
            this.DateXem.TabIndex = 30;
            this.DateXem.ValueChanged += new System.EventHandler(this.DateXem_ValueChanged);
            // 
            // GiaL3Txt
            // 
            this.GiaL3Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaL3Txt.Location = new System.Drawing.Point(206, 350);
            this.GiaL3Txt.Margin = new System.Windows.Forms.Padding(4);
            this.GiaL3Txt.Name = "GiaL3Txt";
            this.GiaL3Txt.Size = new System.Drawing.Size(177, 31);
            this.GiaL3Txt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giá loại 3";
            // 
            // GiaL2Txt
            // 
            this.GiaL2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaL2Txt.Location = new System.Drawing.Point(206, 283);
            this.GiaL2Txt.Margin = new System.Windows.Forms.Padding(4);
            this.GiaL2Txt.Name = "GiaL2Txt";
            this.GiaL2Txt.Size = new System.Drawing.Size(177, 31);
            this.GiaL2Txt.TabIndex = 27;
            this.GiaL2Txt.TextChanged += new System.EventHandler(this.GiaL2Txt_TextChanged);
            // 
            // GiaL1Txt
            // 
            this.GiaL1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaL1Txt.Location = new System.Drawing.Point(206, 218);
            this.GiaL1Txt.Margin = new System.Windows.Forms.Padding(4);
            this.GiaL1Txt.Name = "GiaL1Txt";
            this.GiaL1Txt.Size = new System.Drawing.Size(177, 31);
            this.GiaL1Txt.TabIndex = 26;
            this.GiaL1Txt.TextChanged += new System.EventHandler(this.GiaL1Txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giá loại 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Giá loại 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditBt
            // 
            this.EditBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBt.Location = new System.Drawing.Point(256, 423);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(127, 33);
            this.EditBt.TabIndex = 35;
            this.EditBt.Text = "Chỉnh sửa";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XemGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.XemGiaBt);
            this.Controls.Add(this.IdHHLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DateXem);
            this.Controls.Add(this.GiaL3Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GiaL2Txt);
            this.Controls.Add(this.GiaL1Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XemGiaForm";
            this.Text = "XemGia";
            this.Load += new System.EventHandler(this.TinhCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XemGiaBt;
        private System.Windows.Forms.Label IdHHLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker DateXem;
        private System.Windows.Forms.TextBox GiaL3Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GiaL2Txt;
        private System.Windows.Forms.TextBox GiaL1Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}
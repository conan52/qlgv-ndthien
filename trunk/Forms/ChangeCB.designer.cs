namespace QLGV.Forms
{
    partial class ChangeCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCB));
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.txtHoTen = new QLGV.UserControls.NDThienTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNhom = new QLGV.UserControls.NDThienComboBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtDV = new QLGV.UserControls.NDThienTextBox(this.components);
            this.dtNgayDen = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTruong = new QLGV.UserControls.NDThienComboBox(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Họ và tên";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.ImageKey = "close.jpg";
            this.btClose.ImageList = this.imageList1;
            this.btClose.Location = new System.Drawing.Point(272, 242);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(85, 26);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "address_f2.png");
            this.imageList1.Images.SetKeyName(1, "apply_f2.png");
            this.imageList1.Images.SetKeyName(2, "edit_f2.png");
            this.imageList1.Images.SetKeyName(3, "extensions_f2.png");
            this.imageList1.Images.SetKeyName(4, "new_f2.png");
            this.imageList1.Images.SetKeyName(5, "search_f2.png");
            this.imageList1.Images.SetKeyName(6, "stop_f2.png");
            this.imageList1.Images.SetKeyName(7, "close.jpg");
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.ImageKey = "apply_f2.png";
            this.btSave.ImageList = this.imageList1;
            this.btSave.Location = new System.Drawing.Point(181, 242);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(85, 26);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(112, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Chuyển đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày đến";
            // 
            // cbNhom
            // 
            this.cbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(167, 120);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(185, 21);
            this.cbNhom.TabIndex = 68;
            this.cbNhom.SelectedIndexChanged += new System.EventHandler(this.cbNhom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Đơn vị hiện tại";
            // 
            // txtDV
            // 
            this.txtDV.BackColor = System.Drawing.Color.White;
            this.txtDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDV.ForeColor = System.Drawing.Color.Black;
            this.txtDV.Location = new System.Drawing.Point(112, 47);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(245, 20);
            this.txtDV.TabIndex = 70;
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDen.Location = new System.Drawing.Point(112, 208);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(245, 20);
            this.dtNgayDen.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nhóm đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Tên đơn vị";
            // 
            // cbTruong
            // 
            this.cbTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Location = new System.Drawing.Point(167, 159);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(185, 21);
            this.cbTruong.TabIndex = 75;
            // 
            // ChangeCB
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.cbTruong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayDen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật thông tin trường";
            this.Load += new System.EventHandler(this.Add_HT_CanBo_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private QLGV.UserControls.NDThienTextBox txtHoTen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UserControls.NDThienComboBox cbNhom;
        private System.Windows.Forms.Label label4;
        private UserControls.NDThienTextBox txtDV;
        private UserControls.NDThienDateTimePicker dtNgayDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private UserControls.NDThienComboBox cbTruong;
    }
}
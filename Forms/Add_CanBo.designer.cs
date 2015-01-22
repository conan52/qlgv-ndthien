namespace QLGV.Forms
{
    partial class Add_CanBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_CanBo));
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.laNgayvaodang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.nudPhuCap = new System.Windows.Forms.NumericUpDown();
            this.chkTiengDanToc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.rdDoanVien = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNgachLuong = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbMonDay = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbCdkh = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbQlnn = new QLGV.UserControls.NDThienComboBox(this.components);
            this.txtBacLuong = new QLGV.UserControls.NDThienTextBox(this.components);
            this.txtMaNgach = new QLGV.UserControls.NDThienTextBox(this.components);
            this.cbChucVu = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbChuyenNghanh = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbChuyenMon = new QLGV.UserControls.NDThienComboBox(this.components);
            this.dtNgayVaoDoan = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.cbTinHoc = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbNgoaiNgu = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbChinhTri = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbTonGiao = new QLGV.UserControls.NDThienComboBox(this.components);
            this.cbDanToc = new QLGV.UserControls.NDThienComboBox(this.components);
            this.dtHuongLuongTuNgay = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.dtNgayBoNhiem = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.dtNgayChuyenDen = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.dtNgayVaoNghanh = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.dtHuongPhuCapTuNgay = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.cbGioiTinh = new QLGV.UserControls.NDThienComboBox(this.components);
            this.dtNgaySinh = new QLGV.UserControls.NDThienDateTimePicker(this.components);
            this.txtHoTen = new QLGV.UserControls.NDThienTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhuCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
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
            this.btClose.Location = new System.Drawing.Point(710, 464);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(85, 26);
            this.btClose.TabIndex = 27;
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
            this.btSave.Location = new System.Drawing.Point(619, 464);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(85, 26);
            this.btSave.TabIndex = 26;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Dân tộc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tôn giáo";
            // 
            // laNgayvaodang
            // 
            this.laNgayvaodang.AutoSize = true;
            this.laNgayvaodang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNgayvaodang.Location = new System.Drawing.Point(14, 252);
            this.laNgayvaodang.Name = "laNgayvaodang";
            this.laNgayvaodang.Size = new System.Drawing.Size(88, 15);
            this.laNgayvaodang.TabIndex = 73;
            this.laNgayvaodang.Text = "Ngày vào đảng";
            this.laNgayvaodang.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Chuyên môn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "Chuyên nghành";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Chính trị";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 77;
            this.label11.Text = "Ngoại ngữ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 78;
            this.label12.Text = "Tin học";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 15);
            this.label13.TabIndex = 79;
            this.label13.Text = "Có chứng chỉ tiếng dân tộc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(431, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 80;
            this.label14.Text = "Ngày vào nghành";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(431, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 81;
            this.label15.Text = "Ngày chuyển đến";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(431, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 15);
            this.label16.TabIndex = 82;
            this.label16.Text = "Ngày bổ nhiệm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(431, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 15);
            this.label17.TabIndex = 83;
            this.label17.Text = "Chức vụ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(431, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 15);
            this.label19.TabIndex = 85;
            this.label19.Text = "Mã nghạch";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(431, 329);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 15);
            this.label20.TabIndex = 86;
            this.label20.Text = "Bậc lương";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(431, 363);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 15);
            this.label21.TabIndex = 87;
            this.label21.Text = "Hưởng lương từ ngày";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(431, 390);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 15);
            this.label22.TabIndex = 88;
            this.label22.Text = "Phụ cấp (%)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(431, 422);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 15);
            this.label23.TabIndex = 89;
            this.label23.Text = "Hưởng phụ cấp từ ngày";
            // 
            // nudPhuCap
            // 
            this.nudPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPhuCap.Location = new System.Drawing.Point(582, 390);
            this.nudPhuCap.Name = "nudPhuCap";
            this.nudPhuCap.Size = new System.Drawing.Size(120, 21);
            this.nudPhuCap.TabIndex = 24;
            // 
            // chkTiengDanToc
            // 
            this.chkTiengDanToc.AutoSize = true;
            this.chkTiengDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTiengDanToc.Location = new System.Drawing.Point(183, 454);
            this.chkTiengDanToc.Name = "chkTiengDanToc";
            this.chkTiengDanToc.Size = new System.Drawing.Size(59, 19);
            this.chkTiengDanToc.TabIndex = 12;
            this.chkTiengDanToc.Text = "           ";
            this.chkTiengDanToc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Quản lý nhà nước";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(431, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 15);
            this.label24.TabIndex = 113;
            this.label24.Text = "Chức danh khoa học";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(431, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 15);
            this.label25.TabIndex = 115;
            this.label25.Text = "Môn dạy";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(431, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 15);
            this.label18.TabIndex = 117;
            this.label18.Text = "Ngạch lương";
            // 
            // rdDoanVien
            // 
            this.rdDoanVien.AutoSize = true;
            this.rdDoanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDoanVien.Location = new System.Drawing.Point(138, 223);
            this.rdDoanVien.Name = "rdDoanVien";
            this.rdDoanVien.Size = new System.Drawing.Size(71, 21);
            this.rdDoanVien.TabIndex = 5;
            this.rdDoanVien.Text = "           ";
            this.rdDoanVien.UseVisualStyleBackColor = true;
            this.rdDoanVien.CheckedChanged += new System.EventHandler(this.rdDoanVien_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 120;
            this.label7.Text = "Là đảng viên";
            // 
            // cbNgachLuong
            // 
            this.cbNgachLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgachLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgachLuong.FormattingEnabled = true;
            this.cbNgachLuong.Location = new System.Drawing.Point(582, 255);
            this.cbNgachLuong.Name = "cbNgachLuong";
            this.cbNgachLuong.Size = new System.Drawing.Size(194, 23);
            this.cbNgachLuong.TabIndex = 20;
            this.cbNgachLuong.SelectedIndexChanged += new System.EventHandler(this.cbNgachLuong_SelectedIndexChanged);
            // 
            // cbMonDay
            // 
            this.cbMonDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonDay.FormattingEnabled = true;
            this.cbMonDay.Location = new System.Drawing.Point(582, 93);
            this.cbMonDay.Name = "cbMonDay";
            this.cbMonDay.Size = new System.Drawing.Size(194, 23);
            this.cbMonDay.TabIndex = 15;
            // 
            // cbCdkh
            // 
            this.cbCdkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCdkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCdkh.FormattingEnabled = true;
            this.cbCdkh.Location = new System.Drawing.Point(582, 62);
            this.cbCdkh.Name = "cbCdkh";
            this.cbCdkh.Size = new System.Drawing.Size(194, 23);
            this.cbCdkh.TabIndex = 14;
            // 
            // cbQlnn
            // 
            this.cbQlnn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQlnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQlnn.FormattingEnabled = true;
            this.cbQlnn.Location = new System.Drawing.Point(582, 31);
            this.cbQlnn.Name = "cbQlnn";
            this.cbQlnn.Size = new System.Drawing.Size(194, 23);
            this.cbQlnn.TabIndex = 13;
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.BackColor = System.Drawing.Color.White;
            this.txtBacLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacLuong.ForeColor = System.Drawing.Color.Black;
            this.txtBacLuong.Location = new System.Drawing.Point(582, 325);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(194, 21);
            this.txtBacLuong.TabIndex = 22;
            // 
            // txtMaNgach
            // 
            this.txtMaNgach.BackColor = System.Drawing.Color.White;
            this.txtMaNgach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNgach.ForeColor = System.Drawing.Color.Black;
            this.txtMaNgach.Location = new System.Drawing.Point(582, 292);
            this.txtMaNgach.Name = "txtMaNgach";
            this.txtMaNgach.Size = new System.Drawing.Size(194, 21);
            this.txtMaNgach.TabIndex = 21;
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(582, 223);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(194, 23);
            this.cbChucVu.TabIndex = 19;
            // 
            // cbChuyenNghanh
            // 
            this.cbChuyenNghanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenNghanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenNghanh.FormattingEnabled = true;
            this.cbChuyenNghanh.Location = new System.Drawing.Point(138, 315);
            this.cbChuyenNghanh.Name = "cbChuyenNghanh";
            this.cbChuyenNghanh.Size = new System.Drawing.Size(194, 23);
            this.cbChuyenNghanh.TabIndex = 8;
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.Location = new System.Drawing.Point(138, 285);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(194, 23);
            this.cbChuyenMon.TabIndex = 7;
            // 
            // dtNgayVaoDoan
            // 
            this.dtNgayVaoDoan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayVaoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayVaoDoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoDoan.Location = new System.Drawing.Point(138, 252);
            this.dtNgayVaoDoan.Name = "dtNgayVaoDoan";
            this.dtNgayVaoDoan.Size = new System.Drawing.Size(194, 21);
            this.dtNgayVaoDoan.TabIndex = 6;
            this.dtNgayVaoDoan.Visible = false;
            // 
            // cbTinHoc
            // 
            this.cbTinHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinHoc.FormattingEnabled = true;
            this.cbTinHoc.Location = new System.Drawing.Point(138, 415);
            this.cbTinHoc.Name = "cbTinHoc";
            this.cbTinHoc.Size = new System.Drawing.Size(194, 23);
            this.cbTinHoc.TabIndex = 11;
            // 
            // cbNgoaiNgu
            // 
            this.cbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgoaiNgu.FormattingEnabled = true;
            this.cbNgoaiNgu.Location = new System.Drawing.Point(138, 381);
            this.cbNgoaiNgu.Name = "cbNgoaiNgu";
            this.cbNgoaiNgu.Size = new System.Drawing.Size(194, 23);
            this.cbNgoaiNgu.TabIndex = 10;
            // 
            // cbChinhTri
            // 
            this.cbChinhTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChinhTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChinhTri.FormattingEnabled = true;
            this.cbChinhTri.Location = new System.Drawing.Point(138, 347);
            this.cbChinhTri.Name = "cbChinhTri";
            this.cbChinhTri.Size = new System.Drawing.Size(194, 23);
            this.cbChinhTri.TabIndex = 9;
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.Location = new System.Drawing.Point(138, 183);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(194, 23);
            this.cbTonGiao.TabIndex = 4;
            // 
            // cbDanToc
            // 
            this.cbDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Location = new System.Drawing.Point(138, 146);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(194, 23);
            this.cbDanToc.TabIndex = 3;
            // 
            // dtHuongLuongTuNgay
            // 
            this.dtHuongLuongTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtHuongLuongTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHuongLuongTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHuongLuongTuNgay.Location = new System.Drawing.Point(582, 359);
            this.dtHuongLuongTuNgay.Name = "dtHuongLuongTuNgay";
            this.dtHuongLuongTuNgay.Size = new System.Drawing.Size(194, 21);
            this.dtHuongLuongTuNgay.TabIndex = 23;
            // 
            // dtNgayBoNhiem
            // 
            this.dtNgayBoNhiem.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBoNhiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBoNhiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBoNhiem.Location = new System.Drawing.Point(582, 192);
            this.dtNgayBoNhiem.Name = "dtNgayBoNhiem";
            this.dtNgayBoNhiem.Size = new System.Drawing.Size(194, 21);
            this.dtNgayBoNhiem.TabIndex = 18;
            // 
            // dtNgayChuyenDen
            // 
            this.dtNgayChuyenDen.CustomFormat = "dd/MM/yyyy";
            this.dtNgayChuyenDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayChuyenDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayChuyenDen.Location = new System.Drawing.Point(582, 155);
            this.dtNgayChuyenDen.Name = "dtNgayChuyenDen";
            this.dtNgayChuyenDen.Size = new System.Drawing.Size(194, 21);
            this.dtNgayChuyenDen.TabIndex = 17;
            // 
            // dtNgayVaoNghanh
            // 
            this.dtNgayVaoNghanh.CustomFormat = "dd/MM/yyyy";
            this.dtNgayVaoNghanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayVaoNghanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoNghanh.Location = new System.Drawing.Point(582, 124);
            this.dtNgayVaoNghanh.Name = "dtNgayVaoNghanh";
            this.dtNgayVaoNghanh.Size = new System.Drawing.Size(194, 21);
            this.dtNgayVaoNghanh.TabIndex = 16;
            // 
            // dtHuongPhuCapTuNgay
            // 
            this.dtHuongPhuCapTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtHuongPhuCapTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHuongPhuCapTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHuongPhuCapTuNgay.Location = new System.Drawing.Point(582, 422);
            this.dtHuongPhuCapTuNgay.Name = "dtHuongPhuCapTuNgay";
            this.dtHuongPhuCapTuNgay.Size = new System.Drawing.Size(194, 21);
            this.dtHuongPhuCapTuNgay.TabIndex = 25;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(138, 108);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(194, 23);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(138, 70);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(194, 21);
            this.dtNgaySinh.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(138, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(194, 21);
            this.txtHoTen.TabIndex = 0;
            // 
            // Add_CanBo
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(819, 502);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdDoanVien);
            this.Controls.Add(this.cbNgachLuong);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbMonDay);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbCdkh);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbQlnn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBacLuong);
            this.Controls.Add(this.txtMaNgach);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbChuyenNghanh);
            this.Controls.Add(this.cbChuyenMon);
            this.Controls.Add(this.chkTiengDanToc);
            this.Controls.Add(this.nudPhuCap);
            this.Controls.Add(this.dtNgayVaoDoan);
            this.Controls.Add(this.cbTinHoc);
            this.Controls.Add(this.cbNgoaiNgu);
            this.Controls.Add(this.cbChinhTri);
            this.Controls.Add(this.cbTonGiao);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.dtHuongLuongTuNgay);
            this.Controls.Add(this.dtNgayBoNhiem);
            this.Controls.Add(this.dtNgayChuyenDen);
            this.Controls.Add(this.dtNgayVaoNghanh);
            this.Controls.Add(this.dtHuongPhuCapTuNgay);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.laNgayvaodang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_CanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật thông tin chi tiết cán bộ, giáo viên";
            this.Load += new System.EventHandler(this.Add_HT_CanBo_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhuCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private QLGV.UserControls.NDThienTextBox txtHoTen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ImageList imageList1;
        private UserControls.NDThienDateTimePicker dtNgaySinh;
        private UserControls.NDThienComboBox cbGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laNgayvaodang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private UserControls.NDThienDateTimePicker dtHuongPhuCapTuNgay;
        private UserControls.NDThienDateTimePicker dtNgayVaoNghanh;
        private UserControls.NDThienDateTimePicker dtNgayChuyenDen;
        private UserControls.NDThienDateTimePicker dtNgayBoNhiem;
        private UserControls.NDThienDateTimePicker dtHuongLuongTuNgay;
        private UserControls.NDThienComboBox cbDanToc;
        private UserControls.NDThienComboBox cbTonGiao;
        private UserControls.NDThienComboBox cbChinhTri;
        private UserControls.NDThienComboBox cbNgoaiNgu;
        private UserControls.NDThienComboBox cbTinHoc;
        private UserControls.NDThienDateTimePicker dtNgayVaoDoan;
        private System.Windows.Forms.NumericUpDown nudPhuCap;
        private System.Windows.Forms.CheckBox chkTiengDanToc;
        private UserControls.NDThienComboBox cbChuyenMon;
        private UserControls.NDThienComboBox cbChuyenNghanh;
        private UserControls.NDThienComboBox cbChucVu;
        private UserControls.NDThienTextBox txtMaNgach;
        private UserControls.NDThienTextBox txtBacLuong;
        private UserControls.NDThienComboBox cbQlnn;
        private System.Windows.Forms.Label label6;
        private UserControls.NDThienComboBox cbCdkh;
        private System.Windows.Forms.Label label24;
        private UserControls.NDThienComboBox cbMonDay;
        private System.Windows.Forms.Label label25;
        private UserControls.NDThienComboBox cbNgachLuong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox rdDoanVien;
        private System.Windows.Forms.Label label7;
    }
}
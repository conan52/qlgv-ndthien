namespace QLGV.Forms
{
    partial class SysChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysChangePass));
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.txtpass = new QLGV.UserControls.NDThienTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewpass = new QLGV.UserControls.NDThienTextBox(this.components);
            this.txtnewpasscomfirm = new QLGV.UserControls.NDThienTextBox(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.ImageKey = "close.jpg";
            this.btClose.ImageList = this.imageList1;
            this.btClose.Location = new System.Drawing.Point(274, 114);
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
            this.btSave.Location = new System.Drawing.Point(183, 114);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(85, 26);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(162, 13);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(172, 20);
            this.txtpass.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(162, 45);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(172, 20);
            this.txtnewpass.TabIndex = 70;
            // 
            // txtnewpasscomfirm
            // 
            this.txtnewpasscomfirm.Location = new System.Drawing.Point(162, 75);
            this.txtnewpasscomfirm.Name = "txtnewpasscomfirm";
            this.txtnewpasscomfirm.PasswordChar = '*';
            this.txtnewpasscomfirm.Size = new System.Drawing.Size(172, 20);
            this.txtnewpasscomfirm.TabIndex = 71;
            // 
            // SysChangePass
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(369, 152);
            this.Controls.Add(this.txtnewpasscomfirm);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.Add_HT_TinHoc_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private QLGV.UserControls.NDThienTextBox txtTitle;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ImageList imageList1;
        private UserControls.NDThienTextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UserControls.NDThienTextBox txtnewpass;
        private UserControls.NDThienTextBox txtnewpasscomfirm;
    }
}
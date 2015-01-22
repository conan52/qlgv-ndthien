namespace QLGV.Forms
{
    partial class SysConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysConfig));
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btClose = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm hiện tại";
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.ImageKey = "apply_f2.png";
            this.btLogin.ImageList = this.imageList1;
            this.btLogin.Location = new System.Drawing.Point(90, 117);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(82, 26);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Lưu lại";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
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
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.ImageKey = "close.jpg";
            this.btClose.ImageList = this.imageList1;
            this.btClose.Location = new System.Drawing.Point(178, 117);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(85, 26);
            this.btClose.TabIndex = 48;
            this.btClose.Text = "Đóng";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYear.Location = new System.Drawing.Point(109, 31);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 26);
            this.numYear.TabIndex = 49;
            this.numYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // SysConfig
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 155);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown numYear;
    }
}
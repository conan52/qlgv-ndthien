namespace QLGV.Forms
{
    partial class SysMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.quảnTrịDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TônGiáotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dânTộcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trìnhĐộChuyênMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênNghànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lýLuậnChínhTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngoạiNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrườngCánBộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTrìnhĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoBiênChếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bcDacDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.bcSLM2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHợpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thừaThiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịDanhMụcToolStripMenuItem,
            this.quảnLýTrườngCánBộToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(866, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // quảnTrịDanhMụcToolStripMenuItem
            // 
            this.quảnTrịDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.TônGiáotoolStripMenuItem,
            this.dânTộcToolStripMenuItem,
            this.trìnhĐộChuyênMônToolStripMenuItem,
            this.chuyênNghànhToolStripMenuItem,
            this.lýLuậnChínhTrịToolStripMenuItem,
            this.ngoạiNgữToolStripMenuItem,
            this.tinHọcToolStripMenuItem});
            this.quảnTrịDanhMụcToolStripMenuItem.Name = "quảnTrịDanhMụcToolStripMenuItem";
            this.quảnTrịDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.quảnTrịDanhMụcToolStripMenuItem.Text = "Quản trị danh mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.chứcVụToolStripMenuItem.Tag = "List_ChucVu";
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // TônGiáotoolStripMenuItem
            // 
            this.TônGiáotoolStripMenuItem.Name = "TônGiáotoolStripMenuItem";
            this.TônGiáotoolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.TônGiáotoolStripMenuItem.Tag = "List_TonGiao";
            this.TônGiáotoolStripMenuItem.Text = "Tôn giáo";
            this.TônGiáotoolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // dânTộcToolStripMenuItem
            // 
            this.dânTộcToolStripMenuItem.Name = "dânTộcToolStripMenuItem";
            this.dânTộcToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dânTộcToolStripMenuItem.Tag = "List_DanToc";
            this.dânTộcToolStripMenuItem.Text = "Dân tộc";
            this.dânTộcToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // trìnhĐộChuyênMônToolStripMenuItem
            // 
            this.trìnhĐộChuyênMônToolStripMenuItem.Name = "trìnhĐộChuyênMônToolStripMenuItem";
            this.trìnhĐộChuyênMônToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.trìnhĐộChuyênMônToolStripMenuItem.Tag = "List_TrinhDoChuyenMon";
            this.trìnhĐộChuyênMônToolStripMenuItem.Text = "Trình độ chuyên môn";
            this.trìnhĐộChuyênMônToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // chuyênNghànhToolStripMenuItem
            // 
            this.chuyênNghànhToolStripMenuItem.Name = "chuyênNghànhToolStripMenuItem";
            this.chuyênNghànhToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.chuyênNghànhToolStripMenuItem.Tag = "List_ChuyenNghanh";
            this.chuyênNghànhToolStripMenuItem.Text = "Chuyên nghành";
            this.chuyênNghànhToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // lýLuậnChínhTrịToolStripMenuItem
            // 
            this.lýLuậnChínhTrịToolStripMenuItem.Name = "lýLuậnChínhTrịToolStripMenuItem";
            this.lýLuậnChínhTrịToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lýLuậnChínhTrịToolStripMenuItem.Tag = "List_LyLuanChinhTri";
            this.lýLuậnChínhTrịToolStripMenuItem.Text = "Lý luận chính trị";
            this.lýLuậnChínhTrịToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // ngoạiNgữToolStripMenuItem
            // 
            this.ngoạiNgữToolStripMenuItem.Name = "ngoạiNgữToolStripMenuItem";
            this.ngoạiNgữToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ngoạiNgữToolStripMenuItem.Tag = "List_NgoaiNgu";
            this.ngoạiNgữToolStripMenuItem.Text = "Ngoại ngữ";
            this.ngoạiNgữToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // tinHọcToolStripMenuItem
            // 
            this.tinHọcToolStripMenuItem.Name = "tinHọcToolStripMenuItem";
            this.tinHọcToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tinHọcToolStripMenuItem.Tag = "List_TinHoc";
            this.tinHọcToolStripMenuItem.Text = "Tin học";
            this.tinHọcToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // quảnLýTrườngCánBộToolStripMenuItem
            // 
            this.quảnLýTrườngCánBộToolStripMenuItem.Name = "quảnLýTrườngCánBộToolStripMenuItem";
            this.quảnLýTrườngCánBộToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.quảnLýTrườngCánBộToolStripMenuItem.Tag = "List_Truong_CanBo";
            this.quảnLýTrườngCánBộToolStripMenuItem.Text = "Quản lý trường, cán bộ";
            this.quảnLýTrườngCánBộToolStripMenuItem.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoBiênChếToolStripMenuItem,
            this.bcDacDiem,
            this.thốngKêSốLượngToolStripMenuItem,
            this.bcSLM2,
            this.thốngKêTrìnhĐộToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // thốngKêTrìnhĐộToolStripMenuItem
            // 
            this.thốngKêTrìnhĐộToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngHợpToolStripMenuItem,
            this.c0ToolStripMenuItem,
            this.c1ToolStripMenuItem,
            this.c2ToolStripMenuItem,
            this.thừaThiếuToolStripMenuItem});
            this.thốngKêTrìnhĐộToolStripMenuItem.Name = "thốngKêTrìnhĐộToolStripMenuItem";
            this.thốngKêTrìnhĐộToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.thốngKêTrìnhĐộToolStripMenuItem.Text = "Thống kê trình độ";
            // 
            // thốngKêSốLượngToolStripMenuItem
            // 
            this.thốngKêSốLượngToolStripMenuItem.Name = "thốngKêSốLượngToolStripMenuItem";
            this.thốngKêSốLượngToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.thốngKêSốLượngToolStripMenuItem.Text = "Thống kê số lượng M1";
            this.thốngKêSốLượngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSốLượngToolStripMenuItem_Click);
            // 
            // báoCáoBiênChếToolStripMenuItem
            // 
            this.báoCáoBiênChếToolStripMenuItem.Name = "báoCáoBiênChếToolStripMenuItem";
            this.báoCáoBiênChếToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.báoCáoBiênChếToolStripMenuItem.Text = "Báo cáo biên chế";
            this.báoCáoBiênChếToolStripMenuItem.Click += new System.EventHandler(this.báoCáoBiênChếToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.cấuHìnhHệThốngToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(180, 22);
            this.menuLogin.Text = "Đăng xuất";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // cấuHìnhHệThốngToolStripMenuItem
            // 
            this.cấuHìnhHệThốngToolStripMenuItem.Name = "cấuHìnhHệThốngToolStripMenuItem";
            this.cấuHìnhHệThốngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cấuHìnhHệThốngToolStripMenuItem.Text = "Cấu hình hệ thống";
            this.cấuHìnhHệThốngToolStripMenuItem.Click += new System.EventHandler(this.cấuHìnhHệThốngToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 502);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(866, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // bcDacDiem
            // 
            this.bcDacDiem.Name = "bcDacDiem";
            this.bcDacDiem.Size = new System.Drawing.Size(203, 22);
            this.bcDacDiem.Text = "Báo cáo đặc điểm";
            this.bcDacDiem.Click += new System.EventHandler(this.bcDacDiem_Click);
            // 
            // bcSLM2
            // 
            this.bcSLM2.Name = "bcSLM2";
            this.bcSLM2.Size = new System.Drawing.Size(203, 22);
            this.bcSLM2.Text = "Thống kê số lượng M2";
            this.bcSLM2.Click += new System.EventHandler(this.bcSLM2_Click);
            // 
            // tổngHợpToolStripMenuItem
            // 
            this.tổngHợpToolStripMenuItem.Name = "tổngHợpToolStripMenuItem";
            this.tổngHợpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tổngHợpToolStripMenuItem.Text = "Tổng hợp";
            this.tổngHợpToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpToolStripMenuItem_Click);
            // 
            // c0ToolStripMenuItem
            // 
            this.c0ToolStripMenuItem.Name = "c0ToolStripMenuItem";
            this.c0ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.c0ToolStripMenuItem.Text = "C0";
            this.c0ToolStripMenuItem.Click += new System.EventHandler(this.c0ToolStripMenuItem_Click);
            // 
            // c1ToolStripMenuItem
            // 
            this.c1ToolStripMenuItem.Name = "c1ToolStripMenuItem";
            this.c1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.c1ToolStripMenuItem.Text = "C1";
            this.c1ToolStripMenuItem.Click += new System.EventHandler(this.c1ToolStripMenuItem_Click);
            // 
            // c2ToolStripMenuItem
            // 
            this.c2ToolStripMenuItem.Name = "c2ToolStripMenuItem";
            this.c2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.c2ToolStripMenuItem.Text = "C2";
            this.c2ToolStripMenuItem.Click += new System.EventHandler(this.c2ToolStripMenuItem_Click);
            // 
            // thừaThiếuToolStripMenuItem
            // 
            this.thừaThiếuToolStripMenuItem.Name = "thừaThiếuToolStripMenuItem";
            this.thừaThiếuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thừaThiếuToolStripMenuItem.Text = "Thừa - Thiếu";
            this.thừaThiếuToolStripMenuItem.Click += new System.EventHandler(this.thừaThiếuToolStripMenuItem_Click);
            // 
            // SysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 524);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SysMain";
            this.Text = "Phần mềm quản lý giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrườngCánBộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem TônGiáotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dânTộcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trìnhĐộChuyênMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyênNghànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lýLuậnChínhTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngoạiNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTrìnhĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSốLượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoBiênChếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bcDacDiem;
        private System.Windows.Forms.ToolStripMenuItem bcSLM2;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thừaThiếuToolStripMenuItem;
    }
}




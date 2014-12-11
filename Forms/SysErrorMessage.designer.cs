namespace QLGV.Forms
{
    partial class SysErrorMessage
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
            this.richTextBoxStackTrace = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxStackTrace
            // 
            this.richTextBoxStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxStackTrace.Location = new System.Drawing.Point(4, 116);
            this.richTextBoxStackTrace.Name = "richTextBoxStackTrace";
            this.richTextBoxStackTrace.Size = new System.Drawing.Size(377, 100);
            this.richTextBoxStackTrace.TabIndex = 0;
            this.richTextBoxStackTrace.Text = "";
            this.richTextBoxStackTrace.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(306, 87);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetail.Location = new System.Drawing.Point(225, 87);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonDetail.TabIndex = 2;
            this.buttonDetail.Text = "Chi tiết";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(1, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(380, 75);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "labelMessage";
            // 
            // ErrorMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 220);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxStackTrace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorMessageForm";
            this.Load += new System.EventHandler(this.ErrorMessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStackTrace;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Label labelMessage;
    }
}
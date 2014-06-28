namespace ExcelAddInDataOutput.Form
{
    partial class FormSave
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
            this.lblFileId = new System.Windows.Forms.Label();
            this.txtFileId = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileId
            // 
            this.lblFileId.AutoSize = true;
            this.lblFileId.Location = new System.Drawing.Point(12, 15);
            this.lblFileId.Name = "lblFileId";
            this.lblFileId.Size = new System.Drawing.Size(65, 12);
            this.lblFileId.TabIndex = 0;
            this.lblFileId.Text = "ファイルID";
            // 
            // txtFileId
            // 
            this.txtFileId.Location = new System.Drawing.Point(91, 12);
            this.txtFileId.Name = "txtFileId";
            this.txtFileId.Size = new System.Drawing.Size(188, 21);
            this.txtFileId.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(297, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(32, 20);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 42);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFileId);
            this.Controls.Add(this.lblFileId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSave";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormSave";
            this.Load += new System.EventHandler(this.FormSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileId;
        private System.Windows.Forms.TextBox txtFileId;
        private System.Windows.Forms.Button btnOK;
    }
}
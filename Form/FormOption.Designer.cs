namespace ExcelAddInDataOutput.Form
{
    partial class FormOption
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDbType = new System.Windows.Forms.Label();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnHeaderColor = new System.Windows.Forms.Button();
            this.txtNoData = new System.Windows.Forms.TextBox();
            this.lblNoData = new System.Windows.Forms.Label();
            this.cbFieldName = new System.Windows.Forms.CheckBox();
            this.gbHeaderStyle = new System.Windows.Forms.GroupBox();
            this.gbRow = new System.Windows.Forms.GroupBox();
            this.cbIsNullable = new System.Windows.Forms.CheckBox();
            this.cbIsPrimaryKey = new System.Windows.Forms.CheckBox();
            this.cbDataType = new System.Windows.Forms.CheckBox();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.txtHeaderColor = new System.Windows.Forms.TextBox();
            this.txtFontColor = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.gbDatabase.SuspendLayout();
            this.gbHeaderStyle.SuspendLayout();
            this.gbRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDbType
            // 
            this.lblDbType.AutoSize = true;
            this.lblDbType.Location = new System.Drawing.Point(20, 102);
            this.lblDbType.Name = "lblDbType";
            this.lblDbType.Size = new System.Drawing.Size(41, 12);
            this.lblDbType.TabIndex = 1;
            this.lblDbType.Text = "タイプ";
            // 
            // cbDbType
            // 
            this.cbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "1:SQLServer",
            "2.Oracle",
            "3.MySQL"});
            this.cbDbType.Location = new System.Drawing.Point(85, 99);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(170, 20);
            this.cbDbType.TabIndex = 5;
            this.cbDbType.SelectedIndexChanged += new System.EventHandler(this.cbDbType_SelectedIndexChanged);
            // 
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.txtDatabase);
            this.gbDatabase.Controls.Add(this.txtPassword);
            this.gbDatabase.Controls.Add(this.txtServer);
            this.gbDatabase.Controls.Add(this.txtUserId);
            this.gbDatabase.Controls.Add(this.cbDbType);
            this.gbDatabase.Controls.Add(this.lblDataBase);
            this.gbDatabase.Controls.Add(this.lblPwd);
            this.gbDatabase.Controls.Add(this.lblServer);
            this.gbDatabase.Controls.Add(this.lblUser);
            this.gbDatabase.Controls.Add(this.lblDbType);
            this.gbDatabase.Location = new System.Drawing.Point(12, 12);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Size = new System.Drawing.Size(611, 135);
            this.gbDatabase.TabIndex = 1;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = "データベース";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(320, 56);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(97, 21);
            this.txtDatabase.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(320, 18);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(97, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(85, 59);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(117, 21);
            this.txtServer.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(85, 18);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(117, 21);
            this.txtUserId.TabIndex = 1;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(223, 62);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(77, 12);
            this.lblDataBase.TabIndex = 1;
            this.lblDataBase.Text = "データベース";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(223, 21);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(65, 12);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "パスワード";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(20, 59);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(53, 12);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "サーバー";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 12);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "ユーザー";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(481, 73);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(91, 26);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "テスト";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(18, 20);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(85, 24);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "フォント";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnHeaderColor
            // 
            this.btnHeaderColor.Location = new System.Drawing.Point(18, 63);
            this.btnHeaderColor.Name = "btnHeaderColor";
            this.btnHeaderColor.Size = new System.Drawing.Size(85, 24);
            this.btnHeaderColor.TabIndex = 0;
            this.btnHeaderColor.Text = "ヘッダ色";
            this.btnHeaderColor.UseVisualStyleBackColor = true;
            this.btnHeaderColor.Click += new System.EventHandler(this.btnHeaderColor_Click);
            // 
            // txtNoData
            // 
            this.txtNoData.Location = new System.Drawing.Point(308, 305);
            this.txtNoData.Name = "txtNoData";
            this.txtNoData.Size = new System.Drawing.Size(225, 21);
            this.txtNoData.TabIndex = 3;
            this.txtNoData.Text = "データなし";
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Location = new System.Drawing.Point(312, 279);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(107, 12);
            this.lblNoData.TabIndex = 4;
            this.lblNoData.Text = "データがない場合:";
            // 
            // cbFieldName
            // 
            this.cbFieldName.AutoSize = true;
            this.cbFieldName.Checked = true;
            this.cbFieldName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFieldName.Location = new System.Drawing.Point(28, 37);
            this.cbFieldName.Name = "cbFieldName";
            this.cbFieldName.Size = new System.Drawing.Size(96, 16);
            this.cbFieldName.TabIndex = 5;
            this.cbFieldName.Text = "フィールド名";
            this.cbFieldName.UseVisualStyleBackColor = true;
            // 
            // gbHeaderStyle
            // 
            this.gbHeaderStyle.Controls.Add(this.lblSample);
            this.gbHeaderStyle.Controls.Add(this.txtHeaderColor);
            this.gbHeaderStyle.Controls.Add(this.txtFontColor);
            this.gbHeaderStyle.Controls.Add(this.txtFont);
            this.gbHeaderStyle.Controls.Add(this.btnFont);
            this.gbHeaderStyle.Controls.Add(this.btnHeaderColor);
            this.gbHeaderStyle.Location = new System.Drawing.Point(16, 166);
            this.gbHeaderStyle.Name = "gbHeaderStyle";
            this.gbHeaderStyle.Size = new System.Drawing.Size(556, 98);
            this.gbHeaderStyle.TabIndex = 6;
            this.gbHeaderStyle.TabStop = false;
            this.gbHeaderStyle.Text = "groupBox1";
            // 
            // gbRow
            // 
            this.gbRow.Controls.Add(this.cbIsNullable);
            this.gbRow.Controls.Add(this.cbIsPrimaryKey);
            this.gbRow.Controls.Add(this.cbDataType);
            this.gbRow.Controls.Add(this.cbFieldName);
            this.gbRow.Location = new System.Drawing.Point(16, 270);
            this.gbRow.Name = "gbRow";
            this.gbRow.Size = new System.Drawing.Size(235, 137);
            this.gbRow.TabIndex = 7;
            this.gbRow.TabStop = false;
            this.gbRow.Text = "行";
            // 
            // cbIsNullable
            // 
            this.cbIsNullable.AutoSize = true;
            this.cbIsNullable.Checked = true;
            this.cbIsNullable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsNullable.Location = new System.Drawing.Point(28, 104);
            this.cbIsNullable.Name = "cbIsNullable";
            this.cbIsNullable.Size = new System.Drawing.Size(48, 16);
            this.cbIsNullable.TabIndex = 5;
            this.cbIsNullable.Text = "NULL";
            this.cbIsNullable.UseVisualStyleBackColor = true;
            // 
            // cbIsPrimaryKey
            // 
            this.cbIsPrimaryKey.AutoSize = true;
            this.cbIsPrimaryKey.Checked = true;
            this.cbIsPrimaryKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsPrimaryKey.Location = new System.Drawing.Point(28, 82);
            this.cbIsPrimaryKey.Name = "cbIsPrimaryKey";
            this.cbIsPrimaryKey.Size = new System.Drawing.Size(60, 16);
            this.cbIsPrimaryKey.TabIndex = 5;
            this.cbIsPrimaryKey.Text = "主キー";
            this.cbIsPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // cbDataType
            // 
            this.cbDataType.AutoSize = true;
            this.cbDataType.Checked = true;
            this.cbDataType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDataType.Location = new System.Drawing.Point(28, 59);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(96, 16);
            this.cbDataType.TabIndex = 5;
            this.cbDataType.Text = "データタイプ";
            this.cbDataType.UseVisualStyleBackColor = true;
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(379, 24);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(63, 21);
            this.txtFont.TabIndex = 3;
            this.txtFont.Visible = false;
            // 
            // txtHeaderColor
            // 
            this.txtHeaderColor.Location = new System.Drawing.Point(379, 54);
            this.txtHeaderColor.Name = "txtHeaderColor";
            this.txtHeaderColor.Size = new System.Drawing.Size(63, 21);
            this.txtHeaderColor.TabIndex = 3;
            this.txtHeaderColor.Visible = false;
            // 
            // txtFontColor
            // 
            this.txtFontColor.Location = new System.Drawing.Point(465, 26);
            this.txtFontColor.Name = "txtFontColor";
            this.txtFontColor.Size = new System.Drawing.Size(63, 21);
            this.txtFontColor.TabIndex = 3;
            this.txtFontColor.Visible = false;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(130, 33);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(41, 12);
            this.lblSample.TabIndex = 4;
            this.lblSample.Text = "Sample";
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 467);
            this.Controls.Add(this.gbRow);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.txtNoData);
            this.Controls.Add(this.gbHeaderStyle);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.gbDatabase);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOption";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "データベース設定";
            this.Load += new System.EventHandler(this.FormOption_Load);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.gbHeaderStyle.ResumeLayout(false);
            this.gbHeaderStyle.PerformLayout();
            this.gbRow.ResumeLayout(false);
            this.gbRow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDbType;
        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.GroupBox gbDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.TextBox txtNoData;
        private System.Windows.Forms.Button btnHeaderColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.GroupBox gbHeaderStyle;
        private System.Windows.Forms.CheckBox cbFieldName;
        private System.Windows.Forms.GroupBox gbRow;
        private System.Windows.Forms.CheckBox cbIsNullable;
        private System.Windows.Forms.CheckBox cbIsPrimaryKey;
        private System.Windows.Forms.CheckBox cbDataType;
        private System.Windows.Forms.TextBox txtHeaderColor;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.TextBox txtFontColor;
        private System.Windows.Forms.Label lblSample;
    }
}
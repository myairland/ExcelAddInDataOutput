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
            this.btnHeaderFont = new System.Windows.Forms.Button();
            this.btnHeaderColor = new System.Windows.Forms.Button();
            this.txtNoData = new System.Windows.Forms.TextBox();
            this.lblNoData = new System.Windows.Forms.Label();
            this.cbFieldName = new System.Windows.Forms.CheckBox();
            this.gbHeaderStyle = new System.Windows.Forms.GroupBox();
            this.lblHeaderSample = new System.Windows.Forms.Label();
            this.txtHeaderColor = new System.Windows.Forms.TextBox();
            this.txtHeaderFontColor = new System.Windows.Forms.TextBox();
            this.txtHeaderFont = new System.Windows.Forms.TextBox();
            this.gbRow = new System.Windows.Forms.GroupBox();
            this.cbIsNullable = new System.Windows.Forms.CheckBox();
            this.cbIsPrimaryKey = new System.Windows.Forms.CheckBox();
            this.cbDataType = new System.Windows.Forms.CheckBox();
            this.cbHeaderBox = new System.Windows.Forms.CheckBox();
            this.cbDataBox = new System.Windows.Forms.CheckBox();
            this.gbCellStyle = new System.Windows.Forms.GroupBox();
            this.btnCellColor = new System.Windows.Forms.Button();
            this.btnCellFont = new System.Windows.Forms.Button();
            this.txtCellFont = new System.Windows.Forms.TextBox();
            this.txtCellFontColor = new System.Windows.Forms.TextBox();
            this.txtCellColor = new System.Windows.Forms.TextBox();
            this.lblCellSample = new System.Windows.Forms.Label();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.gbDatabase.SuspendLayout();
            this.gbHeaderStyle.SuspendLayout();
            this.gbRow.SuspendLayout();
            this.gbCellStyle.SuspendLayout();
            this.gbOther.SuspendLayout();
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
            // btnHeaderFont
            // 
            this.btnHeaderFont.Location = new System.Drawing.Point(18, 20);
            this.btnHeaderFont.Name = "btnHeaderFont";
            this.btnHeaderFont.Size = new System.Drawing.Size(106, 24);
            this.btnHeaderFont.TabIndex = 1;
            this.btnHeaderFont.Text = "ヘッダフォント";
            this.btnHeaderFont.UseVisualStyleBackColor = true;
            this.btnHeaderFont.Click += new System.EventHandler(this.btnHeaderFont_Click);
            // 
            // btnHeaderColor
            // 
            this.btnHeaderColor.Location = new System.Drawing.Point(18, 63);
            this.btnHeaderColor.Name = "btnHeaderColor";
            this.btnHeaderColor.Size = new System.Drawing.Size(106, 24);
            this.btnHeaderColor.TabIndex = 2;
            this.btnHeaderColor.Text = "ヘッダ色";
            this.btnHeaderColor.UseVisualStyleBackColor = true;
            this.btnHeaderColor.Click += new System.EventHandler(this.btnHeaderColor_Click);
            // 
            // txtNoData
            // 
            this.txtNoData.Location = new System.Drawing.Point(17, 54);
            this.txtNoData.Name = "txtNoData";
            this.txtNoData.Size = new System.Drawing.Size(225, 21);
            this.txtNoData.TabIndex = 1;
            this.txtNoData.Text = "データなし";
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Location = new System.Drawing.Point(15, 28);
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
            this.cbFieldName.TabIndex = 1;
            this.cbFieldName.Text = "フィールド名";
            this.cbFieldName.UseVisualStyleBackColor = true;
            // 
            // gbHeaderStyle
            // 
            this.gbHeaderStyle.Controls.Add(this.lblHeaderSample);
            this.gbHeaderStyle.Controls.Add(this.txtHeaderColor);
            this.gbHeaderStyle.Controls.Add(this.txtHeaderFontColor);
            this.gbHeaderStyle.Controls.Add(this.txtHeaderFont);
            this.gbHeaderStyle.Controls.Add(this.btnHeaderFont);
            this.gbHeaderStyle.Controls.Add(this.btnHeaderColor);
            this.gbHeaderStyle.Location = new System.Drawing.Point(16, 166);
            this.gbHeaderStyle.Name = "gbHeaderStyle";
            this.gbHeaderStyle.Size = new System.Drawing.Size(284, 98);
            this.gbHeaderStyle.TabIndex = 2;
            this.gbHeaderStyle.TabStop = false;
            this.gbHeaderStyle.Text = "ヘッダスタイル";
            // 
            // lblHeaderSample
            // 
            this.lblHeaderSample.AutoSize = true;
            this.lblHeaderSample.Location = new System.Drawing.Point(135, 44);
            this.lblHeaderSample.Name = "lblHeaderSample";
            this.lblHeaderSample.Size = new System.Drawing.Size(41, 12);
            this.lblHeaderSample.TabIndex = 4;
            this.lblHeaderSample.Text = "Sample";
            // 
            // txtHeaderColor
            // 
            this.txtHeaderColor.Location = new System.Drawing.Point(188, 54);
            this.txtHeaderColor.Name = "txtHeaderColor";
            this.txtHeaderColor.Size = new System.Drawing.Size(63, 21);
            this.txtHeaderColor.TabIndex = 3;
            this.txtHeaderColor.Visible = false;
            // 
            // txtHeaderFontColor
            // 
            this.txtHeaderFontColor.Location = new System.Drawing.Point(257, 23);
            this.txtHeaderFontColor.Name = "txtHeaderFontColor";
            this.txtHeaderFontColor.Size = new System.Drawing.Size(63, 21);
            this.txtHeaderFontColor.TabIndex = 3;
            this.txtHeaderFontColor.Visible = false;
            // 
            // txtHeaderFont
            // 
            this.txtHeaderFont.Location = new System.Drawing.Point(188, 24);
            this.txtHeaderFont.Name = "txtHeaderFont";
            this.txtHeaderFont.Size = new System.Drawing.Size(63, 21);
            this.txtHeaderFont.TabIndex = 3;
            this.txtHeaderFont.Visible = false;
            // 
            // gbRow
            // 
            this.gbRow.Controls.Add(this.cbDataBox);
            this.gbRow.Controls.Add(this.cbHeaderBox);
            this.gbRow.Controls.Add(this.cbIsNullable);
            this.gbRow.Controls.Add(this.cbIsPrimaryKey);
            this.gbRow.Controls.Add(this.cbDataType);
            this.gbRow.Controls.Add(this.cbFieldName);
            this.gbRow.Location = new System.Drawing.Point(16, 270);
            this.gbRow.Name = "gbRow";
            this.gbRow.Size = new System.Drawing.Size(284, 137);
            this.gbRow.TabIndex = 4;
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
            this.cbIsNullable.TabIndex = 4;
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
            this.cbIsPrimaryKey.TabIndex = 3;
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
            this.cbDataType.TabIndex = 2;
            this.cbDataType.Text = "データタイプ";
            this.cbDataType.UseVisualStyleBackColor = true;
            // 
            // cbHeaderBox
            // 
            this.cbHeaderBox.AutoSize = true;
            this.cbHeaderBox.Checked = true;
            this.cbHeaderBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeaderBox.Location = new System.Drawing.Point(163, 37);
            this.cbHeaderBox.Name = "cbHeaderBox";
            this.cbHeaderBox.Size = new System.Drawing.Size(84, 16);
            this.cbHeaderBox.TabIndex = 5;
            this.cbHeaderBox.Text = "ヘッダ枠線";
            this.cbHeaderBox.UseVisualStyleBackColor = true;
            // 
            // cbDataBox
            // 
            this.cbDataBox.AutoSize = true;
            this.cbDataBox.Checked = true;
            this.cbDataBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDataBox.Location = new System.Drawing.Point(163, 69);
            this.cbDataBox.Name = "cbDataBox";
            this.cbDataBox.Size = new System.Drawing.Size(84, 16);
            this.cbDataBox.TabIndex = 6;
            this.cbDataBox.Text = "データ枠線";
            this.cbDataBox.UseVisualStyleBackColor = true;
            // 
            // gbCellStyle
            // 
            this.gbCellStyle.Controls.Add(this.lblCellSample);
            this.gbCellStyle.Controls.Add(this.btnCellFont);
            this.gbCellStyle.Controls.Add(this.txtCellColor);
            this.gbCellStyle.Controls.Add(this.btnCellColor);
            this.gbCellStyle.Controls.Add(this.txtCellFontColor);
            this.gbCellStyle.Controls.Add(this.txtCellFont);
            this.gbCellStyle.Location = new System.Drawing.Point(315, 166);
            this.gbCellStyle.Name = "gbCellStyle";
            this.gbCellStyle.Size = new System.Drawing.Size(308, 98);
            this.gbCellStyle.TabIndex = 3;
            this.gbCellStyle.TabStop = false;
            this.gbCellStyle.Text = "セルスタイル";
            // 
            // btnCellColor
            // 
            this.btnCellColor.Location = new System.Drawing.Point(6, 63);
            this.btnCellColor.Name = "btnCellColor";
            this.btnCellColor.Size = new System.Drawing.Size(106, 24);
            this.btnCellColor.TabIndex = 2;
            this.btnCellColor.Text = "セル色";
            this.btnCellColor.UseVisualStyleBackColor = true;
            this.btnCellColor.Click += new System.EventHandler(this.btnCellColor_Click);
            // 
            // btnCellFont
            // 
            this.btnCellFont.Location = new System.Drawing.Point(6, 20);
            this.btnCellFont.Name = "btnCellFont";
            this.btnCellFont.Size = new System.Drawing.Size(105, 24);
            this.btnCellFont.TabIndex = 1;
            this.btnCellFont.Text = "セルフォント";
            this.btnCellFont.UseVisualStyleBackColor = true;
            this.btnCellFont.Click += new System.EventHandler(this.btnCellFont_Click);
            // 
            // txtCellFont
            // 
            this.txtCellFont.Location = new System.Drawing.Point(163, 23);
            this.txtCellFont.Name = "txtCellFont";
            this.txtCellFont.Size = new System.Drawing.Size(63, 21);
            this.txtCellFont.TabIndex = 3;
            this.txtCellFont.Visible = false;
            // 
            // txtCellFontColor
            // 
            this.txtCellFontColor.Location = new System.Drawing.Point(236, 23);
            this.txtCellFontColor.Name = "txtCellFontColor";
            this.txtCellFontColor.Size = new System.Drawing.Size(63, 21);
            this.txtCellFontColor.TabIndex = 3;
            this.txtCellFontColor.Visible = false;
            // 
            // txtCellColor
            // 
            this.txtCellColor.Location = new System.Drawing.Point(223, 54);
            this.txtCellColor.Name = "txtCellColor";
            this.txtCellColor.Size = new System.Drawing.Size(63, 21);
            this.txtCellColor.TabIndex = 3;
            this.txtCellColor.Visible = false;
            // 
            // lblCellSample
            // 
            this.lblCellSample.AutoSize = true;
            this.lblCellSample.Location = new System.Drawing.Point(121, 42);
            this.lblCellSample.Name = "lblCellSample";
            this.lblCellSample.Size = new System.Drawing.Size(41, 12);
            this.lblCellSample.TabIndex = 4;
            this.lblCellSample.Text = "Sample";
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.lblNoData);
            this.gbOther.Controls.Add(this.txtNoData);
            this.gbOther.Location = new System.Drawing.Point(315, 270);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(307, 136);
            this.gbOther.TabIndex = 5;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "その他";
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 467);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbCellStyle);
            this.Controls.Add(this.gbRow);
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
            this.gbCellStyle.ResumeLayout(false);
            this.gbCellStyle.PerformLayout();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnHeaderFont;
        private System.Windows.Forms.GroupBox gbHeaderStyle;
        private System.Windows.Forms.CheckBox cbFieldName;
        private System.Windows.Forms.GroupBox gbRow;
        private System.Windows.Forms.CheckBox cbIsNullable;
        private System.Windows.Forms.CheckBox cbIsPrimaryKey;
        private System.Windows.Forms.CheckBox cbDataType;
        private System.Windows.Forms.TextBox txtHeaderColor;
        private System.Windows.Forms.TextBox txtHeaderFont;
        private System.Windows.Forms.TextBox txtHeaderFontColor;
        private System.Windows.Forms.Label lblHeaderSample;
        private System.Windows.Forms.CheckBox cbHeaderBox;
        private System.Windows.Forms.CheckBox cbDataBox;
        private System.Windows.Forms.GroupBox gbCellStyle;
        private System.Windows.Forms.Label lblCellSample;
        private System.Windows.Forms.Button btnCellFont;
        private System.Windows.Forms.TextBox txtCellColor;
        private System.Windows.Forms.Button btnCellColor;
        private System.Windows.Forms.TextBox txtCellFontColor;
        private System.Windows.Forms.TextBox txtCellFont;
        private System.Windows.Forms.GroupBox gbOther;
    }
}
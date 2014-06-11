namespace ExcelAddInDataOutput
{
    partial class FormTableOption
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTableId = new System.Windows.Forms.Label();
            this.lblWhere = new System.Windows.Forms.Label();
            this.lblSQL = new System.Windows.Forms.Label();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TABLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WHERE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lslFileList = new System.Windows.Forms.ListBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableId
            // 
            this.lblTableId.AutoSize = true;
            this.lblTableId.Location = new System.Drawing.Point(321, 16);
            this.lblTableId.Name = "lblTableId";
            this.lblTableId.Size = new System.Drawing.Size(65, 12);
            this.lblTableId.TabIndex = 0;
            this.lblTableId.Text = "テーブルID";
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(351, 61);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(35, 12);
            this.lblWhere.TabIndex = 0;
            this.lblWhere.Text = "Where";
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(351, 101);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(35, 12);
            this.lblSQL.TabIndex = 0;
            this.lblSQL.Text = "SQL文";
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(392, 13);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(100, 21);
            this.txtTableId.TabIndex = 5;
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(392, 58);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(100, 21);
            this.txtWhere.TabIndex = 6;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(392, 98);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(282, 86);
            this.txtSQL.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLE_ID,
            this.WHERE,
            this.SQL});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(15, 221);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(659, 155);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // TABLE_ID
            // 
            this.TABLE_ID.HeaderText = "テーブルID";
            this.TABLE_ID.Name = "TABLE_ID";
            this.TABLE_ID.ReadOnly = true;
            // 
            // WHERE
            // 
            this.WHERE.HeaderText = "Where条件";
            this.WHERE.Name = "WHERE";
            this.WHERE.ReadOnly = true;
            this.WHERE.Width = 200;
            // 
            // SQL
            // 
            this.SQL.HeaderText = "SQL文";
            this.SQL.Name = "SQL";
            this.SQL.ReadOnly = true;
            this.SQL.Width = 300;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 65);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(577, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(45, 65);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(642, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 65);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lslFileList
            // 
            this.lslFileList.FormattingEnabled = true;
            this.lslFileList.ItemHeight = 12;
            this.lslFileList.Location = new System.Drawing.Point(114, 16);
            this.lslFileList.Name = "lslFileList";
            this.lslFileList.Size = new System.Drawing.Size(176, 172);
            this.lslFileList.TabIndex = 4;
            this.lslFileList.DoubleClick += new System.EventHandler(this.lslFileList_DoubleClick);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(11, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(87, 21);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "インポート";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 21);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Location = new System.Drawing.Point(12, 92);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(86, 21);
            this.btnDelFile.TabIndex = 3;
            this.btnDelFile.Text = "削除";
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // FormTableOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 395);
            this.Controls.Add(this.lslFileList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.lblSQL);
            this.Controls.Add(this.lblWhere);
            this.Controls.Add(this.lblTableId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTableOption";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "抽出テーブル設定";
            this.Load += new System.EventHandler(this.FormTableOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableId;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lslFileList;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WHERE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQL;
        private System.Windows.Forms.Button btnDelFile;
    }
}
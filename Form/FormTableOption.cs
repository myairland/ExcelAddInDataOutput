using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExcelAddInDataOutput
{
    public partial class FormTableOption : System.Windows.Forms.Form
    {
        enum DATAGRID_ROW : int
        { 
        TABLE_ID = 0,
        WHERE,
        SQL,        
        }

        private string ApplicationDataPath;

        public FormTableOption()
        {
            InitializeComponent();
        }

        private void FormTableOption_Load(object sender, EventArgs e)
        {
            ApplicationDataPath = Common.pathEdit(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                       + Const.PROJECT_NAME;
            InitializeControl();
        }

        private void InitializeControl()
        {
            string []  files = System.IO.Directory.GetFiles(ApplicationDataPath, "*.add");
            foreach (string fileName in files)
            {
                lslFileList.Items.Add(System.IO.Path.GetFileName(fileName));
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTableId.Text) && string.IsNullOrEmpty(txtSQL.Text))
            {
                MessageBox.Show("テーブルID入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTableId.Focus();
                return;
            }

            dataGridView.Rows.Add();

            int maxRowNo = dataGridView.Rows.Count - 1;

            dataGridView[(int)DATAGRID_ROW.TABLE_ID, maxRowNo].Value = txtTableId.Text;
            dataGridView[(int)DATAGRID_ROW.WHERE, maxRowNo].Value = txtWhere.Text;
            dataGridView[(int)DATAGRID_ROW.SQL, maxRowNo].Value = txtSQL.Text;

            this.dataGridView.CurrentCell = dataGridView[(int)DATAGRID_ROW.TABLE_ID, maxRowNo];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = this.dataGridView.CurrentRow;

            if (currentRow != null)
            { 
                currentRow.Cells[(int)DATAGRID_ROW.TABLE_ID].Value = txtTableId.Text;
                currentRow.Cells[(int)DATAGRID_ROW.WHERE].Value = txtWhere.Text;
                currentRow.Cells[(int)DATAGRID_ROW.SQL].Value = txtSQL.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.CurrentRow != null)
            {
                dataGridView.Rows.Remove(this.dataGridView.CurrentRow);
             }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnUpdate.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("少なくとも一つ項目を追加してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTableId.Focus();
                return;
            }

            FormSave formSave = new FormSave();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                formSave.sqlInfo.Add(dataGridView[(int)DATAGRID_ROW.TABLE_ID, i].Value + Const.SPLITOR.ToString() +
                                     dataGridView[(int)DATAGRID_ROW.WHERE, i].Value + Const.SPLITOR.ToString() +
                                      dataGridView[(int)DATAGRID_ROW.SQL, i].Value);                      
            
            }


            formSave.ShowDialog();

            if (!string.IsNullOrEmpty(formSave.fileId))
            {
                lslFileList.Items.Add(formSave.fileId);
            
            }

            clearControl();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string line = string.Empty;
            int maxRowNo = 0;
            string[] info;

            if (lslFileList.SelectedItem == null)
            {
                MessageBox.Show("ファイルIDを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string FileId = lslFileList.SelectedItem.ToString();

            dataGridView.Rows.Clear();

            using (StreamReader reader = new StreamReader(ApplicationDataPath + @"\" + FileId))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    dataGridView.Rows.Add();

                    info = line.Split(Const.SPLITOR);
                    maxRowNo = dataGridView.Rows.Count - 1;

                    dataGridView[(int)DATAGRID_ROW.TABLE_ID, maxRowNo].Value = info[0];
                    dataGridView[(int)DATAGRID_ROW.WHERE, maxRowNo].Value = info[1];
                    dataGridView[(int)DATAGRID_ROW.SQL, maxRowNo].Value = info[2];
                }
            }
   
        }

        private void lslFileList_DoubleClick(object sender, EventArgs e)
        {
            if (lslFileList.SelectedIndex != ListBox.NoMatches)
            {
                btnImport.PerformClick();
            }
            
        }

        private void btnDelFile_Click(object sender, EventArgs e)
        {

            if (lslFileList.SelectedIndex != ListBox.NoMatches)
            {
                DialogResult result = MessageBox.Show("ファイルを削除しますか?", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    string fileId = lslFileList.SelectedItem.ToString();
                    File.Delete(ApplicationDataPath + @"\" + fileId);
                    lslFileList.Items.Remove(lslFileList.SelectedItem);
                    clearControl();
                }
            }
        }

        private void clearControl()
        {
            this.dataGridView.Rows.Clear();
            txtTableId.Text = string.Empty;
            txtWhere.Text = string.Empty;
            txtSQL.Text = string.Empty;
        }


    }
}

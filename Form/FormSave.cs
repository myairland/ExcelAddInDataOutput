using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using ExcelAddInDataOutput.Utility;

namespace ExcelAddInDataOutput.Form
{
    public partial class FormSave :  System.Windows.Forms.Form
    {
        public FormSave()
        {
            InitializeComponent();
            ApplicationDataPath = Common.pathEdit(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                                    + Const.PROJECT_NAME;
        }

        public string fileId;

        private string ApplicationDataPath;

        public List<string> sqlInfo = new List<string>();

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string line = string.Empty;
            if (string.IsNullOrEmpty(txtFileId.Text))
            {
                MessageBox.Show("ファイルID入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileId.Focus();
                return;
            }

            fileId = txtFileId.Text + ".add";

            using (StreamWriter writer = new StreamWriter(ApplicationDataPath + @"\" + fileId))
            {
                foreach(string line in sqlInfo)
                {
                   writer.WriteLine(line);
                
                }
            }

            this.Close();
        }
    }
}

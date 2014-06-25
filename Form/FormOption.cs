using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OracleClient;
using ExcelAddInDataOutput.DataBase;
using ExcelAddInDataOutput.Utility;

namespace ExcelAddInDataOutput.Form
{
    public partial class FormOption : System.Windows.Forms.Form
    {

        private static string ApplicationDataPath;

        private string ConnectionType;

        public FormOption()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOption_Load(object sender, EventArgs e)
        {
            ApplicationDataPath = Common.pathEdit(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                                   + Const.PROJECT_NAME;

            if (!Directory.Exists(ApplicationDataPath))
                Directory.CreateDirectory(ApplicationDataPath);

            FormSerialisor.Deserialise(this, ApplicationDataPath + @"\" + Const.SETTING_XML);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSerialisor.Serialise(this, ApplicationDataPath + @"\" + Const.SETTING_XML);
            this.Close();
        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            BaseDataBase con = DbFactory.CreateDbInstance(ConnectionType, 
                                                    txtUserId.Text, txtPassword.Text, txtServer.Text, 
                                                    txtDatabase.Text);
            if (con.open())
            {
                MessageBox.Show("Connection OK!");
                con.close();
            }
            else
            {
                MessageBox.Show("Connection Fail!");
            }
            
        }

        private void cbDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionType = cbDbType.Text.Substring(0, 1);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            FontConverter cvt = new FontConverter();

            fontDialog.ShowEffects = true;
            fontDialog.ShowColor = true;

            if (lblFont.Text != "")
                fontDialog.Font = cvt.ConvertFromString(lblFont.Text) as Font;

            if (DialogResult.OK == fontDialog.ShowDialog())
            {                
                lblFont.Text = cvt.ConvertToString(fontDialog.Font);
            }
        }

        private void btnHeaderColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            ColorConverter cvt = new ColorConverter();

            if (lblHeaderColor.Text != "")
                colorDialog.Color = (Color)cvt.ConvertFromString(lblHeaderColor.Text);

            if (DialogResult.OK == colorDialog.ShowDialog())
            {                
                lblHeaderColor.Text = cvt.ConvertToString(colorDialog.Color);
                lblHeaderColor.BackColor = colorDialog.Color;
            }
            
        }

 

    }
}

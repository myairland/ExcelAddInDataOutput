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
            string appPath = Common.getApplicationFolder();
   
            if (!Directory.Exists(appPath))
                Directory.CreateDirectory(appPath);

            FormSerialisor.Deserialise(this, appPath + Const.SETTING_XML);

            restoreLabelStr();
        }

        private void restoreLabelStr()
        {
            FontConverter fontConverter = new FontConverter();
            ColorConverter colorCovert = new ColorConverter();


            lblHeaderSample.Font = fontConverter.ConvertFromString(txtHeaderFont.Text) as Font;
            lblHeaderSample.ForeColor = (Color)colorCovert.ConvertFromString(txtHeaderFontColor.Text);

            lblHeaderSample.BackColor = (Color)colorCovert.ConvertFromString(txtHeaderColor.Text);

            lblCellSample.Font = fontConverter.ConvertFromString(txtCellFont.Text) as Font;
            lblCellSample.ForeColor = (Color)colorCovert.ConvertFromString(txtCellFontColor.Text);

            lblCellSample.BackColor = (Color)colorCovert.ConvertFromString(txtCellColor.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSerialisor.Serialise(this, Common.getApplicationFolder()  + Const.SETTING_XML);
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

        private void btnHeaderColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            ColorConverter colorCovert = new ColorConverter();

            if (lblHeaderSample.Text != "")
                colorDialog.Color = lblHeaderSample.BackColor;

            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                txtHeaderColor.Text = colorCovert.ConvertToString(colorDialog.Color);

                lblHeaderSample.BackColor = colorDialog.Color;
               
            }
            
        }

        private void btnHeaderFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            FontConverter fontConverter = new FontConverter();
            ColorConverter colorCovert = new ColorConverter();

            fontDialog.ShowEffects = true;
            fontDialog.ShowColor = true;

            if (lblHeaderSample.Text != "")
            {
                fontDialog.Font = fontConverter.ConvertFromString(lblHeaderSample.Text) as Font;
                fontDialog.Color = lblHeaderSample.ForeColor;
            }

            if (DialogResult.OK == fontDialog.ShowDialog())
            {
                txtHeaderFont.Text = fontConverter.ConvertToString(fontDialog.Font);
                txtHeaderFontColor.Text = colorCovert.ConvertToString(fontDialog.Color);

                lblHeaderSample.Font = fontDialog.Font;
                lblHeaderSample.ForeColor = fontDialog.Color;
            }
        }

        private void btnCellFont_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            ColorConverter colorCovert = new ColorConverter();

            if (lblCellSample.Text != "")
                colorDialog.Color = lblCellSample.BackColor;

            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                txtCellColor.Text = colorCovert.ConvertToString(colorDialog.Color);

                lblCellSample.BackColor = colorDialog.Color;

            }
        }

        private void btnCellColor_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            FontConverter fontConverter = new FontConverter();
            ColorConverter colorCovert = new ColorConverter();

            fontDialog.ShowEffects = true;
            fontDialog.ShowColor = true;

            if (lblCellSample.Text != "")
            {
                fontDialog.Font = fontConverter.ConvertFromString(lblCellSample.Text) as Font;
                fontDialog.Color = lblCellSample.ForeColor;
            }

            if (DialogResult.OK == fontDialog.ShowDialog())
            {
                txtCellFont.Text = fontConverter.ConvertToString(fontDialog.Font);
                txtCellFontColor.Text = colorCovert.ConvertToString(fontDialog.Color);

                lblCellSample.Font = fontDialog.Font;
                lblCellSample.ForeColor = fontDialog.Color;
            }
        }

 

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using ExcelAddInDataOutput.Utility;
using ExcelAddInDataOutput.Form;
using ExcelAddInDataOutput.DataBase;
using Microsoft.Office.Core;


namespace ExcelAddInDataOutput
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;
        
        public Ribbon()
        {
                    }

        #region IRibbonExtensibility のメンバー

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("ExcelAddInDataOutput.Ribbon.xml");
        }

        #endregion

        #region リボンのコールバック
        //ここにコールバック メソッドを作成します。コールバック メソッドの追加の詳細については、ソリューション エクスプローラーでリボンの XML アイテムを選択し、F1 キーを押してください
        public void btnConfigure_Click(Microsoft.Office.Core.IRibbonControl control)
        {
            FormOption formOption = new FormOption();
            formOption.ShowDialog();
        }


        public void btnTableConfigure_Click(Microsoft.Office.Core.IRibbonControl control)
        {
            FormTableOption formTableOption = new FormTableOption();
            formTableOption.ShowDialog();
            ribbon.Invalidate();
        }

        public void galleryData_Change(IRibbonControl control, string selectedId, int selectedIndex)
        {
            string fileName = System.IO.Directory.GetFiles(Common.getConfigFolder(), "*.*")[selectedIndex];
            BaseDataBase db = DbFactory.CreateDbInstanceFromXML();
            DataOutput dataOutput = new DataOutput(Globals.ThisAddIn.Application, db);
            dataOutput.Execute(fileName);
        
        }

        public int galleryData_getItemCount(Office.IRibbonControl control)
        {
            return System.IO.Directory.GetFiles(Common.getConfigFolder(), "*.*").Length;
        }

        public string galleryData_getItemLabel(IRibbonControl control, int index)
        {
            return Path.GetFileName(Directory.GetFiles(Common.getConfigFolder(), "*.*")[index]);
        }

        public string galleryData_getLabel(IRibbonControl control)
        {
            if (control.Id == "galleryData")
            {
                if (System.IO.Directory.GetFiles(Common.getConfigFolder(), "*.*").Length != 0)
                    return "選択";
                else
                    return "未設定";
            }

            return "";
        }

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }
        

        #endregion

        #region ヘルパー

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}

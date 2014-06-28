using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;
using ExcelAddInDataOutput.DataBase;
using ExcelAddInDataOutput.Model;
using System.IO;

namespace ExcelAddInDataOutput.Utility
{
    class DataOutput
    {
        private Application application;

        private BaseDataBase db;

        public DataOutput(Application iApp, BaseDataBase iDb)
        {
            this.application = iApp;
            this.db = iDb;
        }

        public void Execute(string iSettingFile)
        {
            try
            {
                if (!db.open())
                    throw new Exception("データベース接続失敗");

                List<TableInfo> list = GetTableInfo(iSettingFile);

                setDbInfo(list);

                ExcelOutput output = new ExcelOutput(application, db);

                output.Execute(list);

                db.close();

     
            }
            catch (Exception ex)
            {
                db.close();
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        List<TableInfo> GetTableInfo(string iFileName)
        {
            string line;
            string[] info;

            List<TableInfo> list = new List<TableInfo>();

            using (StreamReader reader = new StreamReader(iFileName))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    TableInfo tableInfo = new TableInfo();

                    info = line.Split(Const.SPLITOR);

                    tableInfo.tableId = info[0];
                    tableInfo.where = info[1];
                    tableInfo.sql = info[2];

                    list.Add(tableInfo);
                }
            }

            return list;
        }



        public void setDbInfo(List<TableInfo> list)
        {
            try
            {

                foreach (TableInfo info in list)
                {
                    System.Data.DataTable dataTable = db.getTableSchema(info.tableId);

                    info.tableName = db.getTableName(info.tableId);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        FieldInfo fieldInfo = new FieldInfo();
                        DataRow dataRow = dataTable.Rows[i];
                        fieldInfo.fieldId = dataTable.Rows[i]["fieldId"].ToString();
                        fieldInfo.fieldName = dataTable.Rows[i]["fieldName"].ToString();
                        fieldInfo.dataType = dataTable.Rows[i]["dataType"].ToString();

                        if (dataTable.Rows[i]["isNullable"].ToString() == "True")
                            fieldInfo.IsNullable = true;
                        else
                            fieldInfo.IsNullable = false;

                        if (dataTable.Rows[i]["IsPrimaryKey"].ToString() == "True")
                            fieldInfo.IsPrimaryKey = true;
                        else
                            fieldInfo.IsPrimaryKey = false;                       

                        info.FieldList.Add(fieldInfo);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

       

    }

}

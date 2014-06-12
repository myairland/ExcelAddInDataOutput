using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;
using ExcelAddInDataOutput.DataBase;
using ExcelAddInDataOutput.Model;

namespace ExcelAddInDataOutput.Utility
{
    class DataOutput
    {
        private Workbook workbook;
        
        public DataOutput(Workbook iWorkbook)
        {
            this.workbook = iWorkbook;
        }
        public void Execute(Workbook workbook)
        {
            try
            {
                object de = DBNull.Value;
                string abc = de.ToString();

                List<TableInfo> list = GetTableInfo();

                setDbInfoSQLServer(list);



     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        List<TableInfo> GetTableInfo()
        { 
            List<TableInfo> list = new List<TableInfo>();
            Worksheet sheet = (Worksheet)this.workbook.Worksheets["data"];

            int row = 1;

            while (true)
            {
                if (sheet.Range["A" + row.ToString()].Value == null && sheet.Range["C" + row.ToString()].Value == null)
                    break;

                TableInfo entity = new TableInfo();

                entity.tableId = Common.ConvertNullToEmpty(sheet.Range["A" + row.ToString()].Value);
                entity.where = Common.ConvertNullToEmpty(sheet.Range["B" + row.ToString()].Value);
                entity.sql = Common.ConvertNullToEmpty(sheet.Range["C" + row.ToString()].Value);

                list.Add(entity);

                row++;
            
            }

            return list;
        }

        public void setDbInfoOracle( List<TableInfo> list)
        {
            string server = Common.GetPropertiesFromXmlByName("txtServer");
            string database = Common.GetPropertiesFromXmlByName("txtDatabase");
            string user = Common.GetPropertiesFromXmlByName("txtUserName");
            string password = Common.GetPropertiesFromXmlByName("txtPassword");

        
        }

        public void setDbInfoSQLServer(List<TableInfo> list)
        {
            string server = Common.GetPropertiesFromXmlByName("txtServer");
            string database = Common.GetPropertiesFromXmlByName("txtDatabase");
            string user = Common.GetPropertiesFromXmlByName("txtUserName");
            string password = Common.GetPropertiesFromXmlByName("txtPassword");

            try
            {
            BaseDataBase connnection = DbFactory.CreateDbInstance(Const.DB_TYPE_SQLSERVER, server, user, password, database);

            connnection.open();

            SqlCommand  dbCommand = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
                
             dbCommand.Connection = (System.Data.SqlClient.SqlConnection)connnection.dbConnection;

            dbCommand.CommandType = CommandType.Text;

            adapter.SelectCommand = dbCommand;
            adapter.SelectCommand = dbCommand;

            foreach(TableInfo info in list)
            {
                dbCommand.CommandText = getSql(info.tableId);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                System.Data.DataTable dataTable = dataSet.Tables[0];

                info.tableName = dataTable.Rows[0][""].ToString();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    FieldInfo fieldInfo = new FieldInfo();
                    DataRow dataRow = dataTable.Rows[i];
                   // fieldInfo.fieldId = dataRow;
                    fieldInfo.fieldName = dataTable.Rows[i][""].ToString();
                   // fieldInfo.IsPrimaryKey = dataTable.Rows[i][""].ToString();
                    //fieldInfo.IsNullable = dataTable.Rows[i][""].ToString();
                    fieldInfo.comment = dataTable.Rows[i][""].ToString();
                    fieldInfo.type = dataTable.Rows[i][""].ToString();
                    fieldInfo.fieldId = dataTable.Rows[i][""].ToString();
                }
            
            }

        



                
               

            connnection.close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private string getSql(string tableId)
    {
        string strSQL;

        strSQL = "";
        strSQL = strSQL + "SELECT ";
        strSQL = strSQL + "    tableId=CASE ";
        strSQL = strSQL + "    WHEN A.COLORDER=1 THEN ";
        strSQL = strSQL + "        D.NAME ";
        strSQL = strSQL + "    ELSE ";
        strSQL = strSQL + "        '' ";
        strSQL = strSQL + "    END, ";
        strSQL = strSQL + "    tableName=CASE ";
        strSQL = strSQL + "    WHEN A.COLORDER=1 THEN ";
        strSQL = strSQL + "        ISNULL(F.VALUE,'') ";
        strSQL = strSQL + "    ELSE ";
        strSQL = strSQL + "        '' ";
        strSQL = strSQL + "    END, ";
        strSQL = strSQL + "    fieldOrder=A.COLORDER, ";
        strSQL = strSQL + "    fieldId=A.NAME, ";
        strSQL = strSQL + "    signal=CASE ";
        strSQL = strSQL + "    WHEN COLUMNPROPERTY(A.ID,A.NAME,'ISIDENTITY')=1 THEN ";
        strSQL = strSQL + "        '√' ";
        strSQL = strSQL + "    ELSE ";
        strSQL = strSQL + "        '' ";
        strSQL = strSQL + "    END, ";
        strSQL = strSQL + "    IsPrimaryKey=CASE ";
        strSQL = strSQL + "    WHEN EXISTS ";
        strSQL = strSQL + "                ( ";
        strSQL = strSQL + "                SELECT ";
        strSQL = strSQL + "                    1 ";
        strSQL = strSQL + "                FROM ";
        strSQL = strSQL + "                    SYSOBJECTS ";
        strSQL = strSQL + "                WHERE ";
        strSQL = strSQL + "                    XTYPE='PK' AND ";
        strSQL = strSQL + "                    NAME IN ";
        strSQL = strSQL + "                        ( ";
        strSQL = strSQL + "                        SELECT ";
        strSQL = strSQL + "                            NAME ";
        strSQL = strSQL + "                        FROM ";
        strSQL = strSQL + "                            SYSINDEXES ";
        strSQL = strSQL + "                        WHERE ";
        strSQL = strSQL + "                            INDID IN ";
        strSQL = strSQL + "                                ( ";
        strSQL = strSQL + "                                SELECT ";
        strSQL = strSQL + "                                    INDID ";
        strSQL = strSQL + "                                FROM ";
        strSQL = strSQL + "                                    SYSINDEXKEYS ";
        strSQL = strSQL + "                                WHERE ";
        strSQL = strSQL + "                                    ID = A.ID AND ";
        strSQL = strSQL + "                                    COLID=A.COLID ";
        strSQL = strSQL + "                                ) ";
        strSQL = strSQL + "                        ) ";
        strSQL = strSQL + "                ) THEN ";
        strSQL = strSQL + "                '√' ";
        strSQL = strSQL + "        ELSE ";
        strSQL = strSQL + "                '' ";
        strSQL = strSQL + "    END, ";
        strSQL = strSQL + "    type=B.NAME, ";
        strSQL = strSQL + "    byteCount=A.LENGTH, ";
        strSQL = strSQL + "    integerLength=COLUMNPROPERTY(A.ID,A.NAME,'PRECISION'), ";
        strSQL = strSQL + "    decLength=ISNULL(COLUMNPROPERTY(A.ID,A.NAME,'SCALE'),0), ";
        strSQL = strSQL + "    isNullable=CASE ";
        strSQL = strSQL + "    WHEN A.ISNULLABLE=1 THEN ";
        strSQL = strSQL + "        '√' ";
        strSQL = strSQL + "    ELSE ";
        strSQL = strSQL + "        '' ";
        strSQL = strSQL + "    END, ";
        strSQL = strSQL + "    defaultValue=ISNULL(E.TEXT,''), ";
        strSQL = strSQL + "    fieldName=ISNULL(G.[VALUE],'') ";
        strSQL = strSQL + "FROM ";
        strSQL = strSQL + "    SYSCOLUMNS A ";
        strSQL = strSQL + "    LEFT JOIN ";
        strSQL = strSQL + "    SYSTYPES B ON ";
        strSQL = strSQL + "    A.XUSERTYPE=B.XUSERTYPE ";
        strSQL = strSQL + "    INNER JOIN ";
        strSQL = strSQL + "    SYSOBJECTS D ON ";
        strSQL = strSQL + "    A.ID=D.ID AND ";
        strSQL = strSQL + "    D.XTYPE='U' AND ";
        strSQL = strSQL + "    D.NAME<>'DTPROPERTIES' ";
        strSQL = strSQL + "    LEFT JOIN ";
        strSQL = strSQL + "    SYSCOMMENTS E ON ";
        strSQL = strSQL + "    A.CDEFAULT=E.ID ";
        strSQL = strSQL + "    LEFT JOIN ";
        strSQL = strSQL + "    SYS.EXTENDED_PROPERTIES G ON ";
        strSQL = strSQL + "    A.ID=G.MAJOR_ID AND ";
        strSQL = strSQL + "    A.COLID=G.MINOR_ID ";
        strSQL = strSQL + "    LEFT JOIN ";
        strSQL = strSQL + "    SYS.EXTENDED_PROPERTIES F ON ";
        strSQL = strSQL + "    D.ID=F.MAJOR_ID AND ";
        strSQL = strSQL + "    F.MINOR_ID=0 ";
        strSQL = strSQL + "WHERE   d.name='" + tableId + "'";
        strSQL = strSQL + "ORDER BY ";
        strSQL = strSQL + "    A.ID, ";
        strSQL = strSQL + "    A.COLORDER ";
        

        return strSQL;
    }
        /*
         *   range.NumberFormatLocal = "@";     //设置单元格格式为文本 

range = (Range)worksheet.get_Range("A1", "E1");     //获取Excel多个单元格区域：本例做为Excel表头

range.Merge(0);     //单元格合并动作

worksheet.Cells[1, 1] = "Excel单元格赋值";     //Excel单元格赋值

range.Font.Size = 15;     //设置字体大小

range.Font.Underline=true;     //设置字体是否有下划线

range.Font.Name="黑体";     设置字体的种类

range.HorizontalAlignment=XlHAlign.xlHAlignCenter;     //设置字体在单元格内的对其方式

range.ColumnWidth=15;     //设置单元格的宽度

range.Cells.Interior.Color=System.Drawing.Color.FromArgb(255,204,153).ToArgb();     //设置单元格的背景色

range.Borders.LineStyle=1;     //设置单元格边框的粗细

range.BorderAround(XlLineStyle.xlContinuous,XlBorderWeight.xlThick,XlColorIndex.xlColorIndexAutomatic,System.Drawing.Color.Black.ToArgb());     //给单元格加边框

range.EntireColumn.AutoFit();     //自动调整列宽

Range.HorizontalAlignment= xlCenter;     // 文本水平居中方式

Range.VerticalAlignment= xlCenter     //文本垂直居中方式

Range.WrapText=true;     //文本自动换行

Range.Interior.ColorIndex=39;     //填充颜色为淡紫色

Range.Font.Color=clBlue;     //字体颜色

xlsApp.DisplayAlerts=false;     //保存Excel的时候，不弹出是否保存的窗口直接进行保存

   workbook.SaveCopyAs(temp);/**/
        ///填入完信息之后另存到路径及文件名字*/

    }

}

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
        private Workbook workbook;

        private BaseDataBase db;
        
        public DataOutput(Workbook iWorkbook,BaseDataBase iDb)
        {
            this.workbook = iWorkbook;
            this.db = iDb;
        }

        public void Execute(string iSettingFile)
        {
            try
            {

                List<TableInfo> list = GetTableInfo(iSettingFile);

                setDbInfo(list);



     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

                    info.tableName = dataTable.Rows[0]["tableName"].ToString();

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /*
         * 
         * 
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

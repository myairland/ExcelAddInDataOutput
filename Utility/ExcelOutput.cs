using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using ExcelAddInDataOutput.Model;
using ExcelAddInDataOutput.DataBase;
using System.Data;
using System.Drawing;

namespace ExcelAddInDataOutput.Utility
{
    public class ExcelOutput
    {
        private Application application;

        private BaseDataBase db;

        private System.Drawing.Font font;

        private Color fontColor;

        private Color headerColor;

        public ExcelOutput(Application iApp, BaseDataBase iDb)
        {
            this.application = iApp;
            this.db = iDb;
            initStyleFromXml();
        }

        private void initStyleFromXml()
        {
            FontConverter fontConverter = new FontConverter();
            ColorConverter colorCovert = new ColorConverter();
            string fontColorStr = Common.GetPropertiesFromXmlByName(Const.XML_FONT_COLOR);
            string fontStr = Common.GetPropertiesFromXmlByName(Const.XML_FONT);
            string headerColorStr = Common.GetPropertiesFromXmlByName(Const.XML_HEADER_COLOR);

            if (fontStr != "")
            {
                font = fontConverter.ConvertFromString(fontStr) as System.Drawing.Font;
                fontColor = (Color)colorCovert.ConvertFromString(fontColorStr);
            }
            else
            {
                font = SystemFonts.DefaultFont;
                fontColor = Color.Black;
            }

            if (headerColorStr != "")
            {
                headerColor = (Color)colorCovert.ConvertFromString(headerColorStr);
            }
            else
            {
                headerColor = Color.LightBlue;
            }
           
        }

        public bool Execute(List<TableInfo> list)
        {
            int row = 1;


            Range currentCell = application.ActiveCell;
            row = currentCell.Row;
            try
            {
                foreach(TableInfo tableInfo in list)
                {
                    Worksheet worksheet = (Worksheet)application.ActiveWorkbook.ActiveSheet;
                    string tableNameDisplay;

                    if(string.IsNullOrEmpty(tableInfo.tableName))
                        tableNameDisplay = tableInfo.tableId ;
                    else
                        tableNameDisplay = tableInfo.tableId + "_" + tableInfo.tableName;


                    worksheet.Range["A" + row.ToString()].Value = tableNameDisplay;

                    // column 
                    int colNo = 1;
                    foreach (FieldInfo fieldInfo in tableInfo.FieldList)
                    {
                        
                        worksheet.Cells[(row + 1), colNo] = fieldInfo.fieldId;

                        worksheet.Cells[(row + 2), colNo] = fieldInfo.fieldName;

                        worksheet.Cells[(row + 3), colNo] = fieldInfo.dataType;

                        worksheet.Cells[(row + 4), colNo] = fieldInfo.IsPrimaryKey;

                        worksheet.Cells[(row + 5), colNo] = fieldInfo.IsNullable;

                        //worksheet.Range[worksheet.Cells[(row + 1), colNo], worksheet.Cells[(row + 5), colNo]].Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
                        //worksheet.Range[1, 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                        //    worksheet.Range[1, 1].Interior.Pattern = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                        //worksheet.Range[1, 1].Interior.ColorIndex = 6;
                        Range range = worksheet.get_Range("B89", "K89");
                        range.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);
                        colNo = colNo + 1;
                    }
                    row = row + 6;

                    // data
                    string strSql;
                    strSql = "select * from " + tableInfo.tableId ;

                    System.Data.DataTable data = this.db.GetDataTable(strSql);


                    foreach (DataRow dataRow in data.Rows)
                    {
                        int column = 1;
                        foreach (DataColumn col in data.Columns)
                        {
                            worksheet.Cells[row, (column++)] = dataRow[col].ToString();
                        }

                        row = row + 1;
                    }

                    
                    row = row + 2;
                }


                return true;
            }
            catch
            {
                return false;
            }
        
        }

        private  int ToExcelRGB(Color color)
        {
            return color.R + color.G * 256 + color.B * 256 * 256;
        }

    }
}
    /*   range.NumberFormatLocal = "@";     //设置单元格格式为文本 

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
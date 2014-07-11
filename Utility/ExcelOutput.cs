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

        private System.Drawing.Font headerFont;

        private Color headerFontColor;

        private Color headerColor;

        private System.Drawing.Font cellFont;

        private Color cellFontColor;

        private Color cellColor;

        private bool isFeldNameVisible;

        private bool isDataTypeVisible;

        private bool isPrimaryKeyVisible;

        private bool isNullableVisible;

        private bool isHeaderBoxVisible;

        private bool isDataBoxVisible;

        private string noDataStr;

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

            string headerFontColorStr = Common.GetPropertiesFromXmlByName(Const.XML_HEADER_FONT_COLOR);
            string headerFontStr = Common.GetPropertiesFromXmlByName(Const.XML_HEADER_FONT);
            string headerColorStr = Common.GetPropertiesFromXmlByName(Const.XML_HEADER_COLOR);

            if (headerFontStr != "")
            {
                headerFont = fontConverter.ConvertFromString(headerFontStr) as System.Drawing.Font;
                headerFontColor = (Color)colorCovert.ConvertFromString(headerFontColorStr);
            }
            else
            {
                headerFont = SystemFonts.DefaultFont;
                headerFontColor = Color.Black;
            }

            if (headerColorStr != "")
            {
                headerColor = (Color)colorCovert.ConvertFromString(headerColorStr);
            }
            else
            {
                headerColor = Color.LightBlue;
            }


            string cellFontColorStr = Common.GetPropertiesFromXmlByName(Const.XML_CEll_FONT_COLOR);
            string cellFontStr = Common.GetPropertiesFromXmlByName(Const.XML_CEll_FONT);
            string cellColorStr = Common.GetPropertiesFromXmlByName(Const.XML_CEll_COLOR);

            if (cellFontStr != "")
            {
                cellFont = fontConverter.ConvertFromString(cellFontStr) as System.Drawing.Font;
                cellFontColor = (Color)colorCovert.ConvertFromString(cellFontColorStr);
            }
            else
            {
                cellFont = SystemFonts.DefaultFont;
                cellFontColor = Color.Black;
            }

            if (cellColorStr != "")
            {
                cellColor = (Color)colorCovert.ConvertFromString(cellColorStr);
            }
            else
            {
                cellColor = Color.LightBlue;
            }

            isDataBoxVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_DATA_BOX));
            isHeaderBoxVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_HEADER_BOX));
            isNullableVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_NULLABLE));
            isPrimaryKeyVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_PRIMARY_KEY));
            isDataTypeVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_DATA_TYPE));
            isFeldNameVisible = bool.Parse(Common.GetPropertiesFromXmlByName(Const.XML_CB_FIELD_NAME));
            noDataStr = Common.GetPropertiesFromXmlByName(Const.XML_NO_DATA);
        }

        public bool Execute(List<TableInfo> list)
        {
            int row = 1;
            int rowTemp = 1;
            int primaryKeyCount = 1;
 
            Range firstCell = null  ;
            Range lastCell = null;

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


                    worksheet.Cells[row,1] = tableNameDisplay;

                    // column 
                    int colNo = 1;
                    rowTemp = row + 1;
                    primaryKeyCount = 1;

                    firstCell = (Range)worksheet.Cells[row + 1, 1];

                    foreach (FieldInfo fieldInfo in tableInfo.FieldList)
                    {
                        rowTemp = row + 1;

                        worksheet.Cells[rowTemp++, colNo] = fieldInfo.fieldId;

                        if(isFeldNameVisible)
                            worksheet.Cells[rowTemp++, colNo] = fieldInfo.fieldName;

                        if(isDataTypeVisible)
                            worksheet.Cells[rowTemp++, colNo] = fieldInfo.dataType;

                        if (isPrimaryKeyVisible)
                        {
                            if (fieldInfo.IsPrimaryKey)
                            {
                                worksheet.Cells[rowTemp++, colNo] = primaryKeyCount.ToString();
                                primaryKeyCount++;
                            }
                            else
                            {
                                worksheet.Cells[rowTemp++, colNo] = "";
                            }
                        }                           

                        if (isNullableVisible)
                        {
                            if(fieldInfo.IsNullable)
                                worksheet.Cells[rowTemp++, colNo] = "○";
                            else
                                worksheet.Cells[rowTemp++, colNo] = "×";
                        }

                        colNo = colNo + 1;
                    }
                    

                    row = rowTemp;

                    //format
                    if(colNo != 1) // データある場合
                    {
                        lastCell = (Range)worksheet.Cells[rowTemp - 1, colNo -1];
                        formatCell(worksheet.get_Range(firstCell, lastCell), headerFont, headerFontColor, headerColor);
                        if (isHeaderBoxVisible)
                        {
                            drawCellLine(worksheet.get_Range(firstCell, lastCell));
                        }
                    }

                    // data
                    string strSearchSql;
                    string where;
                    strSearchSql = "select * from " + tableInfo.tableId ;
                    if (string.IsNullOrEmpty(tableInfo.where))
                        where = "";
                    else
                        where = " where " + tableInfo.where;

                    if (string.IsNullOrEmpty(tableInfo.sql))
                        strSearchSql = strSearchSql + where;
                    else
                        strSearchSql = tableInfo.sql;

                    System.Data.DataTable data = this.db.GetDataTable(strSearchSql);


                    firstCell = (Range)worksheet.Cells[row , 1];
                    int column = 1;
                    foreach (DataRow dataRow in data.Rows)
                    {
                        column = 1;
                        foreach (DataColumn columnObj in data.Columns)
                        {
                            worksheet.Cells[row, (column++)] = "'" + dataRow[columnObj].ToString();
                        }

                        row = row + 1;
                    }
                    
                    
                    //format
                    if (column != 1) // データある場合
                    {
                        lastCell = (Range)worksheet.Cells[row - 1, column -1];
                        formatCell(worksheet.get_Range(firstCell, lastCell), cellFont, cellFontColor, cellColor);
                        if (isDataBoxVisible)
                        {
                            drawCellLine(worksheet.get_Range(firstCell, lastCell));
                        }
                    }
                    else
                    {
                        worksheet.Cells[row, 1] = noDataStr;
                        row = row + 1;
                    }
                    
                    row = row + 2;

                    ((Range)worksheet.Cells[row, 1]).Select();
                }               


                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("データ抽出失敗しました。WHERE文を注意してください!");
                return false;
            }
        
        }

        private void formatCell(Range range,System.Drawing.Font font,Color fontColor,Color CellBackColor)
        {
            try
            {
                range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
                range.Interior.Color = System.Drawing.ColorTranslator.ToOle(CellBackColor);
                range.Font.Bold = font.Bold;
                range.Font.Size = font.Size;
                range.Font.Strikethrough = font.Strikeout;
                range.Font.Underline = font.Underline;
                range.Font.Italic = font.Italic;
                range.Font.Name = font.FontFamily;

            }
            catch
            {

            }
        
        }

        private void drawCellLine(Range range)
        {
            range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlThin;

            range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlThin;

            range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlThin;

            range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlThin;

            range.Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlInsideVertical].Weight = XlBorderWeight.xlThin;

            range.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlInsideHorizontal].Weight = XlBorderWeight.xlThin;

        }

    }
}
   
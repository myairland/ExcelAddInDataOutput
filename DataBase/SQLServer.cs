﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ExcelAddInDataOutput.DataBase
{
    public class SQLServer :BaseDataBase
    {
        public SQLServer(string userId,string password,string server,string database)
        {
            this.userId = userId;
            this.password = password;
            this.server = server;
            this.database = database;
            
        
        }

        public override bool open()
        {
            string ConectionString;

            try
            {
                if (string.IsNullOrEmpty(database))
                {
                    ConectionString = @"Server=" + server +
                                            ";User Id=" + userId +
                                            ";Password=" + password + ";";
                    dbConnection = new SqlConnection(ConectionString);
                }

                else
                {
                    ConectionString = @"Server=" + server +
                                        ";User Id=" + userId +
                                        ";Password=" + password +
                                        ";Database=" + database + ";";
                    dbConnection = new SqlConnection(ConectionString);

                }

                dbConnection.Open();


            }
            catch
            {
                return false;
            }

            return true;
        }

        public override void close()
        {
            if (dbConnection != null)
                dbConnection.Close();
        }


        public override DataTable getTableSchema(string tableId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                this.open();

                SqlCommand dbCommand = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();

                dbCommand.Connection = (System.Data.SqlClient.SqlConnection)dbConnection;

                dbCommand.CommandType = CommandType.Text;
                adapter.SelectCommand = dbCommand;

                dbCommand.CommandText = getTableSQL(tableId);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];

                this.close();
            }
            catch
            {
                this.close();
            }

            return dataTable;
 
        }

        private string getTableSQL(string tableId)
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
            strSQL = strSQL + "    isIdentity=CASE ";
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
            strSQL = strSQL + "                'True' ";
            strSQL = strSQL + "        ELSE ";
            strSQL = strSQL + "                'False' ";
            strSQL = strSQL + "    END, ";
            strSQL = strSQL + "    type=B.NAME, ";
            strSQL = strSQL + "    byteCount=A.LENGTH, ";
            strSQL = strSQL + "    integerLength=COLUMNPROPERTY(A.ID,A.NAME,'PRECISION'), ";
            strSQL = strSQL + "    decLength=ISNULL(COLUMNPROPERTY(A.ID,A.NAME,'SCALE'),0), ";
            strSQL = strSQL + "    isNullable=CASE ";
            strSQL = strSQL + "    WHEN A.ISNULLABLE=1 THEN ";
            strSQL = strSQL + "        'True' ";
            strSQL = strSQL + "    ELSE ";
            strSQL = strSQL + "        'False' ";
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


    }
}
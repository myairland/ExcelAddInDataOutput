using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ExcelAddInDataOutput.DataBase
{
    public class MySQL : BaseDataBase
    {
        public MySQL(string userId, string password, string server, string database)
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
                ConectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false",
                                server, userId, password, database);

                dbConnection = new MySqlConnection(ConectionString);

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

        public override System.Data.Common.DbDataAdapter getDbDataAdapter()
        {
            return new MySql.Data.MySqlClient.MySqlDataAdapter();
        }


        public override string getTableNameSQL(string tableId)
        {
            string sql;
            sql = "Select TABLE_COMMENT tableName from INFORMATION_SCHEMA.TABLES Where table_schema = '" + database + "' AND table_name LIKE '" + tableId + "'";
            return sql;
        }

        public override string getTableSchemaSQL(string tableId)
        {
            string strSQL= string.Empty;

            strSQL = strSQL + "SELECT ";
            strSQL = strSQL + "    column_name AS fieldId, ";
            strSQL = strSQL + "    column_comment AS fieldName, ";
            strSQL = strSQL + "    CASE ";
            strSQL = strSQL + "    WHEN IS_NULLABLE = 'YES' THEN ";
            strSQL = strSQL + "        'True' ";
            strSQL = strSQL + "    ELSE ";
            strSQL = strSQL + "        'False' ";
            strSQL = strSQL + "    END AS isNullable, ";
            strSQL = strSQL + "    COLUMN_TYPE AS dataType, ";
            strSQL = strSQL + "    CASE ";
            strSQL = strSQL + "    WHEN COLUMN_key = 'PRI' THEN ";
            strSQL = strSQL + "        'True' ";
            strSQL = strSQL + "    ELSE ";
            strSQL = strSQL + "        'False' ";
            strSQL = strSQL + "    END AS IsPrimaryKey ";
            strSQL = strSQL + "FROM ";
            strSQL = strSQL + "    INFORMATION_SCHEMA.COLUMNS ";
            strSQL = strSQL + "WHERE ";
            strSQL = strSQL + "    TABLE_SCHEMA = '" + database + "'  AND ";
            strSQL = strSQL + "    TABLE_NAME = '" + tableId + "' ";
            strSQL = strSQL + "ORDER BY ";
            strSQL = strSQL + "    ORDINAL_POSITION ";

            return strSQL;
        }

        public override DataTable getSynonymSchema(string tableId)
        {
            return new DataTable();
        }

        public override string getSynonymTableName(string tableId)
        {
            return "";
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Data;

namespace ExcelAddInDataOutput.DataBase
{
    public class Oracle : BaseDataBase
    {
        public Oracle(string userId, string password, string server)
        {
            this.userId = userId;
            this.password = password;
            this.server = server;

        }

        public override bool open()
        {
            string ConectionString;

            try
            {
                ConectionString = @"Data Source=" + server +
                          ";User Id=" + userId +
                          ";Password=" + password;
                dbConnection = new OracleConnection(ConectionString);

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

        public override string getTableSchemaSQL(string tableId)
        {
            string sql = string.Empty;

            sql = sql + "SELECT ";
            sql = sql + "    A.column_name fieldId, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN NVL(A.data_precision,0) = 0 THEN ";
            sql = sql + "        A.data_type || '(' || A.data_length || ')' ";
            sql = sql + "    ELSE ";
            sql = sql + "        A.data_type || '(' || A.data_precision || ',' || A.Data_Scale || ')' ";
            sql = sql + "    END dataType, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN A.nullable = 'N' THEN ";
            sql = sql + "        'False' ";
            sql = sql + "    ELSE ";
            sql = sql + "        'True' ";
            sql = sql + "    END isNullable, ";
            sql = sql + "    B.comments fieldName, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN C.column_name IS NULL THEN ";
            sql = sql + "        'False' ";
            sql = sql + "    ELSE ";
            sql = sql + "        'True' ";
            sql = sql + "    END AS IsPrimaryKey ";
            sql = sql + "FROM ";
            sql = sql + "    user_tab_columns A, ";
            sql = sql + "    user_col_comments B, ";
            sql = sql + "    ( ";
            sql = sql + "    SELECT ";
            sql = sql + "        col.column_name ";
            sql = sql + "    FROM ";
            sql = sql + "        user_constraints con, ";
            sql = sql + "        user_cons_columns col ";
            sql = sql + "    WHERE ";
            sql = sql + "        con.constraint_name = col.constraint_name AND ";
            sql = sql + "        con.constraint_type='P' AND ";
            sql = sql + "        col.table_name = UPPER('" + tableId + "')";
            sql = sql + "    ) C ";
            sql = sql + "WHERE ";
            sql = sql + "    A.Table_Name = B.Table_Name AND ";
            sql = sql + "    A.Column_Name = B.Column_Name AND ";
            sql = sql + "    A.Table_Name = UPPER('" + tableId + "') AND ";
            sql = sql + "    A.column_name = C.column_name(+) ";
            sql = sql + "ORDER BY ";
            sql = sql + "    A.column_id ";



            return sql;

        }


        public override string getTableNameSQL(string tableId)
        {
            string sql = string.Empty;
            sql = sql + "SELECT ";
            sql = sql + "    comments as tableName ";
            sql = sql + "FROM ";
            sql = sql + "    user_tab_comments ";
            sql = sql + "WHERE ";
            sql = sql + "    table_name =UPPER('" + tableId + "')";

            return sql;
        }


        public override System.Data.Common.DbDataAdapter getDbDataAdapter()
        {
            return new OracleDataAdapter();
        }


        public override DataTable getSynonymSchema(string tableId)
        {
            string sql = string.Empty;
            DataTable schemaDataTable = new DataTable();

            sql = sql + "SELECT ";
            sql = sql + "    A.column_name fieldId, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN NVL(A.data_precision,0) = 0 THEN ";
            sql = sql + "        A.data_type || '(' || A.data_length || ')' ";
            sql = sql + "    ELSE ";
            sql = sql + "        A.data_type || '(' || A.data_precision || ',' || A.Data_Scale || ')' ";
            sql = sql + "    END dataType, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN A.nullable = 'N' THEN ";
            sql = sql + "        'False' ";
            sql = sql + "    ELSE ";
            sql = sql + "        'True' ";
            sql = sql + "    END isNullable, ";
            sql = sql + "    B.comments fieldName, ";
            sql = sql + "    CASE ";
            sql = sql + "    WHEN C.column_name IS NULL THEN ";
            sql = sql + "        'False' ";
            sql = sql + "    ELSE ";
            sql = sql + "        'True' ";
            sql = sql + "    END AS IsPrimaryKey ";
            sql = sql + "FROM ";
            sql = sql + "    all_tab_columns A, ";
            sql = sql + "    all_col_comments B, ";
            sql = sql + "    all_synonyms E, ";
            sql = sql + "    ( ";
            sql = sql + "    SELECT ";
            sql = sql + "        col.column_name ";
            sql = sql + "    FROM ";
            sql = sql + "        ALL_CONSTRAINTS con, ";
            sql = sql + "        ALL_CONS_COLUMNS col, ";
            sql = sql + "        all_synonyms syn ";
            sql = sql + "    WHERE ";
            sql = sql + "        con.constraint_name = col.constraint_name AND ";
            sql = sql + "        con.constraint_type='P' AND ";
            sql = sql + "        syn.owner = UPPER('" + userId + "') AND ";
            sql = sql + "        syn.synonym_name = UPPER('" + tableId + "') AND ";
            sql = sql + "        syn.Table_owner = con.owner AND ";
            sql = sql + "        syn.Table_owner = col.owner AND ";
            sql = sql + "        syn.table_name = col.table_name ";
            sql = sql + "    ) C ";
            sql = sql + "WHERE ";
            sql = sql + "    E.owner = UPPER('" + userId + "') AND ";
            sql = sql + "    E.synonym_name = UPPER('" + tableId + "') AND ";
            sql = sql + "    E.Table_owner = A.owner AND ";
            sql = sql + "    A.table_name = E.table_name AND ";
            sql = sql + "    A.Table_Name = B.Table_Name AND ";
            sql = sql + "    A.Column_Name = B.Column_Name AND ";
            sql = sql + "    A.column_name = C.column_name(+) ";
            sql = sql + "ORDER BY ";
            sql = sql + "    A.column_id ";

            schemaDataTable = this.GetDataTable(sql);

            return schemaDataTable;

        }

        public override string getSynonymTableName(string tableId)
        {

            string sql = string.Empty;
            string synonymTableName = string.Empty;


            sql = sql + "SELECT ";
            sql = sql + "    t1.comments as tableName ";
            sql = sql + "FROM ";
            sql = sql + "    all_tab_comments t1, ";
            sql = sql + "    all_synonyms t2 ";
            sql = sql + "WHERE ";
            sql = sql + "    t1.owner = t2.table_owner AND ";
            sql = sql + "    t2.owner = UPPER('" + userId + "') AND ";
            sql = sql + "    t2.synonym_name = UPPER('" + tableId + "') ";

            DataTable dataTable = new DataTable();
            dataTable = this.GetDataTable(sql);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                synonymTableName = dataTable.Rows[0]["tableName"].ToString();
            }
            else
            {
                synonymTableName = "";
            }

            return synonymTableName;
        }
    }
}

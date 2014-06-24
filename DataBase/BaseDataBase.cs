using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ExcelAddInDataOutput.DataBase
{
    public abstract class BaseDataBase
    {
        protected string userId;

        protected string password;

        protected string server;

        protected string database;

        public DbConnection dbConnection;

        public abstract bool open();

        public abstract void close();


        public abstract DbDataAdapter getDbDataAdapter();

        public abstract string getTableSchemaSQL(string tableId);

        public abstract string getTableNameSQL(string tableId);

        public virtual DataTable GetDataTable(string sqlString)
        {
            DbCommand vlCommand = default(DbCommand);
            DbDataAdapter vlAdapter = default(DbDataAdapter);
            DataTable vlDataTable = default(DataTable);

            vlCommand = dbConnection.CreateCommand();
            vlCommand.CommandText = sqlString;

            vlAdapter = getDbDataAdapter();

            vlAdapter.SelectCommand = vlCommand;

            vlDataTable = new DataTable();

            vlAdapter.Fill(vlDataTable);

            return vlDataTable;
        }

        public virtual DataTable getTableSchema(string tableId)
        {
            DataTable dataTable = new DataTable();

            string sql = getTableSchemaSQL(tableId);

            dataTable = this.GetDataTable(sql);

            return dataTable;

        }

        public virtual string getTableName(string tableId)
        {
            string sql = string.Empty;
            string tableName;

            sql = getTableNameSQL(tableId);

            DataTable db = this.GetDataTable(sql);

            if (db != null && db.Rows.Count > 0)
            {
                tableName = db.Rows[0]["tableName"].ToString();
            }
            else
            {
                tableName = "";
            }

            return tableName;
        }


    }
}

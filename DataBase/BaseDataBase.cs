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

        public abstract DataTable getTableSchema(string tableId);

        public abstract string getTableName(string tableId);

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

        public abstract DbDataAdapter getDbDataAdapter();

    }
}

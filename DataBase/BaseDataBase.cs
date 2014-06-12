using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ExcelAddInDataOutput.DataBase
{
    public abstract class BaseDataBase
    {
        protected string userId;

        protected string password;

        protected string server;

        protected string database;

        public IDbConnection dbConnection;

        public abstract bool open();

        public abstract void close();

        public abstract void getDbSchema();

    }
}

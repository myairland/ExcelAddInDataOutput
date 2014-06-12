using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelAddInDataOutput.Utility;

namespace ExcelAddInDataOutput.DataBase
{
    public class DbFactory
    {
        public static BaseDataBase CreateDbInstance(string dbType,string userid,string password,string server,string database)
        {
            BaseDataBase db = null;
            switch (dbType)
            {
                case Const.DB_TYPE_ORACLE:                    
                    break;
                case Const.DB_TYPE_SQLSERVER:
                    db = new SQLServer(userid, password, server, database);
                    break;
                case Const.DB_TYPE_MYSQL:
                    break;
                default:
                    break;
            }

            return db;
        }
    }
}

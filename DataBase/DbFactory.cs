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
                    db = new ExcelAddInDataOutput.DataBase.MySQL(userid, password, server, database);
                    break;
                default:
                    break;
            }

            return db;
        }

        public static BaseDataBase CreateDbInstanceFromXML()
        {
            String dbType = Common.GetPropertiesFromXmlByName(Const.XML_DB_TYPE_KEY).Substring(0,1);
            string server = Common.GetPropertiesFromXmlByName(Const.XML_USER_SERVER_KEY);
            string database = Common.GetPropertiesFromXmlByName(Const.XML_USER_DATABASE_KEY);
            string user = Common.GetPropertiesFromXmlByName(Const.XML_USER_ID_KEY);
            string password = Common.GetPropertiesFromXmlByName(Const.XML_USER_PASSWORD_KEY);

            return CreateDbInstance(dbType, user, password, server, database);

        }
    }
}

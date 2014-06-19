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
            throw new NotImplementedException();
        }

        public override string getTableName(string tableId)
        {
            string sql;
            string tableName;

            sql = "Select TABLE_COMMENT tableName from INFORMATION_SCHEMA.TABLES Where table_schema = '" + database + "AND table_name LIKE '"+tableId+"'";

            DataTable db = this.GetDataTable(sql);

            if(db != null && db.Rows.Count  > 0)
            {
                tableName = db.Rows[0]["tableName"].ToString();
            }
            else
            {
                tableName= "";
            }

            return tableName;
        }

        public override System.Data.Common.DbDataAdapter getDbDataAdapter()
        {
            return new MySql.Data.MySqlClient.MySqlDataAdapter();
        }

        /*

         Create table test1(
            field_name int comment '字段的注释'
        )comment='表的注释'; 

        2 修改表的注释
        alter table test1 comment '修改后的表的注释'; 
                 * 
        3 修改字段的注释
        alter table test1 modify column field_name int comment '修改后的字段注释';   */
    }
}


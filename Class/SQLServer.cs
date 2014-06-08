using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ExcelAddInDataOutput
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
        public SQLServer(string userId, string password, string server)
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





    }
}

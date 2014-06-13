using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ExcelAddInDataOutput.DataBase
{
    public class MySQL : BaseDataBase
    {
        public override bool open()
        {
            string ConectionString;

            try
            {
                //if (string.IsNullOrEmpty(database))
                //{
                //    ConectionString = @"Server=" + server +
                //                            ";User Id=" + userId +
                //                            ";Password=" + password + ";";
                //    dbConnection = new SqlConnection(ConectionString);
                //}

                //else
                //{
                //    ConectionString = @"Server=" + server +
                //                        ";User Id=" + userId +
                //                        ";Password=" + password +
                //                        ";Database=" + database + ";";
                //    dbConnection = new SqlConnection(ConectionString);

                //}

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
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Xml;

namespace ExcelAddInDataOutput
{
    class Common
    {



        public static BaseDataBase GetConnection(string DbType, string server, string userName, string password, string database)
        {
            string ConectionString = string.Empty;

            BaseDataBase con = null;

            if (DbType == Const.DB_TYPE_ORACLE)
            {
               
            }
            else if (DbType == Const.DB_TYPE_SQLSERVER)
            {
                con = new SQLServer(userName, password, server,database);
            }

            return con;

        }

        public static string pathEdit(string path)
        {
            if (path.EndsWith("\\"))
                return path;
            else
                return path + "\\";
        }

        public static string ConvertNullToEmpty(object obj)
        {
            if (obj == null)
                return "";
            else
                return obj.ToString();
        }

        public static string GetPropertiesFromXmlByName(string Name)
        {
           string xmlPath = Common.pathEdit(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                       + Const.PROJECT_NAME + @"\" + Const.SETTING_XML;

           XmlDocument xmlSerialisedForm = new XmlDocument();
           xmlSerialisedForm.Load(xmlPath);
           XmlNode topLevel = xmlSerialisedForm.ChildNodes[1];
           foreach (XmlNode node in topLevel.ChildNodes)
           {
               string result = findNode(node, Name);

               if ("" != result)
                   return result;
           }

           return "";
        }

        private static string findNode(XmlNode Node, string Name)
        {
            string controlName = Node.Attributes["Name"].Value;
            string controlType = Node.Attributes["Type"].Value;

            if (controlName == Name)
                return Node["Text"].InnerText;

            if (Node.HasChildNodes)
            {
                XmlNodeList xnlControls = Node.SelectNodes("Control");
                foreach (XmlNode node2 in xnlControls)
                {
                    string result = findNode(node2, Name);

                    if ("" != result)
                        return result;
                }
            }

            return "";

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelAddInDataOutput
{
    public class TableInfo
    {
        public string tableId;
        public string where;
        public string sql;

        public string tableName;

        public List<FieldInfo> FieldList = new List<FieldInfo>();

    }
}

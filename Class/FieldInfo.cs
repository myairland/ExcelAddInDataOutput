using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelAddInDataOutput
{
    public class FieldInfo
    {
        public string fieldId;
        public string fieldName;
        public bool? IsPrimaryKey;
        public bool? IsNullable;
        public string comment;
        public string type;
        public int? integerLength;
        public int? decLength;
        

    }
}

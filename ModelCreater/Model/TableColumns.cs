using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater.Model
{
    public class TableColumns
    {
        public string ColumnName { get; set; }
        public string Comment { get; set; }
        public bool IsNullable { get; set; }
        public string ColumnType { get; set; }
        public string DataType { get; set; }
        public int MaxLangth { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
    }
}

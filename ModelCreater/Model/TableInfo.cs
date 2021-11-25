using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater.Model
{
    public class TableInfo
    {
        [DisplayName("序号")]
        public int RowNum { get; set; }
        [DisplayName("表名")]
        public string TableName { get; set; }
        [DisplayName("注释")]
        public string Comment { get; set; }
    }
}

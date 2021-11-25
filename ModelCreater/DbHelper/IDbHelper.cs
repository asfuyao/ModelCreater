using ModelCreater.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater.DbHelper
{
    public interface IDbHelper
    {
        List<TableInfo> GetTableInfo();
        List<TableColumns> GetTableColumns(string tableName, bool useNullNumberType, bool useNullDateType, bool convertGuidString);
    }
}

using ModelCreater.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater.DbHelper
{
    public class MySqlHelper : IDbHelper
    {
        private string _ConnectionString;

        public MySqlHelper(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<TableColumns> GetTableColumns(string tableName, bool useNullNumberType, bool useNullDateType, bool convertGuidString)
        {
            throw new NotImplementedException();
        }

        public List<TableInfo> GetTableInfo()
        {
            throw new NotImplementedException();
        }
    }
}

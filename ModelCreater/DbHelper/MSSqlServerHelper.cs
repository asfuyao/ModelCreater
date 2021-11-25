using Dapper;
using ModelCreater.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelCreater.DbHelper
{
    public class MSSqlServerHelper : IDbHelper
    {
        private string _ConnectionString;
        private List<SqlTypeMap> _SqlTypeMaps;

        public MSSqlServerHelper(string ConnectionString)
        {
            _ConnectionString = ConnectionString;

            _SqlTypeMaps = FileHelper.LoadMapRulFile(Application.StartupPath + "\\SqlTypeMap\\MSSqlServerMap.txt");
        }
                
        /// <summary>
        /// 获取当前数据库所有表信息
        /// </summary>
        /// <returns></returns>
        public List<TableInfo> GetTableInfo()
        {
            try
            {
                string sqlstr = @"SELECT    ROW_NUMBER() OVER ( ORDER BY a.name ) AS RowNum, a.name AS TableName,
                                      CONVERT(NVARCHAR(100), ISNULL(g.[value], '')) AS Comment
                            FROM      sys.tables a
                            LEFT JOIN sys.extended_properties g ON( a.object_id = g.major_id
                                                                AND g.minor_id = 0 )
                            WHERE     a.name <> 'sysdiagrams'";
                using (IDbConnection connection = new SqlConnection(_ConnectionString))
                {
                    var data = connection.Query<TableInfo>(sqlstr);
                    return data != null ? data.ToList() : new List<TableInfo>();
                }
            }
            catch (Exception ex)
            {
                LogHelper.ShowLogMessage(ex.Message);
                return new List<TableInfo>();
            }
        }

        /// <summary>
        /// 获取表字段信息
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<TableColumns> GetTableColumns(string tableName, bool useNullNumberType, bool useNullDateType, bool convertGuidString)
        {
            try
            {
                string sqlstr = $@"SELECT c.name ColumnName, ISNULL(ds.value, N'') Comment, c.is_nullable IsNullable, ts.name AS ColumnType,
                                          c.max_length MaxLangth, c.precision Precision, c.scale Scale
                                FROM      sys.columns c
                                LEFT JOIN sys.extended_properties ds ON ds.major_id = c.object_id
                                                                    AND ds.minor_id = c.column_id
                                LEFT JOIN sys.types ts ON c.system_type_id = ts.system_type_id
                                                      AND ts.user_type_id = c.user_type_id
                                LEFT JOIN sys.tables tbs ON tbs.object_id = c.object_id
                                WHERE     tbs.name = '{tableName}'";

                using (IDbConnection connection = new SqlConnection(_ConnectionString))
                {
                    var data = connection.Query<TableColumns>(sqlstr);

                    if (data != null)
                    {
                        foreach (var item in data)
                        {
                            item.DataType = ConvertDataType(item.ColumnType, item.IsNullable, useNullNumberType, useNullDateType, convertGuidString);
                        }
                        return data.ToList();
                    }
                    else return new List<TableColumns>();
                }
            }
            catch (Exception ex)
            {
                LogHelper.ShowLogMessage(ex.Message);
                return new List<TableColumns>();
            }
        }

        /// <summary>
        /// sql数据类型转c#数据类型
        /// </summary>
        private string ConvertDataType(string sqlDataType, bool isNullable, bool useNullNumberType, bool useNullDateType, bool convertGuid2String)
        {
            string data_type = "object";
            string nullstr = isNullable ? "?" : "";

            var sqlTypeMap = _SqlTypeMaps.FirstOrDefault(t => t.SqlType == sqlDataType);

            if (sqlTypeMap != null)
            {
                data_type = sqlTypeMap.CSharpType;
                if (sqlTypeMap.SqlTypeCategory == 'n' && useNullNumberType) data_type += nullstr;
                else if (sqlTypeMap.SqlTypeCategory == 'd' && useNullDateType) data_type += nullstr;
                else if (sqlTypeMap.SqlType == "uniqueidentifier" && convertGuid2String) data_type = "string";
            }

            return data_type;
        }
    }
}

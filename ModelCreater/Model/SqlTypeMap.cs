using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater.Model
{
    /// <summary>
    /// 数据库和C#数据类型映射
    /// </summary>
    public class SqlTypeMap
    {
        /// <summary>
        /// SQL数据类型
        /// </summary>
        public string SqlType { get; set; }
        /// <summary>
        /// C#数据类型
        /// </summary>
        public string CSharpType { get; set; }
        /// <summary>
        /// SQL数据类型归类，s字符型、n数值型、d日期型、o其他
        /// </summary>
        public char SqlTypeCategory { get; set; }
    }
}

using ModelCreater.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCreater
{
    public class FileHelper
    {
        #region 写文件
        /// <summary>
        /// 写文件
        /// </summary>
        public static void WriteFile(string path, string str, string className)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = path + "\\" + className + ".cs";

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(str);
                    sw.Flush();
                }
            }
        }
        #endregion

        #region 读文件
        /// <summary>
        /// 读文件
        /// </summary>
        public static string ReadFile(string path)
        {
            string result = string.Empty;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }
        #endregion

        /// <summary>
        /// 加载sql数据类型映射文件
        /// </summary>
        /// <param name="mapRulFilePath"></param>
        /// <returns></returns>
        public static List<SqlTypeMap> LoadMapRulFile(string mapRulFilePath)
        {
            List<SqlTypeMap> sqlTypeMaps = new List<SqlTypeMap>();

            if (File.Exists(mapRulFilePath))
            {
                try
                {
                    var mapRuls = File.ReadAllLines(mapRulFilePath);
                    if (mapRuls != null)
                    {
                        foreach (var mapRul in mapRuls)
                        {
                            if (!string.IsNullOrEmpty(mapRul) && mapRul.Trim().Substring(0,1) != "#")
                            {
                                var rul = mapRul.Split(',');
                                if (rul.Length == 3)
                                {
                                    sqlTypeMaps.Add(new SqlTypeMap() { SqlType = rul[0], CSharpType = rul[1], SqlTypeCategory = rul[2][0] });
                                }
                            }
                        }
                    }
                }
                catch
                {
                    return sqlTypeMaps;
                }
            }

            return sqlTypeMaps;
        }
    }
}

using Dapper;
using ModelCreater.DbHelper;
using ModelCreater.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelCreater
{
    public partial class FrmMain : Form
    {
        private readonly string _ModelsPath = ConfigurationManager.AppSettings["ModelsPath"];

        private IDbHelper dbHelper;
        private int _Num = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tbNameSpace.Text = ConfigurationManager.AppSettings["NameSpace"];
            tbClassSuffix.Text = ConfigurationManager.AppSettings["ClassSuffix"];
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;

            Dictionary<string, string> dicDatabaseType = new Dictionary<string, string>();
            dicDatabaseType.Add("MSSqlServer", ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString());
            dicDatabaseType.Add("MySql", ConfigurationManager.ConnectionStrings["MySql"].ToString());
            dicDatabaseType.Add("Oracle", ConfigurationManager.ConnectionStrings["Oracle"].ToString());
            dicDatabaseType.Add("SQLite", ConfigurationManager.ConnectionStrings["SQLite"].ToString());
            cbDatabaseType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDatabaseType.DataSource = dicDatabaseType.ToList();
            cbDatabaseType.DisplayMember = "Key";
            cbDatabaseType.ValueMember = "Value";
            cbDatabaseType.SelectedIndex = -1;
            cbDatabaseType.SelectedIndexChanged += new EventHandler(cbDatabaseType_SelectedIndexChanged);

            dgTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            timer1.Enabled = true;
        }

        private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbConnectString.Text = cbDatabaseType.SelectedValue.ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDatabaseType.Text)) return;

            switch (cbDatabaseType.Text)
            {
                case "MSSqlServer":
                    dbHelper = new MSSqlServerHelper(tbConnectString.Text);
                    break;
                //case "MySql":
                //    dbHelper = new MySqlHelper(tbConnectString.Text);
                //    break;
                default:
                    return;
            }

            dgTables.DataSource = dbHelper.GetTableInfo();
        }

        private void BtnCreateModel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameSpace.Text))
            {
                MessageBox.Show("必须填写命名空间");
                return;
            }
            if (dgTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要生成Model的表");
                return;
            }

            Thread myThread = new Thread(new ThreadStart(() =>
            {
                string appStartupPath = Application.StartupPath;
                string strNamespace = tbNameSpace.Text;
                string strClassTemplate;
                string strFieldTemplate = string.Empty;
                Regex regField = new Regex(@"[ \t]*#field start([\s\S]*)#field end", RegexOptions.IgnoreCase);

                try
                {
                    //读模板
                    strClassTemplate = FileHelper.ReadFile(appStartupPath + "\\ModelTemplate.txt");
                    Match matchField = regField.Match(strClassTemplate);
                    if (matchField.Success)
                    {
                        strFieldTemplate = matchField.Groups[1].Value.TrimEnd(' ');
                    }


                    //获取选中表
                    List<TableInfo> tableInfos = new List<TableInfo>();
                    foreach (DataGridViewRow item in dgTables.SelectedRows)
                    {
                        tableInfos.Add(new TableInfo()
                        {
                            RowNum = int.Parse(item.Cells[0].Value.ToString()),
                            TableName = item.Cells[1].Value.ToString(),
                            Comment = item.Cells[2].Value.ToString(),
                        });
                    }

                    //初始化进度条
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = 0;
                        progressBar1.Maximum = tableInfos.Count;
                    }));

                    _Num = 0;

                    //遍历表
                    foreach (var item in tableInfos)
                    {
                        string tableComments = item.Comment; //表注释
                        string strClass = strClassTemplate.Replace("#table_comments", tableComments.Replace("\r\n", "\r\n    /// ").Replace("\n", "\r\n        /// "));
                        strClass = strClass.Replace("#name_space", strNamespace);
                        strClass = strClass.Replace("#table_name", item.TableName);
                        string strClassName = item.TableName + tbClassSuffix.Text; //类名
                        strClass = strClass.Replace("#class_name", strClassName);

                        //获取表字段
                        StringBuilder sbFields = new StringBuilder();
                        var tableColumns = dbHelper.GetTableColumns(item.TableName, cbUseNullNumberType.Checked, cbUseNullDateType.Checked, cbGuidConvertString.Checked);
                        foreach (var column in tableColumns)
                        {
                            string strField = strFieldTemplate.Replace("#field_comments", column.Comment.Replace("\r\n", "\r\n        /// ").Replace("\n", "\r\n        /// "));

                            strField = strField.Replace("#data_type", column.DataType);
                            strField = strField.Replace("#field_name", column.ColumnName);

                            sbFields.Append(strField);
                        }
                        strClass = regField.Replace(strClass, sbFields.ToString());

                        //生成model
                        FileHelper.WriteFile($"{appStartupPath}\\{_ModelsPath}", strClass, strClassName);

                        //增加进度
                        _Num++;

                    }
                    MessageBox.Show($"Model生成完毕，请查看{_ModelsPath}目录");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }));
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Invoke(new Action(() => progressBar1.Value = _Num));
        }
    }
}

namespace ModelCreater
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConnectString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BtnCreateModel = new System.Windows.Forms.Button();
            this.dgTables = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameSpace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClassSuffix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGuidConvertString = new System.Windows.Forms.CheckBox();
            this.cbUseNullDateType = new System.Windows.Forms.CheckBox();
            this.cbUseNullNumberType = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDatabaseType
            // 
            this.cbDatabaseType.FormattingEnabled = true;
            this.cbDatabaseType.Location = new System.Drawing.Point(125, 24);
            this.cbDatabaseType.Name = "cbDatabaseType";
            this.cbDatabaseType.Size = new System.Drawing.Size(245, 23);
            this.cbDatabaseType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库类型";
            // 
            // tbConnectString
            // 
            this.tbConnectString.Location = new System.Drawing.Point(125, 62);
            this.tbConnectString.Name = "tbConnectString";
            this.tbConnectString.Size = new System.Drawing.Size(834, 25);
            this.tbConnectString.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "连接串";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据表";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(965, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 25);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "连接数据库";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BtnCreateModel
            // 
            this.BtnCreateModel.Location = new System.Drawing.Point(965, 101);
            this.BtnCreateModel.Name = "BtnCreateModel";
            this.BtnCreateModel.Size = new System.Drawing.Size(121, 25);
            this.BtnCreateModel.TabIndex = 7;
            this.BtnCreateModel.Text = "生成Model";
            this.BtnCreateModel.UseVisualStyleBackColor = true;
            this.BtnCreateModel.Click += new System.EventHandler(this.BtnCreateModel_Click);
            // 
            // dgTables
            // 
            this.dgTables.AllowUserToAddRows = false;
            this.dgTables.AllowUserToDeleteRows = false;
            this.dgTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTables.Location = new System.Drawing.Point(0, 0);
            this.dgTables.Name = "dgTables";
            this.dgTables.ReadOnly = true;
            this.dgTables.RowHeadersWidth = 51;
            this.dgTables.RowTemplate.Height = 27;
            this.dgTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTables.Size = new System.Drawing.Size(1176, 438);
            this.dgTables.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "命名空间";
            // 
            // tbNameSpace
            // 
            this.tbNameSpace.Location = new System.Drawing.Point(126, 101);
            this.tbNameSpace.Name = "tbNameSpace";
            this.tbNameSpace.Size = new System.Drawing.Size(175, 25);
            this.tbNameSpace.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "类后缀";
            // 
            // tbClassSuffix
            // 
            this.tbClassSuffix.Location = new System.Drawing.Point(405, 101);
            this.tbClassSuffix.Name = "tbClassSuffix";
            this.tbClassSuffix.Size = new System.Drawing.Size(175, 25);
            this.tbClassSuffix.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGuidConvertString);
            this.panel1.Controls.Add(this.cbUseNullDateType);
            this.panel1.Controls.Add(this.cbUseNullNumberType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDatabaseType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbClassSuffix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbConnectString);
            this.panel1.Controls.Add(this.tbNameSpace);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.BtnCreateModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 200);
            this.panel1.TabIndex = 13;
            // 
            // cbGuidConvertString
            // 
            this.cbGuidConvertString.AutoSize = true;
            this.cbGuidConvertString.Location = new System.Drawing.Point(431, 143);
            this.cbGuidConvertString.Name = "cbGuidConvertString";
            this.cbGuidConvertString.Size = new System.Drawing.Size(166, 19);
            this.cbGuidConvertString.TabIndex = 15;
            this.cbGuidConvertString.Text = "Guid类型转为字符串";
            this.cbGuidConvertString.UseVisualStyleBackColor = true;
            // 
            // cbUseNullDateType
            // 
            this.cbUseNullDateType.AutoSize = true;
            this.cbUseNullDateType.Checked = true;
            this.cbUseNullDateType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseNullDateType.Location = new System.Drawing.Point(246, 143);
            this.cbUseNullDateType.Name = "cbUseNullDateType";
            this.cbUseNullDateType.Size = new System.Drawing.Size(149, 19);
            this.cbUseNullDateType.TabIndex = 14;
            this.cbUseNullDateType.Text = "使用可空日期类型";
            this.cbUseNullDateType.UseVisualStyleBackColor = true;
            // 
            // cbUseNullNumberType
            // 
            this.cbUseNullNumberType.AutoSize = true;
            this.cbUseNullNumberType.Location = new System.Drawing.Point(50, 143);
            this.cbUseNullNumberType.Name = "cbUseNullNumberType";
            this.cbUseNullNumberType.Size = new System.Drawing.Size(149, 19);
            this.cbUseNullNumberType.TabIndex = 13;
            this.cbUseNullNumberType.Text = "使用可空数值类型";
            this.cbUseNullNumberType.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgTables);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 438);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 35);
            this.panel3.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1176, 35);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model创建工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTables)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabaseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConnectString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button BtnCreateModel;
        private System.Windows.Forms.DataGridView dgTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClassSuffix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbGuidConvertString;
        private System.Windows.Forms.CheckBox cbUseNullDateType;
        private System.Windows.Forms.CheckBox cbUseNullNumberType;
    }
}


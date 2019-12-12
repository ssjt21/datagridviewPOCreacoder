using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.InteropServices;





namespace PocExpRecoder
{
    public partial class Form1 : Form
    {

        // 全局配置
        public GlobalConfig gConfig = new GlobalConfig();
        //应用程序配置文件
        public static string  confFile = Application.StartupPath + @"\conf\" + @"\application.conf";
        public const byte vbKeyDelete = 0x2E;    // Delete 键
        //表结构设计
        private static string table_sql = @"
        CREATE TABLE IF NOT EXISTS POCCVEInfo(
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        cveNo VARCHAR(32),
        VulnName NVARCHAR(256),
        VulnType NVARCHAR(256),
        VulnPlatform NVARCHAR(256),
        ExpOrPocAddr NVARCHAR(512),
        VersionIllustrate NVARCHAR(512),
        Illustrate NVARCHAR(512),
        username VARCHAR(32),
        email NVARCHAR(64)
)
";
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        private string t_name = "POCCVEInfo";
        private SQLiteConnection conn=null;
        //[DllImport("user32.dll")];
        private SQLiteDataAdapter mAdapter = null;
        private DataSet ds = new DataSet();
        //private DataTable dt = null;
     

        public Form1()
        {
            InitializeComponent();
            //dt = new DataTable(this.t_name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitConfigEnv();
            CveDataGridView.RowHeadersVisible = false;



        }
        //加载配置文件./conf/application.conf
        private void InitConfigEnv()
        {
            string confDir = Application.StartupPath + @"\conf\";
            string confFile = confDir + @"\application.conf";
            //如果文件夹不存在就创建conf文件夹
           if ( Directory.Exists(confDir)==false)
            {
                Directory.CreateDirectory(confDir);
            }
            //如果conf文件夹下没有application.conf配置文件就创建配置文件
            if (File.Exists(confFile) == false)
            {
                //创建json配置文件并写入默认配置
                CeateConfFile(confFile);
            }
            //读取配置文件 application.conf将数据加载到应用程序中
            LoadConfig(confFile);
            // 判断数据库文件存在不存在，如果不存在就创建数据库文件，存在就
            CreateDB();
            //初始化数据
            SelectAll();

        }
        //创建json 应用程序配置文件
        public void CeateConfFile(string configFile)
        {
            //创建json对象
            //JObject jsonObj = new JObject();

            //GlobalConfig gConfig = new GlobalConfig();
            

            //获取默认的sqlite文件配置
            gConfig.SqliteFilePath = Application.StartupPath + @"/db/sqlite_data.db";

            //用户信息配置（姓名，邮箱）
            this.gConfig.UserConfig = new Dictionary<string, string>();
            gConfig.UserConfig.Add("username","");
            gConfig.UserConfig.Add("email", "");

            string jsonConfig = JsonConvert.SerializeObject(gConfig);
            //MessageBox.Show(str);
            if (!File.Exists(configFile))
            {
                FileStream AppConfigf = new FileStream(configFile, FileMode.Create, FileAccess.ReadWrite);
                AppConfigf.Close();
            }
            //写入json配置数据
            File.WriteAllText(configFile, jsonConfig);
           // return gConfig;

        }
        // 加载配置文件
        public void LoadConfig(string configFile)
        {
            string jsonStr = File.ReadAllText(configFile);
            this.gConfig = (GlobalConfig)JsonConvert.DeserializeObject(jsonStr,typeof(GlobalConfig));
        }
        // 写入更新的配置文件
        public void UpdateConfig(Dictionary<string,object> gconfig)
        {
            Type t = this.gConfig.GetType();
            //object obj = Activator.CreateInstance(t);
            
            foreach(var item in gconfig)
            {
                try
                {
                    //FieldInfo field = t.GetField(item.Key);
                    //field.SetValue(obj,item.Value);
                    PropertyInfo propertyInfo = t.GetProperty(item.Key);//获取属性
                    propertyInfo.SetValue(this.gConfig,item.Value);//设置属性
                   // MessageBox.Show(item.Key, item.Value);

                }
                 catch(Exception)
                {

                }
                //PropertyInfo field=t.GetProperty(item.Key)
                
            }
            string jsonConfig = JsonConvert.SerializeObject(this.gConfig);
            File.WriteAllText(Form1.confFile, jsonConfig);
            //MessageBox.Show(this.gConfig.ToString());
        }

        //数据库初始化
        private void CreateDB()
        {
            string dbfile = this.gConfig.SqliteFilePath;
            //MessageBox.Show(dbfile);
            //if (File.Exists(dbfile) && dbfile!="")
            //{
              //  return;
           // }
            if(dbfile=="")
            {
                dbfile = Application.StartupPath + @"\db\sqlite_data.db";
                this.gConfig.SqliteFilePath = dbfile;
                Dictionary<string, object> config = new Dictionary<string, object>();
                config.Add("SqliteFilePath", dbfile);
                UpdateConfig(config);
            }
            

            if (!File.Exists(dbfile))
            {
               // MessageBox.Show("111");
              //如果文件夹不存在就创建db文件夹
                string dbDir = Path.GetDirectoryName(dbfile);
                if (Directory.Exists(dbDir) == false)
                {
                    Directory.CreateDirectory(dbDir);
                }
                FileStream AppConfigf = new FileStream(dbfile, FileMode.Create, FileAccess.ReadWrite);
                AppConfigf.Close();
              
            }
            SQLiteConnection con = new SQLiteConnection("data source=" + dbfile);
            con.Open();
            //创建表
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = Form1.table_sql;
            cmd.ExecuteNonQuery();
            this.conn = con;
           
        }
        //读取数据库数据加载数据到控件中

        private void SelectAll()
        {
            if (this.conn != null)
            {
                //SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from " + this.t_name, this.conn);
                this.mAdapter = new SQLiteDataAdapter("select * from " + this.t_name, this.conn);
                //DataTable dt = new DataTable();
                //DataSet ds = new DataSet();
                //ds.Tables.Add(this.dt);
                ds.Tables.Clear();
                this.mAdapter.Fill(ds,t_name);
                
                CveDataGridView.DataSource = ds.Tables[0];
                CveDataGridView.FirstDisplayedScrollingRowIndex = CveDataGridView.Rows.Count - 1;
            }

            //MessageBox.Show("9999");


        }

        private void AboutStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "该程序为Topsec安服人员登记CVE信息使用！","关于");
        }

        private void VersionUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前软件暂不支持在线自动更新", "更新");
        }

        private void VersionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CVE登记工具 Version 1.0 2019/04/02", "版本信息");
        }

        private void BugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bug和意见反馈请发送至邮箱:\t\n\n\twang_di@topsec.com.cnt\n\n\t谢谢！\t", "意见反馈");
        }

        //显示sqlite文件配置窗口
        private void SQLiteConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //创建二级窗口对象
            FormSQLiteConfig f = new FormSQLiteConfig(this);
            //指定当前二级窗口的父窗口
            //f.Owner = this;
            //指定窗口显示的位置为父窗口的中间位置
            f.StartPosition = FormStartPosition.CenterParent;

            //订阅事件
            f.ConfigChange_even += new FormSQLiteConfig.ConfigChange(UpdateConfig);


            f.ShowDialog();
          
            //或者通过下面的这种方式指定父窗口
            //f.ShowDialog(this);
            
            //Form1 manform = new Form1();

        }

        private void UserConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建用户配置窗口
            FormUserConfig f = new FormUserConfig(this);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ConfigChange_even += new FormUserConfig.ConfigChange(UpdateConfig);
            f.ShowDialog();

        }

        private void CveDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭数据库连接
            if(this.conn!=null)
            {
                this.conn.Close();
            }
            
        }

        private void CveDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(e.RowIndex>=0)
                {
                    CveDataGridView.ClearSelection();
                    CveDataGridView.Rows[e.RowIndex].Selected = true;

                }

                DataGridcontextMenuStrip.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();

        }

        private void CveDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F5:
                    SelectAll();
                    
                    break;
                case Keys.Delete:
                    DialogResult result;
                    result=MessageBox.Show("确定要删除！"+"ID="+CveDataGridView.Rows[CveDataGridView.CurrentRow.Index].Cells["ID"].Value, "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if(result!=DialogResult.OK)
                    {
                        CveDataGridView.ClearSelection();
                    }
                    else
                    {
                        try
                        {
                            this.ds.AcceptChanges();
                            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(this.mAdapter);

                            ds.Tables[0].Rows[CveDataGridView.CurrentRow.Index].Delete();

                            // dt.Rows[CveDataGridView.CurrentRow.Index].Delete();
                            this.mAdapter.DeleteCommand = scb.GetDeleteCommand();

                            this.mAdapter.Update(ds, this.t_name);
                            CveDataGridView.ClearSelection();
                        }
                        catch(Exception)
                        {

                        }
                        
                    }
                    
                    break;
            }
        }

        private void CveDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(vbKeyDelete,0,0,0);//模拟按下delete键操作
        }

    
  

        private void CveDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SQLiteCommandBuilder scb = new SQLiteCommandBuilder(mAdapter);
                mAdapter.UpdateCommand = scb.GetUpdateCommand();
                mAdapter.Update(ds, t_name);
                //SelectAll();
                //CveDataGridView.Rows[CveDataGridView.Rows.Count - 1].Selected = true;
            }
            catch(Exception)
            {

            }
            
        }

        private void CveDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["username"].Value = gConfig.UserConfig["username"];
            e.Row.Cells["email"].Value = gConfig.UserConfig["email"];

        }

        private void CveDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(mAdapter);
            mAdapter.InsertCommand = scb.GetInsertCommand();
            mAdapter.Update(ds, t_name);
            CveDataGridView.ClearSelection();
        }
    }

    public class GlobalConfig
    {
        private string sqliteFilePath="";
        private Dictionary<string, string> userConfig ;
        [DefaultValue("")]
        [JsonProperty("SqliteFilePath")]
        public string SqliteFilePath
        {
            get;set;
            /*
            get
            {
                return sqliteFilePath;
            }
            set
            {
                sqliteFilePath = value;
            }*/
            
        }
        [DefaultValue(null)]
        [JsonProperty("UserConfig")]
        public Dictionary<string,string> UserConfig
        {
            get;set;
            /*
            get { return userConfig; }
            set { userConfig = value; }*/
        }

    }
}

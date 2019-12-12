using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//用于配置文件解析
using Newtonsoft.Json;

namespace PocExpRecoder
{
    public partial class FormSQLiteConfig : Form
    {

        public FormSQLiteConfig(Form1 form1)
        {
            InitializeComponent();
            txtBoxSQLiteConfig.Text = form1.gConfig.SqliteFilePath;
          
            
        }
        public delegate void ConfigChange(Dictionary<string, object> gconfig);
        public event ConfigChange ConfigChange_even;

     


        private void btnChangeSQLite_Click(object sender, EventArgs e)
        {
            OpenFileDialog sqliteFileDlg = new OpenFileDialog();
            //设定打开路径为程所在文件夹下的db文件夹
            sqliteFileDlg.InitialDirectory = Application.StartupPath+@"\db";
            //设置显示的过滤规则
            sqliteFileDlg.Filter = "SQLite文件(*.db;*.sqlite)|*.db;*.sqlite|所有文件|*.*";
            //检查文件有效
            sqliteFileDlg.ValidateNames = true;
            sqliteFileDlg.CheckPathExists = true;
            sqliteFileDlg.CheckFileExists = true;
            if(sqliteFileDlg.ShowDialog()==DialogResult.OK)
            {
                txtBoxSQLiteConfig.Text = sqliteFileDlg.FileName;
            }


        }

        public void txtBoxSQLiteConfig_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, object> sqliteconfig = new Dictionary<string, object>();
            sqliteconfig.Add("SqliteFilePath", txtBoxSQLiteConfig.Text);
            if(ConfigChange_even!=null)//这里必须判断。是个大坑
            {
                ConfigChange_even(sqliteconfig);
            }
            
        }
    }
}

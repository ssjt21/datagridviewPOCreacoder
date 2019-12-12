using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocExpRecoder
{
    public partial class FormUserConfig : Form
    {
        public FormUserConfig(Form1 form1)
        {
            InitializeComponent();
            textBoxName.Text = form1.gConfig.UserConfig["username"];
            textBoxEmail.Text = form1.gConfig.UserConfig["email"];

        }
        public delegate void ConfigChange(Dictionary<string, object> gconfig);
        public event ConfigChange ConfigChange_even;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = false;
            textBoxName.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = true;
            textBoxName.ReadOnly = true;
            Dictionary<string, string> configVal = new Dictionary<string, string>();
            configVal.Add("username", textBoxName.Text);
            configVal.Add("email", textBoxEmail.Text);
            Dictionary<string, object> userconfig = new Dictionary<string, object>();
            userconfig.Add("UserConfig",configVal );
            if (ConfigChange_even != null)//这里必须判断。是个大坑
            {
                ConfigChange_even(userconfig);
            }
            


        }
    }
}

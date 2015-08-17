using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS
{
    public partial class Login : Form
    {
        public static string right;
        public static string name;        //记录登录用户名字
        public static string pwd;         //记录登录用户密码
        BaseClass.DataBaseConnection datacon = new EmployeeIMS.BaseClass.DataBaseConnection();
        BaseClass.DataOperate doperate = new EmployeeIMS.BaseClass.DataOperate();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            doperate.cboxBind("select a_Name From AdministerInfo", "AdministerInfo", "a_Name", comboBoxUName);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int returnValue = doperate.userLogin(comboBoxUName.Text.Trim(), textUPWD.Text.Trim());
            if (100 == returnValue)
            {
                MainForm mainForm = new MainForm();
                name = comboBoxUName.Text.Trim();
                pwd = textUPWD.Text.Trim();
                this.Hide();
                mainForm.Show();
            }
            else if (-100 == returnValue)
            {
                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUPWD.Text = "";
                //comboBoxUName.Focus();
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxUName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader sqlRead = datacon.getRead("Select a_Name,a_Authority From AdministerInfo Where a_Name='" +
                                       comboBoxUName.Text.Trim() +"'");
            if (sqlRead.Read())
            {
                labelRight.Text = sqlRead["a_Authority"].ToString();
                right = labelRight.Text;
                
            }

        }

        private void textUPWD_TextChanged(object sender, EventArgs e)
        {
            //从数据库中读取密码
            DataSet ds =datacon.getDataSets("Select a_Password From AdministerInfo Where a_Name='" + comboBoxUName.Text.Trim() +"'","AdministerInfo");
            //如果输入的密码长度 等于 真正的密码 登陆按钮获得焦点
            if(textUPWD.Text.Trim().Length == ds.Tables[0].Rows[0][0].ToString().Length )
            {
                btnLogin.Focus();
            }
        }
       
    }
}

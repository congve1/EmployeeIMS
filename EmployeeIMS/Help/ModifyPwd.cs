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

namespace EmployeeIMS.Help
{
    public partial class ModifyPwd : Form
    {
        public ModifyPwd()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataBaseConnection con = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void ModifyPwd_Load(object sender, EventArgs e)
        {
            txtUserName_Mp.Text = EmployeeIMS.Login.name;
        }

        private void btnExit_MP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MoifyPwd_FormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnsure_MP_Click(object sender, EventArgs e)
        {
            SqlDataReader pwd = con.getRead("Select a_Name,a_Password From AdministerInfo Where a_Name='" +
                                            txtUserName_Mp.Text.Trim()+"'");
            string oldPassword = "";
            if(pwd.Read())
                oldPassword = pwd["a_Password"].ToString();
            if (txtNewPwd_MP.Text.Trim() != txtVerfyPwd_MP.Text.Trim())
            {
                errorProvider1.SetError(txtVerfyPwd_MP, "输入密码不一致");
            }
            else if (txtOldPwd_MP.Text.Trim() != oldPassword)
            {
                MessageBox.Show("用户旧密码输入错误，请重新输入！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPwd_MP.Text = "";
            }
            else
            {
                con.executeSQLCommand("update AdministerInfo set a_Password='" + txtNewPwd_MP.Text.Trim() + "'where a_Name='" + txtUserName_Mp.Text.Trim() + "'");
                
                if (MessageBox.Show("密码修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}

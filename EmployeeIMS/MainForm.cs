using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeIMS.Help;
using EmployeeIMS.ManageInfo;
using EmployeeIMS.SearchInfo;
using EmployeeIMS.SystemManage;
namespace EmployeeIMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentTime.Text += DateTime.Today.ToLongDateString();
            loginTime.Text += DateTime.Now.ToShortTimeString();
            labelCRight.Text += Login.right;
            if (Login.right == "普通用户" )
            {
                员工信息管理ToolStripMenuItem.Enabled = false;
                部门信息管理ToolStripMenuItem.Enabled = false;
                btnMEmployeeInfo.Enabled = false;
                btnMDepartmentInfo.Enabled = false;
                用户管理ToolStripMenuItem.Enabled = false;
                btnUsersM.Enabled = false;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("您真的要退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MainForm fmain = new MainForm();
                fmain.Show();
            }
        }

        private void btnChangePWD_Click(object sender, EventArgs e)
        {
            ModifyPwd modifyPwd = new ModifyPwd();
            modifyPwd.ShowDialog();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChangePWD_Click(sender, e);
        }

        private void btnUsersM_Click(object sender, EventArgs e)
        {
            UsersManage users = new UsersManage();
            users.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUsersM_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DataStore dataStore = new DataStore();
            dataStore.ShowDialog();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSaveData_Click(sender, e);
        }

        private void btnReturnData_Click(object sender, EventArgs e)
        {
            DataRevert dataRevert = new DataRevert();
            dataRevert.ShowDialog();
        }

        private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReturnData_Click(sender, e);
        }

        private void btnPressData_Click(object sender, EventArgs e)
        {
            DataPress dataPress = new DataPress();
            dataPress.ShowDialog();
        }

        private void 数据压缩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPressData_Click(sender, e);
        }

        private void btnSDepartment_Click(object sender, EventArgs e)
        {
            SearchDeparmentInfo depaInfo = new SearchDeparmentInfo();
            depaInfo.ShowDialog();
        }

        private void 部门信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSDepartment_Click(sender, e);
        }

        private void btnSEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployeeInfo employeeInfo = new SearchEmployeeInfo();
            employeeInfo.ShowDialog();
        }

        private void 员工信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSEmployee_Click(sender, e);
        }

        private void btnCEmployee_Click(object sender, EventArgs e)
        {
            SearchSalaryInfo employeCount = new SearchSalaryInfo();
            employeCount.ShowDialog();
        }

        private void 员工信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCEmployee_Click(sender, e);
        }

        private void btnMEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeManage employeeManage = new EmployeeManage();
            employeeManage.ShowDialog();
        }

        private void 员工信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMEmployeeInfo_Click(sender, e);
        }

        private void btnMDepartmentInfo_Click(object sender, EventArgs e)
        {
            DepartmentManage departmentManage = new DepartmentManage();
            departmentManage.ShowDialog();
        }

        private void 部门信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMDepartmentInfo_Click(sender, e);
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void 系统维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void 信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

     
    }
}

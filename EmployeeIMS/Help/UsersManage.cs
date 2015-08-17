using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.Help
{
    public partial class UsersManage : Form
    {
        public UsersManage()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataBaseConnection con = new EmployeeIMS.BaseClass.DataBaseConnection();
        EmployeeIMS.BaseClass.DataOperate dataOp = new 
            EmployeeIMS.BaseClass.DataOperate();
        private void UsersManage_Load(object sender, EventArgs e)
        {
            DataSet myds = con.getDataSets("Select a_ID As 用户ID, a_Name As 用户名, a_Password As 用户密码, a_Authority As 用户权限 From AdministerInfo ", "AdministerInfo");
            dgUsersInfo_UM.DataSource = myds.Tables["AdministerInfo"];
            dataOp.cboxBind("Select a_Name From AdministerInfo", "AdministerInfo", "a_Name", cmbUName_UM);
        }


        private void UsersManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_UM_Click(object sender, EventArgs e)
        {
            try
            {
                int rValue = dataOp.InsertUser(cmbUName_UM.Text.Trim(), txtPwd_UM.Text.Trim(),
                                                 cmbAuthority_UM.Text.Trim());
                if (rValue == 100)
                {
                    MessageBox.Show("该用户已经存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("用户信息添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsersManage_Load(sender, e);//更新DataGridView中的内容
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMd_UM_Click(object sender, EventArgs e)
        {
            try
            {
                dataOp.updateUser(Convert.ToInt32(dgUsersInfo_UM[0, dgUsersInfo_UM.CurrentCell.RowIndex].Value),
                                   txtPwd_UM.Text.Trim(), cmbAuthority_UM.Text.Trim());
                MessageBox.Show("用户信息修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsersManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_UM_Click(object sender, EventArgs e)
        {
            try
            {
                con.executeSQLCommand("delete From AdministerInfo Where a_ID = "+
                                       Convert.ToString(dgUsersInfo_UM[0,dgUsersInfo_UM.CurrentCell.RowIndex].Value).Trim()
                                      +"");

                MessageBox.Show("删除用户信息成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsersManage_Load(sender, e);//更新DataGridView中的数据
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgUsersInfo_UM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbUName_UM.Text = Convert.ToString(dgUsersInfo_UM[1, dgUsersInfo_UM.CurrentCell.RowIndex].Value).Trim();
            txtPwd_UM.Text = Convert.ToString(dgUsersInfo_UM[2, dgUsersInfo_UM.CurrentCell.RowIndex].Value).Trim();
            cmbAuthority_UM.Text = Convert.ToString(dgUsersInfo_UM[3, dgUsersInfo_UM.CurrentCell.RowIndex].Value).Trim();
        }
    }
}

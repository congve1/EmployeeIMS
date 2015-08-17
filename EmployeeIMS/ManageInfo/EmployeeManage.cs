using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.ManageInfo
{
    public partial class EmployeeManage : Form
    {
        public EmployeeManage()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataOperate dataOp = new
          EmployeeIMS.BaseClass.DataOperate();
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void EmployeeManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_EM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            cmbEID_EM.Text = "";
            txtEName_EM.Text = "";
            cmbESex_EM.Text = "";
            dtBorn_EM.Text = "";
            cmbEMarriage_EM.Text = "";
            cmbStatus_EM.Text = "";
            txtEEdu_EM.Text = "";
            dtEnroll_EM.Text = "";
            dtInDue_EM.Text = "";
            txtEDuty_EM.Text = "";
            cmbEEstate_EM.Text = "";
            txtRemark_EM.Text = ""; 
            DataSet ds = dataCon.getDataSets("Select e_ID As '员工编号', e_Name As '姓名',e_Sex As '性别', e_BornDate As '出生日期',"
	                                           +"e_Marriage As '婚姻状况', e_Status As '政治面貌', e_Education As '学历',"+
	                                            "e_EnrollDate As '入厂日期', e_InDueFormDate As '转正日期',e_Duty As '职务',"+
	                                            "e_Estate As '在职否', E_Remark As '备注' From EmployeeInfo", "EmployeeInfo");
            dgEmInfo_EM.DataSource = ds.Tables["EmployeeInfo"];
            dataOp.cboxBind("Select e_ID From EmployeeInfo","EmployeeInfo","e_ID",cmbEID_EM);
        }

        private void dgEmInfo_EM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbEID_EM.Text = Convert.ToString(dgEmInfo_EM[0,dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            txtEName_EM.Text = Convert.ToString(dgEmInfo_EM[1, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            cmbESex_EM.Text = Convert.ToString(dgEmInfo_EM[2, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            dtBorn_EM.Text = Convert.ToString(dgEmInfo_EM[3, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            cmbEMarriage_EM.Text = Convert.ToString(dgEmInfo_EM[4, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            cmbStatus_EM.Text = Convert.ToString(dgEmInfo_EM[5, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            txtEEdu_EM.Text = Convert.ToString(dgEmInfo_EM[6, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            dtEnroll_EM.Text = Convert.ToString(dgEmInfo_EM[7, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            dtInDue_EM.Text = Convert.ToString(dgEmInfo_EM[8, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            txtEDuty_EM.Text = Convert.ToString(dgEmInfo_EM[9, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            cmbEEstate_EM.Text = Convert.ToString(dgEmInfo_EM[10, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim();
            txtRemark_EM.Text = Convert.ToString(dgEmInfo_EM[11, dgEmInfo_EM.CurrentCell.RowIndex].Value).Trim(); 
        }

        private void btnDel_EM_Click(object sender, EventArgs e)
        {
            try
            {
                dataCon.executeSQLCommand("Delete From EmployeeInfo Where e_ID = " + cmbEID_EM.Text.Trim() + "");
                MessageBox.Show("员工信息删除成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnModify_EM_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("asdfasdf");
                Console.WriteLine(dtBorn_EM.Value.ToString("yyyy/MM/dd hh:mm:ss"));
                dataCon.executeSQLCommand("Update EmployeeInfo set e_Name='" + txtEName_EM.Text.Trim() +"'," +
                                            "e_Sex='" + cmbESex_EM.Text.Trim() + "'," + "e_BornDate='" + dtBorn_EM.Value.ToString("yyyy/MM/dd hh:mm:ss") + "',"
                                            + "e_Marriage='"+cmbEMarriage_EM.Text.Trim()+"',"+
                                            "e_Status='"+cmbStatus_EM.Text.Trim()+"',"+
                                            "e_Education='"+txtEEdu_EM.Text.Trim()+"',"+
                                            "e_EnrollDate='" + dtEnroll_EM.Value.ToString("yyyy/MM/dd hh:mm:ss") + "'," +
                                            "e_InDueFormDate='" + dtInDue_EM.Value.ToString("yyyy/MM/dd hh:mm:ss") + "'," +
                                            "e_Duty='"+txtEDuty_EM.Text.Trim()+"',"+
                                            "e_Estate='"+cmbEEstate_EM.Text.Trim()+"',"+
                                            "e_Remark='"+txtRemark_EM.Text.Trim()+"' Where e_ID="+cmbEID_EM.Text.Trim());
                MessageBox.Show("员工信息修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_EM_Click(object sender, EventArgs e)
        {
            try
            {
                dataCon.executeSQLCommand("Insert Into EmployeeInfo Values('"+txtEName_EM.Text.Trim()+"','"+
                                            cmbESex_EM.Text.ToString().Trim() + "','" +
                                             dtBorn_EM.Value.ToString("yyyy/MM/dd hh:mm:ss")+"','"+
                                             cmbEMarriage_EM.Text.ToString().Trim()+"','"+
                                             cmbStatus_EM.Text.ToString().Trim()+"','"+
                                             txtEEdu_EM.Text.ToString().Trim() +"','"+
                                             dtEnroll_EM.Value.ToString("yyyy/MM/dd hh:mm:ss")+"','"+
                                             dtInDue_EM.Value.ToString("yyyy/MM/dd hh:mm:ss")+"',"+
                                             "1,'"+ txtEDuty_EM.Text.ToString().Trim()+ "','"+
                                            cmbEEstate_EM.Text.ToString().Trim()+"','"+
                                            txtRemark_EM.Text.ToString().Trim()+"')");
                MessageBox.Show("员工信息添加成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeManage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

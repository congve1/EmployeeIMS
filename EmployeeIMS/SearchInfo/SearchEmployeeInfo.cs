using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.SearchInfo
{
    public partial class SearchEmployeeInfo : Form
    {
        public SearchEmployeeInfo()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataOperate dataOp = new EmployeeIMS.BaseClass.DataOperate();
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void SearchEmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_SE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchEmployeeInfo_Load(object sender, EventArgs e)
        {
            DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
            "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
            "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo e", "EmployeeInfo");

            dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];

        }

        private void dgDataE_SE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_SE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbSCondition_SE.Text.Trim()))
            {
                SearchEmployeeInfo_Load(sender, e);
            }
            else if (cmbSCondition_SE.Text.Trim() == "员工姓名")
            {
                DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
           "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
           "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo  e "
           + "Where e.e_Name = '"+txtSKWords_SE.Text.Trim() +"'", "EmployeeInfo");

                dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];
            }
            else if (cmbSCondition_SE.Text.Trim() == "性别")
            {
                DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
           "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
           "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo  e "
           + "Where e.e_Sex = '" + txtSKWords_SE.Text.Trim() + "'", "EmployeeInfo");

                dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];
            }
            else if (cmbSCondition_SE.Text.Trim() == "婚姻状况")
            {
                DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
           "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
           "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo  e "
           + "Where e.e_Marriage = '" + txtSKWords_SE.Text.Trim() + "'", "EmployeeInfo");

                dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];
            }
            else if (cmbSCondition_SE.Text.Trim() == "政治面貌")
            {
                DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
           "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
           "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo  e "
           + "Where e.e_Status = '" + txtSKWords_SE.Text.Trim() + "'", "EmployeeInfo");

                dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];
            }
            else if (cmbSCondition_SE.Text.Trim() == "职务")
            {
                DataSet ds = dataCon.getDataSets("SELECT  e.e_ID As '员工编号',e.e_Name As '员工姓名'," +
           "e.e_Sex As '性别', e.e_BornDate As '出生日期', e.e_Marriage As '婚姻状况' ,e.e_Status As '政治面貌'," +
           "e.e_EnrollDate As '入场日期',e.e_InDueFormDate As '转正日期',e.e_Duty As '职务',e.e_Estate ,e.e_Remark As '备注' FROM  EmployeeInfo  e "
           + "Where e.e_Duty = '" + txtSKWords_SE.Text.Trim() + "'", "EmployeeInfo");

                dgDataE_SE.DataSource = ds.Tables["EmployeeInfo"];
            }
            txtSKWords_SE.Text = "";
        }
    }
}

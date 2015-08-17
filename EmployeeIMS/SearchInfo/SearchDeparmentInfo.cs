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
    public partial class SearchDeparmentInfo : Form
    {
        public SearchDeparmentInfo()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataOperate dataOp = new EmployeeIMS.BaseClass.DataOperate();
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void SearchDeparmentInfo_Load(object sender, EventArgs e)
        {
            DataSet myDs = dataCon.getDataSets("Select d_ID As 部门编号, d_Name As 部门名称,d_Number As 部门人数 From DepartmentInfo", "DepartmentInfo");
            dgDataD_SD.DataSource = myDs.Tables["DepartmentInfo"];
        }

        private void SearchDeparmentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_SD_Click(object sender, EventArgs e)
        {
            try
            {
                if ("" == cmbSCondition_SD.Text.Trim())
                {
                    SearchDeparmentInfo_Load(sender, e);//更新数据
                }
                //按条件查询
                else if (cmbSCondition_SD.Text.Trim() == "部门编号")
                {
                    DataSet myDs = dataCon.getDataSets("Select d_ID As 部门编号, d_Name As 部门名称,d_Number As 部门人数 From DepartmentInfo"+
                        " Where d_ID = " + txtSKWords_SD.Text.Trim()+"", "DepartmentInfo");//获得数据集合
                    dgDataD_SD.DataSource = myDs.Tables["DepartmentInfo"];//更新数据
                }
                else if (cmbSCondition_SD.Text.Trim() == "部门名称")
                {
                    DataSet myDs = dataCon.getDataSets("Select d_ID As 部门编号, d_Name As 部门名称,d_Number As 部门人数 From DepartmentInfo" +
                        " Where d_Name = '" + txtSKWords_SD.Text.Trim() + "'", "DepartmentInfo");
                    dgDataD_SD.DataSource = myDs.Tables["DepartmentInfo"];
                }
                else if (cmbSCondition_SD.Text.Trim() == "部门人数")
                {
                    DataSet myDs = dataCon.getDataSets("Select d_ID As 部门编号, d_Name As 部门名称,d_Number As 部门人数 From DepartmentInfo" +
                        " Where d_Number = " + txtSKWords_SD.Text.Trim() + "", "DepartmentInfo");
                    dgDataD_SD.DataSource = myDs.Tables["DepartmentInfo"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgDataD_SD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

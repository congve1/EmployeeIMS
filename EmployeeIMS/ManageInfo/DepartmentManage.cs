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
    public partial class DepartmentManage : Form
    {
        public DepartmentManage()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataOperate dataOp = new
          EmployeeIMS.BaseClass.DataOperate();
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void DepartmentManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_DM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentManage_Load(object sender, EventArgs e)
        {
            DataSet myDs = dataCon.getDataSets("Select d_ID As 部门编号, d_Name As 部门名称,d_Number As 部门人数 From DepartmentInfo", "DepartmentInfo");
            dgDInfo_DM.DataSource = myDs.Tables["DepartmentInfo"];
            dataOp.cboxBind("Select d_Name From DepartmentInfo", "DepartmentInfo", "d_Name", cmbDName_DM);
        }

        private void dgDInfo_DM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgDInfo_DM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDNumber_DM.Text = Convert.ToString(dgDInfo_DM[2, dgDInfo_DM.CurrentCell.RowIndex].Value);
            cmbDName_DM.Text = Convert.ToString(dgDInfo_DM[1, dgDInfo_DM.CurrentCell.RowIndex].Value);
        }
    }
}

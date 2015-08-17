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
    public partial class SearchSalaryInfo : Form
    {
        public SearchSalaryInfo()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeInfoCount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeInfoCount_Load(object sender, EventArgs e)
        {
            DataSet ds = dataCon.getDataSets("Select * From EmployeeInfo","EmployeeInfo");
            textBox1.Text = ds.Tables[0].Rows.Count.ToString();
        }
    }
}

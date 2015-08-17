using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.SystemManage
{
    public partial class DataRevert : Form
    {
        public DataRevert()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void DataRevert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_DR_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            txtPath_DR.Text = openFileDialog1.FileName.ToString().Trim();
        }

        private void btnRevert_DR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPath_DR.Text.Trim()))
            {
                MessageBox.Show("请选择还原路径！");
                return;
            }
            try
            {
                dataCon.executeSQLCommand("use master restore database EmployeeIMS from disk='" + txtPath_DR.Text.Trim() + "'");
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}

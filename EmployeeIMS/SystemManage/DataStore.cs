using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.SystemManage
{
    public partial class DataStore : Form
    {
        public DataStore()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void DataStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_DS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSP_DS_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath_DS.Text = folderBrowserDialog1.SelectedPath.ToString().Trim()+"\\";
        }

        private void btnStore_DS_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPath_DS.Text.Trim()))
            {
                MessageBox.Show("请选择备份路径！");
                return;
            }
            try
            {
                if (File.Exists(txtPath_DS.Text.Trim() + "_DSbackup"))
                {
                    MessageBox.Show("该文件已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPath_DS.Text = "";
                    txtPath_DS.Focus();
                }
                else
                {
                    dataCon.executeSQLCommand("backup database EmployeeIMS to disk='"
                                               + txtPath_DS.Text.Trim() + "_DSbackup'");
                    MessageBox.Show("数据备份成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}

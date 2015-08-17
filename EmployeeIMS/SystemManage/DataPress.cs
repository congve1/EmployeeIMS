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
    public partial class DataPress : Form
    {
        public DataPress()
        {
            InitializeComponent();
        }
        EmployeeIMS.BaseClass.DataOperate dataOp = new EmployeeIMS.BaseClass.DataOperate();
        EmployeeIMS.BaseClass.DataBaseConnection dataCon = new EmployeeIMS.BaseClass.DataBaseConnection();
        private void btnExit_DP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataPress_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnFS_DP_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "all Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            txtFPath_DP.Text = openFileDialog1.FileName.ToString().Trim();
        }

        private void btnSPath_DP_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath_DP.Text = folderBrowserDialog1.SelectedPath.ToString().Trim() + "\\";
        }

        private void txtPath_DP_TextChanged(object sender, EventArgs e)
        {
            txtPath_DP.ReadOnly = true;
            btnFCopress_DP.Enabled = true;
            btnDCompress_DP.Enabled = false;
        }

        private void DataPress_Load(object sender, EventArgs e)
        {
            if (txtPath_DP.Text == "" && txtFPath_DP.Text == "")
            {
                btnDCompress_DP.Enabled = true;
            }
        }

        private void btnDCompress_DP_Click(object sender, EventArgs e)
        {
            try
            {
                 if (MessageBox.Show("确定要压缩数据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                 {
                     dataCon.executeSQLCommand("dbcc shrinkdatabase (EmployeeIMS,10)");
                     MessageBox.Show("数据压缩成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFCopress_DP_Click(object sender, EventArgs e)
        {
            try
            {
                dataOp.compressFile(txtFPath_DP.Text.Trim(), txtPath_DP.Text.Trim() + "compressed.zip");
                MessageBox.Show("文件压缩成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnDCompress_DP.Enabled = true;
            txtPath_DP.ReadOnly = true;
            btnFCopress_DP.Enabled = false;
        }
    }
}

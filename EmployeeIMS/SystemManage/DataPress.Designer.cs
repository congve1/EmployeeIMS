namespace EmployeeIMS.SystemManage
{
    partial class DataPress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPress));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit_DP = new System.Windows.Forms.Button();
            this.btnFCopress_DP = new System.Windows.Forms.Button();
            this.btnDCompress_DP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPath_DP = new System.Windows.Forms.TextBox();
            this.txtFPath_DP = new System.Windows.Forms.TextBox();
            this.labelPACP_DP = new System.Windows.Forms.Label();
            this.labelFTCP_DP = new System.Windows.Forms.Label();
            this.btnSPath_DP = new System.Windows.Forms.Button();
            this.btnFS_DP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit_DP);
            this.groupBox1.Controls.Add(this.btnFCopress_DP);
            this.groupBox1.Controls.Add(this.btnDCompress_DP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据压缩";
            // 
            // btnExit_DP
            // 
            this.btnExit_DP.Location = new System.Drawing.Point(264, 129);
            this.btnExit_DP.Name = "btnExit_DP";
            this.btnExit_DP.Size = new System.Drawing.Size(75, 23);
            this.btnExit_DP.TabIndex = 3;
            this.btnExit_DP.Text = "退出";
            this.btnExit_DP.UseVisualStyleBackColor = true;
            this.btnExit_DP.Click += new System.EventHandler(this.btnExit_DP_Click);
            // 
            // btnFCopress_DP
            // 
            this.btnFCopress_DP.Enabled = false;
            this.btnFCopress_DP.Location = new System.Drawing.Point(144, 129);
            this.btnFCopress_DP.Name = "btnFCopress_DP";
            this.btnFCopress_DP.Size = new System.Drawing.Size(75, 23);
            this.btnFCopress_DP.TabIndex = 2;
            this.btnFCopress_DP.Text = "文件压缩";
            this.btnFCopress_DP.UseVisualStyleBackColor = true;
            this.btnFCopress_DP.Click += new System.EventHandler(this.btnFCopress_DP_Click);
            // 
            // btnDCompress_DP
            // 
            this.btnDCompress_DP.Enabled = false;
            this.btnDCompress_DP.Location = new System.Drawing.Point(25, 129);
            this.btnDCompress_DP.Name = "btnDCompress_DP";
            this.btnDCompress_DP.Size = new System.Drawing.Size(75, 23);
            this.btnDCompress_DP.TabIndex = 1;
            this.btnDCompress_DP.Text = "数据压缩";
            this.btnDCompress_DP.UseVisualStyleBackColor = true;
            this.btnDCompress_DP.Click += new System.EventHandler(this.btnDCompress_DP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPath_DP);
            this.groupBox2.Controls.Add(this.txtFPath_DP);
            this.groupBox2.Controls.Add(this.labelPACP_DP);
            this.groupBox2.Controls.Add(this.labelFTCP_DP);
            this.groupBox2.Controls.Add(this.btnSPath_DP);
            this.groupBox2.Controls.Add(this.btnFS_DP);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtPath_DP
            // 
            this.txtPath_DP.Location = new System.Drawing.Point(88, 64);
            this.txtPath_DP.Name = "txtPath_DP";
            this.txtPath_DP.Size = new System.Drawing.Size(153, 21);
            this.txtPath_DP.TabIndex = 5;
            this.txtPath_DP.TextChanged += new System.EventHandler(this.txtPath_DP_TextChanged);
            // 
            // txtFPath_DP
            // 
            this.txtFPath_DP.Location = new System.Drawing.Point(90, 30);
            this.txtFPath_DP.Name = "txtFPath_DP";
            this.txtFPath_DP.Size = new System.Drawing.Size(153, 21);
            this.txtFPath_DP.TabIndex = 4;
            // 
            // labelPACP_DP
            // 
            this.labelPACP_DP.AutoSize = true;
            this.labelPACP_DP.Location = new System.Drawing.Point(5, 68);
            this.labelPACP_DP.Name = "labelPACP_DP";
            this.labelPACP_DP.Size = new System.Drawing.Size(77, 12);
            this.labelPACP_DP.TabIndex = 3;
            this.labelPACP_DP.Text = "压缩后的文件";
            // 
            // labelFTCP_DP
            // 
            this.labelFTCP_DP.AutoSize = true;
            this.labelFTCP_DP.Location = new System.Drawing.Point(7, 34);
            this.labelFTCP_DP.Name = "labelFTCP_DP";
            this.labelFTCP_DP.Size = new System.Drawing.Size(77, 12);
            this.labelFTCP_DP.TabIndex = 2;
            this.labelFTCP_DP.Text = "要压缩的文件";
            // 
            // btnSPath_DP
            // 
            this.btnSPath_DP.Image = ((System.Drawing.Image)(resources.GetObject("btnSPath_DP.Image")));
            this.btnSPath_DP.Location = new System.Drawing.Point(247, 63);
            this.btnSPath_DP.Name = "btnSPath_DP";
            this.btnSPath_DP.Size = new System.Drawing.Size(75, 23);
            this.btnSPath_DP.TabIndex = 1;
            this.btnSPath_DP.UseVisualStyleBackColor = true;
            this.btnSPath_DP.Click += new System.EventHandler(this.btnSPath_DP_Click);
            // 
            // btnFS_DP
            // 
            this.btnFS_DP.Image = ((System.Drawing.Image)(resources.GetObject("btnFS_DP.Image")));
            this.btnFS_DP.Location = new System.Drawing.Point(247, 29);
            this.btnFS_DP.Name = "btnFS_DP";
            this.btnFS_DP.Size = new System.Drawing.Size(75, 23);
            this.btnFS_DP.TabIndex = 0;
            this.btnFS_DP.UseVisualStyleBackColor = true;
            this.btnFS_DP.Click += new System.EventHandler(this.btnFS_DP_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 193);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataPress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据压缩";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataPress_FormClosed);
            this.Load += new System.EventHandler(this.DataPress_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit_DP;
        private System.Windows.Forms.Button btnFCopress_DP;
        private System.Windows.Forms.Button btnDCompress_DP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPath_DP;
        private System.Windows.Forms.TextBox txtFPath_DP;
        private System.Windows.Forms.Label labelPACP_DP;
        private System.Windows.Forms.Label labelFTCP_DP;
        private System.Windows.Forms.Button btnSPath_DP;
        private System.Windows.Forms.Button btnFS_DP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
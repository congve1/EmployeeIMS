namespace EmployeeIMS.SystemManage
{
    partial class DataStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit_DS = new System.Windows.Forms.Button();
            this.btnStore_DS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSP_DS = new System.Windows.Forms.Button();
            this.txtPath_DS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit_DS);
            this.groupBox1.Controls.Add(this.btnStore_DS);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据备份";
            // 
            // btnExit_DS
            // 
            this.btnExit_DS.Location = new System.Drawing.Point(173, 101);
            this.btnExit_DS.Name = "btnExit_DS";
            this.btnExit_DS.Size = new System.Drawing.Size(75, 23);
            this.btnExit_DS.TabIndex = 2;
            this.btnExit_DS.Text = "退出";
            this.btnExit_DS.UseVisualStyleBackColor = true;
            this.btnExit_DS.Click += new System.EventHandler(this.btnExit_DS_Click);
            // 
            // btnStore_DS
            // 
            this.btnStore_DS.Location = new System.Drawing.Point(44, 101);
            this.btnStore_DS.Name = "btnStore_DS";
            this.btnStore_DS.Size = new System.Drawing.Size(75, 23);
            this.btnStore_DS.TabIndex = 1;
            this.btnStore_DS.Text = "数据备份";
            this.btnStore_DS.UseVisualStyleBackColor = true;
            this.btnStore_DS.Click += new System.EventHandler(this.btnStore_DS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSP_DS);
            this.groupBox2.Controls.Add(this.txtPath_DS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnSP_DS
            // 
            this.btnSP_DS.Image = ((System.Drawing.Image)(resources.GetObject("btnSP_DS.Image")));
            this.btnSP_DS.Location = new System.Drawing.Point(187, 37);
            this.btnSP_DS.Name = "btnSP_DS";
            this.btnSP_DS.Size = new System.Drawing.Size(43, 23);
            this.btnSP_DS.TabIndex = 2;
            this.btnSP_DS.UseVisualStyleBackColor = true;
            this.btnSP_DS.Click += new System.EventHandler(this.btnSP_DS_Click);
            // 
            // txtPath_DS
            // 
            this.txtPath_DS.Location = new System.Drawing.Point(30, 37);
            this.txtPath_DS.Name = "txtPath_DS";
            this.txtPath_DS.Size = new System.Drawing.Size(140, 21);
            this.txtPath_DS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份文件路径";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\";
            // 
            // DataStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 148);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataStore_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit_DS;
        private System.Windows.Forms.Button btnStore_DS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSP_DS;
        private System.Windows.Forms.TextBox txtPath_DS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
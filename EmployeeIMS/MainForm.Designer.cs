namespace EmployeeIMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据压缩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfoManage = new System.Windows.Forms.TabPage();
            this.btnMDepartmentInfo = new System.Windows.Forms.Button();
            this.btnMEmployeeInfo = new System.Windows.Forms.Button();
            this.tabInfoSearch = new System.Windows.Forms.TabPage();
            this.btnSEmployee = new System.Windows.Forms.Button();
            this.btnCEmployee = new System.Windows.Forms.Button();
            this.btnSDepartment = new System.Windows.Forms.Button();
            this.tabSystemManage = new System.Windows.Forms.TabPage();
            this.btnRevertData = new System.Windows.Forms.Button();
            this.btnPressData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUsersM = new System.Windows.Forms.Button();
            this.btnChangePWD = new System.Windows.Forms.Button();
            this.btnRPInfoQ = new System.Windows.Forms.Button();
            this.btnTrainingInfoQ = new System.Windows.Forms.Button();
            this.btnTrainingM = new System.Windows.Forms.Button();
            this.btnSalaryM = new System.Windows.Forms.Button();
            this.btnRPInfoM = new System.Windows.Forms.Button();
            this.薪资信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.培训信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.培训信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInfoManage.SuspendLayout();
            this.tabInfoSearch.SuspendLayout();
            this.tabSystemManage.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息管理ToolStripMenuItem,
            this.部门信息管理ToolStripMenuItem,
            this.薪资信息管理ToolStripMenuItem,
            this.奖惩信息管理ToolStripMenuItem,
            this.培训信息管理ToolStripMenuItem});
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            resources.ApplyResources(this.信息管理ToolStripMenuItem, "信息管理ToolStripMenuItem");
            this.信息管理ToolStripMenuItem.Click += new System.EventHandler(this.信息管理ToolStripMenuItem_Click);
            // 
            // 员工信息管理ToolStripMenuItem
            // 
            this.员工信息管理ToolStripMenuItem.Name = "员工信息管理ToolStripMenuItem";
            resources.ApplyResources(this.员工信息管理ToolStripMenuItem, "员工信息管理ToolStripMenuItem");
            this.员工信息管理ToolStripMenuItem.Click += new System.EventHandler(this.员工信息管理ToolStripMenuItem_Click);
            // 
            // 部门信息管理ToolStripMenuItem
            // 
            this.部门信息管理ToolStripMenuItem.Name = "部门信息管理ToolStripMenuItem";
            resources.ApplyResources(this.部门信息管理ToolStripMenuItem, "部门信息管理ToolStripMenuItem");
            this.部门信息管理ToolStripMenuItem.Click += new System.EventHandler(this.部门信息管理ToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门信息查询ToolStripMenuItem,
            this.员工信息查询ToolStripMenuItem,
            this.员工信息统计ToolStripMenuItem,
            this.培训信息查询ToolStripMenuItem,
            this.奖惩信息查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            resources.ApplyResources(this.信息查询ToolStripMenuItem, "信息查询ToolStripMenuItem");
            this.信息查询ToolStripMenuItem.Click += new System.EventHandler(this.信息查询ToolStripMenuItem_Click);
            // 
            // 部门信息查询ToolStripMenuItem
            // 
            this.部门信息查询ToolStripMenuItem.Name = "部门信息查询ToolStripMenuItem";
            resources.ApplyResources(this.部门信息查询ToolStripMenuItem, "部门信息查询ToolStripMenuItem");
            this.部门信息查询ToolStripMenuItem.Click += new System.EventHandler(this.部门信息查询ToolStripMenuItem_Click);
            // 
            // 员工信息查询ToolStripMenuItem
            // 
            this.员工信息查询ToolStripMenuItem.Name = "员工信息查询ToolStripMenuItem";
            resources.ApplyResources(this.员工信息查询ToolStripMenuItem, "员工信息查询ToolStripMenuItem");
            this.员工信息查询ToolStripMenuItem.Click += new System.EventHandler(this.员工信息查询ToolStripMenuItem_Click);
            // 
            // 员工信息统计ToolStripMenuItem
            // 
            this.员工信息统计ToolStripMenuItem.Name = "员工信息统计ToolStripMenuItem";
            resources.ApplyResources(this.员工信息统计ToolStripMenuItem, "员工信息统计ToolStripMenuItem");
            this.员工信息统计ToolStripMenuItem.Click += new System.EventHandler(this.员工信息统计ToolStripMenuItem_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据备份ToolStripMenuItem,
            this.数据还原ToolStripMenuItem,
            this.数据压缩ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            resources.ApplyResources(this.系统维护ToolStripMenuItem, "系统维护ToolStripMenuItem");
            this.系统维护ToolStripMenuItem.Click += new System.EventHandler(this.系统维护ToolStripMenuItem_Click);
            // 
            // 数据备份ToolStripMenuItem
            // 
            this.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem";
            resources.ApplyResources(this.数据备份ToolStripMenuItem, "数据备份ToolStripMenuItem");
            this.数据备份ToolStripMenuItem.Click += new System.EventHandler(this.数据备份ToolStripMenuItem_Click);
            // 
            // 数据还原ToolStripMenuItem
            // 
            this.数据还原ToolStripMenuItem.Name = "数据还原ToolStripMenuItem";
            resources.ApplyResources(this.数据还原ToolStripMenuItem, "数据还原ToolStripMenuItem");
            this.数据还原ToolStripMenuItem.Click += new System.EventHandler(this.数据还原ToolStripMenuItem_Click);
            // 
            // 数据压缩ToolStripMenuItem
            // 
            this.数据压缩ToolStripMenuItem.Name = "数据压缩ToolStripMenuItem";
            resources.ApplyResources(this.数据压缩ToolStripMenuItem, "数据压缩ToolStripMenuItem");
            this.数据压缩ToolStripMenuItem.Click += new System.EventHandler(this.数据压缩ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改密码ToolStripMenuItem,
            this.关于本系统ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            resources.ApplyResources(this.更改密码ToolStripMenuItem, "更改密码ToolStripMenuItem");
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 关于本系统ToolStripMenuItem
            // 
            this.关于本系统ToolStripMenuItem.Name = "关于本系统ToolStripMenuItem";
            resources.ApplyResources(this.关于本系统ToolStripMenuItem, "关于本系统ToolStripMenuItem");
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            resources.ApplyResources(this.用户管理ToolStripMenuItem, "用户管理ToolStripMenuItem");
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            resources.ApplyResources(this.退出系统ToolStripMenuItem, "退出系统ToolStripMenuItem");
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.labelCRight,
            this.toolStripStatusLabel4,
            this.CurrentTime,
            this.toolStripStatusLabel5,
            this.loginTime,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel3});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // labelCRight
            // 
            this.labelCRight.Name = "labelCRight";
            resources.ApplyResources(this.labelCRight, "labelCRight");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // CurrentTime
            // 
            this.CurrentTime.Name = "CurrentTime";
            resources.ApplyResources(this.CurrentTime, "CurrentTime");
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            resources.ApplyResources(this.toolStripStatusLabel5, "toolStripStatusLabel5");
            // 
            // loginTime
            // 
            this.loginTime.Name = "loginTime";
            resources.ApplyResources(this.loginTime, "loginTime");
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            resources.ApplyResources(this.toolStripStatusLabel6, "toolStripStatusLabel6");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfoManage);
            this.tabControl1.Controls.Add(this.tabInfoSearch);
            this.tabControl1.Controls.Add(this.tabSystemManage);
            this.tabControl1.Controls.Add(this.tabHelp);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabInfoManage
            // 
            resources.ApplyResources(this.tabInfoManage, "tabInfoManage");
            this.tabInfoManage.Controls.Add(this.btnRPInfoM);
            this.tabInfoManage.Controls.Add(this.btnSalaryM);
            this.tabInfoManage.Controls.Add(this.btnTrainingM);
            this.tabInfoManage.Controls.Add(this.btnMDepartmentInfo);
            this.tabInfoManage.Controls.Add(this.btnMEmployeeInfo);
            this.tabInfoManage.Name = "tabInfoManage";
            this.tabInfoManage.UseVisualStyleBackColor = true;
            // 
            // btnMDepartmentInfo
            // 
            resources.ApplyResources(this.btnMDepartmentInfo, "btnMDepartmentInfo");
            this.btnMDepartmentInfo.Name = "btnMDepartmentInfo";
            this.btnMDepartmentInfo.UseVisualStyleBackColor = true;
            this.btnMDepartmentInfo.Click += new System.EventHandler(this.btnMDepartmentInfo_Click);
            // 
            // btnMEmployeeInfo
            // 
            resources.ApplyResources(this.btnMEmployeeInfo, "btnMEmployeeInfo");
            this.btnMEmployeeInfo.Name = "btnMEmployeeInfo";
            this.btnMEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnMEmployeeInfo.Click += new System.EventHandler(this.btnMEmployeeInfo_Click);
            // 
            // tabInfoSearch
            // 
            resources.ApplyResources(this.tabInfoSearch, "tabInfoSearch");
            this.tabInfoSearch.Controls.Add(this.btnTrainingInfoQ);
            this.tabInfoSearch.Controls.Add(this.btnRPInfoQ);
            this.tabInfoSearch.Controls.Add(this.btnSEmployee);
            this.tabInfoSearch.Controls.Add(this.btnCEmployee);
            this.tabInfoSearch.Controls.Add(this.btnSDepartment);
            this.tabInfoSearch.Name = "tabInfoSearch";
            this.tabInfoSearch.UseVisualStyleBackColor = true;
            // 
            // btnSEmployee
            // 
            this.btnSEmployee.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSEmployee, "btnSEmployee");
            this.btnSEmployee.Name = "btnSEmployee";
            this.btnSEmployee.UseVisualStyleBackColor = true;
            this.btnSEmployee.Click += new System.EventHandler(this.btnSEmployee_Click);
            // 
            // btnCEmployee
            // 
            this.btnCEmployee.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCEmployee, "btnCEmployee");
            this.btnCEmployee.Name = "btnCEmployee";
            this.btnCEmployee.UseVisualStyleBackColor = true;
            this.btnCEmployee.Click += new System.EventHandler(this.btnCEmployee_Click);
            // 
            // btnSDepartment
            // 
            this.btnSDepartment.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSDepartment, "btnSDepartment");
            this.btnSDepartment.Name = "btnSDepartment";
            this.btnSDepartment.UseVisualStyleBackColor = true;
            this.btnSDepartment.Click += new System.EventHandler(this.btnSDepartment_Click);
            // 
            // tabSystemManage
            // 
            resources.ApplyResources(this.tabSystemManage, "tabSystemManage");
            this.tabSystemManage.Controls.Add(this.btnRevertData);
            this.tabSystemManage.Controls.Add(this.btnPressData);
            this.tabSystemManage.Controls.Add(this.btnSaveData);
            this.tabSystemManage.Name = "tabSystemManage";
            this.tabSystemManage.UseVisualStyleBackColor = true;
            // 
            // btnRevertData
            // 
            this.btnRevertData.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRevertData, "btnRevertData");
            this.btnRevertData.Name = "btnRevertData";
            this.btnRevertData.UseVisualStyleBackColor = true;
            this.btnRevertData.Click += new System.EventHandler(this.btnReturnData_Click);
            // 
            // btnPressData
            // 
            this.btnPressData.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPressData, "btnPressData");
            this.btnPressData.Name = "btnPressData";
            this.btnPressData.UseVisualStyleBackColor = true;
            this.btnPressData.Click += new System.EventHandler(this.btnPressData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSaveData, "btnSaveData");
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // tabHelp
            // 
            resources.ApplyResources(this.tabHelp, "tabHelp");
            this.tabHelp.Controls.Add(this.btnAbout);
            this.tabHelp.Controls.Add(this.btnExit);
            this.tabHelp.Controls.Add(this.btnUsersM);
            this.tabHelp.Controls.Add(this.btnChangePWD);
            this.tabHelp.ForeColor = System.Drawing.Color.Coral;
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUsersM
            // 
            this.btnUsersM.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUsersM, "btnUsersM");
            this.btnUsersM.Name = "btnUsersM";
            this.btnUsersM.UseVisualStyleBackColor = true;
            this.btnUsersM.Click += new System.EventHandler(this.btnUsersM_Click);
            // 
            // btnChangePWD
            // 
            this.btnChangePWD.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnChangePWD, "btnChangePWD");
            this.btnChangePWD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangePWD.Name = "btnChangePWD";
            this.btnChangePWD.UseVisualStyleBackColor = true;
            this.btnChangePWD.Click += new System.EventHandler(this.btnChangePWD_Click);
            // 
            // btnRPInfoQ
            // 
            this.btnRPInfoQ.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRPInfoQ, "btnRPInfoQ");
            this.btnRPInfoQ.Name = "btnRPInfoQ";
            this.btnRPInfoQ.UseVisualStyleBackColor = true;
            // 
            // btnTrainingInfoQ
            // 
            this.btnTrainingInfoQ.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTrainingInfoQ, "btnTrainingInfoQ");
            this.btnTrainingInfoQ.Name = "btnTrainingInfoQ";
            this.btnTrainingInfoQ.UseVisualStyleBackColor = true;
            // 
            // btnTrainingM
            // 
            resources.ApplyResources(this.btnTrainingM, "btnTrainingM");
            this.btnTrainingM.Name = "btnTrainingM";
            this.btnTrainingM.UseVisualStyleBackColor = true;
            // 
            // btnSalaryM
            // 
            resources.ApplyResources(this.btnSalaryM, "btnSalaryM");
            this.btnSalaryM.Name = "btnSalaryM";
            this.btnSalaryM.UseVisualStyleBackColor = true;
            // 
            // btnRPInfoM
            // 
            resources.ApplyResources(this.btnRPInfoM, "btnRPInfoM");
            this.btnRPInfoM.Name = "btnRPInfoM";
            this.btnRPInfoM.UseVisualStyleBackColor = true;
            // 
            // 薪资信息管理ToolStripMenuItem
            // 
            this.薪资信息管理ToolStripMenuItem.Name = "薪资信息管理ToolStripMenuItem";
            resources.ApplyResources(this.薪资信息管理ToolStripMenuItem, "薪资信息管理ToolStripMenuItem");
            // 
            // 奖惩信息管理ToolStripMenuItem
            // 
            this.奖惩信息管理ToolStripMenuItem.Name = "奖惩信息管理ToolStripMenuItem";
            resources.ApplyResources(this.奖惩信息管理ToolStripMenuItem, "奖惩信息管理ToolStripMenuItem");
            // 
            // 培训信息管理ToolStripMenuItem
            // 
            this.培训信息管理ToolStripMenuItem.Name = "培训信息管理ToolStripMenuItem";
            resources.ApplyResources(this.培训信息管理ToolStripMenuItem, "培训信息管理ToolStripMenuItem");
            // 
            // 培训信息查询ToolStripMenuItem
            // 
            this.培训信息查询ToolStripMenuItem.Name = "培训信息查询ToolStripMenuItem";
            resources.ApplyResources(this.培训信息查询ToolStripMenuItem, "培训信息查询ToolStripMenuItem");
            // 
            // 奖惩信息查询ToolStripMenuItem
            // 
            this.奖惩信息查询ToolStripMenuItem.Name = "奖惩信息查询ToolStripMenuItem";
            resources.ApplyResources(this.奖惩信息查询ToolStripMenuItem, "奖惩信息查询ToolStripMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabInfoManage.ResumeLayout(false);
            this.tabInfoSearch.ResumeLayout(false);
            this.tabSystemManage.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel loginTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfoManage;
        private System.Windows.Forms.TabPage tabInfoSearch;
        private System.Windows.Forms.TabPage tabSystemManage;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUsersM;
        private System.Windows.Forms.Button btnChangePWD;
        private System.Windows.Forms.Button btnSEmployee;
        private System.Windows.Forms.Button btnCEmployee;
        private System.Windows.Forms.Button btnSDepartment;
        private System.Windows.Forms.Button btnRevertData;
        private System.Windows.Forms.Button btnPressData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Button btnMDepartmentInfo;
        private System.Windows.Forms.Button btnMEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem 员工信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据压缩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelCRight;
        private System.Windows.Forms.Button btnTrainingInfoQ;
        private System.Windows.Forms.Button btnRPInfoQ;
        private System.Windows.Forms.Button btnRPInfoM;
        private System.Windows.Forms.Button btnSalaryM;
        private System.Windows.Forms.Button btnTrainingM;
        private System.Windows.Forms.ToolStripMenuItem 薪资信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖惩信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 培训信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 培训信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖惩信息查询ToolStripMenuItem;
    }
}
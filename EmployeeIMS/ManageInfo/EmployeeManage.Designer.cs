namespace EmployeeIMS.ManageInfo
{
    partial class EmployeeManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgEmInfo_EM = new System.Windows.Forms.DataGridView();
            this.btnAdd_EM = new System.Windows.Forms.Button();
            this.btnModify_EM = new System.Windows.Forms.Button();
            this.btnDel_EM = new System.Windows.Forms.Button();
            this.btnExit_EM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEName_EM = new System.Windows.Forms.TextBox();
            this.txtEDuty_EM = new System.Windows.Forms.TextBox();
            this.txtRemark_EM = new System.Windows.Forms.TextBox();
            this.cmbEID_EM = new System.Windows.Forms.ComboBox();
            this.cmbESex_EM = new System.Windows.Forms.ComboBox();
            this.cmbEMarriage_EM = new System.Windows.Forms.ComboBox();
            this.txtEEdu_EM = new System.Windows.Forms.TextBox();
            this.cmbEEstate_EM = new System.Windows.Forms.ComboBox();
            this.dtBorn_EM = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus_EM = new System.Windows.Forms.ComboBox();
            this.dtEnroll_EM = new System.Windows.Forms.DateTimePicker();
            this.dtInDue_EM = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmInfo_EM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtInDue_EM);
            this.groupBox1.Controls.Add(this.dtEnroll_EM);
            this.groupBox1.Controls.Add(this.cmbStatus_EM);
            this.groupBox1.Controls.Add(this.dtBorn_EM);
            this.groupBox1.Controls.Add(this.cmbEEstate_EM);
            this.groupBox1.Controls.Add(this.txtEEdu_EM);
            this.groupBox1.Controls.Add(this.cmbEMarriage_EM);
            this.groupBox1.Controls.Add(this.cmbESex_EM);
            this.groupBox1.Controls.Add(this.cmbEID_EM);
            this.groupBox1.Controls.Add(this.txtRemark_EM);
            this.groupBox1.Controls.Add(this.txtEDuty_EM);
            this.groupBox1.Controls.Add(this.txtEName_EM);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit_EM);
            this.groupBox2.Controls.Add(this.btnDel_EM);
            this.groupBox2.Controls.Add(this.btnModify_EM);
            this.groupBox2.Controls.Add(this.btnAdd_EM);
            this.groupBox2.Location = new System.Drawing.Point(497, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // dgEmInfo_EM
            // 
            this.dgEmInfo_EM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmInfo_EM.Location = new System.Drawing.Point(4, 334);
            this.dgEmInfo_EM.Name = "dgEmInfo_EM";
            this.dgEmInfo_EM.ReadOnly = true;
            this.dgEmInfo_EM.RowTemplate.Height = 23;
            this.dgEmInfo_EM.Size = new System.Drawing.Size(639, 246);
            this.dgEmInfo_EM.TabIndex = 2;
            this.dgEmInfo_EM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmInfo_EM_CellClick);
            // 
            // btnAdd_EM
            // 
            this.btnAdd_EM.Location = new System.Drawing.Point(33, 50);
            this.btnAdd_EM.Name = "btnAdd_EM";
            this.btnAdd_EM.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_EM.TabIndex = 0;
            this.btnAdd_EM.Text = "添加";
            this.btnAdd_EM.UseVisualStyleBackColor = true;
            this.btnAdd_EM.Click += new System.EventHandler(this.btnAdd_EM_Click);
            // 
            // btnModify_EM
            // 
            this.btnModify_EM.Location = new System.Drawing.Point(33, 119);
            this.btnModify_EM.Name = "btnModify_EM";
            this.btnModify_EM.Size = new System.Drawing.Size(75, 23);
            this.btnModify_EM.TabIndex = 1;
            this.btnModify_EM.Text = "修改";
            this.btnModify_EM.UseVisualStyleBackColor = true;
            this.btnModify_EM.Click += new System.EventHandler(this.btnModify_EM_Click);
            // 
            // btnDel_EM
            // 
            this.btnDel_EM.Location = new System.Drawing.Point(33, 176);
            this.btnDel_EM.Name = "btnDel_EM";
            this.btnDel_EM.Size = new System.Drawing.Size(75, 23);
            this.btnDel_EM.TabIndex = 2;
            this.btnDel_EM.Text = "删除";
            this.btnDel_EM.UseVisualStyleBackColor = true;
            this.btnDel_EM.Click += new System.EventHandler(this.btnDel_EM_Click);
            // 
            // btnExit_EM
            // 
            this.btnExit_EM.Location = new System.Drawing.Point(33, 232);
            this.btnExit_EM.Name = "btnExit_EM";
            this.btnExit_EM.Size = new System.Drawing.Size(75, 23);
            this.btnExit_EM.TabIndex = 3;
            this.btnExit_EM.Text = "退出";
            this.btnExit_EM.UseVisualStyleBackColor = true;
            this.btnExit_EM.Click += new System.EventHandler(this.btnExit_EM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "出生日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "婚姻状况";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "政治面貌";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "学历";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "入厂日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "转正日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "职务";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "在职否";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "备注";
            // 
            // txtEName_EM
            // 
            this.txtEName_EM.Location = new System.Drawing.Point(92, 56);
            this.txtEName_EM.Name = "txtEName_EM";
            this.txtEName_EM.Size = new System.Drawing.Size(121, 21);
            this.txtEName_EM.TabIndex = 12;
            // 
            // txtEDuty_EM
            // 
            this.txtEDuty_EM.Location = new System.Drawing.Point(321, 71);
            this.txtEDuty_EM.Name = "txtEDuty_EM";
            this.txtEDuty_EM.Size = new System.Drawing.Size(121, 21);
            this.txtEDuty_EM.TabIndex = 13;
            // 
            // txtRemark_EM
            // 
            this.txtRemark_EM.Location = new System.Drawing.Point(321, 165);
            this.txtRemark_EM.Name = "txtRemark_EM";
            this.txtRemark_EM.Size = new System.Drawing.Size(121, 21);
            this.txtRemark_EM.TabIndex = 14;
            // 
            // cmbEID_EM
            // 
            this.cmbEID_EM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEID_EM.FormattingEnabled = true;
            this.cmbEID_EM.Location = new System.Drawing.Point(92, 25);
            this.cmbEID_EM.Name = "cmbEID_EM";
            this.cmbEID_EM.Size = new System.Drawing.Size(121, 20);
            this.cmbEID_EM.TabIndex = 15;
            // 
            // cmbESex_EM
            // 
            this.cmbESex_EM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESex_EM.FormattingEnabled = true;
            this.cmbESex_EM.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbESex_EM.Location = new System.Drawing.Point(92, 91);
            this.cmbESex_EM.Name = "cmbESex_EM";
            this.cmbESex_EM.Size = new System.Drawing.Size(121, 20);
            this.cmbESex_EM.TabIndex = 16;
            // 
            // cmbEMarriage_EM
            // 
            this.cmbEMarriage_EM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEMarriage_EM.FormattingEnabled = true;
            this.cmbEMarriage_EM.Items.AddRange(new object[] {
            "已婚",
            "未婚"});
            this.cmbEMarriage_EM.Location = new System.Drawing.Point(92, 126);
            this.cmbEMarriage_EM.Name = "cmbEMarriage_EM";
            this.cmbEMarriage_EM.Size = new System.Drawing.Size(121, 20);
            this.cmbEMarriage_EM.TabIndex = 18;
            // 
            // txtEEdu_EM
            // 
            this.txtEEdu_EM.Location = new System.Drawing.Point(321, 24);
            this.txtEEdu_EM.Name = "txtEEdu_EM";
            this.txtEEdu_EM.Size = new System.Drawing.Size(121, 21);
            this.txtEEdu_EM.TabIndex = 19;
            // 
            // cmbEEstate_EM
            // 
            this.cmbEEstate_EM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEEstate_EM.FormattingEnabled = true;
            this.cmbEEstate_EM.Items.AddRange(new object[] {
            "在职",
            "离职"});
            this.cmbEEstate_EM.Location = new System.Drawing.Point(321, 118);
            this.cmbEEstate_EM.Name = "cmbEEstate_EM";
            this.cmbEEstate_EM.Size = new System.Drawing.Size(121, 20);
            this.cmbEEstate_EM.TabIndex = 20;
            // 
            // dtBorn_EM
            // 
            this.dtBorn_EM.Location = new System.Drawing.Point(101, 224);
            this.dtBorn_EM.Name = "dtBorn_EM";
            this.dtBorn_EM.Size = new System.Drawing.Size(341, 21);
            this.dtBorn_EM.TabIndex = 21;
            // 
            // cmbStatus_EM
            // 
            this.cmbStatus_EM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus_EM.FormattingEnabled = true;
            this.cmbStatus_EM.Items.AddRange(new object[] {
            "团员",
            "党员",
            "群众",
            "其他",
            ""});
            this.cmbStatus_EM.Location = new System.Drawing.Point(92, 161);
            this.cmbStatus_EM.Name = "cmbStatus_EM";
            this.cmbStatus_EM.Size = new System.Drawing.Size(121, 20);
            this.cmbStatus_EM.TabIndex = 22;
            // 
            // dtEnroll_EM
            // 
            this.dtEnroll_EM.Location = new System.Drawing.Point(101, 256);
            this.dtEnroll_EM.Name = "dtEnroll_EM";
            this.dtEnroll_EM.Size = new System.Drawing.Size(341, 21);
            this.dtEnroll_EM.TabIndex = 23;
            // 
            // dtInDue_EM
            // 
            this.dtInDue_EM.Location = new System.Drawing.Point(101, 288);
            this.dtInDue_EM.Name = "dtInDue_EM";
            this.dtInDue_EM.Size = new System.Drawing.Size(341, 21);
            this.dtInDue_EM.TabIndex = 24;
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 592);
            this.Controls.Add(this.dgEmInfo_EM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeManage_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmInfo_EM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgEmInfo_EM;
        private System.Windows.Forms.DateTimePicker dtInDue_EM;
        private System.Windows.Forms.DateTimePicker dtEnroll_EM;
        private System.Windows.Forms.ComboBox cmbStatus_EM;
        private System.Windows.Forms.DateTimePicker dtBorn_EM;
        private System.Windows.Forms.ComboBox cmbEEstate_EM;
        private System.Windows.Forms.TextBox txtEEdu_EM;
        private System.Windows.Forms.ComboBox cmbEMarriage_EM;
        private System.Windows.Forms.ComboBox cmbESex_EM;
        private System.Windows.Forms.ComboBox cmbEID_EM;
        private System.Windows.Forms.TextBox txtRemark_EM;
        private System.Windows.Forms.TextBox txtEDuty_EM;
        private System.Windows.Forms.TextBox txtEName_EM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit_EM;
        private System.Windows.Forms.Button btnDel_EM;
        private System.Windows.Forms.Button btnModify_EM;
        private System.Windows.Forms.Button btnAdd_EM;
    }
}
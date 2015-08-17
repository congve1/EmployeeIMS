namespace EmployeeIMS.ManageInfo
{
    partial class DepartmentManage
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
            this.txtDNumber_DM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDName_DM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit_DM = new System.Windows.Forms.Button();
            this.btnModify_DM = new System.Windows.Forms.Button();
            this.btnAdd_DM = new System.Windows.Forms.Button();
            this.dgDInfo_DM = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDInfo_DM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNumber_DM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDName_DM);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // txtDNumber_DM
            // 
            this.txtDNumber_DM.Location = new System.Drawing.Point(67, 77);
            this.txtDNumber_DM.Name = "txtDNumber_DM";
            this.txtDNumber_DM.Size = new System.Drawing.Size(117, 21);
            this.txtDNumber_DM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "部门人数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "部门名称";
            // 
            // cmbDName_DM
            // 
            this.cmbDName_DM.FormattingEnabled = true;
            this.cmbDName_DM.Location = new System.Drawing.Point(63, 28);
            this.cmbDName_DM.Name = "cmbDName_DM";
            this.cmbDName_DM.Size = new System.Drawing.Size(121, 20);
            this.cmbDName_DM.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit_DM);
            this.groupBox2.Controls.Add(this.btnModify_DM);
            this.groupBox2.Controls.Add(this.btnAdd_DM);
            this.groupBox2.Location = new System.Drawing.Point(196, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(63, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnExit_DM
            // 
            this.btnExit_DM.Location = new System.Drawing.Point(7, 93);
            this.btnExit_DM.Name = "btnExit_DM";
            this.btnExit_DM.Size = new System.Drawing.Size(51, 23);
            this.btnExit_DM.TabIndex = 2;
            this.btnExit_DM.Text = "退出";
            this.btnExit_DM.UseVisualStyleBackColor = true;
            this.btnExit_DM.Click += new System.EventHandler(this.btnExit_DM_Click);
            // 
            // btnModify_DM
            // 
            this.btnModify_DM.Location = new System.Drawing.Point(7, 61);
            this.btnModify_DM.Name = "btnModify_DM";
            this.btnModify_DM.Size = new System.Drawing.Size(50, 23);
            this.btnModify_DM.TabIndex = 1;
            this.btnModify_DM.Text = "修改";
            this.btnModify_DM.UseVisualStyleBackColor = true;
            // 
            // btnAdd_DM
            // 
            this.btnAdd_DM.Location = new System.Drawing.Point(7, 21);
            this.btnAdd_DM.Name = "btnAdd_DM";
            this.btnAdd_DM.Size = new System.Drawing.Size(51, 23);
            this.btnAdd_DM.TabIndex = 0;
            this.btnAdd_DM.Text = "添加";
            this.btnAdd_DM.UseVisualStyleBackColor = true;
            // 
            // dgDInfo_DM
            // 
            this.dgDInfo_DM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDInfo_DM.Location = new System.Drawing.Point(12, 139);
            this.dgDInfo_DM.Name = "dgDInfo_DM";
            this.dgDInfo_DM.ReadOnly = true;
            this.dgDInfo_DM.RowTemplate.Height = 23;
            this.dgDInfo_DM.Size = new System.Drawing.Size(260, 150);
            this.dgDInfo_DM.TabIndex = 1;
            this.dgDInfo_DM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDInfo_DM_CellClick);
            this.dgDInfo_DM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDInfo_DM_CellContentClick);
            // 
            // DepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.dgDInfo_DM);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepartmentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentManage_FormClosed);
            this.Load += new System.EventHandler(this.DepartmentManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDInfo_DM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNumber_DM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDName_DM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit_DM;
        private System.Windows.Forms.Button btnModify_DM;
        private System.Windows.Forms.Button btnAdd_DM;
        private System.Windows.Forms.DataGridView dgDInfo_DM;
    }
}
namespace EmployeeIMS.Help
{
    partial class UsersManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAuthority_UM = new System.Windows.Forms.ComboBox();
            this.cmbUName_UM = new System.Windows.Forms.ComboBox();
            this.txtPwd_UM = new System.Windows.Forms.TextBox();
            this.labelAuthority_UM = new System.Windows.Forms.Label();
            this.labelPWD_UM = new System.Windows.Forms.Label();
            this.labelUName_UM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel_UM = new System.Windows.Forms.Button();
            this.btnMd_UM = new System.Windows.Forms.Button();
            this.btnAdd_UM = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgUsersInfo_UM = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInfo_UM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAuthority_UM);
            this.groupBox1.Controls.Add(this.cmbUName_UM);
            this.groupBox1.Controls.Add(this.txtPwd_UM);
            this.groupBox1.Controls.Add(this.labelAuthority_UM);
            this.groupBox1.Controls.Add(this.labelPWD_UM);
            this.groupBox1.Controls.Add(this.labelUName_UM);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // cmbAuthority_UM
            // 
            this.cmbAuthority_UM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthority_UM.FormattingEnabled = true;
            this.cmbAuthority_UM.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbAuthority_UM.Location = new System.Drawing.Point(69, 128);
            this.cmbAuthority_UM.Name = "cmbAuthority_UM";
            this.cmbAuthority_UM.Size = new System.Drawing.Size(121, 20);
            this.cmbAuthority_UM.TabIndex = 5;
            // 
            // cmbUName_UM
            // 
            this.cmbUName_UM.FormattingEnabled = true;
            this.cmbUName_UM.Location = new System.Drawing.Point(68, 31);
            this.cmbUName_UM.Name = "cmbUName_UM";
            this.cmbUName_UM.Size = new System.Drawing.Size(121, 20);
            this.cmbUName_UM.TabIndex = 4;
            // 
            // txtPwd_UM
            // 
            this.txtPwd_UM.Location = new System.Drawing.Point(68, 78);
            this.txtPwd_UM.Name = "txtPwd_UM";
            this.txtPwd_UM.Size = new System.Drawing.Size(121, 21);
            this.txtPwd_UM.TabIndex = 3;
            this.txtPwd_UM.UseSystemPasswordChar = true;
            // 
            // labelAuthority_UM
            // 
            this.labelAuthority_UM.AutoSize = true;
            this.labelAuthority_UM.Location = new System.Drawing.Point(4, 131);
            this.labelAuthority_UM.Name = "labelAuthority_UM";
            this.labelAuthority_UM.Size = new System.Drawing.Size(53, 12);
            this.labelAuthority_UM.TabIndex = 2;
            this.labelAuthority_UM.Text = "用户权限";
            this.labelAuthority_UM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPWD_UM
            // 
            this.labelPWD_UM.AutoSize = true;
            this.labelPWD_UM.Location = new System.Drawing.Point(28, 83);
            this.labelPWD_UM.Name = "labelPWD_UM";
            this.labelPWD_UM.Size = new System.Drawing.Size(29, 12);
            this.labelPWD_UM.TabIndex = 1;
            this.labelPWD_UM.Text = "密码";
            // 
            // labelUName_UM
            // 
            this.labelUName_UM.AutoSize = true;
            this.labelUName_UM.Location = new System.Drawing.Point(16, 34);
            this.labelUName_UM.Name = "labelUName_UM";
            this.labelUName_UM.Size = new System.Drawing.Size(41, 12);
            this.labelUName_UM.TabIndex = 0;
            this.labelUName_UM.Text = "用户名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel_UM);
            this.groupBox2.Controls.Add(this.btnMd_UM);
            this.groupBox2.Controls.Add(this.btnAdd_UM);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnDel_UM
            // 
            this.btnDel_UM.Image = ((System.Drawing.Image)(resources.GetObject("btnDel_UM.Image")));
            this.btnDel_UM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel_UM.Location = new System.Drawing.Point(48, 132);
            this.btnDel_UM.Name = "btnDel_UM";
            this.btnDel_UM.Size = new System.Drawing.Size(59, 23);
            this.btnDel_UM.TabIndex = 2;
            this.btnDel_UM.Text = "删除";
            this.btnDel_UM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel_UM.UseVisualStyleBackColor = true;
            this.btnDel_UM.Click += new System.EventHandler(this.btnDel_UM_Click);
            // 
            // btnMd_UM
            // 
            this.btnMd_UM.Image = ((System.Drawing.Image)(resources.GetObject("btnMd_UM.Image")));
            this.btnMd_UM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMd_UM.Location = new System.Drawing.Point(48, 76);
            this.btnMd_UM.Name = "btnMd_UM";
            this.btnMd_UM.Size = new System.Drawing.Size(59, 23);
            this.btnMd_UM.TabIndex = 1;
            this.btnMd_UM.Text = "修改";
            this.btnMd_UM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMd_UM.UseVisualStyleBackColor = true;
            this.btnMd_UM.Click += new System.EventHandler(this.btnMd_UM_Click);
            // 
            // btnAdd_UM
            // 
            this.btnAdd_UM.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_UM.Image")));
            this.btnAdd_UM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_UM.Location = new System.Drawing.Point(48, 20);
            this.btnAdd_UM.Name = "btnAdd_UM";
            this.btnAdd_UM.Size = new System.Drawing.Size(59, 23);
            this.btnAdd_UM.TabIndex = 0;
            this.btnAdd_UM.Text = "添加";
            this.btnAdd_UM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_UM.UseVisualStyleBackColor = true;
            this.btnAdd_UM.Click += new System.EventHandler(this.btnAdd_UM_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgUsersInfo_UM);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 196);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgUsersInfo_UM
            // 
            this.dgUsersInfo_UM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsersInfo_UM.Location = new System.Drawing.Point(0, 9);
            this.dgUsersInfo_UM.Name = "dgUsersInfo_UM";
            this.dgUsersInfo_UM.ReadOnly = true;
            this.dgUsersInfo_UM.RowTemplate.Height = 23;
            this.dgUsersInfo_UM.Size = new System.Drawing.Size(371, 187);
            this.dgUsersInfo_UM.TabIndex = 0;
            this.dgUsersInfo_UM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsersInfo_UM_CellClick);

            // 
            // UsersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsersManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersManage_FormClosed);
            this.Load += new System.EventHandler(this.UsersManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInfo_UM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAuthority_UM;
        private System.Windows.Forms.ComboBox cmbUName_UM;
        private System.Windows.Forms.TextBox txtPwd_UM;
        private System.Windows.Forms.Label labelAuthority_UM;
        private System.Windows.Forms.Label labelPWD_UM;
        private System.Windows.Forms.Label labelUName_UM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel_UM;
        private System.Windows.Forms.Button btnMd_UM;
        private System.Windows.Forms.Button btnAdd_UM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgUsersInfo_UM;
    }
}
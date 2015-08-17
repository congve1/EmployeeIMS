namespace EmployeeIMS.SearchInfo
{
    partial class SearchEmployeeInfo
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
            this.dgDataE_SE = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit_SE = new System.Windows.Forms.Button();
            this.btnSearch_SE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSKWords_SE = new System.Windows.Forms.TextBox();
            this.cmbSCondition_SE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataE_SE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDataE_SE
            // 
            this.dgDataE_SE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataE_SE.Location = new System.Drawing.Point(12, 119);
            this.dgDataE_SE.Name = "dgDataE_SE";
            this.dgDataE_SE.ReadOnly = true;
            this.dgDataE_SE.RowTemplate.Height = 23;
            this.dgDataE_SE.Size = new System.Drawing.Size(451, 217);
            this.dgDataE_SE.TabIndex = 5;
            this.dgDataE_SE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDataE_SE_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit_SE);
            this.groupBox2.Controls.Add(this.btnSearch_SE);
            this.groupBox2.Location = new System.Drawing.Point(382, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnExit_SE
            // 
            this.btnExit_SE.Location = new System.Drawing.Point(7, 61);
            this.btnExit_SE.Name = "btnExit_SE";
            this.btnExit_SE.Size = new System.Drawing.Size(75, 23);
            this.btnExit_SE.TabIndex = 1;
            this.btnExit_SE.Text = "退出 ";
            this.btnExit_SE.UseVisualStyleBackColor = true;
            this.btnExit_SE.Click += new System.EventHandler(this.btnExit_SE_Click);
            // 
            // btnSearch_SE
            // 
            this.btnSearch_SE.Location = new System.Drawing.Point(6, 20);
            this.btnSearch_SE.Name = "btnSearch_SE";
            this.btnSearch_SE.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_SE.TabIndex = 0;
            this.btnSearch_SE.Text = "查询";
            this.btnSearch_SE.UseVisualStyleBackColor = true;
            this.btnSearch_SE.Click += new System.EventHandler(this.btnSearch_SE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSKWords_SE);
            this.groupBox1.Controls.Add(this.cmbSCondition_SE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // txtSKWords_SE
            // 
            this.txtSKWords_SE.Location = new System.Drawing.Point(121, 69);
            this.txtSKWords_SE.Name = "txtSKWords_SE";
            this.txtSKWords_SE.Size = new System.Drawing.Size(181, 21);
            this.txtSKWords_SE.TabIndex = 3;
            // 
            // cmbSCondition_SE
            // 
            this.cmbSCondition_SE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSCondition_SE.FormattingEnabled = true;
            this.cmbSCondition_SE.Items.AddRange(new object[] {
            "员工姓名",
            "性别",
            "婚姻状况",
            "政治面貌",
            "职务",
            ""});
            this.cmbSCondition_SE.Location = new System.Drawing.Point(121, 29);
            this.cmbSCondition_SE.Name = "cmbSCondition_SE";
            this.cmbSCondition_SE.Size = new System.Drawing.Size(181, 20);
            this.cmbSCondition_SE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询关键字";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择查询条件";
            // 
            // SearchEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 339);
            this.Controls.Add(this.dgDataE_SE);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchEmployeeInfo_FormClosed);
            this.Load += new System.EventHandler(this.SearchEmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDataE_SE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDataE_SE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit_SE;
        private System.Windows.Forms.Button btnSearch_SE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSKWords_SE;
        private System.Windows.Forms.ComboBox cmbSCondition_SE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace EmployeeIMS.SearchInfo
{
    partial class SearchDeparmentInfo
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
            this.txtSKWords_SD = new System.Windows.Forms.TextBox();
            this.cmbSCondition_SD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit_SD = new System.Windows.Forms.Button();
            this.btnSearch_SD = new System.Windows.Forms.Button();
            this.dgDataD_SD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataD_SD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSKWords_SD);
            this.groupBox1.Controls.Add(this.cmbSCondition_SD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // txtSKWords_SD
            // 
            this.txtSKWords_SD.Location = new System.Drawing.Point(121, 69);
            this.txtSKWords_SD.Name = "txtSKWords_SD";
            this.txtSKWords_SD.Size = new System.Drawing.Size(181, 21);
            this.txtSKWords_SD.TabIndex = 3;
            // 
            // cmbSCondition_SD
            // 
            this.cmbSCondition_SD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSCondition_SD.FormattingEnabled = true;
            this.cmbSCondition_SD.Items.AddRange(new object[] {
            "部门编号",
            "部门名称",
            "部门人数",
            ""});
            this.cmbSCondition_SD.Location = new System.Drawing.Point(121, 29);
            this.cmbSCondition_SD.Name = "cmbSCondition_SD";
            this.cmbSCondition_SD.Size = new System.Drawing.Size(181, 20);
            this.cmbSCondition_SD.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit_SD);
            this.groupBox2.Controls.Add(this.btnSearch_SD);
            this.groupBox2.Location = new System.Drawing.Point(382, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnExit_SD
            // 
            this.btnExit_SD.Location = new System.Drawing.Point(7, 61);
            this.btnExit_SD.Name = "btnExit_SD";
            this.btnExit_SD.Size = new System.Drawing.Size(75, 23);
            this.btnExit_SD.TabIndex = 1;
            this.btnExit_SD.Text = "退出 ";
            this.btnExit_SD.UseVisualStyleBackColor = true;
            this.btnExit_SD.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch_SD
            // 
            this.btnSearch_SD.Location = new System.Drawing.Point(6, 20);
            this.btnSearch_SD.Name = "btnSearch_SD";
            this.btnSearch_SD.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_SD.TabIndex = 0;
            this.btnSearch_SD.Text = "查询";
            this.btnSearch_SD.UseVisualStyleBackColor = true;
            this.btnSearch_SD.Click += new System.EventHandler(this.btnSearch_SD_Click);
            // 
            // dgDataD_SD
            // 
            this.dgDataD_SD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataD_SD.Location = new System.Drawing.Point(12, 119);
            this.dgDataD_SD.Name = "dgDataD_SD";
            this.dgDataD_SD.ReadOnly = true;
            this.dgDataD_SD.RowTemplate.Height = 23;
            this.dgDataD_SD.Size = new System.Drawing.Size(451, 217);
            this.dgDataD_SD.TabIndex = 2;
            this.dgDataD_SD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDataD_SD_CellClick);
            // 
            // SearchDeparmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 348);
            this.Controls.Add(this.dgDataD_SD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchDeparmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchDeparmentInfo_FormClosed);
            this.Load += new System.EventHandler(this.SearchDeparmentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDataD_SD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSKWords_SD;
        private System.Windows.Forms.ComboBox cmbSCondition_SD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit_SD;
        private System.Windows.Forms.Button btnSearch_SD;
        private System.Windows.Forms.DataGridView dgDataD_SD;
    }
}
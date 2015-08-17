namespace EmployeeIMS.SystemManage
{
    partial class DataRevert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRevert));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRevert_DR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch_DR = new System.Windows.Forms.Button();
            this.txtPath_DR = new System.Windows.Forms.TextBox();
            this.labelFTRevert_DR = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnRevert_DR);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据还原";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRevert_DR
            // 
            this.btnRevert_DR.Location = new System.Drawing.Point(32, 103);
            this.btnRevert_DR.Name = "btnRevert_DR";
            this.btnRevert_DR.Size = new System.Drawing.Size(75, 23);
            this.btnRevert_DR.TabIndex = 1;
            this.btnRevert_DR.Text = "还原";
            this.btnRevert_DR.UseVisualStyleBackColor = true;
            this.btnRevert_DR.Click += new System.EventHandler(this.btnRevert_DR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch_DR);
            this.groupBox2.Controls.Add(this.txtPath_DR);
            this.groupBox2.Controls.Add(this.labelFTRevert_DR);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch_DR
            // 
            this.btnSearch_DR.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_DR.Image")));
            this.btnSearch_DR.Location = new System.Drawing.Point(177, 42);
            this.btnSearch_DR.Name = "btnSearch_DR";
            this.btnSearch_DR.Size = new System.Drawing.Size(32, 23);
            this.btnSearch_DR.TabIndex = 2;
            this.btnSearch_DR.UseVisualStyleBackColor = true;
            this.btnSearch_DR.Click += new System.EventHandler(this.btnSearch_DR_Click);
            // 
            // txtPath_DR
            // 
            this.txtPath_DR.Location = new System.Drawing.Point(26, 43);
            this.txtPath_DR.Name = "txtPath_DR";
            this.txtPath_DR.Size = new System.Drawing.Size(145, 21);
            this.txtPath_DR.TabIndex = 1;
            // 
            // labelFTRevert_DR
            // 
            this.labelFTRevert_DR.AutoSize = true;
            this.labelFTRevert_DR.Location = new System.Drawing.Point(26, 21);
            this.labelFTRevert_DR.Name = "labelFTRevert_DR";
            this.labelFTRevert_DR.Size = new System.Drawing.Size(77, 12);
            this.labelFTRevert_DR.TabIndex = 0;
            this.labelFTRevert_DR.Text = "要还原的文件";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataRevert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataRevert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据还原";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataRevert_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRevert_DR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch_DR;
        private System.Windows.Forms.TextBox txtPath_DR;
        private System.Windows.Forms.Label labelFTRevert_DR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
namespace PAndC
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClearA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClearB = new System.Windows.Forms.Button();
            this.txtNums = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lbxLeft = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelected = new System.Windows.Forms.ListBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlPort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearA
            // 
            this.btnClearA.Location = new System.Drawing.Point(440, 10);
            this.btnClearA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearA.Name = "btnClearA";
            this.btnClearA.Size = new System.Drawing.Size(56, 39);
            this.btnClearA.TabIndex = 0;
            this.btnClearA.Text = "清空";
            this.btnClearA.UseVisualStyleBackColor = true;
            this.btnClearA.Click += new System.EventHandler(this.btnClearA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "输出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.Location = new System.Drawing.Point(555, 10);
            this.btnClearB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(56, 39);
            this.btnClearB.TabIndex = 2;
            this.btnClearB.Text = "清空";
            this.btnClearB.UseVisualStyleBackColor = true;
            this.btnClearB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(20, 10);
            this.txtNums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(180, 21);
            this.txtNums.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(259, 10);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(50, 39);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbxLeft
            // 
            this.lbxLeft.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxLeft.FormattingEnabled = true;
            this.lbxLeft.ItemHeight = 12;
            this.lbxLeft.Location = new System.Drawing.Point(9, 80);
            this.lbxLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxLeft.Name = "lbxLeft";
            this.lbxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLeft.Size = new System.Drawing.Size(258, 448);
            this.lbxLeft.TabIndex = 6;
            this.lbxLeft.SelectedIndexChanged += new System.EventHandler(this.lbxLeft_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.FormattingEnabled = true;
            this.lblSelected.ItemHeight = 12;
            this.lblSelected.Location = new System.Drawing.Point(271, 56);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(258, 472);
            this.lblSelected.TabIndex = 7;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 12;
            this.lbxOutput.Location = new System.Drawing.Point(532, 56);
            this.lbxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(258, 472);
            this.lbxOutput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "每行10个数字，数字间使用空格分隔";
            // 
            // ddlPort
            // 
            this.ddlPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPort.FormattingEnabled = true;
            this.ddlPort.Location = new System.Drawing.Point(641, 20);
            this.ddlPort.Name = "ddlPort";
            this.ddlPort.Size = new System.Drawing.Size(121, 20);
            this.ddlPort.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "清空";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ddlPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lbxLeft);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.btnClearB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClearA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClearB;
        private System.Windows.Forms.TextBox txtNums;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox lbxLeft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ListBox lblSelected;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}


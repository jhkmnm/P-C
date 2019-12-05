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
            this.lblSelected = new System.Windows.Forms.ListBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearA
            // 
            this.btnClearA.Location = new System.Drawing.Point(564, 9);
            this.btnClearA.Name = "btnClearA";
            this.btnClearA.Size = new System.Drawing.Size(75, 26);
            this.btnClearA.TabIndex = 0;
            this.btnClearA.Text = "清空";
            this.btnClearA.UseVisualStyleBackColor = true;
            this.btnClearA.Click += new System.EventHandler(this.btnClearA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1102, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "输出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.Location = new System.Drawing.Point(964, 9);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(75, 26);
            this.btnClearB.TabIndex = 2;
            this.btnClearB.Text = "清空";
            this.btnClearB.UseVisualStyleBackColor = true;
            this.btnClearB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(12, 12);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(239, 25);
            this.txtNums.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(330, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(67, 26);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbxLeft
            // 
            this.lbxLeft.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxLeft.FormattingEnabled = true;
            this.lbxLeft.ItemHeight = 15;
            this.lbxLeft.Location = new System.Drawing.Point(12, 53);
            this.lbxLeft.Name = "lbxLeft";
            this.lbxLeft.Size = new System.Drawing.Size(385, 589);
            this.lbxLeft.TabIndex = 6;
            this.lbxLeft.SelectedIndexChanged += new System.EventHandler(this.lbxLeft_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.FormattingEnabled = true;
            this.lblSelected.ItemHeight = 15;
            this.lblSelected.Location = new System.Drawing.Point(403, 53);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(385, 589);
            this.lblSelected.TabIndex = 7;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 15;
            this.lbxOutput.Location = new System.Drawing.Point(794, 53);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(385, 589);
            this.lbxOutput.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 653);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lbxLeft);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.btnClearB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClearA);
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
    }
}


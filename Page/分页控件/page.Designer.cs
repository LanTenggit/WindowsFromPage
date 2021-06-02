namespace Collidal_Weigh.Page
{
    partial class page
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.Sum_page = new System.Windows.Forms.ToolStripLabel();
            this.Frist_page = new System.Windows.Forms.ToolStripButton();
            this.Last_page = new System.Windows.Forms.ToolStripButton();
            this.c_page = new System.Windows.Forms.ToolStripTextBox();
            this.Next_page = new System.Windows.Forms.ToolStripButton();
            this.Not_page = new System.Windows.Forms.ToolStripButton();
            this.tb_linkNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.page_size = new System.Windows.Forms.ToolStripLabel();
            this.sum_data = new System.Windows.Forms.ToolStripLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigator1.CanOverflow = false;
            this.bindingNavigator1.CountItem = this.Sum_page;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Frist_page,
            this.Last_page,
            this.c_page,
            this.Sum_page,
            this.Next_page,
            this.Not_page,
            this.tb_linkNum,
            this.toolStripButton7,
            this.page_size,
            this.sum_data});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.Frist_page;
            this.bindingNavigator1.MoveLastItem = this.Not_page;
            this.bindingNavigator1.MoveNextItem = this.Next_page;
            this.bindingNavigator1.MovePreviousItem = this.Last_page;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.c_page;
            this.bindingNavigator1.Size = new System.Drawing.Size(670, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // Sum_page
            // 
            this.Sum_page.Name = "Sum_page";
            this.Sum_page.Size = new System.Drawing.Size(32, 22);
            this.Sum_page.Text = "/ {0}";
            this.Sum_page.ToolTipText = "总项数";
            // 
            // Frist_page
            // 
            this.Frist_page.Image = ((System.Drawing.Image)(resources.GetObject("Frist_page.Image")));
            this.Frist_page.Name = "Frist_page";
            this.Frist_page.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Frist_page.RightToLeftAutoMirrorImage = true;
            this.Frist_page.Size = new System.Drawing.Size(72, 22);
            this.Frist_page.Text = "首页";
            this.Frist_page.Click += new System.EventHandler(this.Frist_page_Click);
            // 
            // Last_page
            // 
            this.Last_page.Image = ((System.Drawing.Image)(resources.GetObject("Last_page.Image")));
            this.Last_page.Name = "Last_page";
            this.Last_page.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Last_page.RightToLeftAutoMirrorImage = true;
            this.Last_page.Size = new System.Drawing.Size(84, 22);
            this.Last_page.Text = "上一页";
            this.Last_page.Click += new System.EventHandler(this.Last_page_Click);
            // 
            // c_page
            // 
            this.c_page.AccessibleName = "位置";
            this.c_page.AutoSize = false;
            this.c_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_page.Name = "c_page";
            this.c_page.Size = new System.Drawing.Size(50, 23);
            this.c_page.Text = "0";
            this.c_page.ToolTipText = "当前位置";
            // 
            // Next_page
            // 
            this.Next_page.Image = ((System.Drawing.Image)(resources.GetObject("Next_page.Image")));
            this.Next_page.Name = "Next_page";
            this.Next_page.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Next_page.RightToLeftAutoMirrorImage = true;
            this.Next_page.Size = new System.Drawing.Size(84, 22);
            this.Next_page.Text = "下一页";
            this.Next_page.Click += new System.EventHandler(this.Next_page_Click);
            // 
            // Not_page
            // 
            this.Not_page.Image = ((System.Drawing.Image)(resources.GetObject("Not_page.Image")));
            this.Not_page.Name = "Not_page";
            this.Not_page.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Not_page.RightToLeftAutoMirrorImage = true;
            this.Not_page.Size = new System.Drawing.Size(72, 22);
            this.Not_page.Text = "尾页";
            this.Not_page.Click += new System.EventHandler(this.Not_page_Click);
            // 
            // tb_linkNum
            // 
            this.tb_linkNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_linkNum.Name = "tb_linkNum";
            this.tb_linkNum.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton7.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton7.Text = "跳转";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // page_size
            // 
            this.page_size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.page_size.Image = ((System.Drawing.Image)(resources.GetObject("page_size.Image")));
            this.page_size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.page_size.Name = "page_size";
            this.page_size.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.page_size.Size = new System.Drawing.Size(40, 22);
            this.page_size.Text = "行";
            // 
            // sum_data
            // 
            this.sum_data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sum_data.Image = ((System.Drawing.Image)(resources.GetObject("sum_data.Image")));
            this.sum_data.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sum_data.Name = "sum_data";
            this.sum_data.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sum_data.Size = new System.Drawing.Size(76, 22);
            this.sum_data.Text = "共多少行";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(673, 1);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(673, 26);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "page";
            this.Size = new System.Drawing.Size(673, 26);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel Sum_page;
        private System.Windows.Forms.ToolStripButton Frist_page;
        private System.Windows.Forms.ToolStripButton Last_page;
        private System.Windows.Forms.ToolStripTextBox c_page;
        private System.Windows.Forms.ToolStripButton Next_page;
        private System.Windows.Forms.ToolStripButton Not_page;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel page_size;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripTextBox tb_linkNum;
        private System.Windows.Forms.ToolStripLabel sum_data;
    }
}

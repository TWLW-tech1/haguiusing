namespace 库存管理
{
    partial class Form7
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
            dataGridView1 = new DataGridView();
            序号 = new DataGridViewTextBoxColumn();
            商品编号 = new DataGridViewTextBoxColumn();
            员工编号 = new DataGridViewTextBoxColumn();
            品牌 = new DataGridViewTextBoxColumn();
            商品名称 = new DataGridViewTextBoxColumn();
            价格 = new DataGridViewTextBoxColumn();
            库存 = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 序号, 商品编号, 员工编号, 品牌, 商品名称, 价格, 库存 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 385);
            dataGridView1.TabIndex = 0;
            // 
            // 序号
            // 
            序号.HeaderText = "序号";
            序号.MinimumWidth = 8;
            序号.Name = "序号";
            序号.Width = 90;
            // 
            // 商品编号
            // 
            商品编号.HeaderText = "商品编号";
            商品编号.MinimumWidth = 8;
            商品编号.Name = "商品编号";
            商品编号.Width = 150;
            // 
            // 员工编号
            // 
            员工编号.HeaderText = "员工编号";
            员工编号.MinimumWidth = 8;
            员工编号.Name = "员工编号";
            员工编号.Width = 150;
            // 
            // 品牌
            // 
            品牌.HeaderText = "品牌";
            品牌.MinimumWidth = 8;
            品牌.Name = "品牌";
            品牌.Width = 150;
            // 
            // 商品名称
            // 
            商品名称.HeaderText = "商品名称";
            商品名称.MinimumWidth = 8;
            商品名称.Name = "商品名称";
            商品名称.Width = 150;
            // 
            // 价格
            // 
            价格.HeaderText = "价格";
            价格.MinimumWidth = 8;
            价格.Name = "价格";
            价格.Width = 150;
            // 
            // 库存
            // 
            库存.HeaderText = "库存";
            库存.MinimumWidth = 8;
            库存.Name = "库存";
            库存.Width = 150;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 385;
            splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(343, 6);
            button1.Name = "button1";
            button1.Size = new Size(142, 52);
            button1.TabIndex = 0;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 商品编号;
        private DataGridViewTextBoxColumn 员工编号;
        private DataGridViewTextBoxColumn 品牌;
        private DataGridViewTextBoxColumn 商品名称;
        private DataGridViewTextBoxColumn 价格;
        private DataGridViewTextBoxColumn 库存;
        private SplitContainer splitContainer1;
        private Button button1;
    }
}
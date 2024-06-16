namespace 库存管理
{
    partial class Form8
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            序号 = new DataGridViewTextBoxColumn();
            商品编号 = new DataGridViewTextBoxColumn();
            品牌 = new DataGridViewTextBoxColumn();
            商品名称 = new DataGridViewTextBoxColumn();
            库存 = new DataGridViewTextBoxColumn();
            实际库存 = new DataGridViewTextBoxColumn();
            盈亏情况 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(715, 424);
            splitContainer1.SplitterDistance = 359;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 序号, 商品编号, 品牌, 商品名称, 库存, 实际库存, 盈亏情况 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(715, 359);
            dataGridView1.TabIndex = 0;
            // 
            // 序号
            // 
            序号.HeaderText = "序号";
            序号.Name = "序号";
            序号.ReadOnly = true;
            // 
            // 商品编号
            // 
            商品编号.HeaderText = "商品编号";
            商品编号.Name = "商品编号";
            商品编号.ReadOnly = true;
            // 
            // 品牌
            // 
            品牌.HeaderText = "品牌";
            品牌.Name = "品牌";
            品牌.ReadOnly = true;
            // 
            // 商品名称
            // 
            商品名称.HeaderText = "商品名称";
            商品名称.Name = "商品名称";
            商品名称.ReadOnly = true;
            // 
            // 库存
            // 
            库存.HeaderText = "库存";
            库存.Name = "库存";
            库存.ReadOnly = true;
            // 
            // 实际库存
            // 
            实际库存.HeaderText = "实际库存";
            实际库存.Name = "实际库存";
            实际库存.ReadOnly = true;
            // 
            // 盈亏情况
            // 
            盈亏情况.HeaderText = "盈亏情况";
            盈亏情况.Name = "盈亏情况";
            盈亏情况.ReadOnly = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(333, 17);
            button2.Name = "button2";
            button2.Size = new Size(74, 32);
            button2.TabIndex = 1;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(177, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 424);
            Controls.Add(splitContainer1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 商品编号;
        private DataGridViewTextBoxColumn 品牌;
        private DataGridViewTextBoxColumn 商品名称;
        private DataGridViewTextBoxColumn 库存;
        private DataGridViewTextBoxColumn 实际库存;
        private DataGridViewTextBoxColumn 盈亏情况;
    }
}
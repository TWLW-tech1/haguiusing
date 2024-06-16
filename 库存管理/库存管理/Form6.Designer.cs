namespace 库存管理
{
    partial class Form6
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
            员工编号 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            性别 = new DataGridViewTextBoxColumn();
            年龄 = new DataGridViewTextBoxColumn();
            工龄 = new DataGridViewTextBoxColumn();
            手机号码 = new DataGridViewTextBoxColumn();
            家庭住址 = new DataGridViewTextBoxColumn();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 序号, 员工编号, 姓名, 性别, 年龄, 工龄, 手机号码, 家庭住址 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 388);
            dataGridView1.TabIndex = 0;
            // 
            // 序号
            // 
            序号.HeaderText = "序号";
            序号.MinimumWidth = 8;
            序号.Name = "序号";
            序号.ReadOnly = true;
            序号.Width = 90;
            // 
            // 员工编号
            // 
            员工编号.HeaderText = "员工编号";
            员工编号.MinimumWidth = 8;
            员工编号.Name = "员工编号";
            员工编号.ReadOnly = true;
            员工编号.Width = 150;
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.MinimumWidth = 8;
            姓名.Name = "姓名";
            姓名.ReadOnly = true;
            姓名.Width = 150;
            // 
            // 性别
            // 
            性别.HeaderText = "性别";
            性别.MinimumWidth = 8;
            性别.Name = "性别";
            性别.ReadOnly = true;
            性别.Width = 90;
            // 
            // 年龄
            // 
            年龄.HeaderText = "年龄";
            年龄.MinimumWidth = 8;
            年龄.Name = "年龄";
            年龄.ReadOnly = true;
            年龄.Width = 90;
            // 
            // 工龄
            // 
            工龄.HeaderText = "工龄";
            工龄.MinimumWidth = 8;
            工龄.Name = "工龄";
            工龄.ReadOnly = true;
            工龄.Width = 90;
            // 
            // 手机号码
            // 
            手机号码.HeaderText = "手机号码";
            手机号码.MinimumWidth = 8;
            手机号码.Name = "手机号码";
            手机号码.ReadOnly = true;
            手机号码.Width = 150;
            // 
            // 家庭住址
            // 
            家庭住址.HeaderText = "家庭住址";
            家庭住址.MinimumWidth = 8;
            家庭住址.Name = "家庭住址";
            家庭住址.ReadOnly = true;
            家庭住址.Width = 150;
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
            splitContainer1.Size = new Size(800, 458);
            splitContainer1.SplitterDistance = 388;
            splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(334, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 0;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(splitContainer1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load_1;
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
        private DataGridViewTextBoxColumn 员工编号;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 性别;
        private DataGridViewTextBoxColumn 年龄;
        private DataGridViewTextBoxColumn 工龄;
        private DataGridViewTextBoxColumn 手机号码;
        private DataGridViewTextBoxColumn 家庭住址;
        private SplitContainer splitContainer1;
        private Button button1;
    }
}
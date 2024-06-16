namespace 库存管理
{
    partial class Form2
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
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(300, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 30);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(300, 224);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 30);
            textBox5.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(300, 292);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 30);
            textBox7.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(312, 366);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 7;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(300, 38);
            label1.Name = "label1";
            label1.Size = new Size(237, 67);
            label1.TabIndex = 12;
            label1.Text = "欢迎注册";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(112, 158);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 13;
            label2.Text = "请输入用户名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(112, 226);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 14;
            label3.Text = "请输入密码";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(112, 294);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 15;
            label4.Text = "请确认密码";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox7;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
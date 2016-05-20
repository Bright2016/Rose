namespace mymouse
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnleft = new System.Windows.Forms.Button();
            this.btnmid = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.Test1 = new System.Windows.Forms.Button();
            this.Test2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(29, 65);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(75, 23);
            this.btnleft.TabIndex = 0;
            this.btnleft.Text = "左";
            this.btnleft.UseVisualStyleBackColor = true;
            // 
            // btnmid
            // 
            this.btnmid.Location = new System.Drawing.Point(29, 131);
            this.btnmid.Name = "btnmid";
            this.btnmid.Size = new System.Drawing.Size(75, 23);
            this.btnmid.TabIndex = 1;
            this.btnmid.Text = "中";
            this.btnmid.UseVisualStyleBackColor = true;
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(29, 193);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(75, 23);
            this.btnright.TabIndex = 2;
            this.btnright.Text = "右";
            this.btnright.UseVisualStyleBackColor = true;
            // 
            // Test1
            // 
            this.Test1.Location = new System.Drawing.Point(173, 65);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(75, 23);
            this.Test1.TabIndex = 3;
            this.Test1.Text = "button1";
            this.Test1.UseVisualStyleBackColor = true;
            this.Test1.Click += new System.EventHandler(this.Test1_Click);
            // 
            // Test2
            // 
            this.Test2.Location = new System.Drawing.Point(173, 131);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(75, 23);
            this.Test2.TabIndex = 4;
            this.Test2.Text = "button2";
            this.Test2.UseVisualStyleBackColor = true;
            this.Test2.Click += new System.EventHandler(this.Test2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Test2);
            this.Controls.Add(this.Test1);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnmid);
            this.Controls.Add(this.btnleft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnmid;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button Test1;
        private System.Windows.Forms.Button Test2;
    }
}


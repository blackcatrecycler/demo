namespace demo1
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
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.LalView = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNumAdd2 = new System.Windows.Forms.Button();
            this.BtnNumClear = new System.Windows.Forms.Button();
            this.BtnNumAdd1 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNum1
            // 
            this.BtnNum1.Location = new System.Drawing.Point(121, 227);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(133, 106);
            this.BtnNum1.TabIndex = 0;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = true;
            this.BtnNum1.Click += new System.EventHandler(this.BtnNum1_Click);
            // 
            // LalView
            // 
            this.LalView.AutoSize = true;
            this.LalView.Location = new System.Drawing.Point(44, 146);
            this.LalView.Name = "LalView";
            this.LalView.Size = new System.Drawing.Size(31, 15);
            this.LalView.TabIndex = 1;
            this.LalView.Text = "123";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(443, 121);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnNum2
            // 
            this.BtnNum2.Location = new System.Drawing.Point(316, 227);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(138, 106);
            this.BtnNum2.TabIndex = 3;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = true;
            this.BtnNum2.Click += new System.EventHandler(this.BtnNum2_Click);
            // 
            // BtnNumAdd2
            // 
            this.BtnNumAdd2.Location = new System.Drawing.Point(650, 146);
            this.BtnNumAdd2.Name = "BtnNumAdd2";
            this.BtnNumAdd2.Size = new System.Drawing.Size(111, 52);
            this.BtnNumAdd2.TabIndex = 4;
            this.BtnNumAdd2.Text = "+10";
            this.BtnNumAdd2.UseVisualStyleBackColor = true;
            // 
            // BtnNumClear
            // 
            this.BtnNumClear.Location = new System.Drawing.Point(521, 227);
            this.BtnNumClear.Name = "BtnNumClear";
            this.BtnNumClear.Size = new System.Drawing.Size(131, 106);
            this.BtnNumClear.TabIndex = 5;
            this.BtnNumClear.Text = "清除";
            this.BtnNumClear.UseVisualStyleBackColor = true;
            this.BtnNumClear.Click += new System.EventHandler(this.BtnNumClear_Click);
            // 
            // BtnNumAdd1
            // 
            this.BtnNumAdd1.Location = new System.Drawing.Point(650, 60);
            this.BtnNumAdd1.Name = "BtnNumAdd1";
            this.BtnNumAdd1.Size = new System.Drawing.Size(111, 51);
            this.BtnNumAdd1.TabIndex = 6;
            this.BtnNumAdd1.Text = "+3";
            this.BtnNumAdd1.UseVisualStyleBackColor = true;
            this.BtnNumAdd1.Click += new System.EventHandler(this.BtnNumAdd1_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(686, 227);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(75, 35);
            this.BtnPlus.TabIndex = 7;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(686, 286);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(75, 47);
            this.BtnResult.TabIndex = 8;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 364);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnNumAdd1);
            this.Controls.Add(this.BtnNumClear);
            this.Controls.Add(this.BtnNumAdd2);
            this.Controls.Add(this.BtnNum2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LalView);
            this.Controls.Add(this.BtnNum1);
            this.MaximumSize = new System.Drawing.Size(825, 411);
            this.MinimumSize = new System.Drawing.Size(825, 411);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Label LalView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.Button BtnNumAdd2;
        private System.Windows.Forms.Button BtnNumClear;
        internal System.Windows.Forms.Button BtnNumAdd1;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnResult;
    }
}


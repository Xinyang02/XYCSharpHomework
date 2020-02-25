namespace Caculator_2
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
            this.chooseOpe = new System.Windows.Forms.ComboBox();
            this.inputNum1 = new System.Windows.Forms.TextBox();
            this.inputNum2 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseOpe
            // 
            this.chooseOpe.FormattingEnabled = true;
            this.chooseOpe.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.chooseOpe.Location = new System.Drawing.Point(291, 155);
            this.chooseOpe.Name = "chooseOpe";
            this.chooseOpe.Size = new System.Drawing.Size(69, 23);
            this.chooseOpe.TabIndex = 0;
            this.chooseOpe.SelectedIndexChanged += new System.EventHandler(this.chooseOpe_SelectedIndexChanged);
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(171, 155);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(100, 25);
            this.inputNum1.TabIndex = 1;
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(380, 155);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(100, 25);
            this.inputNum2.TabIndex = 2;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(543, 158);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 15);
            this.answer.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.inputNum1);
            this.Controls.Add(this.chooseOpe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseOpe;
        private System.Windows.Forms.TextBox inputNum1;
        private System.Windows.Forms.TextBox inputNum2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button button1;
    }
}


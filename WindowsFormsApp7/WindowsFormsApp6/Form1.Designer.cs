namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.series = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.checker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // series
            // 
            this.series.Location = new System.Drawing.Point(15, 77);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(353, 20);
            this.series.TabIndex = 1;
            this.series.Text = "0";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(15, 120);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(353, 20);
            this.number.TabIndex = 2;
            this.number.Text = "0";
            // 
            // checker
            // 
            this.checker.Location = new System.Drawing.Point(15, 163);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(122, 23);
            this.checker.TabIndex = 5;
            this.checker.Text = "check passport data";
            this.checker.UseVisualStyleBackColor = true;
            this.checker.Click += new System.EventHandler(this.gen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.checker);
            this.Controls.Add(this.number);
            this.Controls.Add(this.series);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox series;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button checker;
    }
}


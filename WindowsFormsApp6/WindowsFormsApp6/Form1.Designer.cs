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
            this.pass = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.latin = new System.Windows.Forms.TextBox();
            this.digits = new System.Windows.Forms.TextBox();
            this.special = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(12, 24);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(35, 13);
            this.pass.TabIndex = 0;
            this.pass.Text = "label1";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(15, 77);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(70, 20);
            this.amount.TabIndex = 1;
            this.amount.Text = "0";
            this.amount.Leave += new System.EventHandler(this.amount_Leave);
            // 
            // latin
            // 
            this.latin.Location = new System.Drawing.Point(15, 120);
            this.latin.Name = "latin";
            this.latin.Size = new System.Drawing.Size(70, 20);
            this.latin.TabIndex = 2;
            this.latin.Text = "0";
            this.latin.Leave += new System.EventHandler(this.latin_Leave);
            // 
            // digits
            // 
            this.digits.Location = new System.Drawing.Point(15, 169);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(70, 20);
            this.digits.TabIndex = 3;
            this.digits.Text = "0";
            this.digits.Leave += new System.EventHandler(this.digits_Leave);
            // 
            // special
            // 
            this.special.Location = new System.Drawing.Point(15, 222);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(70, 20);
            this.special.TabIndex = 4;
            this.special.Text = "0";
            this.special.Leave += new System.EventHandler(this.special_Leave);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(15, 276);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(122, 23);
            this.gen.TabIndex = 5;
            this.gen.Text = "generate password";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(15, 361);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(122, 23);
            this.list.TabIndex = 6;
            this.list.Text = "see list of passwords";
            this.list.UseVisualStyleBackColor = true;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(15, 320);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(122, 23);
            this.copy.TabIndex = 7;
            this.copy.Text = "copy password";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.list);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.special);
            this.Controls.Add(this.digits);
            this.Controls.Add(this.latin);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.pass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox latin;
        private System.Windows.Forms.TextBox digits;
        private System.Windows.Forms.TextBox special;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button copy;
    }
}


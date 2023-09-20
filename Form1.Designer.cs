namespace BudgetApp
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
            this.logbuttom = new System.Windows.Forms.Button();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.passfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logbuttom
            // 
            this.logbuttom.Location = new System.Drawing.Point(488, 65);
            this.logbuttom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logbuttom.Name = "logbuttom";
            this.logbuttom.Size = new System.Drawing.Size(100, 28);
            this.logbuttom.TabIndex = 0;
            this.logbuttom.Text = "Log In";
            this.logbuttom.UseVisualStyleBackColor = true;
            this.logbuttom.Click += new System.EventHandler(this.logbuttom_Click);
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(285, 69);
            this.loginfield.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(132, 22);
            this.loginfield.TabIndex = 1;
            // 
            // passfield
            // 
            this.passfield.Location = new System.Drawing.Point(285, 102);
            this.passfield.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(132, 22);
            this.passfield.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.passfield);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.logbuttom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logbuttom;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.TextBox passfield;
    }
}


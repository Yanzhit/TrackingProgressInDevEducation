
namespace TrackingProgressInDevEducation.Forms
{
    partial class Main
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
            this.InputLogin = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputLogin
            // 
            this.InputLogin.Location = new System.Drawing.Point(39, 66);
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.Size = new System.Drawing.Size(229, 20);
            this.InputLogin.TabIndex = 0;
            this.InputLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(39, 126);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(229, 20);
            this.InputPassword.TabIndex = 1;
            this.InputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(112, 163);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // LoginText
            // 
            this.LoginText.Enabled = false;
            this.LoginText.Location = new System.Drawing.Point(39, 40);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(37, 20);
            this.LoginText.TabIndex = 3;
            this.LoginText.Text = "Логин";
            // 
            // PasswordText
            // 
            this.PasswordText.Enabled = false;
            this.PasswordText.Location = new System.Drawing.Point(39, 100);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Пароль";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 231);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputLogin);
            this.Name = "Main";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputLogin;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
    }
}


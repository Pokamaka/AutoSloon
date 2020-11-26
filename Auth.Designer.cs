namespace AutoSloon
{
    partial class Auth
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_closed = new System.Windows.Forms.Button();
            this.tb_UserLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_UserPassword = new System.Windows.Forms.TextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.btn_HelpPasswrod = new System.Windows.Forms.Label();
            this.btn_Reg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для авторизации введите \r\nВаш логин и пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать!";
            // 
            // btn_closed
            // 
            this.btn_closed.FlatAppearance.BorderSize = 0;
            this.btn_closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closed.Location = new System.Drawing.Point(445, 1);
            this.btn_closed.Name = "btn_closed";
            this.btn_closed.Size = new System.Drawing.Size(30, 30);
            this.btn_closed.TabIndex = 2;
            this.btn_closed.Text = "X";
            this.btn_closed.UseVisualStyleBackColor = true;
            this.btn_closed.Click += new System.EventHandler(this.btn_closed_Click);
            // 
            // tb_UserLogin
            // 
            this.tb_UserLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_UserLogin.Location = new System.Drawing.Point(190, 161);
            this.tb_UserLogin.Name = "tb_UserLogin";
            this.tb_UserLogin.Size = new System.Drawing.Size(178, 31);
            this.tb_UserLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Логин:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_UserPassword
            // 
            this.tb_UserPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_UserPassword.Location = new System.Drawing.Point(190, 208);
            this.tb_UserPassword.Name = "tb_UserPassword";
            this.tb_UserPassword.PasswordChar = '*';
            this.tb_UserPassword.Size = new System.Drawing.Size(178, 31);
            this.tb_UserPassword.TabIndex = 3;
            this.tb_UserPassword.UseSystemPasswordChar = true;
            // 
            // btn_auth
            // 
            this.btn_auth.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_auth.FlatAppearance.BorderSize = 0;
            this.btn_auth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auth.ForeColor = System.Drawing.Color.White;
            this.btn_auth.Location = new System.Drawing.Point(163, 276);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(150, 55);
            this.btn_auth.TabIndex = 4;
            this.btn_auth.Text = "Войти";
            this.btn_auth.UseVisualStyleBackColor = false;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // btn_HelpPasswrod
            // 
            this.btn_HelpPasswrod.AutoSize = true;
            this.btn_HelpPasswrod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HelpPasswrod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_HelpPasswrod.ForeColor = System.Drawing.Color.Gray;
            this.btn_HelpPasswrod.Location = new System.Drawing.Point(358, 355);
            this.btn_HelpPasswrod.Name = "btn_HelpPasswrod";
            this.btn_HelpPasswrod.Size = new System.Drawing.Size(116, 16);
            this.btn_HelpPasswrod.TabIndex = 5;
            this.btn_HelpPasswrod.Text = "Забыли пароль?";
            // 
            // btn_Reg
            // 
            this.btn_Reg.AutoSize = true;
            this.btn_Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reg.ForeColor = System.Drawing.Color.Gray;
            this.btn_Reg.Location = new System.Drawing.Point(4, 355);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(94, 16);
            this.btn_Reg.TabIndex = 5;
            this.btn_Reg.Text = "Регистрация";
            // 
            // Auth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 374);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.btn_HelpPasswrod);
            this.Controls.Add(this.btn_auth);
            this.Controls.Add(this.tb_UserPassword);
            this.Controls.Add(this.tb_UserLogin);
            this.Controls.Add(this.btn_closed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_closed;
        private System.Windows.Forms.TextBox tb_UserLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_UserPassword;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Label btn_HelpPasswrod;
        private System.Windows.Forms.Label btn_Reg;
    }
}



namespace Client
{
    partial class RegistrationForm
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonBackLogRegForm = new System.Windows.Forms.Button();
            this.comboBoxAccessRight = new System.Windows.Forms.ComboBox();
            this.labelAccessRight = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Enabled = false;
            this.buttonRegistration.Location = new System.Drawing.Point(135, 182);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(130, 38);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonBackLogRegForm
            // 
            this.buttonBackLogRegForm.Location = new System.Drawing.Point(24, 218);
            this.buttonBackLogRegForm.Name = "buttonBackLogRegForm";
            this.buttonBackLogRegForm.Size = new System.Drawing.Size(75, 35);
            this.buttonBackLogRegForm.TabIndex = 1;
            this.buttonBackLogRegForm.Text = "<< Назад";
            this.buttonBackLogRegForm.UseVisualStyleBackColor = true;
            this.buttonBackLogRegForm.Click += new System.EventHandler(this.buttonBackLogRegForm_Click);
            // 
            // comboBoxAccessRight
            // 
            this.comboBoxAccessRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccessRight.FormattingEnabled = true;
            this.comboBoxAccessRight.Items.AddRange(new object[] {
            "Администратор",
            "Авинавигационный специалист"});
            this.comboBoxAccessRight.Location = new System.Drawing.Point(135, 44);
            this.comboBoxAccessRight.Name = "comboBoxAccessRight";
            this.comboBoxAccessRight.Size = new System.Drawing.Size(183, 23);
            this.comboBoxAccessRight.TabIndex = 2;
            this.comboBoxAccessRight.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAccessRight
            // 
            this.labelAccessRight.AutoSize = true;
            this.labelAccessRight.Location = new System.Drawing.Point(38, 26);
            this.labelAccessRight.Name = "labelAccessRight";
            this.labelAccessRight.Size = new System.Drawing.Size(234, 15);
            this.labelAccessRight.TabIndex = 3;
            this.labelAccessRight.Text = "Выберите права доступа учётной записи:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(38, 70);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(178, 15);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Введите логин учётной записи:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(38, 122);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(185, 15);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Введите пароль учётной записи:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(135, 88);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(130, 23);
            this.textBoxLogin.TabIndex = 8;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(135, 140);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(130, 23);
            this.textBoxPass.TabIndex = 9;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(380, 275);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAccessRight);
            this.Controls.Add(this.comboBoxAccessRight);
            this.Controls.Add(this.buttonBackLogRegForm);
            this.Controls.Add(this.buttonRegistration);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно регистрации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonBackLogRegForm;
        private System.Windows.Forms.ComboBox comboBoxAccessRight;
        private System.Windows.Forms.Label labelAccessRight;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}
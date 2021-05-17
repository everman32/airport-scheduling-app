
namespace Client
{
    partial class ActionChoiseForm
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
            this.buttonLogForm = new System.Windows.Forms.Button();
            this.buttonRegForm = new System.Windows.Forms.Button();
            this.buttonBackMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogForm
            // 
            this.buttonLogForm.Location = new System.Drawing.Point(117, 38);
            this.buttonLogForm.Name = "buttonLogForm";
            this.buttonLogForm.Size = new System.Drawing.Size(99, 29);
            this.buttonLogForm.TabIndex = 0;
            this.buttonLogForm.Text = "Авторизация";
            this.buttonLogForm.UseVisualStyleBackColor = true;
            this.buttonLogForm.Click += new System.EventHandler(this.buttonAuthorizationPanel_Click);
            // 
            // buttonRegForm
            // 
            this.buttonRegForm.Location = new System.Drawing.Point(117, 94);
            this.buttonRegForm.Name = "buttonRegForm";
            this.buttonRegForm.Size = new System.Drawing.Size(99, 29);
            this.buttonRegForm.TabIndex = 1;
            this.buttonRegForm.Text = "Регистрация";
            this.buttonRegForm.UseVisualStyleBackColor = true;
            this.buttonRegForm.Click += new System.EventHandler(this.buttonRegForm_Click);
            // 
            // buttonBackMainForm
            // 
            this.buttonBackMainForm.Location = new System.Drawing.Point(12, 123);
            this.buttonBackMainForm.Name = "buttonBackMainForm";
            this.buttonBackMainForm.Size = new System.Drawing.Size(75, 33);
            this.buttonBackMainForm.TabIndex = 2;
            this.buttonBackMainForm.Text = "<< Назад";
            this.buttonBackMainForm.UseVisualStyleBackColor = true;
            this.buttonBackMainForm.Click += new System.EventHandler(this.buttonBackMainForm_Click);
            // 
            // ActionChoiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.buttonBackMainForm);
            this.Controls.Add(this.buttonRegForm);
            this.Controls.Add(this.buttonLogForm);
            this.MaximizeBox = false;
            this.Name = "ActionChoiseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно выбора действия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogRegForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginRegisterPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogForm;
        private System.Windows.Forms.Button buttonRegForm;
        private System.Windows.Forms.Button buttonBackMainForm;
    }
}

namespace Client
{
    partial class LoginRegisterPanel
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
            this.buttonAuthorizationPanel = new System.Windows.Forms.Button();
            this.buttonRegisterPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorizationPanel
            // 
            this.buttonAuthorizationPanel.Location = new System.Drawing.Point(117, 38);
            this.buttonAuthorizationPanel.Name = "buttonAuthorizationPanel";
            this.buttonAuthorizationPanel.Size = new System.Drawing.Size(99, 29);
            this.buttonAuthorizationPanel.TabIndex = 0;
            this.buttonAuthorizationPanel.Text = "Авторизация";
            this.buttonAuthorizationPanel.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterPanel
            // 
            this.buttonRegisterPanel.Location = new System.Drawing.Point(117, 94);
            this.buttonRegisterPanel.Name = "buttonRegisterPanel";
            this.buttonRegisterPanel.Size = new System.Drawing.Size(99, 29);
            this.buttonRegisterPanel.TabIndex = 1;
            this.buttonRegisterPanel.Text = "Регистрация";
            this.buttonRegisterPanel.UseVisualStyleBackColor = true;
            // 
            // LoginRegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.buttonRegisterPanel);
            this.Controls.Add(this.buttonAuthorizationPanel);
            this.Name = "LoginRegisterPanel";
            this.Text = "LoginRegisterPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorizationPanel;
        private System.Windows.Forms.Button buttonRegisterPanel;
    }
}
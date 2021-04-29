
namespace Client
{
    partial class AdminForm
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
            this.buttonBackLogForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackLogForm
            // 
            this.buttonBackLogForm.Location = new System.Drawing.Point(22, 367);
            this.buttonBackLogForm.Name = "buttonBackLogForm";
            this.buttonBackLogForm.Size = new System.Drawing.Size(80, 39);
            this.buttonBackLogForm.TabIndex = 0;
            this.buttonBackLogForm.Text = "<< Назад";
            this.buttonBackLogForm.UseVisualStyleBackColor = true;
            this.buttonBackLogForm.Click += new System.EventHandler(this.buttonBackLogin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(516, 418);
            this.Controls.Add(this.buttonBackLogForm);
            this.Name = "AdminForm";
            this.Text = "Окно администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackLogForm;
    }
}
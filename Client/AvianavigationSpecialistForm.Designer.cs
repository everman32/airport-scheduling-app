﻿
namespace Client
{
    partial class AvianavigationSpecialistForm
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
            this.buttonBackLogForm.Location = new System.Drawing.Point(29, 300);
            this.buttonBackLogForm.Name = "buttonBackLogForm";
            this.buttonBackLogForm.Size = new System.Drawing.Size(91, 37);
            this.buttonBackLogForm.TabIndex = 0;
            this.buttonBackLogForm.Text = "<< Назад";
            this.buttonBackLogForm.UseVisualStyleBackColor = true;
            this.buttonBackLogForm.Click += new System.EventHandler(this.buttonBackLogReg_Click);
            // 
            // AvianavigationSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(514, 357);
            this.Controls.Add(this.buttonBackLogForm);
            this.Name = "AvianavigationSpecialistForm";
            this.Text = "Окно авинавигационного специалиста";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackLogForm;
    }
}
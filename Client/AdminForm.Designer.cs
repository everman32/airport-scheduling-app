
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
            this.buttonWorkFlightRequests = new System.Windows.Forms.Button();
            this.buttonSearchBestAlternative = new System.Windows.Forms.Button();
            this.buttonWorkDestinations = new System.Windows.Forms.Button();
            this.buttonWorkPassengers = new System.Windows.Forms.Button();
            this.buttonWorkAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackLogForm
            // 
            this.buttonBackLogForm.Location = new System.Drawing.Point(19, 318);
            this.buttonBackLogForm.Name = "buttonBackLogForm";
            this.buttonBackLogForm.Size = new System.Drawing.Size(69, 34);
            this.buttonBackLogForm.TabIndex = 0;
            this.buttonBackLogForm.Text = "<< Назад";
            this.buttonBackLogForm.UseVisualStyleBackColor = true;
            this.buttonBackLogForm.Click += new System.EventHandler(this.buttonBackLogin_Click);
            // 
            // buttonWorkFlightRequests
            // 
            this.buttonWorkFlightRequests.Location = new System.Drawing.Point(127, 137);
            this.buttonWorkFlightRequests.Name = "buttonWorkFlightRequests";
            this.buttonWorkFlightRequests.Size = new System.Drawing.Size(197, 38);
            this.buttonWorkFlightRequests.TabIndex = 8;
            this.buttonWorkFlightRequests.Text = "Работа с заявками на полёты";
            this.buttonWorkFlightRequests.UseVisualStyleBackColor = true;
            this.buttonWorkFlightRequests.Click += new System.EventHandler(this.buttonWorkFlightRequests_Click);
            // 
            // buttonSearchBestAlternative
            // 
            this.buttonSearchBestAlternative.Location = new System.Drawing.Point(125, 192);
            this.buttonSearchBestAlternative.Name = "buttonSearchBestAlternative";
            this.buttonSearchBestAlternative.Size = new System.Drawing.Size(199, 48);
            this.buttonSearchBestAlternative.TabIndex = 7;
            this.buttonSearchBestAlternative.Text = "Поиск наилучшей альтернативы расписания для пункта назначения";
            this.buttonSearchBestAlternative.UseVisualStyleBackColor = true;
            this.buttonSearchBestAlternative.Click += new System.EventHandler(this.buttonSearchBestAlternative_Click);
            // 
            // buttonWorkDestinations
            // 
            this.buttonWorkDestinations.Location = new System.Drawing.Point(127, 85);
            this.buttonWorkDestinations.Name = "buttonWorkDestinations";
            this.buttonWorkDestinations.Size = new System.Drawing.Size(197, 37);
            this.buttonWorkDestinations.TabIndex = 6;
            this.buttonWorkDestinations.Text = "Работа с пунктами назначения";
            this.buttonWorkDestinations.UseVisualStyleBackColor = true;
            this.buttonWorkDestinations.Click += new System.EventHandler(this.buttonWorkDestinations_Click);
            // 
            // buttonWorkPassengers
            // 
            this.buttonWorkPassengers.Location = new System.Drawing.Point(127, 31);
            this.buttonWorkPassengers.Name = "buttonWorkPassengers";
            this.buttonWorkPassengers.Size = new System.Drawing.Size(197, 37);
            this.buttonWorkPassengers.TabIndex = 5;
            this.buttonWorkPassengers.Text = "Работа с пассажирами";
            this.buttonWorkPassengers.UseVisualStyleBackColor = true;
            this.buttonWorkPassengers.Click += new System.EventHandler(this.buttonWorkPassengers_Click);
            // 
            // buttonWorkAccounts
            // 
            this.buttonWorkAccounts.Location = new System.Drawing.Point(127, 260);
            this.buttonWorkAccounts.Name = "buttonWorkAccounts";
            this.buttonWorkAccounts.Size = new System.Drawing.Size(197, 36);
            this.buttonWorkAccounts.TabIndex = 9;
            this.buttonWorkAccounts.Text = "Работа с учётными записями";
            this.buttonWorkAccounts.UseVisualStyleBackColor = true;
            this.buttonWorkAccounts.Click += new System.EventHandler(this.buttonWorkAccounts_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(442, 362);
            this.Controls.Add(this.buttonWorkAccounts);
            this.Controls.Add(this.buttonWorkFlightRequests);
            this.Controls.Add(this.buttonSearchBestAlternative);
            this.Controls.Add(this.buttonWorkDestinations);
            this.Controls.Add(this.buttonWorkPassengers);
            this.Controls.Add(this.buttonBackLogForm);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackLogForm;
        private System.Windows.Forms.Button buttonWorkFlightRequests;
        private System.Windows.Forms.Button buttonSearchBestAlternative;
        private System.Windows.Forms.Button buttonWorkDestinations;
        private System.Windows.Forms.Button buttonWorkPassengers;
        private System.Windows.Forms.Button buttonWorkAccounts;
    }
}
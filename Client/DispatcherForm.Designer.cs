
namespace Client
{
    partial class DispatcherForm
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
            this.buttonWorkPassengers = new System.Windows.Forms.Button();
            this.buttonWorkDestinations = new System.Windows.Forms.Button();
            this.buttonSearchBestAlternative = new System.Windows.Forms.Button();
            this.buttonWorkFlightRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackLogForm
            // 
            this.buttonBackLogForm.Location = new System.Drawing.Point(12, 308);
            this.buttonBackLogForm.Name = "buttonBackLogForm";
            this.buttonBackLogForm.Size = new System.Drawing.Size(91, 37);
            this.buttonBackLogForm.TabIndex = 0;
            this.buttonBackLogForm.Text = "<< Назад";
            this.buttonBackLogForm.UseVisualStyleBackColor = true;
            this.buttonBackLogForm.Click += new System.EventHandler(this.buttonBackLogReg_Click);
            // 
            // buttonWorkPassengers
            // 
            this.buttonWorkPassengers.Location = new System.Drawing.Point(163, 34);
            this.buttonWorkPassengers.Name = "buttonWorkPassengers";
            this.buttonWorkPassengers.Size = new System.Drawing.Size(197, 43);
            this.buttonWorkPassengers.TabIndex = 1;
            this.buttonWorkPassengers.Text = "Работа с пассажирами";
            this.buttonWorkPassengers.UseVisualStyleBackColor = true;
            this.buttonWorkPassengers.Click += new System.EventHandler(this.buttonWorkClients_Click);
            // 
            // buttonWorkDestinations
            // 
            this.buttonWorkDestinations.Location = new System.Drawing.Point(163, 94);
            this.buttonWorkDestinations.Name = "buttonWorkDestinations";
            this.buttonWorkDestinations.Size = new System.Drawing.Size(197, 43);
            this.buttonWorkDestinations.TabIndex = 2;
            this.buttonWorkDestinations.Text = "Работа с пунктами назначения";
            this.buttonWorkDestinations.UseVisualStyleBackColor = true;
            this.buttonWorkDestinations.Click += new System.EventHandler(this.buttonWorkDestinations_Click);
            // 
            // buttonSearchBestAlternative
            // 
            this.buttonSearchBestAlternative.Location = new System.Drawing.Point(161, 216);
            this.buttonSearchBestAlternative.Name = "buttonSearchBestAlternative";
            this.buttonSearchBestAlternative.Size = new System.Drawing.Size(199, 40);
            this.buttonSearchBestAlternative.TabIndex = 3;
            this.buttonSearchBestAlternative.Text = "Поиск наилучшей альтернативы расписания для пункта назначения";
            this.buttonSearchBestAlternative.UseVisualStyleBackColor = true;
            this.buttonSearchBestAlternative.Click += new System.EventHandler(this.buttonSearchBestAlternative_Click);
            // 
            // buttonWorkFlightRequests
            // 
            this.buttonWorkFlightRequests.Location = new System.Drawing.Point(163, 152);
            this.buttonWorkFlightRequests.Name = "buttonWorkFlightRequests";
            this.buttonWorkFlightRequests.Size = new System.Drawing.Size(197, 44);
            this.buttonWorkFlightRequests.TabIndex = 4;
            this.buttonWorkFlightRequests.Text = "Работа с заявками на полёты";
            this.buttonWorkFlightRequests.UseVisualStyleBackColor = true;
            this.buttonWorkFlightRequests.Click += new System.EventHandler(this.buttonWorkFlightRequests_Click);
            // 
            // DispatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(514, 357);
            this.Controls.Add(this.buttonWorkFlightRequests);
            this.Controls.Add(this.buttonSearchBestAlternative);
            this.Controls.Add(this.buttonWorkDestinations);
            this.Controls.Add(this.buttonWorkPassengers);
            this.Controls.Add(this.buttonBackLogForm);
            this.MaximizeBox = false;
            this.Name = "DispatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно диспетчера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AvianavigationSpecialistForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackLogForm;
        private System.Windows.Forms.Button buttonWorkPassengers;
        private System.Windows.Forms.Button buttonWorkDestinations;
        private System.Windows.Forms.Button buttonSearchBestAlternative;
        private System.Windows.Forms.Button buttonWorkFlightRequests;
    }
}

namespace Client
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonConnectClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(31, 22);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(38, 15);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Порт:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(238, 19);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(108, 23);
            this.textBoxPort.TabIndex = 1;
            // 
            // buttonConnectClient
            // 
            this.buttonConnectClient.Location = new System.Drawing.Point(238, 78);
            this.buttonConnectClient.Name = "buttonConnectClient";
            this.buttonConnectClient.Size = new System.Drawing.Size(108, 45);
            this.buttonConnectClient.TabIndex = 2;
            this.buttonConnectClient.Text = "Подключиться к серверу";
            this.buttonConnectClient.UseVisualStyleBackColor = true;
            this.buttonConnectClient.Click += new System.EventHandler(this.buttonConnectClient_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(377, 135);
            this.Controls.Add(this.buttonConnectClient);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Name = "MainPanel";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnectClient;
    }
}


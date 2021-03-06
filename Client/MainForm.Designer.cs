
namespace Client
{
    partial class MainForm
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
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(35, 21);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(148, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Введите порт подключения:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPort.Location = new System.Drawing.Point(204, 16);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(93, 26);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // buttonConnectClient
            // 
            this.buttonConnectClient.Enabled = false;
            this.buttonConnectClient.Location = new System.Drawing.Point(204, 52);
            this.buttonConnectClient.Name = "buttonConnectClient";
            this.buttonConnectClient.Size = new System.Drawing.Size(93, 39);
            this.buttonConnectClient.TabIndex = 2;
            this.buttonConnectClient.Text = "Подключиться к серверу";
            this.buttonConnectClient.UseVisualStyleBackColor = true;
            this.buttonConnectClient.Click += new System.EventHandler(this.buttonConnectClient_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Location = new System.Drawing.Point(10, 75);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(64, 31);
            this.buttonShutdown.TabIndex = 3;
            this.buttonShutdown.Text = "Выход";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(323, 117);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonConnectClient);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно подключения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnectClient;
        private System.Windows.Forms.Button buttonShutdown;
    }
}


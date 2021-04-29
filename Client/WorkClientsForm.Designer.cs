
namespace Client
{
    partial class WorkClientsForm
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
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.buttonUploadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(31, 282);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(91, 37);
            this.buttonBackAvianavForm.TabIndex = 0;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Location = new System.Drawing.Point(160, 59);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.RowTemplate.Height = 25;
            this.ClientsGridView.Size = new System.Drawing.Size(527, 168);
            this.ClientsGridView.TabIndex = 1;
            // 
            // buttonUploadData
            // 
            this.buttonUploadData.Location = new System.Drawing.Point(31, 43);
            this.buttonUploadData.Name = "buttonUploadData";
            this.buttonUploadData.Size = new System.Drawing.Size(91, 44);
            this.buttonUploadData.TabIndex = 2;
            this.buttonUploadData.Text = "Получить данные";
            this.buttonUploadData.UseVisualStyleBackColor = true;
            this.buttonUploadData.Click += new System.EventHandler(this.buttonUploadData_Click);
            // 
            // WorkClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(739, 355);
            this.Controls.Add(this.buttonUploadData);
            this.Controls.Add(this.ClientsGridView);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.Name = "WorkClientsForm";
            this.Text = "Окно работы с клиентами";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.Button buttonUploadData;
    }
}

namespace Client
{
    partial class Report
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
            this.PassengersFlightGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersFlightGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengersFlightGridView
            // 
            this.PassengersFlightGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PassengersFlightGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassengersFlightGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersFlightGridView.Location = new System.Drawing.Point(27, 24);
            this.PassengersFlightGridView.Name = "PassengersFlightGridView";
            this.PassengersFlightGridView.RowTemplate.Height = 25;
            this.PassengersFlightGridView.Size = new System.Drawing.Size(702, 316);
            this.PassengersFlightGridView.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassengersFlightGridView);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно отчёта о пассажирах пункта назначения";
            ((System.ComponentModel.ISupportInitialize)(this.PassengersFlightGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView PassengersFlightGridView;
    }
}

namespace Client
{
    partial class WorkDestinationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDestinationsForm));
            this.toolStripWorkDestinations = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.DestinationsGridView = new System.Windows.Forms.DataGridView();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripWorkDestinations.SuspendLayout();
            this.panelViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationsGridView)).BeginInit();
            this.panelAdding.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripWorkDestinations
            // 
            this.toolStripWorkDestinations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButton1});
            this.toolStripWorkDestinations.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkDestinations.Name = "toolStripWorkDestinations";
            this.toolStripWorkDestinations.Size = new System.Drawing.Size(938, 25);
            this.toolStripWorkDestinations.TabIndex = 0;
            this.toolStripWorkDestinations.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(235, 22);
            this.toolStripButtonView.Text = "Просмотр данных о пунктах назначения";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(224, 22);
            this.toolStripButtonAdd.Text = "Добавить данные о пункте назначения";
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(252, 22);
            this.toolStripButtonEdit.Text = "Редактировать данные о пункте назначения";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(216, 22);
            this.toolStripButton1.Text = "Удалить данные о пункте назначения";
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(35, 275);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(81, 34);
            this.buttonBackAvianavForm.TabIndex = 1;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // panelViewing
            // 
            this.panelViewing.Controls.Add(this.DestinationsGridView);
            this.panelViewing.Location = new System.Drawing.Point(219, 74);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(404, 176);
            this.panelViewing.TabIndex = 2;
            // 
            // DestinationsGridView
            // 
            this.DestinationsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DestinationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationsGridView.Location = new System.Drawing.Point(14, 12);
            this.DestinationsGridView.Name = "DestinationsGridView";
            this.DestinationsGridView.RowTemplate.Height = 25;
            this.DestinationsGridView.Size = new System.Drawing.Size(374, 150);
            this.DestinationsGridView.TabIndex = 0;
            // 
            // panelAdding
            // 
            this.panelAdding.Controls.Add(this.label1);
            this.panelAdding.Location = new System.Drawing.Point(192, 71);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(440, 213);
            this.panelAdding.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // WorkDestinationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(938, 336);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.Controls.Add(this.toolStripWorkDestinations);
            this.Name = "WorkDestinationsForm";
            this.Text = "Окно работы с пунктами назначения";
            this.toolStripWorkDestinations.ResumeLayout(false);
            this.toolStripWorkDestinations.PerformLayout();
            this.panelViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationsGridView)).EndInit();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripWorkDestinations;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.DataGridView DestinationsGridView;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Label label1;
    }
}
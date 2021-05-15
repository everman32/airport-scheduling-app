
namespace Client
{
    partial class WorkCondorsetAlternative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkCondorsetAlternative));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSearchAlternative = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSchedule = new System.Windows.Forms.ToolStripButton();
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.panelSearchingAlternative = new System.Windows.Forms.Panel();
            this.buttonSearchAlternative = new System.Windows.Forms.Button();
            this.labelPairwiseComparison = new System.Windows.Forms.Label();
            this.dataGridPairwiseComparison = new System.Windows.Forms.DataGridView();
            this.dataGridPreferences = new System.Windows.Forms.DataGridView();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.buttonGetEstimatedPriorityTimes = new System.Windows.Forms.Button();
            this.buttonPairwiseComparison = new System.Windows.Forms.Button();
            this.dataGridPriorityTimes = new System.Windows.Forms.DataGridView();
            this.labelPriorityTimes = new System.Windows.Forms.Label();
            this.dataGridEstimatedTimes = new System.Windows.Forms.DataGridView();
            this.labelEstimatedTimes = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.panelViewingSchedule = new System.Windows.Forms.Panel();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.panelDeletingSchedule = new System.Windows.Forms.Panel();
            this.buttonDeleteSchedule = new System.Windows.Forms.Button();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelSearchingAlternative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPairwiseComparison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreferences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriorityTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstimatedTimes)).BeginInit();
            this.panelViewingSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.panelDeletingSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSearchAlternative,
            this.toolStripButtonViewSchedule,
            this.toolStripButtonDeleteSchedule});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSearchAlternative
            // 
            this.toolStripButtonSearchAlternative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearchAlternative.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchAlternative.Image")));
            this.toolStripButtonSearchAlternative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchAlternative.Name = "toolStripButtonSearchAlternative";
            this.toolStripButtonSearchAlternative.Size = new System.Drawing.Size(321, 22);
            this.toolStripButtonSearchAlternative.Text = "Найти наилучшую альтернативу для пункта назначения";
            this.toolStripButtonSearchAlternative.Click += new System.EventHandler(this.toolStripButtonSearchAlternative_Click);
            // 
            // toolStripButtonViewSchedule
            // 
            this.toolStripButtonViewSchedule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonViewSchedule.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewSchedule.Image")));
            this.toolStripButtonViewSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewSchedule.Name = "toolStripButtonViewSchedule";
            this.toolStripButtonViewSchedule.Size = new System.Drawing.Size(188, 22);
            this.toolStripButtonViewSchedule.Text = "Просмотр готового расписания";
            this.toolStripButtonViewSchedule.Click += new System.EventHandler(this.toolStripButtonViewSchedule_Click);
            // 
            // toolStripButtonDeleteSchedule
            // 
            this.toolStripButtonDeleteSchedule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteSchedule.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteSchedule.Image")));
            this.toolStripButtonDeleteSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteSchedule.Name = "toolStripButtonDeleteSchedule";
            this.toolStripButtonDeleteSchedule.Size = new System.Drawing.Size(123, 22);
            this.toolStripButtonDeleteSchedule.Text = "Удалить расписание";
            this.toolStripButtonDeleteSchedule.Click += new System.EventHandler(this.toolStripButtonDeleteSchedule_Click);
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(12, 641);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(84, 36);
            this.buttonBackAvianavForm.TabIndex = 1;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // panelSearchingAlternative
            // 
            this.panelSearchingAlternative.Controls.Add(this.buttonSearchAlternative);
            this.panelSearchingAlternative.Controls.Add(this.labelPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.dataGridPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.dataGridPreferences);
            this.panelSearchingAlternative.Controls.Add(this.labelPreferences);
            this.panelSearchingAlternative.Controls.Add(this.buttonGetEstimatedPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.buttonPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.dataGridPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.labelPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.dataGridEstimatedTimes);
            this.panelSearchingAlternative.Controls.Add(this.labelEstimatedTimes);
            this.panelSearchingAlternative.Controls.Add(this.labelDestination);
            this.panelSearchingAlternative.Controls.Add(this.comboBoxDestination);
            this.panelSearchingAlternative.Location = new System.Drawing.Point(12, 28);
            this.panelSearchingAlternative.Name = "panelSearchingAlternative";
            this.panelSearchingAlternative.Size = new System.Drawing.Size(777, 607);
            this.panelSearchingAlternative.TabIndex = 2;
            // 
            // buttonSearchAlternative
            // 
            this.buttonSearchAlternative.Location = new System.Drawing.Point(530, 281);
            this.buttonSearchAlternative.Name = "buttonSearchAlternative";
            this.buttonSearchAlternative.Size = new System.Drawing.Size(135, 37);
            this.buttonSearchAlternative.TabIndex = 12;
            this.buttonSearchAlternative.Text = "Найти альтернативы";
            this.buttonSearchAlternative.UseVisualStyleBackColor = true;
            this.buttonSearchAlternative.Visible = false;
            this.buttonSearchAlternative.Click += new System.EventHandler(this.buttonSearchAlternative_Click);
            // 
            // labelPairwiseComparison
            // 
            this.labelPairwiseComparison.AutoSize = true;
            this.labelPairwiseComparison.Location = new System.Drawing.Point(458, 121);
            this.labelPairwiseComparison.Name = "labelPairwiseComparison";
            this.labelPairwiseComparison.Size = new System.Drawing.Size(180, 15);
            this.labelPairwiseComparison.TabIndex = 11;
            this.labelPairwiseComparison.Text = "Матрица попарных сравнений:";
            this.labelPairwiseComparison.Visible = false;
            // 
            // dataGridPairwiseComparison
            // 
            this.dataGridPairwiseComparison.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPairwiseComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPairwiseComparison.Location = new System.Drawing.Point(458, 139);
            this.dataGridPairwiseComparison.Name = "dataGridPairwiseComparison";
            this.dataGridPairwiseComparison.RowTemplate.Height = 25;
            this.dataGridPairwiseComparison.Size = new System.Drawing.Size(274, 123);
            this.dataGridPairwiseComparison.TabIndex = 10;
            this.dataGridPairwiseComparison.Visible = false;
            // 
            // dataGridPreferences
            // 
            this.dataGridPreferences.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPreferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreferences.Location = new System.Drawing.Point(0, 359);
            this.dataGridPreferences.Name = "dataGridPreferences";
            this.dataGridPreferences.RowTemplate.Height = 25;
            this.dataGridPreferences.Size = new System.Drawing.Size(404, 160);
            this.dataGridPreferences.TabIndex = 9;
            this.dataGridPreferences.Visible = false;
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Location = new System.Drawing.Point(0, 341);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(256, 15);
            this.labelPreferences.TabIndex = 8;
            this.labelPreferences.Text = "Матрица проранжированных предпочтений:";
            this.labelPreferences.Visible = false;
            // 
            // buttonGetEstimatedPriorityTimes
            // 
            this.buttonGetEstimatedPriorityTimes.Location = new System.Drawing.Point(211, 18);
            this.buttonGetEstimatedPriorityTimes.Name = "buttonGetEstimatedPriorityTimes";
            this.buttonGetEstimatedPriorityTimes.Size = new System.Drawing.Size(125, 23);
            this.buttonGetEstimatedPriorityTimes.TabIndex = 7;
            this.buttonGetEstimatedPriorityTimes.Text = "Получить времена";
            this.buttonGetEstimatedPriorityTimes.UseVisualStyleBackColor = true;
            this.buttonGetEstimatedPriorityTimes.Visible = false;
            this.buttonGetEstimatedPriorityTimes.Click += new System.EventHandler(this.buttonGetEstimatedPriorityTimes_Click);
            // 
            // buttonPairwiseComparison
            // 
            this.buttonPairwiseComparison.Location = new System.Drawing.Point(466, 63);
            this.buttonPairwiseComparison.Name = "buttonPairwiseComparison";
            this.buttonPairwiseComparison.Size = new System.Drawing.Size(164, 47);
            this.buttonPairwiseComparison.TabIndex = 6;
            this.buttonPairwiseComparison.Text = "Составить матрицу попарных сравнений";
            this.buttonPairwiseComparison.UseVisualStyleBackColor = true;
            this.buttonPairwiseComparison.Visible = false;
            this.buttonPairwiseComparison.Click += new System.EventHandler(this.buttonPairwiseComparisonMatrix_Click);
            // 
            // dataGridPriorityTimes
            // 
            this.dataGridPriorityTimes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPriorityTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPriorityTimes.Location = new System.Drawing.Point(0, 157);
            this.dataGridPriorityTimes.Name = "dataGridPriorityTimes";
            this.dataGridPriorityTimes.RowTemplate.Height = 25;
            this.dataGridPriorityTimes.Size = new System.Drawing.Size(404, 161);
            this.dataGridPriorityTimes.TabIndex = 5;
            this.dataGridPriorityTimes.Visible = false;
            // 
            // labelPriorityTimes
            // 
            this.labelPriorityTimes.AutoSize = true;
            this.labelPriorityTimes.Location = new System.Drawing.Point(0, 139);
            this.labelPriorityTimes.Name = "labelPriorityTimes";
            this.labelPriorityTimes.Size = new System.Drawing.Size(167, 15);
            this.labelPriorityTimes.TabIndex = 4;
            this.labelPriorityTimes.Text = "Матрица выбранных времён";
            this.labelPriorityTimes.Visible = false;
            // 
            // dataGridEstimatedTimes
            // 
            this.dataGridEstimatedTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstimatedTimes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEstimatedTimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEstimatedTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEstimatedTimes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEstimatedTimes.Location = new System.Drawing.Point(0, 63);
            this.dataGridEstimatedTimes.Name = "dataGridEstimatedTimes";
            this.dataGridEstimatedTimes.RowTemplate.Height = 25;
            this.dataGridEstimatedTimes.Size = new System.Drawing.Size(404, 73);
            this.dataGridEstimatedTimes.TabIndex = 3;
            this.dataGridEstimatedTimes.Visible = false;
            // 
            // labelEstimatedTimes
            // 
            this.labelEstimatedTimes.AutoSize = true;
            this.labelEstimatedTimes.Location = new System.Drawing.Point(0, 45);
            this.labelEstimatedTimes.Name = "labelEstimatedTimes";
            this.labelEstimatedTimes.Size = new System.Drawing.Size(214, 15);
            this.labelEstimatedTimes.TabIndex = 2;
            this.labelEstimatedTimes.Text = "Предлагаемые пассажирам времена:";
            this.labelEstimatedTimes.Visible = false;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(0, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(430, 15);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Выберите пункт назначения из заявки для поиска наилучшей альтернативы:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(0, 19);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(142, 23);
            this.comboBoxDestination.TabIndex = 0;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // panelViewingSchedule
            // 
            this.panelViewingSchedule.Controls.Add(this.dataGridViewSchedule);
            this.panelViewingSchedule.Location = new System.Drawing.Point(35, 40);
            this.panelViewingSchedule.Name = "panelViewingSchedule";
            this.panelViewingSchedule.Size = new System.Drawing.Size(642, 250);
            this.panelViewingSchedule.TabIndex = 3;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(16, 7);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(614, 227);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // panelDeletingSchedule
            // 
            this.panelDeletingSchedule.Controls.Add(this.buttonDeleteSchedule);
            this.panelDeletingSchedule.Controls.Add(this.textBoxDeleteId);
            this.panelDeletingSchedule.Controls.Add(this.labelDelete);
            this.panelDeletingSchedule.Location = new System.Drawing.Point(151, 28);
            this.panelDeletingSchedule.Name = "panelDeletingSchedule";
            this.panelDeletingSchedule.Size = new System.Drawing.Size(366, 262);
            this.panelDeletingSchedule.TabIndex = 0;
            // 
            // buttonDeleteSchedule
            // 
            this.buttonDeleteSchedule.Enabled = false;
            this.buttonDeleteSchedule.Location = new System.Drawing.Point(142, 143);
            this.buttonDeleteSchedule.Name = "buttonDeleteSchedule";
            this.buttonDeleteSchedule.Size = new System.Drawing.Size(74, 28);
            this.buttonDeleteSchedule.TabIndex = 5;
            this.buttonDeleteSchedule.Text = "Удалить";
            this.buttonDeleteSchedule.UseVisualStyleBackColor = true;
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(133, 113);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeleteId.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(59, 95);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(273, 15);
            this.labelDelete.TabIndex = 3;
            this.labelDelete.Text = "Введите идент. номер расписания для удаления:";
            // 
            // WorkCondorsetAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 689);
            this.Controls.Add(this.panelSearchingAlternative);
            this.Controls.Add(this.panelViewingSchedule);
            this.Controls.Add(this.panelDeletingSchedule);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WorkCondorsetAlternative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Окно поиска наилучшей альтернативы методом Кондорсе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkCondorsetAlternative_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelSearchingAlternative.ResumeLayout(false);
            this.panelSearchingAlternative.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPairwiseComparison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreferences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriorityTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstimatedTimes)).EndInit();
            this.panelViewingSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.panelDeletingSchedule.ResumeLayout(false);
            this.panelDeletingSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchAlternative;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewSchedule;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSchedule;
        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.Panel panelSearchingAlternative;
        private System.Windows.Forms.Panel panelViewingSchedule;
        private System.Windows.Forms.Panel panelDeletingSchedule;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button buttonDeleteSchedule;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.DataGridView dataGridEstimatedTimes;
        private System.Windows.Forms.Label labelEstimatedTimes;
        private System.Windows.Forms.DataGridView dataGridPriorityTimes;
        private System.Windows.Forms.Label labelPriorityTimes;
        private System.Windows.Forms.Button buttonPairwiseComparison;
        private System.Windows.Forms.Button buttonGetEstimatedPriorityTimes;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.DataGridView dataGridPreferences;
        private System.Windows.Forms.DataGridView dataGridPairwiseComparison;
        private System.Windows.Forms.Label labelPairwiseComparison;
        private System.Windows.Forms.Button buttonSearchAlternative;
    }
}
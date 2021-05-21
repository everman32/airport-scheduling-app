
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSearchAlternative = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSchedule = new System.Windows.Forms.ToolStripButton();
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.panelSearchingAlternative = new System.Windows.Forms.Panel();
            this.buttonSearchAlternative = new System.Windows.Forms.Button();
            this.buttonReportPassengersFlight = new System.Windows.Forms.Button();
            this.labelPairwiseComparison = new System.Windows.Forms.Label();
            this.PairwiseComparisonGridView = new System.Windows.Forms.DataGridView();
            this.PreferencesGridView = new System.Windows.Forms.DataGridView();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.buttonGetEstimatedPriorityTimes = new System.Windows.Forms.Button();
            this.PriorityTimesGridView = new System.Windows.Forms.DataGridView();
            this.labelPriorityTimes = new System.Windows.Forms.Label();
            this.EstimatedTimesGridView = new System.Windows.Forms.DataGridView();
            this.labelEstimatedTimes = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.buttonGraphDate = new System.Windows.Forms.Button();
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.buttonDeleteSchedule = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panelSearchingAlternative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PairwiseComparisonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityTimesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstimatedTimesGridView)).BeginInit();
            this.panelViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            this.panelDeleting.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSearchAlternative
            // 
            this.toolStripButtonSearchAlternative.Checked = true;
            this.toolStripButtonSearchAlternative.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.toolStripButtonViewSchedule.Checked = true;
            this.toolStripButtonViewSchedule.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.toolStripButtonDeleteSchedule.Checked = true;
            this.toolStripButtonDeleteSchedule.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(6, 393);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(72, 31);
            this.buttonBackAvianavForm.TabIndex = 1;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // panelSearchingAlternative
            // 
            this.panelSearchingAlternative.Controls.Add(this.buttonSearchAlternative);
            this.panelSearchingAlternative.Controls.Add(this.buttonReportPassengersFlight);
            this.panelSearchingAlternative.Controls.Add(this.labelPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.PairwiseComparisonGridView);
            this.panelSearchingAlternative.Controls.Add(this.PreferencesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelPreferences);
            this.panelSearchingAlternative.Controls.Add(this.buttonGetEstimatedPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.PriorityTimesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.EstimatedTimesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelEstimatedTimes);
            this.panelSearchingAlternative.Controls.Add(this.labelDestination);
            this.panelSearchingAlternative.Controls.Add(this.comboBoxDestination);
            this.panelSearchingAlternative.Location = new System.Drawing.Point(10, 23);
            this.panelSearchingAlternative.Name = "panelSearchingAlternative";
            this.panelSearchingAlternative.Size = new System.Drawing.Size(855, 364);
            this.panelSearchingAlternative.TabIndex = 2;
            // 
            // buttonSearchAlternative
            // 
            this.buttonSearchAlternative.Location = new System.Drawing.Point(445, 305);
            this.buttonSearchAlternative.Name = "buttonSearchAlternative";
            this.buttonSearchAlternative.Size = new System.Drawing.Size(138, 48);
            this.buttonSearchAlternative.TabIndex = 12;
            this.buttonSearchAlternative.Text = "Найти альтернативы";
            this.buttonSearchAlternative.UseVisualStyleBackColor = true;
            this.buttonSearchAlternative.Visible = false;
            this.buttonSearchAlternative.Click += new System.EventHandler(this.buttonSearchAlternative_Click);
            // 
            // buttonReportPassengersFlight
            // 
            this.buttonReportPassengersFlight.Location = new System.Drawing.Point(683, 305);
            this.buttonReportPassengersFlight.Name = "buttonReportPassengersFlight";
            this.buttonReportPassengersFlight.Size = new System.Drawing.Size(147, 47);
            this.buttonReportPassengersFlight.TabIndex = 2;
            this.buttonReportPassengersFlight.Text = "Отчёт с подробной информацией о пассажирах рейса";
            this.buttonReportPassengersFlight.UseVisualStyleBackColor = true;
            this.buttonReportPassengersFlight.Visible = false;
            this.buttonReportPassengersFlight.Click += new System.EventHandler(this.buttonReportPassengersFlight_Click);
            // 
            // labelPairwiseComparison
            // 
            this.labelPairwiseComparison.AutoSize = true;
            this.labelPairwiseComparison.Location = new System.Drawing.Point(446, 172);
            this.labelPairwiseComparison.Name = "labelPairwiseComparison";
            this.labelPairwiseComparison.Size = new System.Drawing.Size(163, 13);
            this.labelPairwiseComparison.TabIndex = 11;
            this.labelPairwiseComparison.Text = "Матрица попарных сравнений:";
            this.labelPairwiseComparison.Visible = false;
            // 
            // PairwiseComparisonGridView
            // 
            this.PairwiseComparisonGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PairwiseComparisonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PairwiseComparisonGridView.Location = new System.Drawing.Point(445, 188);
            this.PairwiseComparisonGridView.Name = "PairwiseComparisonGridView";
            this.PairwiseComparisonGridView.RowTemplate.Height = 25;
            this.PairwiseComparisonGridView.Size = new System.Drawing.Size(399, 107);
            this.PairwiseComparisonGridView.TabIndex = 10;
            this.PairwiseComparisonGridView.Visible = false;
            this.PairwiseComparisonGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PairwiseComparisonGridView_RowsAdded);
            // 
            // PreferencesGridView
            // 
            this.PreferencesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PreferencesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreferencesGridView.Location = new System.Drawing.Point(445, 26);
            this.PreferencesGridView.Name = "PreferencesGridView";
            this.PreferencesGridView.RowTemplate.Height = 25;
            this.PreferencesGridView.Size = new System.Drawing.Size(399, 127);
            this.PreferencesGridView.TabIndex = 9;
            this.PreferencesGridView.Visible = false;
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Location = new System.Drawing.Point(444, 10);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(229, 13);
            this.labelPreferences.TabIndex = 8;
            this.labelPreferences.Text = "Матрица проранжированных предпочтений:";
            this.labelPreferences.Visible = false;
            // 
            // buttonGetEstimatedPriorityTimes
            // 
            this.buttonGetEstimatedPriorityTimes.Location = new System.Drawing.Point(172, 20);
            this.buttonGetEstimatedPriorityTimes.Name = "buttonGetEstimatedPriorityTimes";
            this.buttonGetEstimatedPriorityTimes.Size = new System.Drawing.Size(107, 30);
            this.buttonGetEstimatedPriorityTimes.TabIndex = 7;
            this.buttonGetEstimatedPriorityTimes.Text = "Получить даты";
            this.buttonGetEstimatedPriorityTimes.UseVisualStyleBackColor = true;
            this.buttonGetEstimatedPriorityTimes.Visible = false;
            this.buttonGetEstimatedPriorityTimes.Click += new System.EventHandler(this.buttonGetEstimatedPriorityTimes_Click);
            // 
            // PriorityTimesGridView
            // 
            this.PriorityTimesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriorityTimesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriorityTimesGridView.Location = new System.Drawing.Point(5, 156);
            this.PriorityTimesGridView.Name = "PriorityTimesGridView";
            this.PriorityTimesGridView.RowTemplate.Height = 25;
            this.PriorityTimesGridView.Size = new System.Drawing.Size(416, 140);
            this.PriorityTimesGridView.TabIndex = 5;
            this.PriorityTimesGridView.Visible = false;
            // 
            // labelPriorityTimes
            // 
            this.labelPriorityTimes.AutoSize = true;
            this.labelPriorityTimes.Location = new System.Drawing.Point(6, 140);
            this.labelPriorityTimes.Name = "labelPriorityTimes";
            this.labelPriorityTimes.Size = new System.Drawing.Size(152, 13);
            this.labelPriorityTimes.TabIndex = 4;
            this.labelPriorityTimes.Text = "Матрица выбранных времён";
            this.labelPriorityTimes.Visible = false;
            // 
            // EstimatedTimesGridView
            // 
            this.EstimatedTimesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstimatedTimesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstimatedTimesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.EstimatedTimesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstimatedTimesGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.EstimatedTimesGridView.Location = new System.Drawing.Point(6, 72);
            this.EstimatedTimesGridView.Name = "EstimatedTimesGridView";
            this.EstimatedTimesGridView.RowTemplate.Height = 25;
            this.EstimatedTimesGridView.Size = new System.Drawing.Size(415, 63);
            this.EstimatedTimesGridView.TabIndex = 3;
            this.EstimatedTimesGridView.Visible = false;
            // 
            // labelEstimatedTimes
            // 
            this.labelEstimatedTimes.AutoSize = true;
            this.labelEstimatedTimes.Location = new System.Drawing.Point(8, 54);
            this.labelEstimatedTimes.Name = "labelEstimatedTimes";
            this.labelEstimatedTimes.Size = new System.Drawing.Size(182, 13);
            this.labelEstimatedTimes.TabIndex = 2;
            this.labelEstimatedTimes.Text = "Предлагаемые пассажирам даты:";
            this.labelEstimatedTimes.Visible = false;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(3, 3);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(399, 13);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Выберите пункт назначения из заявки для поиска наилучшей альтернативы:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(3, 21);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(152, 28);
            this.comboBoxDestination.TabIndex = 0;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // panelViewing
            // 
            this.panelViewing.Controls.Add(this.buttonGraphDate);
            this.panelViewing.Controls.Add(this.ScheduleGridView);
            this.panelViewing.Location = new System.Drawing.Point(6, 23);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(859, 364);
            this.panelViewing.TabIndex = 3;
            // 
            // buttonGraphDate
            // 
            this.buttonGraphDate.Location = new System.Drawing.Point(365, 199);
            this.buttonGraphDate.Name = "buttonGraphDate";
            this.buttonGraphDate.Size = new System.Drawing.Size(142, 45);
            this.buttonGraphDate.TabIndex = 1;
            this.buttonGraphDate.Text = "Диаграмма количества пассажиров";
            this.buttonGraphDate.UseVisualStyleBackColor = true;
            this.buttonGraphDate.Click += new System.EventHandler(this.buttonGraphDate_Click);
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ScheduleGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Location = new System.Drawing.Point(15, 19);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.RowTemplate.Height = 25;
            this.ScheduleGridView.Size = new System.Drawing.Size(833, 174);
            this.ScheduleGridView.TabIndex = 0;
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.comboBoxDelete);
            this.panelDeleting.Controls.Add(this.buttonDeleteSchedule);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Location = new System.Drawing.Point(245, 110);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(418, 99);
            this.panelDeleting.TabIndex = 0;
            // 
            // buttonDeleteSchedule
            // 
            this.buttonDeleteSchedule.Enabled = false;
            this.buttonDeleteSchedule.Location = new System.Drawing.Point(122, 64);
            this.buttonDeleteSchedule.Name = "buttonDeleteSchedule";
            this.buttonDeleteSchedule.Size = new System.Drawing.Size(152, 28);
            this.buttonDeleteSchedule.TabIndex = 5;
            this.buttonDeleteSchedule.Text = "Удалить";
            this.buttonDeleteSchedule.UseVisualStyleBackColor = true;
            this.buttonDeleteSchedule.Click += new System.EventHandler(this.buttonDeleteSchedule_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(3, 3);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(194, 13);
            this.labelDelete.TabIndex = 3;
            this.labelDelete.Text = "Выберите расписание для удаления:";
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(0, 19);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(374, 28);
            this.comboBoxDelete.TabIndex = 6;
            this.comboBoxDelete.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // WorkCondorsetAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(877, 429);
            this.Controls.Add(this.panelSearchingAlternative);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.panelViewing);
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
            ((System.ComponentModel.ISupportInitialize)(this.PairwiseComparisonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityTimesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstimatedTimesGridView)).EndInit();
            this.panelViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.panelDeleting.ResumeLayout(false);
            this.panelDeleting.PerformLayout();
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
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.Panel panelDeleting;
        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.Windows.Forms.Button buttonDeleteSchedule;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.DataGridView EstimatedTimesGridView;
        private System.Windows.Forms.Label labelEstimatedTimes;
        private System.Windows.Forms.DataGridView PriorityTimesGridView;
        private System.Windows.Forms.Label labelPriorityTimes;
        private System.Windows.Forms.Button buttonGetEstimatedPriorityTimes;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.DataGridView PreferencesGridView;
        private System.Windows.Forms.DataGridView PairwiseComparisonGridView;
        private System.Windows.Forms.Label labelPairwiseComparison;
        private System.Windows.Forms.Button buttonSearchAlternative;
        private System.Windows.Forms.Button buttonReportPassengersFlight;
        private System.Windows.Forms.Button buttonGraphDate;
        private System.Windows.Forms.ComboBox comboBoxDelete;
    }
}
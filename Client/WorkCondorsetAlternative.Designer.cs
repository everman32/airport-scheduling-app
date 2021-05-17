
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
            this.buttonReportPassengersFlight = new System.Windows.Forms.Button();
            this.labelPairwiseComparison = new System.Windows.Forms.Label();
            this.PairwiseComparisonGridView = new System.Windows.Forms.DataGridView();
            this.PreferencesGridView = new System.Windows.Forms.DataGridView();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.buttonGetEstimatedPriorityTimes = new System.Windows.Forms.Button();
            this.buttonPairwiseComparison = new System.Windows.Forms.Button();
            this.PriorityTimesGridView = new System.Windows.Forms.DataGridView();
            this.labelPriorityTimes = new System.Windows.Forms.Label();
            this.EstimatedTimesGridView = new System.Windows.Forms.DataGridView();
            this.labelEstimatedTimes = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.buttonChartPopularityDestinations = new System.Windows.Forms.Button();
            this.buttonReportFlightDetails = new System.Windows.Forms.Button();
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.buttonDeleteSchedule = new System.Windows.Forms.Button();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
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
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(20, 531);
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
            this.panelSearchingAlternative.Controls.Add(this.buttonReportPassengersFlight);
            this.panelSearchingAlternative.Controls.Add(this.labelPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.PairwiseComparisonGridView);
            this.panelSearchingAlternative.Controls.Add(this.PreferencesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelPreferences);
            this.panelSearchingAlternative.Controls.Add(this.buttonGetEstimatedPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.buttonPairwiseComparison);
            this.panelSearchingAlternative.Controls.Add(this.PriorityTimesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelPriorityTimes);
            this.panelSearchingAlternative.Controls.Add(this.EstimatedTimesGridView);
            this.panelSearchingAlternative.Controls.Add(this.labelEstimatedTimes);
            this.panelSearchingAlternative.Controls.Add(this.labelDestination);
            this.panelSearchingAlternative.Controls.Add(this.comboBoxDestination);
            this.panelSearchingAlternative.Location = new System.Drawing.Point(12, 28);
            this.panelSearchingAlternative.Name = "panelSearchingAlternative";
            this.panelSearchingAlternative.Size = new System.Drawing.Size(712, 497);
            this.panelSearchingAlternative.TabIndex = 2;
            // 
            // buttonSearchAlternative
            // 
            this.buttonSearchAlternative.Location = new System.Drawing.Point(498, 207);
            this.buttonSearchAlternative.Name = "buttonSearchAlternative";
            this.buttonSearchAlternative.Size = new System.Drawing.Size(150, 37);
            this.buttonSearchAlternative.TabIndex = 12;
            this.buttonSearchAlternative.Text = "Найти альтернативы";
            this.buttonSearchAlternative.UseVisualStyleBackColor = true;
            this.buttonSearchAlternative.Visible = false;
            this.buttonSearchAlternative.Click += new System.EventHandler(this.buttonSearchAlternative_Click);
            // 
            // buttonReportPassengersFlight
            // 
            this.buttonReportPassengersFlight.Location = new System.Drawing.Point(480, 425);
            this.buttonReportPassengersFlight.Name = "buttonReportPassengersFlight";
            this.buttonReportPassengersFlight.Size = new System.Drawing.Size(150, 54);
            this.buttonReportPassengersFlight.TabIndex = 2;
            this.buttonReportPassengersFlight.Text = "Отчёт с подробной информацией о пассажирах рейса";
            this.buttonReportPassengersFlight.UseVisualStyleBackColor = true;
            this.buttonReportPassengersFlight.Visible = false;
            this.buttonReportPassengersFlight.Click += new System.EventHandler(this.buttonReportPassengersFlight_Click);
            // 
            // labelPairwiseComparison
            // 
            this.labelPairwiseComparison.AutoSize = true;
            this.labelPairwiseComparison.Location = new System.Drawing.Point(431, 51);
            this.labelPairwiseComparison.Name = "labelPairwiseComparison";
            this.labelPairwiseComparison.Size = new System.Drawing.Size(180, 15);
            this.labelPairwiseComparison.TabIndex = 11;
            this.labelPairwiseComparison.Text = "Матрица попарных сравнений:";
            this.labelPairwiseComparison.Visible = false;
            // 
            // PairwiseComparisonGridView
            // 
            this.PairwiseComparisonGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PairwiseComparisonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PairwiseComparisonGridView.Location = new System.Drawing.Point(431, 69);
            this.PairwiseComparisonGridView.Name = "PairwiseComparisonGridView";
            this.PairwiseComparisonGridView.RowTemplate.Height = 25;
            this.PairwiseComparisonGridView.Size = new System.Drawing.Size(274, 123);
            this.PairwiseComparisonGridView.TabIndex = 10;
            this.PairwiseComparisonGridView.Visible = false;
            // 
            // PreferencesGridView
            // 
            this.PreferencesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PreferencesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreferencesGridView.Location = new System.Drawing.Point(4, 343);
            this.PreferencesGridView.Name = "PreferencesGridView";
            this.PreferencesGridView.RowTemplate.Height = 25;
            this.PreferencesGridView.Size = new System.Drawing.Size(404, 146);
            this.PreferencesGridView.TabIndex = 9;
            this.PreferencesGridView.Visible = false;
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Location = new System.Drawing.Point(4, 325);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(256, 15);
            this.labelPreferences.TabIndex = 8;
            this.labelPreferences.Text = "Матрица проранжированных предпочтений:";
            this.labelPreferences.Visible = false;
            // 
            // buttonGetEstimatedPriorityTimes
            // 
            this.buttonGetEstimatedPriorityTimes.Location = new System.Drawing.Point(212, 25);
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
            this.buttonPairwiseComparison.Location = new System.Drawing.Point(498, 9);
            this.buttonPairwiseComparison.Name = "buttonPairwiseComparison";
            this.buttonPairwiseComparison.Size = new System.Drawing.Size(150, 39);
            this.buttonPairwiseComparison.TabIndex = 6;
            this.buttonPairwiseComparison.Text = "Составить матрицу попарных сравнений";
            this.buttonPairwiseComparison.UseVisualStyleBackColor = true;
            this.buttonPairwiseComparison.Visible = false;
            this.buttonPairwiseComparison.Click += new System.EventHandler(this.buttonPairwiseComparisonMatrix_Click);
            // 
            // PriorityTimesGridView
            // 
            this.PriorityTimesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriorityTimesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriorityTimesGridView.Location = new System.Drawing.Point(2, 161);
            this.PriorityTimesGridView.Name = "PriorityTimesGridView";
            this.PriorityTimesGridView.RowTemplate.Height = 25;
            this.PriorityTimesGridView.Size = new System.Drawing.Size(404, 161);
            this.PriorityTimesGridView.TabIndex = 5;
            this.PriorityTimesGridView.Visible = false;
            // 
            // labelPriorityTimes
            // 
            this.labelPriorityTimes.AutoSize = true;
            this.labelPriorityTimes.Location = new System.Drawing.Point(4, 141);
            this.labelPriorityTimes.Name = "labelPriorityTimes";
            this.labelPriorityTimes.Size = new System.Drawing.Size(167, 15);
            this.labelPriorityTimes.TabIndex = 4;
            this.labelPriorityTimes.Text = "Матрица выбранных времён";
            this.labelPriorityTimes.Visible = false;
            // 
            // EstimatedTimesGridView
            // 
            this.EstimatedTimesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstimatedTimesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstimatedTimesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EstimatedTimesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstimatedTimesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EstimatedTimesGridView.Location = new System.Drawing.Point(4, 65);
            this.EstimatedTimesGridView.Name = "EstimatedTimesGridView";
            this.EstimatedTimesGridView.RowTemplate.Height = 25;
            this.EstimatedTimesGridView.Size = new System.Drawing.Size(404, 73);
            this.EstimatedTimesGridView.TabIndex = 3;
            this.EstimatedTimesGridView.Visible = false;
            // 
            // labelEstimatedTimes
            // 
            this.labelEstimatedTimes.AutoSize = true;
            this.labelEstimatedTimes.Location = new System.Drawing.Point(2, 47);
            this.labelEstimatedTimes.Name = "labelEstimatedTimes";
            this.labelEstimatedTimes.Size = new System.Drawing.Size(214, 15);
            this.labelEstimatedTimes.TabIndex = 2;
            this.labelEstimatedTimes.Text = "Предлагаемые пассажирам времена:";
            this.labelEstimatedTimes.Visible = false;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(3, 3);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(430, 15);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Выберите пункт назначения из заявки для поиска наилучшей альтернативы:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(4, 24);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(142, 23);
            this.comboBoxDestination.TabIndex = 0;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // panelViewing
            // 
            this.panelViewing.Controls.Add(this.buttonChartPopularityDestinations);
            this.panelViewing.Controls.Add(this.buttonReportFlightDetails);
            this.panelViewing.Controls.Add(this.ScheduleGridView);
            this.panelViewing.Location = new System.Drawing.Point(7, 96);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(713, 351);
            this.panelViewing.TabIndex = 3;
            // 
            // buttonChartPopularityDestinations
            // 
            this.buttonChartPopularityDestinations.Location = new System.Drawing.Point(485, 287);
            this.buttonChartPopularityDestinations.Name = "buttonChartPopularityDestinations";
            this.buttonChartPopularityDestinations.Size = new System.Drawing.Size(181, 54);
            this.buttonChartPopularityDestinations.TabIndex = 3;
            this.buttonChartPopularityDestinations.Text = "Диаграмма с популярностью пунктов назначения";
            this.buttonChartPopularityDestinations.UseVisualStyleBackColor = true;
            this.buttonChartPopularityDestinations.Visible = false;
            // 
            // buttonReportFlightDetails
            // 
            this.buttonReportFlightDetails.Location = new System.Drawing.Point(56, 287);
            this.buttonReportFlightDetails.Name = "buttonReportFlightDetails";
            this.buttonReportFlightDetails.Size = new System.Drawing.Size(165, 54);
            this.buttonReportFlightDetails.TabIndex = 1;
            this.buttonReportFlightDetails.Text = "Отчёт с подробной информацацией о рейсе";
            this.buttonReportFlightDetails.UseVisualStyleBackColor = true;
            this.buttonReportFlightDetails.Visible = false;
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ScheduleGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Location = new System.Drawing.Point(11, 7);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.RowTemplate.Height = 25;
            this.ScheduleGridView.Size = new System.Drawing.Size(690, 227);
            this.ScheduleGridView.TabIndex = 0;
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.buttonDeleteSchedule);
            this.panelDeleting.Controls.Add(this.textBoxDeleteId);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Location = new System.Drawing.Point(172, 70);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(366, 262);
            this.panelDeleting.TabIndex = 0;
            // 
            // buttonDeleteSchedule
            // 
            this.buttonDeleteSchedule.Enabled = false;
            this.buttonDeleteSchedule.Location = new System.Drawing.Point(133, 150);
            this.buttonDeleteSchedule.Name = "buttonDeleteSchedule";
            this.buttonDeleteSchedule.Size = new System.Drawing.Size(100, 32);
            this.buttonDeleteSchedule.TabIndex = 5;
            this.buttonDeleteSchedule.Text = "Удалить";
            this.buttonDeleteSchedule.UseVisualStyleBackColor = true;
            this.buttonDeleteSchedule.Click += new System.EventHandler(this.buttonDeleteSchedule_Click);
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(133, 113);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeleteId.TabIndex = 4;
            this.textBoxDeleteId.TextChanged += new System.EventHandler(this.textBoxDeleteId_TextChanged);
            this.textBoxDeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeleteId_KeyPress);
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
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(731, 573);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.panelSearchingAlternative);
            this.Controls.Add(this.panelDeleting);
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
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.DataGridView EstimatedTimesGridView;
        private System.Windows.Forms.Label labelEstimatedTimes;
        private System.Windows.Forms.DataGridView PriorityTimesGridView;
        private System.Windows.Forms.Label labelPriorityTimes;
        private System.Windows.Forms.Button buttonPairwiseComparison;
        private System.Windows.Forms.Button buttonGetEstimatedPriorityTimes;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.DataGridView PreferencesGridView;
        private System.Windows.Forms.DataGridView PairwiseComparisonGridView;
        private System.Windows.Forms.Label labelPairwiseComparison;
        private System.Windows.Forms.Button buttonSearchAlternative;
        private System.Windows.Forms.Button buttonReportPassengersFlight;
        private System.Windows.Forms.Button buttonChartPopularityDestinations;
        private System.Windows.Forms.Button buttonReportFlightDetails;
    }
}
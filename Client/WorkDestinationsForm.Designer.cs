
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
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.DestinationsGridView = new System.Windows.Forms.DataGridView();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.maskedTextBoxEstimatedTime3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEstimatedTime2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEstimatedTime1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddDestination = new System.Windows.Forms.Button();
            this.textBoxAirplaneModel = new System.Windows.Forms.TextBox();
            this.textBoxFlightDuration = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEstimatedTime3 = new System.Windows.Forms.Label();
            this.labelEstimatedTime2 = new System.Windows.Forms.Label();
            this.labelEstimatedTime1 = new System.Windows.Forms.Label();
            this.labelAirplaneModel = new System.Windows.Forms.Label();
            this.labelFlightDuration = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelEditing = new System.Windows.Forms.Panel();
            this.textBoxNewvalueLetterOrDigit = new System.Windows.Forms.TextBox();
            this.textBoxNewvalueLetter = new System.Windows.Forms.TextBox();
            this.textBoxNewvalueDigit = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNewvalueDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.labelEditValue = new System.Windows.Forms.Label();
            this.labelEditCriteria = new System.Windows.Forms.Label();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.labelEditId = new System.Windows.Forms.Label();
            this.textBoxEditId = new System.Windows.Forms.TextBox();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.buttonDeleteDestination = new System.Windows.Forms.Button();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.toolStripWorkDestinations.SuspendLayout();
            this.panelViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationsGridView)).BeginInit();
            this.panelAdding.SuspendLayout();
            this.panelEditing.SuspendLayout();
            this.panelDeleting.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripWorkDestinations
            // 
            this.toolStripWorkDestinations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStripWorkDestinations.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkDestinations.Name = "toolStripWorkDestinations";
            this.toolStripWorkDestinations.Size = new System.Drawing.Size(1142, 25);
            this.toolStripWorkDestinations.TabIndex = 0;
            this.toolStripWorkDestinations.Text = "toolStrip1";
            this.toolStripWorkDestinations.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripWorkDestinations_ItemClicked);
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(235, 22);
            this.toolStripButtonView.Text = "Просмотр данных о пунктах назначения";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(224, 22);
            this.toolStripButtonAdd.Text = "Добавить данные о пункте назначения";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(252, 22);
            this.toolStripButtonEdit.Text = "Редактировать данные о пункте назначения";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(216, 22);
            this.toolStripButtonDelete.Text = "Удалить данные о пункте назначения";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(26, 336);
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
            this.panelViewing.Location = new System.Drawing.Point(12, 28);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(1124, 302);
            this.panelViewing.TabIndex = 2;
            // 
            // DestinationsGridView
            // 
            this.DestinationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DestinationsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DestinationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationsGridView.Location = new System.Drawing.Point(14, 12);
            this.DestinationsGridView.Name = "DestinationsGridView";
            this.DestinationsGridView.RowTemplate.Height = 25;
            this.DestinationsGridView.Size = new System.Drawing.Size(1098, 281);
            this.DestinationsGridView.TabIndex = 0;
            // 
            // panelAdding
            // 
            this.panelAdding.Controls.Add(this.maskedTextBoxEstimatedTime3);
            this.panelAdding.Controls.Add(this.maskedTextBoxEstimatedTime2);
            this.panelAdding.Controls.Add(this.maskedTextBoxEstimatedTime1);
            this.panelAdding.Controls.Add(this.buttonAddDestination);
            this.panelAdding.Controls.Add(this.textBoxAirplaneModel);
            this.panelAdding.Controls.Add(this.textBoxFlightDuration);
            this.panelAdding.Controls.Add(this.textBoxName);
            this.panelAdding.Controls.Add(this.labelEstimatedTime3);
            this.panelAdding.Controls.Add(this.labelEstimatedTime2);
            this.panelAdding.Controls.Add(this.labelEstimatedTime1);
            this.panelAdding.Controls.Add(this.labelAirplaneModel);
            this.panelAdding.Controls.Add(this.labelFlightDuration);
            this.panelAdding.Controls.Add(this.labelName);
            this.panelAdding.Enabled = false;
            this.panelAdding.Location = new System.Drawing.Point(200, 71);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(522, 238);
            this.panelAdding.TabIndex = 3;
            // 
            // maskedTextBoxEstimatedTime3
            // 
            this.maskedTextBoxEstimatedTime3.Location = new System.Drawing.Point(260, 157);
            this.maskedTextBoxEstimatedTime3.Mask = "0000-00-00 00:00";
            this.maskedTextBoxEstimatedTime3.Name = "maskedTextBoxEstimatedTime3";
            this.maskedTextBoxEstimatedTime3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxEstimatedTime3.TabIndex = 17;
            this.maskedTextBoxEstimatedTime3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxEstimatedTime3_MaskInputRejected);
            // 
            // maskedTextBoxEstimatedTime2
            // 
            this.maskedTextBoxEstimatedTime2.Location = new System.Drawing.Point(260, 113);
            this.maskedTextBoxEstimatedTime2.Mask = "0000-00-00 00:00";
            this.maskedTextBoxEstimatedTime2.Name = "maskedTextBoxEstimatedTime2";
            this.maskedTextBoxEstimatedTime2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxEstimatedTime2.TabIndex = 16;
            this.maskedTextBoxEstimatedTime2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxEstimatedTime2_MaskInputRejected);
            // 
            // maskedTextBoxEstimatedTime1
            // 
            this.maskedTextBoxEstimatedTime1.Location = new System.Drawing.Point(260, 69);
            this.maskedTextBoxEstimatedTime1.Mask = "0000-00-00 00:00";
            this.maskedTextBoxEstimatedTime1.Name = "maskedTextBoxEstimatedTime1";
            this.maskedTextBoxEstimatedTime1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxEstimatedTime1.TabIndex = 15;
            this.maskedTextBoxEstimatedTime1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxEstimatedTime1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxEstimatedTime1_MaskInputRejected);
            // 
            // buttonAddDestination
            // 
            this.buttonAddDestination.Enabled = false;
            this.buttonAddDestination.Location = new System.Drawing.Point(155, 194);
            this.buttonAddDestination.Name = "buttonAddDestination";
            this.buttonAddDestination.Size = new System.Drawing.Size(75, 34);
            this.buttonAddDestination.TabIndex = 14;
            this.buttonAddDestination.Text = "Добавить";
            this.buttonAddDestination.UseVisualStyleBackColor = true;
            this.buttonAddDestination.Click += new System.EventHandler(this.buttonAddDestination_Click);
            // 
            // textBoxAirplaneModel
            // 
            this.textBoxAirplaneModel.Location = new System.Drawing.Point(5, 157);
            this.textBoxAirplaneModel.Name = "textBoxAirplaneModel";
            this.textBoxAirplaneModel.Size = new System.Drawing.Size(100, 23);
            this.textBoxAirplaneModel.TabIndex = 10;
            this.textBoxAirplaneModel.TextChanged += new System.EventHandler(this.textBoxAirplaneModel_TextChanged);
            this.textBoxAirplaneModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAirplaneModel_KeyPress);
            // 
            // textBoxFlightDuration
            // 
            this.textBoxFlightDuration.Location = new System.Drawing.Point(5, 110);
            this.textBoxFlightDuration.Name = "textBoxFlightDuration";
            this.textBoxFlightDuration.Size = new System.Drawing.Size(100, 23);
            this.textBoxFlightDuration.TabIndex = 9;
            this.textBoxFlightDuration.TextChanged += new System.EventHandler(this.textBoxFlightDuration_TextChanged);
            this.textBoxFlightDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFlightDuration_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(4, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelEstimatedTime3
            // 
            this.labelEstimatedTime3.AutoSize = true;
            this.labelEstimatedTime3.Location = new System.Drawing.Point(260, 139);
            this.labelEstimatedTime3.Name = "labelEstimatedTime3";
            this.labelEstimatedTime3.Size = new System.Drawing.Size(209, 15);
            this.labelEstimatedTime3.TabIndex = 6;
            this.labelEstimatedTime3.Text = "Введите третье предлагаемое время:";
            // 
            // labelEstimatedTime2
            // 
            this.labelEstimatedTime2.AutoSize = true;
            this.labelEstimatedTime2.Location = new System.Drawing.Point(260, 95);
            this.labelEstimatedTime2.Name = "labelEstimatedTime2";
            this.labelEstimatedTime2.Size = new System.Drawing.Size(212, 15);
            this.labelEstimatedTime2.TabIndex = 5;
            this.labelEstimatedTime2.Text = "Введите второе предлагаемое время:";
            // 
            // labelEstimatedTime1
            // 
            this.labelEstimatedTime1.AutoSize = true;
            this.labelEstimatedTime1.Location = new System.Drawing.Point(260, 51);
            this.labelEstimatedTime1.Name = "labelEstimatedTime1";
            this.labelEstimatedTime1.Size = new System.Drawing.Size(213, 15);
            this.labelEstimatedTime1.TabIndex = 4;
            this.labelEstimatedTime1.Text = "Введите первое предлагаемое время:";
            // 
            // labelAirplaneModel
            // 
            this.labelAirplaneModel.AutoSize = true;
            this.labelAirplaneModel.Location = new System.Drawing.Point(5, 139);
            this.labelAirplaneModel.Name = "labelAirplaneModel";
            this.labelAirplaneModel.Size = new System.Drawing.Size(152, 15);
            this.labelAirplaneModel.TabIndex = 3;
            this.labelAirplaneModel.Text = "Введите модель самолёта:";
            // 
            // labelFlightDuration
            // 
            this.labelFlightDuration.AutoSize = true;
            this.labelFlightDuration.Location = new System.Drawing.Point(5, 95);
            this.labelFlightDuration.Name = "labelFlightDuration";
            this.labelFlightDuration.Size = new System.Drawing.Size(209, 15);
            this.labelFlightDuration.TabIndex = 2;
            this.labelFlightDuration.Text = "Введите продолжительность полёта:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(244, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Введите наименование пункта назначения:";
            // 
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.textBoxNewvalueLetterOrDigit);
            this.panelEditing.Controls.Add(this.textBoxNewvalueLetter);
            this.panelEditing.Controls.Add(this.textBoxNewvalueDigit);
            this.panelEditing.Controls.Add(this.maskedTextBoxNewvalueDate);
            this.panelEditing.Controls.Add(this.buttonEditDestination);
            this.panelEditing.Controls.Add(this.labelEditValue);
            this.panelEditing.Controls.Add(this.labelEditCriteria);
            this.panelEditing.Controls.Add(this.comboBoxEdit);
            this.panelEditing.Controls.Add(this.labelEditId);
            this.panelEditing.Controls.Add(this.textBoxEditId);
            this.panelEditing.Enabled = false;
            this.panelEditing.Location = new System.Drawing.Point(255, 71);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(396, 231);
            this.panelEditing.TabIndex = 16;
            // 
            // textBoxNewvalueLetterOrDigit
            // 
            this.textBoxNewvalueLetterOrDigit.Location = new System.Drawing.Point(98, 154);
            this.textBoxNewvalueLetterOrDigit.Name = "textBoxNewvalueLetterOrDigit";
            this.textBoxNewvalueLetterOrDigit.Size = new System.Drawing.Size(121, 23);
            this.textBoxNewvalueLetterOrDigit.TabIndex = 10;
            this.textBoxNewvalueLetterOrDigit.Visible = false;
            this.textBoxNewvalueLetterOrDigit.TextChanged += new System.EventHandler(this.textBoxNewValueLetterOrDigit_TextChanged);
            this.textBoxNewvalueLetterOrDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewValueLetterOrDigit_KeyPress);
            // 
            // textBoxNewvalueLetter
            // 
            this.textBoxNewvalueLetter.Location = new System.Drawing.Point(98, 154);
            this.textBoxNewvalueLetter.Name = "textBoxNewvalueLetter";
            this.textBoxNewvalueLetter.Size = new System.Drawing.Size(121, 23);
            this.textBoxNewvalueLetter.TabIndex = 9;
            this.textBoxNewvalueLetter.Visible = false;
            this.textBoxNewvalueLetter.TextChanged += new System.EventHandler(this.textBoxNewvalueLetter_TextChanged);
            this.textBoxNewvalueLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetter_KeyPress);
            // 
            // textBoxNewvalueDigit
            // 
            this.textBoxNewvalueDigit.Location = new System.Drawing.Point(100, 154);
            this.textBoxNewvalueDigit.Name = "textBoxNewvalueDigit";
            this.textBoxNewvalueDigit.Size = new System.Drawing.Size(119, 23);
            this.textBoxNewvalueDigit.TabIndex = 8;
            this.textBoxNewvalueDigit.Visible = false;
            this.textBoxNewvalueDigit.TextChanged += new System.EventHandler(this.textBoxNewvalueDigit_TextChanged);
            this.textBoxNewvalueDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueDigit_KeyPress);
            // 
            // maskedTextBoxNewvalueDate
            // 
            this.maskedTextBoxNewvalueDate.Location = new System.Drawing.Point(98, 154);
            this.maskedTextBoxNewvalueDate.Mask = "0000-00-00 00:00";
            this.maskedTextBoxNewvalueDate.Name = "maskedTextBoxNewvalueDate";
            this.maskedTextBoxNewvalueDate.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBoxNewvalueDate.TabIndex = 7;
            this.maskedTextBoxNewvalueDate.Visible = false;
            this.maskedTextBoxNewvalueDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNewvalue_MaskInputRejected);
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Enabled = false;
            this.buttonEditDestination.Location = new System.Drawing.Point(98, 183);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(121, 37);
            this.buttonEditDestination.TabIndex = 6;
            this.buttonEditDestination.Text = "Редактировать";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Click += new System.EventHandler(this.buttonEditDestination_Click);
            // 
            // labelEditValue
            // 
            this.labelEditValue.AutoSize = true;
            this.labelEditValue.Location = new System.Drawing.Point(98, 136);
            this.labelEditValue.Name = "labelEditValue";
            this.labelEditValue.Size = new System.Drawing.Size(143, 15);
            this.labelEditValue.TabIndex = 4;
            this.labelEditValue.Text = "Введите новое значение:";
            this.labelEditValue.Visible = false;
            // 
            // labelEditCriteria
            // 
            this.labelEditCriteria.AutoSize = true;
            this.labelEditCriteria.Location = new System.Drawing.Point(98, 84);
            this.labelEditCriteria.Name = "labelEditCriteria";
            this.labelEditCriteria.Size = new System.Drawing.Size(197, 15);
            this.labelEditCriteria.TabIndex = 3;
            this.labelEditCriteria.Text = "Выберите редактируемые данные:";
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Items.AddRange(new object[] {
            "Наименование",
            "Продолжительность полёта",
            "Модель самолёта",
            "Первое предлагаемое время",
            "Второе предлагаемое время",
            "Третье предлагаемое время"});
            this.comboBoxEdit.Location = new System.Drawing.Point(98, 102);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(176, 23);
            this.comboBoxEdit.TabIndex = 2;
            this.comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_SelectedIndexChanged);
            // 
            // labelEditId
            // 
            this.labelEditId.AutoSize = true;
            this.labelEditId.Location = new System.Drawing.Point(98, 36);
            this.labelEditId.Name = "labelEditId";
            this.labelEditId.Size = new System.Drawing.Size(284, 15);
            this.labelEditId.TabIndex = 1;
            this.labelEditId.Text = "Введите Идент. номер редактируемого пассажира";
            // 
            // textBoxEditId
            // 
            this.textBoxEditId.Location = new System.Drawing.Point(98, 57);
            this.textBoxEditId.Name = "textBoxEditId";
            this.textBoxEditId.Size = new System.Drawing.Size(121, 23);
            this.textBoxEditId.TabIndex = 0;
            this.textBoxEditId.TextChanged += new System.EventHandler(this.textBoxEditId_TextChanged);
            this.textBoxEditId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditId_KeyPress);
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.buttonDeleteDestination);
            this.panelDeleting.Controls.Add(this.textBoxDeleteId);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Enabled = false;
            this.panelDeleting.Location = new System.Drawing.Point(281, 51);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(315, 231);
            this.panelDeleting.TabIndex = 18;
            // 
            // buttonDeleteDestination
            // 
            this.buttonDeleteDestination.Enabled = false;
            this.buttonDeleteDestination.Location = new System.Drawing.Point(118, 125);
            this.buttonDeleteDestination.Name = "buttonDeleteDestination";
            this.buttonDeleteDestination.Size = new System.Drawing.Size(74, 28);
            this.buttonDeleteDestination.TabIndex = 2;
            this.buttonDeleteDestination.Text = "Удалить";
            this.buttonDeleteDestination.UseVisualStyleBackColor = true;
            this.buttonDeleteDestination.Click += new System.EventHandler(this.buttonDeletePassenger_Click);
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(109, 95);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeleteId.TabIndex = 1;
            this.textBoxDeleteId.TextChanged += new System.EventHandler(this.textBoxDeleteId_TextChanged);
            this.textBoxDeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeleteId_KeyPress);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(3, 74);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(312, 15);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Введите идент. номер пункта назначения для удаления:";
            // 
            // WorkDestinationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1142, 382);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.panelEditing);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.Controls.Add(this.toolStripWorkDestinations);
            this.MaximizeBox = false;
            this.Name = "WorkDestinationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно работы с пунктами назначения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkDestinationsForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkDestinationsForm_Load);
            this.toolStripWorkDestinations.ResumeLayout(false);
            this.toolStripWorkDestinations.PerformLayout();
            this.panelViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationsGridView)).EndInit();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.panelEditing.ResumeLayout(false);
            this.panelEditing.PerformLayout();
            this.panelDeleting.ResumeLayout(false);
            this.panelDeleting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripWorkDestinations;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.DataGridView DestinationsGridView;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Label labelEstimatedTime3;
        private System.Windows.Forms.Label labelEstimatedTime2;
        private System.Windows.Forms.Label labelEstimatedTime1;
        private System.Windows.Forms.Label labelAirplaneModel;
        private System.Windows.Forms.Label labelFlightDuration;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddDestination;
        private System.Windows.Forms.TextBox textBoxAirplaneModel;
        private System.Windows.Forms.TextBox textBoxFlightDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEstimatedTime3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEstimatedTime2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEstimatedTime1;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Label labelEditValue;
        private System.Windows.Forms.Label labelEditCriteria;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Label labelEditId;
        private System.Windows.Forms.TextBox textBoxEditId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNewvalueDate;
        private System.Windows.Forms.TextBox textBoxNewvalueLetterOrDigit;
        private System.Windows.Forms.TextBox textBoxNewvalueLetter;
        private System.Windows.Forms.TextBox textBoxNewvalueDigit;
        private System.Windows.Forms.Panel panelDeleting;
        private System.Windows.Forms.Button buttonDeleteDestination;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Label labelDelete;
        public System.Windows.Forms.Panel panelEditing;
    }
}
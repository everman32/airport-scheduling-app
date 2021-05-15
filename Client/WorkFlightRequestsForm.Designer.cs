
namespace Client
{
    partial class WorkFlightRequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFlightRequestsForm));
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.buttonDeleteFlightRequest = new System.Windows.Forms.Button();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.panelEditing = new System.Windows.Forms.Panel();
            this.buttonViewEdit = new System.Windows.Forms.Button();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.buttonEditPassenger = new System.Windows.Forms.Button();
            this.buttonEditGetTime = new System.Windows.Forms.Button();
            this.comboBoxEditLowestPriorityTime = new System.Windows.Forms.ComboBox();
            this.comboBoxEditMediumPriorityTime = new System.Windows.Forms.ComboBox();
            this.comboBoxEditHighestPriorityTime = new System.Windows.Forms.ComboBox();
            this.labelEditLowestPriorityTime = new System.Windows.Forms.Label();
            this.labelEditMediumPriorityTime = new System.Windows.Forms.Label();
            this.labelEditHighestPriorityTime = new System.Windows.Forms.Label();
            this.buttonEditFlightRequest = new System.Windows.Forms.Button();
            this.labelEditId = new System.Windows.Forms.Label();
            this.textBoxEditId = new System.Windows.Forms.TextBox();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.buttonGetTime = new System.Windows.Forms.Button();
            this.comboBoxLowestPriorityTime = new System.Windows.Forms.ComboBox();
            this.comboBoxMediumPriorityTime = new System.Windows.Forms.ComboBox();
            this.comboBoxHighestPriorityTime = new System.Windows.Forms.ComboBox();
            this.comboBoxPassenger = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.buttonAddFlightRequest = new System.Windows.Forms.Button();
            this.labelLowestPriorityTime = new System.Windows.Forms.Label();
            this.labelMediumPriorityTime = new System.Windows.Forms.Label();
            this.labelHighestPriorityTime = new System.Windows.Forms.Label();
            this.labelPassengerId = new System.Windows.Forms.Label();
            this.labelDestinationId = new System.Windows.Forms.Label();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.FlightRequestsGridView = new System.Windows.Forms.DataGridView();
            this.toolStripWorkDestinations = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.panelDeleting.SuspendLayout();
            this.panelEditing.SuspendLayout();
            this.panelAdding.SuspendLayout();
            this.panelViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightRequestsGridView)).BeginInit();
            this.toolStripWorkDestinations.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(12, 345);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(95, 39);
            this.buttonBackAvianavForm.TabIndex = 0;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.buttonDeleteFlightRequest);
            this.panelDeleting.Controls.Add(this.textBoxDeleteId);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Enabled = false;
            this.panelDeleting.Location = new System.Drawing.Point(117, 48);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(315, 231);
            this.panelDeleting.TabIndex = 23;
            // 
            // buttonDeleteFlightRequest
            // 
            this.buttonDeleteFlightRequest.Enabled = false;
            this.buttonDeleteFlightRequest.Location = new System.Drawing.Point(118, 125);
            this.buttonDeleteFlightRequest.Name = "buttonDeleteFlightRequest";
            this.buttonDeleteFlightRequest.Size = new System.Drawing.Size(74, 28);
            this.buttonDeleteFlightRequest.TabIndex = 2;
            this.buttonDeleteFlightRequest.Text = "Удалить";
            this.buttonDeleteFlightRequest.UseVisualStyleBackColor = true;
            this.buttonDeleteFlightRequest.Click += new System.EventHandler(this.buttonDeleteDestination_Click);
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
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.buttonViewEdit);
            this.panelEditing.Controls.Add(this.buttonEditDestination);
            this.panelEditing.Controls.Add(this.buttonEditPassenger);
            this.panelEditing.Controls.Add(this.buttonEditGetTime);
            this.panelEditing.Controls.Add(this.comboBoxEditLowestPriorityTime);
            this.panelEditing.Controls.Add(this.comboBoxEditMediumPriorityTime);
            this.panelEditing.Controls.Add(this.comboBoxEditHighestPriorityTime);
            this.panelEditing.Controls.Add(this.labelEditLowestPriorityTime);
            this.panelEditing.Controls.Add(this.labelEditMediumPriorityTime);
            this.panelEditing.Controls.Add(this.labelEditHighestPriorityTime);
            this.panelEditing.Controls.Add(this.buttonEditFlightRequest);
            this.panelEditing.Controls.Add(this.labelEditId);
            this.panelEditing.Controls.Add(this.textBoxEditId);
            this.panelEditing.Enabled = false;
            this.panelEditing.Location = new System.Drawing.Point(91, 68);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(440, 231);
            this.panelEditing.TabIndex = 22;
            // 
            // buttonViewEdit
            // 
            this.buttonViewEdit.Location = new System.Drawing.Point(14, 143);
            this.buttonViewEdit.Name = "buttonViewEdit";
            this.buttonViewEdit.Size = new System.Drawing.Size(144, 38);
            this.buttonViewEdit.TabIndex = 33;
            this.buttonViewEdit.Text = "Редактировать время в заявке";
            this.buttonViewEdit.UseVisualStyleBackColor = true;
            this.buttonViewEdit.Click += new System.EventHandler(this.buttonViewEdit_Click);
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Location = new System.Drawing.Point(14, 99);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(144, 38);
            this.buttonEditDestination.TabIndex = 32;
            this.buttonEditDestination.Text = "Редактировать данные пункта назначения";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Click += new System.EventHandler(this.buttonEditDestination_Click);
            // 
            // buttonEditPassenger
            // 
            this.buttonEditPassenger.Location = new System.Drawing.Point(14, 51);
            this.buttonEditPassenger.Name = "buttonEditPassenger";
            this.buttonEditPassenger.Size = new System.Drawing.Size(144, 41);
            this.buttonEditPassenger.TabIndex = 31;
            this.buttonEditPassenger.Text = "Редактировать данные пассажира";
            this.buttonEditPassenger.UseVisualStyleBackColor = true;
            this.buttonEditPassenger.Click += new System.EventHandler(this.buttonEditPassenger_Click);
            // 
            // buttonEditGetTime
            // 
            this.buttonEditGetTime.Location = new System.Drawing.Point(315, 25);
            this.buttonEditGetTime.Name = "buttonEditGetTime";
            this.buttonEditGetTime.Size = new System.Drawing.Size(118, 23);
            this.buttonEditGetTime.TabIndex = 30;
            this.buttonEditGetTime.Text = "Получить время";
            this.buttonEditGetTime.UseVisualStyleBackColor = true;
            this.buttonEditGetTime.Visible = false;
            this.buttonEditGetTime.Click += new System.EventHandler(this.buttonEditGetTime_Click);
            // 
            // comboBoxEditLowestPriorityTime
            // 
            this.comboBoxEditLowestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditLowestPriorityTime.FormattingEnabled = true;
            this.comboBoxEditLowestPriorityTime.Location = new System.Drawing.Point(166, 158);
            this.comboBoxEditLowestPriorityTime.Name = "comboBoxEditLowestPriorityTime";
            this.comboBoxEditLowestPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxEditLowestPriorityTime.TabIndex = 29;
            this.comboBoxEditLowestPriorityTime.Visible = false;
            this.comboBoxEditLowestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLowestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxEditMediumPriorityTime
            // 
            this.comboBoxEditMediumPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditMediumPriorityTime.FormattingEnabled = true;
            this.comboBoxEditMediumPriorityTime.Location = new System.Drawing.Point(167, 114);
            this.comboBoxEditMediumPriorityTime.Name = "comboBoxEditMediumPriorityTime";
            this.comboBoxEditMediumPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxEditMediumPriorityTime.TabIndex = 28;
            this.comboBoxEditMediumPriorityTime.Visible = false;
            this.comboBoxEditMediumPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMediumPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxEditHighestPriorityTime
            // 
            this.comboBoxEditHighestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditHighestPriorityTime.FormattingEnabled = true;
            this.comboBoxEditHighestPriorityTime.Location = new System.Drawing.Point(167, 69);
            this.comboBoxEditHighestPriorityTime.Name = "comboBoxEditHighestPriorityTime";
            this.comboBoxEditHighestPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxEditHighestPriorityTime.TabIndex = 27;
            this.comboBoxEditHighestPriorityTime.Visible = false;
            this.comboBoxEditHighestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHighestPriorityTime_SelectedIndexChanged);
            // 
            // labelEditLowestPriorityTime
            // 
            this.labelEditLowestPriorityTime.AutoSize = true;
            this.labelEditLowestPriorityTime.Location = new System.Drawing.Point(168, 140);
            this.labelEditLowestPriorityTime.Name = "labelEditLowestPriorityTime";
            this.labelEditLowestPriorityTime.Size = new System.Drawing.Size(233, 15);
            this.labelEditLowestPriorityTime.TabIndex = 26;
            this.labelEditLowestPriorityTime.Text = "Выберите время, низшее по приоритету:";
            this.labelEditLowestPriorityTime.Visible = false;
            // 
            // labelEditMediumPriorityTime
            // 
            this.labelEditMediumPriorityTime.AutoSize = true;
            this.labelEditMediumPriorityTime.Location = new System.Drawing.Point(164, 95);
            this.labelEditMediumPriorityTime.Name = "labelEditMediumPriorityTime";
            this.labelEditMediumPriorityTime.Size = new System.Drawing.Size(235, 15);
            this.labelEditMediumPriorityTime.TabIndex = 25;
            this.labelEditMediumPriorityTime.Text = "Выберите время, среднее по приоритету:";
            this.labelEditMediumPriorityTime.Visible = false;
            // 
            // labelEditHighestPriorityTime
            // 
            this.labelEditHighestPriorityTime.AutoSize = true;
            this.labelEditHighestPriorityTime.Location = new System.Drawing.Point(164, 51);
            this.labelEditHighestPriorityTime.Name = "labelEditHighestPriorityTime";
            this.labelEditHighestPriorityTime.Size = new System.Drawing.Size(258, 15);
            this.labelEditHighestPriorityTime.TabIndex = 24;
            this.labelEditHighestPriorityTime.Text = "Выберите время с наивысшим приоритетом:";
            this.labelEditHighestPriorityTime.Visible = false;
            // 
            // buttonEditFlightRequest
            // 
            this.buttonEditFlightRequest.Enabled = false;
            this.buttonEditFlightRequest.Location = new System.Drawing.Point(166, 187);
            this.buttonEditFlightRequest.Name = "buttonEditFlightRequest";
            this.buttonEditFlightRequest.Size = new System.Drawing.Size(150, 37);
            this.buttonEditFlightRequest.TabIndex = 6;
            this.buttonEditFlightRequest.Text = "Редактировать";
            this.buttonEditFlightRequest.UseVisualStyleBackColor = true;
            this.buttonEditFlightRequest.Visible = false;
            this.buttonEditFlightRequest.Click += new System.EventHandler(this.buttonEditFlightRequest_Click);
            // 
            // labelEditId
            // 
            this.labelEditId.AutoSize = true;
            this.labelEditId.Location = new System.Drawing.Point(166, 7);
            this.labelEditId.Name = "labelEditId";
            this.labelEditId.Size = new System.Drawing.Size(258, 15);
            this.labelEditId.TabIndex = 1;
            this.labelEditId.Text = "Введите Идент. номер редактируемой заявки:";
            this.labelEditId.Visible = false;
            // 
            // textBoxEditId
            // 
            this.textBoxEditId.Location = new System.Drawing.Point(168, 28);
            this.textBoxEditId.Name = "textBoxEditId";
            this.textBoxEditId.Size = new System.Drawing.Size(121, 23);
            this.textBoxEditId.TabIndex = 0;
            this.textBoxEditId.Visible = false;
            this.textBoxEditId.TextChanged += new System.EventHandler(this.textBoxEditId_TextChanged);
            this.textBoxEditId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditId_KeyPress);
            // 
            // panelAdding
            // 
            this.panelAdding.Controls.Add(this.buttonGetTime);
            this.panelAdding.Controls.Add(this.comboBoxLowestPriorityTime);
            this.panelAdding.Controls.Add(this.comboBoxMediumPriorityTime);
            this.panelAdding.Controls.Add(this.comboBoxHighestPriorityTime);
            this.panelAdding.Controls.Add(this.comboBoxPassenger);
            this.panelAdding.Controls.Add(this.comboBoxDestination);
            this.panelAdding.Controls.Add(this.buttonAddFlightRequest);
            this.panelAdding.Controls.Add(this.labelLowestPriorityTime);
            this.panelAdding.Controls.Add(this.labelMediumPriorityTime);
            this.panelAdding.Controls.Add(this.labelHighestPriorityTime);
            this.panelAdding.Controls.Add(this.labelPassengerId);
            this.panelAdding.Controls.Add(this.labelDestinationId);
            this.panelAdding.Enabled = false;
            this.panelAdding.Location = new System.Drawing.Point(36, 68);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(522, 238);
            this.panelAdding.TabIndex = 21;
            // 
            // buttonGetTime
            // 
            this.buttonGetTime.Location = new System.Drawing.Point(112, 69);
            this.buttonGetTime.Name = "buttonGetTime";
            this.buttonGetTime.Size = new System.Drawing.Size(118, 23);
            this.buttonGetTime.TabIndex = 23;
            this.buttonGetTime.Text = "Получить время";
            this.buttonGetTime.UseVisualStyleBackColor = true;
            this.buttonGetTime.Click += new System.EventHandler(this.buttonGetTime_Click);
            // 
            // comboBoxLowestPriorityTime
            // 
            this.comboBoxLowestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLowestPriorityTime.FormattingEnabled = true;
            this.comboBoxLowestPriorityTime.Location = new System.Drawing.Point(260, 157);
            this.comboBoxLowestPriorityTime.Name = "comboBoxLowestPriorityTime";
            this.comboBoxLowestPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxLowestPriorityTime.TabIndex = 22;
            this.comboBoxLowestPriorityTime.Visible = false;
            this.comboBoxLowestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxLowestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxMediumPriorityTime
            // 
            this.comboBoxMediumPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMediumPriorityTime.FormattingEnabled = true;
            this.comboBoxMediumPriorityTime.Location = new System.Drawing.Point(260, 113);
            this.comboBoxMediumPriorityTime.Name = "comboBoxMediumPriorityTime";
            this.comboBoxMediumPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxMediumPriorityTime.TabIndex = 21;
            this.comboBoxMediumPriorityTime.Visible = false;
            this.comboBoxMediumPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxMediumPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxHighestPriorityTime
            // 
            this.comboBoxHighestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHighestPriorityTime.FormattingEnabled = true;
            this.comboBoxHighestPriorityTime.Location = new System.Drawing.Point(260, 69);
            this.comboBoxHighestPriorityTime.Name = "comboBoxHighestPriorityTime";
            this.comboBoxHighestPriorityTime.Size = new System.Drawing.Size(150, 23);
            this.comboBoxHighestPriorityTime.TabIndex = 20;
            this.comboBoxHighestPriorityTime.Visible = false;
            this.comboBoxHighestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxHighestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxPassenger
            // 
            this.comboBoxPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPassenger.FormattingEnabled = true;
            this.comboBoxPassenger.Location = new System.Drawing.Point(3, 113);
            this.comboBoxPassenger.Name = "comboBoxPassenger";
            this.comboBoxPassenger.Size = new System.Drawing.Size(227, 23);
            this.comboBoxPassenger.TabIndex = 19;
            this.comboBoxPassenger.SelectedIndexChanged += new System.EventHandler(this.comboBoxPassenger_SelectedIndexChanged);
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(3, 69);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(104, 23);
            this.comboBoxDestination.TabIndex = 18;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // buttonAddFlightRequest
            // 
            this.buttonAddFlightRequest.Enabled = false;
            this.buttonAddFlightRequest.Location = new System.Drawing.Point(155, 194);
            this.buttonAddFlightRequest.Name = "buttonAddFlightRequest";
            this.buttonAddFlightRequest.Size = new System.Drawing.Size(75, 34);
            this.buttonAddFlightRequest.TabIndex = 14;
            this.buttonAddFlightRequest.Text = "Добавить";
            this.buttonAddFlightRequest.UseVisualStyleBackColor = true;
            this.buttonAddFlightRequest.Click += new System.EventHandler(this.buttonAddDestination_Click);
            // 
            // labelLowestPriorityTime
            // 
            this.labelLowestPriorityTime.AutoSize = true;
            this.labelLowestPriorityTime.Location = new System.Drawing.Point(260, 139);
            this.labelLowestPriorityTime.Name = "labelLowestPriorityTime";
            this.labelLowestPriorityTime.Size = new System.Drawing.Size(233, 15);
            this.labelLowestPriorityTime.TabIndex = 6;
            this.labelLowestPriorityTime.Text = "Выберите время, низшее по приоритету:";
            this.labelLowestPriorityTime.Visible = false;
            // 
            // labelMediumPriorityTime
            // 
            this.labelMediumPriorityTime.AutoSize = true;
            this.labelMediumPriorityTime.Location = new System.Drawing.Point(260, 95);
            this.labelMediumPriorityTime.Name = "labelMediumPriorityTime";
            this.labelMediumPriorityTime.Size = new System.Drawing.Size(235, 15);
            this.labelMediumPriorityTime.TabIndex = 5;
            this.labelMediumPriorityTime.Text = "Выберите время, среднее по приоритету:";
            this.labelMediumPriorityTime.Visible = false;
            // 
            // labelHighestPriorityTime
            // 
            this.labelHighestPriorityTime.AutoSize = true;
            this.labelHighestPriorityTime.Location = new System.Drawing.Point(260, 51);
            this.labelHighestPriorityTime.Name = "labelHighestPriorityTime";
            this.labelHighestPriorityTime.Size = new System.Drawing.Size(258, 15);
            this.labelHighestPriorityTime.TabIndex = 4;
            this.labelHighestPriorityTime.Text = "Выберите время с наивысшим приоритетом:";
            this.labelHighestPriorityTime.Visible = false;
            // 
            // labelPassengerId
            // 
            this.labelPassengerId.AutoSize = true;
            this.labelPassengerId.Location = new System.Drawing.Point(0, 95);
            this.labelPassengerId.Name = "labelPassengerId";
            this.labelPassengerId.Size = new System.Drawing.Size(127, 15);
            this.labelPassengerId.TabIndex = 1;
            this.labelPassengerId.Text = "Выберите пассажира:";
            // 
            // labelDestinationId
            // 
            this.labelDestinationId.AutoSize = true;
            this.labelDestinationId.Location = new System.Drawing.Point(0, 51);
            this.labelDestinationId.Name = "labelDestinationId";
            this.labelDestinationId.Size = new System.Drawing.Size(165, 15);
            this.labelDestinationId.TabIndex = 0;
            this.labelDestinationId.Text = "Выберите пункт назначения:";
            // 
            // panelViewing
            // 
            this.panelViewing.Controls.Add(this.FlightRequestsGridView);
            this.panelViewing.Location = new System.Drawing.Point(0, 28);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(1129, 244);
            this.panelViewing.TabIndex = 20;
            // 
            // FlightRequestsGridView
            // 
            this.FlightRequestsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FlightRequestsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightRequestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightRequestsGridView.Location = new System.Drawing.Point(0, 12);
            this.FlightRequestsGridView.Name = "FlightRequestsGridView";
            this.FlightRequestsGridView.RowTemplate.Height = 25;
            this.FlightRequestsGridView.Size = new System.Drawing.Size(1161, 226);
            this.FlightRequestsGridView.TabIndex = 0;
            // 
            // toolStripWorkDestinations
            // 
            this.toolStripWorkDestinations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStripWorkDestinations.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripWorkDestinations.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkDestinations.Name = "toolStripWorkDestinations";
            this.toolStripWorkDestinations.Size = new System.Drawing.Size(1182, 25);
            this.toolStripWorkDestinations.TabIndex = 19;
            this.toolStripWorkDestinations.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(107, 22);
            this.toolStripButtonView.Text = "Просмотр заявок";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(101, 22);
            this.toolStripButtonAdd.Text = "Добавить заявку";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(129, 22);
            this.toolStripButtonEdit.Text = "Редактировать заявку";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonDelete.Text = "Удалить заявку";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // WorkFlightRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 417);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.panelEditing);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.toolStripWorkDestinations);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.MaximizeBox = false;
            this.Name = "WorkFlightRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно работы с заявками на полёты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkFlightRequestsForm_FormClosed);
            this.panelDeleting.ResumeLayout(false);
            this.panelDeleting.PerformLayout();
            this.panelEditing.ResumeLayout(false);
            this.panelEditing.PerformLayout();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.panelViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlightRequestsGridView)).EndInit();
            this.toolStripWorkDestinations.ResumeLayout(false);
            this.toolStripWorkDestinations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.Panel panelDeleting;
        private System.Windows.Forms.Button buttonDeleteFlightRequest;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Panel panelEditing;
        private System.Windows.Forms.Button buttonEditFlightRequest;
        private System.Windows.Forms.Label labelEditId;
        private System.Windows.Forms.TextBox textBoxEditId;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Button buttonAddFlightRequest;
        private System.Windows.Forms.Label labelLowestPriorityTime;
        private System.Windows.Forms.Label labelMediumPriorityTime;
        private System.Windows.Forms.Label labelHighestPriorityTime;
        private System.Windows.Forms.Label labelPassengerId;
        private System.Windows.Forms.Label labelDestinationId;
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.DataGridView FlightRequestsGridView;
        private System.Windows.Forms.ToolStrip toolStripWorkDestinations;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxPassenger;
        private System.Windows.Forms.ComboBox comboBoxLowestPriorityTime;
        private System.Windows.Forms.ComboBox comboBoxMediumPriorityTime;
        private System.Windows.Forms.ComboBox comboBoxHighestPriorityTime;
        private System.Windows.Forms.Button buttonGetTime;
        private System.Windows.Forms.ComboBox comboBoxEditLowestPriorityTime;
        private System.Windows.Forms.ComboBox comboBoxEditMediumPriorityTime;
        private System.Windows.Forms.ComboBox comboBoxEditHighestPriorityTime;
        private System.Windows.Forms.Label labelEditLowestPriorityTime;
        private System.Windows.Forms.Label labelEditMediumPriorityTime;
        private System.Windows.Forms.Label labelEditHighestPriorityTime;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Button buttonEditPassenger;
        private System.Windows.Forms.Button buttonEditGetTime;
        private System.Windows.Forms.Button buttonViewEdit;
    }
}
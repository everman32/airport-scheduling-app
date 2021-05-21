
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
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.buttonDeleteFlightRequest = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.panelEditing = new System.Windows.Forms.Panel();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
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
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(10, 299);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(81, 34);
            this.buttonBackAvianavForm.TabIndex = 0;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.comboBoxDelete);
            this.panelDeleting.Controls.Add(this.buttonDeleteFlightRequest);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Enabled = false;
            this.panelDeleting.Location = new System.Drawing.Point(229, 70);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(299, 160);
            this.panelDeleting.TabIndex = 23;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(4, 50);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(289, 28);
            this.comboBoxDelete.TabIndex = 3;
            this.comboBoxDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelete_SelectedIndexChanged);
            // 
            // buttonDeleteFlightRequest
            // 
            this.buttonDeleteFlightRequest.Enabled = false;
            this.buttonDeleteFlightRequest.Location = new System.Drawing.Point(10, 114);
            this.buttonDeleteFlightRequest.Name = "buttonDeleteFlightRequest";
            this.buttonDeleteFlightRequest.Size = new System.Drawing.Size(153, 32);
            this.buttonDeleteFlightRequest.TabIndex = 2;
            this.buttonDeleteFlightRequest.Text = "Удалить";
            this.buttonDeleteFlightRequest.UseVisualStyleBackColor = true;
            this.buttonDeleteFlightRequest.Click += new System.EventHandler(this.buttonDeleteDestination_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(3, 34);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(169, 13);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Выберите заявку для удаления:";
            // 
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.comboBoxEdit);
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
            this.panelEditing.Enabled = false;
            this.panelEditing.Location = new System.Drawing.Point(234, 54);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(433, 274);
            this.panelEditing.TabIndex = 22;
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Location = new System.Drawing.Point(6, 21);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(289, 28);
            this.comboBoxEdit.TabIndex = 34;
            this.comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_SelectedIndexChanged);
            // 
            // buttonViewEdit
            // 
            this.buttonViewEdit.Location = new System.Drawing.Point(231, 233);
            this.buttonViewEdit.Name = "buttonViewEdit";
            this.buttonViewEdit.Size = new System.Drawing.Size(10, 44);
            this.buttonViewEdit.TabIndex = 33;
            this.buttonViewEdit.Text = "Редактировать время в заявке";
            this.buttonViewEdit.UseVisualStyleBackColor = true;
            this.buttonViewEdit.Visible = false;
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Location = new System.Drawing.Point(231, 192);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(10, 44);
            this.buttonEditDestination.TabIndex = 32;
            this.buttonEditDestination.Text = "Редактировать данные пункта назначения";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Visible = false;
            this.buttonEditDestination.Click += new System.EventHandler(this.buttonEditDestination_Click);
            // 
            // buttonEditPassenger
            // 
            this.buttonEditPassenger.Location = new System.Drawing.Point(231, 164);
            this.buttonEditPassenger.Name = "buttonEditPassenger";
            this.buttonEditPassenger.Size = new System.Drawing.Size(10, 36);
            this.buttonEditPassenger.TabIndex = 31;
            this.buttonEditPassenger.Text = "Редактировать данные пассажира";
            this.buttonEditPassenger.UseVisualStyleBackColor = true;
            this.buttonEditPassenger.Visible = false;
            this.buttonEditPassenger.Click += new System.EventHandler(this.buttonEditPassenger_Click);
            // 
            // buttonEditGetTime
            // 
            this.buttonEditGetTime.Enabled = false;
            this.buttonEditGetTime.Location = new System.Drawing.Point(323, 20);
            this.buttonEditGetTime.Name = "buttonEditGetTime";
            this.buttonEditGetTime.Size = new System.Drawing.Size(101, 29);
            this.buttonEditGetTime.TabIndex = 30;
            this.buttonEditGetTime.Text = "Получить даты";
            this.buttonEditGetTime.UseVisualStyleBackColor = true;
            this.buttonEditGetTime.Click += new System.EventHandler(this.buttonEditGetTime_Click);
            // 
            // comboBoxEditLowestPriorityTime
            // 
            this.comboBoxEditLowestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditLowestPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditLowestPriorityTime.FormattingEnabled = true;
            this.comboBoxEditLowestPriorityTime.Location = new System.Drawing.Point(10, 182);
            this.comboBoxEditLowestPriorityTime.Name = "comboBoxEditLowestPriorityTime";
            this.comboBoxEditLowestPriorityTime.Size = new System.Drawing.Size(148, 28);
            this.comboBoxEditLowestPriorityTime.TabIndex = 29;
            this.comboBoxEditLowestPriorityTime.Visible = false;
            this.comboBoxEditLowestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLowestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxEditMediumPriorityTime
            // 
            this.comboBoxEditMediumPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditMediumPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditMediumPriorityTime.FormattingEnabled = true;
            this.comboBoxEditMediumPriorityTime.Location = new System.Drawing.Point(9, 130);
            this.comboBoxEditMediumPriorityTime.Name = "comboBoxEditMediumPriorityTime";
            this.comboBoxEditMediumPriorityTime.Size = new System.Drawing.Size(149, 28);
            this.comboBoxEditMediumPriorityTime.TabIndex = 28;
            this.comboBoxEditMediumPriorityTime.Visible = false;
            this.comboBoxEditMediumPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMediumPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxEditHighestPriorityTime
            // 
            this.comboBoxEditHighestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditHighestPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditHighestPriorityTime.FormattingEnabled = true;
            this.comboBoxEditHighestPriorityTime.Location = new System.Drawing.Point(9, 79);
            this.comboBoxEditHighestPriorityTime.Name = "comboBoxEditHighestPriorityTime";
            this.comboBoxEditHighestPriorityTime.Size = new System.Drawing.Size(149, 28);
            this.comboBoxEditHighestPriorityTime.TabIndex = 27;
            this.comboBoxEditHighestPriorityTime.Visible = false;
            this.comboBoxEditHighestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHighestPriorityTime_SelectedIndexChanged);
            // 
            // labelEditLowestPriorityTime
            // 
            this.labelEditLowestPriorityTime.AutoSize = true;
            this.labelEditLowestPriorityTime.Location = new System.Drawing.Point(6, 166);
            this.labelEditLowestPriorityTime.Name = "labelEditLowestPriorityTime";
            this.labelEditLowestPriorityTime.Size = new System.Drawing.Size(214, 13);
            this.labelEditLowestPriorityTime.TabIndex = 26;
            this.labelEditLowestPriorityTime.Text = "Выберите время, низшее по приоритету:";
            this.labelEditLowestPriorityTime.Visible = false;
            // 
            // labelEditMediumPriorityTime
            // 
            this.labelEditMediumPriorityTime.AutoSize = true;
            this.labelEditMediumPriorityTime.Location = new System.Drawing.Point(6, 115);
            this.labelEditMediumPriorityTime.Name = "labelEditMediumPriorityTime";
            this.labelEditMediumPriorityTime.Size = new System.Drawing.Size(218, 13);
            this.labelEditMediumPriorityTime.TabIndex = 25;
            this.labelEditMediumPriorityTime.Text = "Выберите время, среднее по приоритету:";
            this.labelEditMediumPriorityTime.Visible = false;
            // 
            // labelEditHighestPriorityTime
            // 
            this.labelEditHighestPriorityTime.AutoSize = true;
            this.labelEditHighestPriorityTime.Location = new System.Drawing.Point(5, 63);
            this.labelEditHighestPriorityTime.Name = "labelEditHighestPriorityTime";
            this.labelEditHighestPriorityTime.Size = new System.Drawing.Size(236, 13);
            this.labelEditHighestPriorityTime.TabIndex = 24;
            this.labelEditHighestPriorityTime.Text = "Выберите время с наивысшим приоритетом:";
            // 
            // buttonEditFlightRequest
            // 
            this.buttonEditFlightRequest.Enabled = false;
            this.buttonEditFlightRequest.Location = new System.Drawing.Point(10, 230);
            this.buttonEditFlightRequest.Name = "buttonEditFlightRequest";
            this.buttonEditFlightRequest.Size = new System.Drawing.Size(148, 32);
            this.buttonEditFlightRequest.TabIndex = 6;
            this.buttonEditFlightRequest.Text = "Редактировать";
            this.buttonEditFlightRequest.UseVisualStyleBackColor = true;
            this.buttonEditFlightRequest.Click += new System.EventHandler(this.buttonEditFlightRequest_Click);
            // 
            // labelEditId
            // 
            this.labelEditId.AutoSize = true;
            this.labelEditId.Location = new System.Drawing.Point(3, 5);
            this.labelEditId.Name = "labelEditId";
            this.labelEditId.Size = new System.Drawing.Size(205, 13);
            this.labelEditId.TabIndex = 1;
            this.labelEditId.Text = "Выберите заявку для редактирования:";
            this.labelEditId.Visible = false;
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
            this.panelAdding.Location = new System.Drawing.Point(204, 54);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(551, 221);
            this.panelAdding.TabIndex = 21;
            // 
            // buttonGetTime
            // 
            this.buttonGetTime.Enabled = false;
            this.buttonGetTime.Location = new System.Drawing.Point(154, 34);
            this.buttonGetTime.Name = "buttonGetTime";
            this.buttonGetTime.Size = new System.Drawing.Size(101, 32);
            this.buttonGetTime.TabIndex = 23;
            this.buttonGetTime.Text = "Получить время";
            this.buttonGetTime.UseVisualStyleBackColor = true;
            this.buttonGetTime.Click += new System.EventHandler(this.buttonGetTime_Click);
            // 
            // comboBoxLowestPriorityTime
            // 
            this.comboBoxLowestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLowestPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLowestPriorityTime.FormattingEnabled = true;
            this.comboBoxLowestPriorityTime.Location = new System.Drawing.Point(313, 157);
            this.comboBoxLowestPriorityTime.Name = "comboBoxLowestPriorityTime";
            this.comboBoxLowestPriorityTime.Size = new System.Drawing.Size(184, 28);
            this.comboBoxLowestPriorityTime.TabIndex = 22;
            this.comboBoxLowestPriorityTime.Visible = false;
            this.comboBoxLowestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxLowestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxMediumPriorityTime
            // 
            this.comboBoxMediumPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMediumPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMediumPriorityTime.FormattingEnabled = true;
            this.comboBoxMediumPriorityTime.Location = new System.Drawing.Point(312, 97);
            this.comboBoxMediumPriorityTime.Name = "comboBoxMediumPriorityTime";
            this.comboBoxMediumPriorityTime.Size = new System.Drawing.Size(185, 28);
            this.comboBoxMediumPriorityTime.TabIndex = 21;
            this.comboBoxMediumPriorityTime.Visible = false;
            this.comboBoxMediumPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxMediumPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxHighestPriorityTime
            // 
            this.comboBoxHighestPriorityTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHighestPriorityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHighestPriorityTime.FormattingEnabled = true;
            this.comboBoxHighestPriorityTime.Location = new System.Drawing.Point(312, 38);
            this.comboBoxHighestPriorityTime.Name = "comboBoxHighestPriorityTime";
            this.comboBoxHighestPriorityTime.Size = new System.Drawing.Size(185, 28);
            this.comboBoxHighestPriorityTime.TabIndex = 20;
            this.comboBoxHighestPriorityTime.Visible = false;
            this.comboBoxHighestPriorityTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxHighestPriorityTime_SelectedIndexChanged);
            // 
            // comboBoxPassenger
            // 
            this.comboBoxPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPassenger.FormattingEnabled = true;
            this.comboBoxPassenger.Location = new System.Drawing.Point(3, 98);
            this.comboBoxPassenger.Name = "comboBoxPassenger";
            this.comboBoxPassenger.Size = new System.Drawing.Size(252, 28);
            this.comboBoxPassenger.TabIndex = 19;
            this.comboBoxPassenger.SelectedIndexChanged += new System.EventHandler(this.comboBoxPassenger_SelectedIndexChanged);
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(3, 36);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(145, 28);
            this.comboBoxDestination.TabIndex = 18;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // buttonAddFlightRequest
            // 
            this.buttonAddFlightRequest.Enabled = false;
            this.buttonAddFlightRequest.Location = new System.Drawing.Point(139, 168);
            this.buttonAddFlightRequest.Name = "buttonAddFlightRequest";
            this.buttonAddFlightRequest.Size = new System.Drawing.Size(100, 32);
            this.buttonAddFlightRequest.TabIndex = 14;
            this.buttonAddFlightRequest.Text = "Добавить";
            this.buttonAddFlightRequest.UseVisualStyleBackColor = true;
            this.buttonAddFlightRequest.Click += new System.EventHandler(this.buttonAddDestination_Click);
            // 
            // labelLowestPriorityTime
            // 
            this.labelLowestPriorityTime.AutoSize = true;
            this.labelLowestPriorityTime.Location = new System.Drawing.Point(310, 140);
            this.labelLowestPriorityTime.Name = "labelLowestPriorityTime";
            this.labelLowestPriorityTime.Size = new System.Drawing.Size(214, 13);
            this.labelLowestPriorityTime.TabIndex = 6;
            this.labelLowestPriorityTime.Text = "Выберите время, низшее по приоритету:";
            this.labelLowestPriorityTime.Visible = false;
            // 
            // labelMediumPriorityTime
            // 
            this.labelMediumPriorityTime.AutoSize = true;
            this.labelMediumPriorityTime.Location = new System.Drawing.Point(310, 80);
            this.labelMediumPriorityTime.Name = "labelMediumPriorityTime";
            this.labelMediumPriorityTime.Size = new System.Drawing.Size(218, 13);
            this.labelMediumPriorityTime.TabIndex = 5;
            this.labelMediumPriorityTime.Text = "Выберите время, среднее по приоритету:";
            this.labelMediumPriorityTime.Visible = false;
            // 
            // labelHighestPriorityTime
            // 
            this.labelHighestPriorityTime.AutoSize = true;
            this.labelHighestPriorityTime.Location = new System.Drawing.Point(311, 18);
            this.labelHighestPriorityTime.Name = "labelHighestPriorityTime";
            this.labelHighestPriorityTime.Size = new System.Drawing.Size(236, 13);
            this.labelHighestPriorityTime.TabIndex = 4;
            this.labelHighestPriorityTime.Text = "Выберите время с наивысшим приоритетом:";
            this.labelHighestPriorityTime.Visible = false;
            // 
            // labelPassengerId
            // 
            this.labelPassengerId.AutoSize = true;
            this.labelPassengerId.Location = new System.Drawing.Point(0, 82);
            this.labelPassengerId.Name = "labelPassengerId";
            this.labelPassengerId.Size = new System.Drawing.Size(119, 13);
            this.labelPassengerId.TabIndex = 1;
            this.labelPassengerId.Text = "Выберите пассажира:";
            // 
            // labelDestinationId
            // 
            this.labelDestinationId.AutoSize = true;
            this.labelDestinationId.Location = new System.Drawing.Point(0, 19);
            this.labelDestinationId.Name = "labelDestinationId";
            this.labelDestinationId.Size = new System.Drawing.Size(153, 13);
            this.labelDestinationId.TabIndex = 0;
            this.labelDestinationId.Text = "Выберите пункт назначения:";
            // 
            // panelViewing
            // 
            this.panelViewing.Controls.Add(this.FlightRequestsGridView);
            this.panelViewing.Location = new System.Drawing.Point(6, 24);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(836, 270);
            this.panelViewing.TabIndex = 20;
            // 
            // FlightRequestsGridView
            // 
            this.FlightRequestsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FlightRequestsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightRequestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightRequestsGridView.Location = new System.Drawing.Point(6, 10);
            this.FlightRequestsGridView.Name = "FlightRequestsGridView";
            this.FlightRequestsGridView.RowTemplate.Height = 25;
            this.FlightRequestsGridView.Size = new System.Drawing.Size(817, 246);
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
            this.toolStripWorkDestinations.Size = new System.Drawing.Size(851, 25);
            this.toolStripWorkDestinations.TabIndex = 19;
            this.toolStripWorkDestinations.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.Checked = true;
            this.toolStripButtonView.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.toolStripButtonAdd.Checked = true;
            this.toolStripButtonAdd.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.toolStripButtonEdit.Checked = true;
            this.toolStripButtonEdit.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.toolStripButtonDelete.Checked = true;
            this.toolStripButtonDelete.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(851, 339);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.panelEditing);
            this.Controls.Add(this.panelAdding);
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
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Panel panelEditing;
        private System.Windows.Forms.Button buttonEditFlightRequest;
        private System.Windows.Forms.Label labelEditId;
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
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.ComboBox comboBoxDelete;
    }
}
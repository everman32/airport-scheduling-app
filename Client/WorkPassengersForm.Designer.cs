
namespace Client
{
    partial class WorkPassengersForm
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
            this.PassengersGridView = new System.Windows.Forms.DataGridView();
            this.toolStripWorkPassengers = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.labelPhone_Number = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.buttonAddPassenger = new System.Windows.Forms.Button();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.panelEditing = new System.Windows.Forms.Panel();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.buttonEditPassenger = new System.Windows.Forms.Button();
            this.textBoxNewvalue = new System.Windows.Forms.TextBox();
            this.labelEditValue = new System.Windows.Forms.Label();
            this.labelEditCriteria = new System.Windows.Forms.Label();
            this.comboBoxEditCriteria = new System.Windows.Forms.ComboBox();
            this.labelEditId = new System.Windows.Forms.Label();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.buttonDeletePassenger = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGridView)).BeginInit();
            this.toolStripWorkPassengers.SuspendLayout();
            this.panelAdding.SuspendLayout();
            this.panelViewing.SuspendLayout();
            this.panelEditing.SuspendLayout();
            this.panelDeleting.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(12, 295);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(78, 32);
            this.buttonBackAvianavForm.TabIndex = 0;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // PassengersGridView
            // 
            this.PassengersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PassengersGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassengersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersGridView.Location = new System.Drawing.Point(7, 0);
            this.PassengersGridView.Name = "PassengersGridView";
            this.PassengersGridView.ReadOnly = true;
            this.PassengersGridView.RowTemplate.Height = 25;
            this.PassengersGridView.Size = new System.Drawing.Size(401, 219);
            this.PassengersGridView.TabIndex = 1;
            // 
            // toolStripWorkPassengers
            // 
            this.toolStripWorkPassengers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripWorkPassengers.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.toolStripWorkPassengers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStripWorkPassengers.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkPassengers.Name = "toolStripWorkPassengers";
            this.toolStripWorkPassengers.Size = new System.Drawing.Size(711, 25);
            this.toolStripWorkPassengers.TabIndex = 3;
            this.toolStripWorkPassengers.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.Checked = true;
            this.toolStripButtonView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(201, 22);
            this.toolStripButtonView.Text = "Просмотреть данные о пассажирах";
            this.toolStripButtonView.ToolTipText = "Просмотреть данные";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Checked = true;
            this.toolStripButtonAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(124, 22);
            this.toolStripButtonAdd.Text = "Добавить пассажира";
            this.toolStripButtonAdd.ToolTipText = "Добавить данные";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Checked = true;
            this.toolStripButtonEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(204, 22);
            this.toolStripButtonEdit.Text = "Редактировать данные о пассажире";
            this.toolStripButtonEdit.ToolTipText = "Редактировать данные";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Checked = true;
            this.toolStripButtonDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(167, 22);
            this.toolStripButtonDelete.Text = "Удалить данные о пассажире";
            this.toolStripButtonDelete.ToolTipText = "Удалить данные";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // labelPhone_Number
            // 
            this.labelPhone_Number.AutoSize = true;
            this.labelPhone_Number.Location = new System.Drawing.Point(4, 157);
            this.labelPhone_Number.Name = "labelPhone_Number";
            this.labelPhone_Number.Size = new System.Drawing.Size(212, 13);
            this.labelPhone_Number.TabIndex = 5;
            this.labelPhone_Number.Text = "Введите телефонный номер пассажира:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(5, 3);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(162, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Введите фамилию пассажира:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Введите имя пассажира:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(8, 108);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(159, 13);
            this.labelPatronymic.TabIndex = 8;
            this.labelPatronymic.Text = "Введите отчество пассажира:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(8, 173);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(125, 26);
            this.textBoxPhoneNumber.TabIndex = 10;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhone_Number_TextChanged);
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_Number_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(8, 17);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(125, 26);
            this.textBoxSurname.TabIndex = 11;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(8, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 26);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(8, 125);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(125, 26);
            this.textBoxPatronymic.TabIndex = 13;
            this.textBoxPatronymic.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            this.textBoxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronymic_KeyPress);
            // 
            // buttonAddPassenger
            // 
            this.buttonAddPassenger.Enabled = false;
            this.buttonAddPassenger.Location = new System.Drawing.Point(8, 220);
            this.buttonAddPassenger.Name = "buttonAddPassenger";
            this.buttonAddPassenger.Size = new System.Drawing.Size(125, 31);
            this.buttonAddPassenger.TabIndex = 14;
            this.buttonAddPassenger.Text = "Добавить";
            this.buttonAddPassenger.UseVisualStyleBackColor = true;
            this.buttonAddPassenger.Click += new System.EventHandler(this.buttonAddPassenger_Click);
            // 
            // panelAdding
            // 
            this.panelAdding.Controls.Add(this.buttonAddPassenger);
            this.panelAdding.Controls.Add(this.textBoxName);
            this.panelAdding.Controls.Add(this.textBoxPatronymic);
            this.panelAdding.Controls.Add(this.labelName);
            this.panelAdding.Controls.Add(this.textBoxPhoneNumber);
            this.panelAdding.Controls.Add(this.labelPatronymic);
            this.panelAdding.Controls.Add(this.textBoxSurname);
            this.panelAdding.Controls.Add(this.labelSurname);
            this.panelAdding.Controls.Add(this.labelPhone_Number);
            this.panelAdding.Enabled = false;
            this.panelAdding.Location = new System.Drawing.Point(271, 28);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(218, 259);
            this.panelAdding.TabIndex = 15;
            // 
            // panelViewing
            // 
            this.panelViewing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelViewing.Controls.Add(this.PassengersGridView);
            this.panelViewing.Enabled = false;
            this.panelViewing.Location = new System.Drawing.Point(154, 48);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(413, 226);
            this.panelViewing.TabIndex = 16;
            // 
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.comboBoxEdit);
            this.panelEditing.Controls.Add(this.buttonEditPassenger);
            this.panelEditing.Controls.Add(this.textBoxNewvalue);
            this.panelEditing.Controls.Add(this.labelEditValue);
            this.panelEditing.Controls.Add(this.labelEditCriteria);
            this.panelEditing.Controls.Add(this.comboBoxEditCriteria);
            this.panelEditing.Controls.Add(this.labelEditId);
            this.panelEditing.Enabled = false;
            this.panelEditing.Location = new System.Drawing.Point(222, 56);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(269, 200);
            this.panelEditing.TabIndex = 15;
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Location = new System.Drawing.Point(6, 16);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(260, 28);
            this.comboBoxEdit.TabIndex = 7;
            this.comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_SelectedIndexChanged_1);
            // 
            // buttonEditPassenger
            // 
            this.buttonEditPassenger.Enabled = false;
            this.buttonEditPassenger.Location = new System.Drawing.Point(7, 162);
            this.buttonEditPassenger.Name = "buttonEditPassenger";
            this.buttonEditPassenger.Size = new System.Drawing.Size(194, 32);
            this.buttonEditPassenger.TabIndex = 6;
            this.buttonEditPassenger.Text = "Редактировать";
            this.buttonEditPassenger.UseVisualStyleBackColor = true;
            this.buttonEditPassenger.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxNewvalue
            // 
            this.textBoxNewvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewvalue.Location = new System.Drawing.Point(7, 123);
            this.textBoxNewvalue.Name = "textBoxNewvalue";
            this.textBoxNewvalue.Size = new System.Drawing.Size(194, 26);
            this.textBoxNewvalue.TabIndex = 5;
            this.textBoxNewvalue.TextChanged += new System.EventHandler(this.textBoxNewvalue_TextChanged);
            // 
            // labelEditValue
            // 
            this.labelEditValue.AutoSize = true;
            this.labelEditValue.Location = new System.Drawing.Point(4, 106);
            this.labelEditValue.Name = "labelEditValue";
            this.labelEditValue.Size = new System.Drawing.Size(135, 13);
            this.labelEditValue.TabIndex = 4;
            this.labelEditValue.Text = "Введите новое значение:";
            // 
            // labelEditCriteria
            // 
            this.labelEditCriteria.AutoSize = true;
            this.labelEditCriteria.Location = new System.Drawing.Point(4, 53);
            this.labelEditCriteria.Name = "labelEditCriteria";
            this.labelEditCriteria.Size = new System.Drawing.Size(184, 13);
            this.labelEditCriteria.TabIndex = 3;
            this.labelEditCriteria.Text = "Выберите редактируемые данные:";
            // 
            // comboBoxEditCriteria
            // 
            this.comboBoxEditCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditCriteria.FormattingEnabled = true;
            this.comboBoxEditCriteria.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Телефонный номер"});
            this.comboBoxEditCriteria.Location = new System.Drawing.Point(6, 70);
            this.comboBoxEditCriteria.Name = "comboBoxEditCriteria";
            this.comboBoxEditCriteria.Size = new System.Drawing.Size(195, 28);
            this.comboBoxEditCriteria.TabIndex = 2;
            this.comboBoxEditCriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_SelectedIndexChanged);
            // 
            // labelEditId
            // 
            this.labelEditId.AutoSize = true;
            this.labelEditId.Location = new System.Drawing.Point(3, 0);
            this.labelEditId.Name = "labelEditId";
            this.labelEditId.Size = new System.Drawing.Size(266, 13);
            this.labelEditId.TabIndex = 1;
            this.labelEditId.Text = "Выберите пассажира для редактирования данных:";
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.comboBoxDelete);
            this.panelDeleting.Controls.Add(this.buttonDeletePassenger);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Enabled = false;
            this.panelDeleting.Location = new System.Drawing.Point(224, 54);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(260, 200);
            this.panelDeleting.TabIndex = 17;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(5, 30);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(252, 28);
            this.comboBoxDelete.TabIndex = 3;
            this.comboBoxDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelete_SelectedIndexChanged);
            // 
            // buttonDeletePassenger
            // 
            this.buttonDeletePassenger.Enabled = false;
            this.buttonDeletePassenger.Location = new System.Drawing.Point(5, 69);
            this.buttonDeletePassenger.Name = "buttonDeletePassenger";
            this.buttonDeletePassenger.Size = new System.Drawing.Size(185, 37);
            this.buttonDeletePassenger.TabIndex = 2;
            this.buttonDeletePassenger.Text = "Удалить";
            this.buttonDeletePassenger.UseVisualStyleBackColor = true;
            this.buttonDeletePassenger.Click += new System.EventHandler(this.buttonDeletePassenger_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(2, 5);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(190, 13);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Выберите пассажира для удаления:";
            // 
            // WorkPassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(711, 339);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.panelEditing);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.toolStripWorkPassengers);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.MaximizeBox = false;
            this.Name = "WorkPassengersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно работы с пассажирами";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkPassengersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGridView)).EndInit();
            this.toolStripWorkPassengers.ResumeLayout(false);
            this.toolStripWorkPassengers.PerformLayout();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.panelViewing.ResumeLayout(false);
            this.panelEditing.ResumeLayout(false);
            this.panelEditing.PerformLayout();
            this.panelDeleting.ResumeLayout(false);
            this.panelDeleting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PassengersGridView;
        private System.Windows.Forms.ToolStrip toolStripWorkPassengers;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Label labelPhone_Number;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Button buttonAddPassenger;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.Button buttonEditPassenger;
        private System.Windows.Forms.TextBox textBoxNewvalue;
        private System.Windows.Forms.Label labelEditValue;
        private System.Windows.Forms.Label labelEditCriteria;
        private System.Windows.Forms.ComboBox comboBoxEditCriteria;
        private System.Windows.Forms.Label labelEditId;
        private System.Windows.Forms.Panel panelDeleting;
        private System.Windows.Forms.Button buttonDeletePassenger;
        private System.Windows.Forms.Label labelDelete;
        public System.Windows.Forms.Panel panelEditing;
        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.ComboBox comboBoxDelete;
    }
}
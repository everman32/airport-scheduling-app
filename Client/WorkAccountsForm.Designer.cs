
namespace Client
{
    partial class WorkAccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkAccountsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.panelDeleting = new System.Windows.Forms.Panel();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.panelEditing = new System.Windows.Forms.Panel();
            this.comboBoxEditLogin = new System.Windows.Forms.ComboBox();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.textBoxNewvalue = new System.Windows.Forms.TextBox();
            this.labelEditValue = new System.Windows.Forms.Label();
            this.labelEditLogin = new System.Windows.Forms.Label();
            this.panelViewing = new System.Windows.Forms.Panel();
            this.AccountsGridView = new System.Windows.Forms.DataGridView();
            this.buttonBackAvianavForm = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAccessRight = new System.Windows.Forms.Label();
            this.comboBoxAccessRight = new System.Windows.Forms.ComboBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panelDeleting.SuspendLayout();
            this.panelEditing.SuspendLayout();
            this.panelViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).BeginInit();
            this.panelAdding.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.Checked = true;
            this.toolStripButtonView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(224, 22);
            this.toolStripButtonView.Text = "Просмотр данных об учётных записях";
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
            this.toolStripButtonAdd.Size = new System.Drawing.Size(167, 22);
            this.toolStripButtonAdd.Text = "Добавление учётной записи";
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
            this.toolStripButtonEdit.Size = new System.Drawing.Size(247, 22);
            this.toolStripButtonEdit.Text = "Редактировать данные об учётных записях";
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
            this.toolStripButtonDelete.Size = new System.Drawing.Size(145, 22);
            this.toolStripButtonDelete.Text = "Удалить учётную запись";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // panelDeleting
            // 
            this.panelDeleting.Controls.Add(this.comboBoxDelete);
            this.panelDeleting.Controls.Add(this.buttonDeleteAccount);
            this.panelDeleting.Controls.Add(this.labelDelete);
            this.panelDeleting.Enabled = false;
            this.panelDeleting.Location = new System.Drawing.Point(286, 54);
            this.panelDeleting.Name = "panelDeleting";
            this.panelDeleting.Size = new System.Drawing.Size(244, 200);
            this.panelDeleting.TabIndex = 22;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(6, 25);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(206, 28);
            this.comboBoxDelete.TabIndex = 3;
            this.comboBoxDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelete_SelectedIndexChanged);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Enabled = false;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(28, 87);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(139, 33);
            this.buttonDeleteAccount.TabIndex = 2;
            this.buttonDeleteAccount.Text = "Удалить";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(3, 4);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(213, 13);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Выберите учётную запись для удаления:";
            // 
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.comboBoxEditLogin);
            this.panelEditing.Controls.Add(this.buttonEditAccount);
            this.panelEditing.Controls.Add(this.textBoxNewvalue);
            this.panelEditing.Controls.Add(this.labelEditValue);
            this.panelEditing.Controls.Add(this.labelEditLogin);
            this.panelEditing.Enabled = false;
            this.panelEditing.Location = new System.Drawing.Point(286, 53);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Size = new System.Drawing.Size(267, 157);
            this.panelEditing.TabIndex = 19;
            // 
            // comboBoxEditLogin
            // 
            this.comboBoxEditLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditLogin.FormattingEnabled = true;
            this.comboBoxEditLogin.Location = new System.Drawing.Point(5, 21);
            this.comboBoxEditLogin.Name = "comboBoxEditLogin";
            this.comboBoxEditLogin.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEditLogin.TabIndex = 7;
            this.comboBoxEditLogin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.Enabled = false;
            this.buttonEditAccount.Location = new System.Drawing.Point(5, 119);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(121, 32);
            this.buttonEditAccount.TabIndex = 6;
            this.buttonEditAccount.Text = "Редактировать";
            this.buttonEditAccount.UseVisualStyleBackColor = true;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditPassenger_Click);
            // 
            // textBoxNewvalue
            // 
            this.textBoxNewvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewvalue.Location = new System.Drawing.Point(5, 77);
            this.textBoxNewvalue.Name = "textBoxNewvalue";
            this.textBoxNewvalue.Size = new System.Drawing.Size(121, 26);
            this.textBoxNewvalue.TabIndex = 5;
            this.textBoxNewvalue.TextChanged += new System.EventHandler(this.textBoxNewvalue_TextChanged);
            this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalue_KeyPress);
            // 
            // labelEditValue
            // 
            this.labelEditValue.AutoSize = true;
            this.labelEditValue.Location = new System.Drawing.Point(5, 59);
            this.labelEditValue.Name = "labelEditValue";
            this.labelEditValue.Size = new System.Drawing.Size(126, 13);
            this.labelEditValue.TabIndex = 4;
            this.labelEditValue.Text = "Введите новый пароль:";
            // 
            // labelEditLogin
            // 
            this.labelEditLogin.AutoSize = true;
            this.labelEditLogin.Location = new System.Drawing.Point(3, 5);
            this.labelEditLogin.Name = "labelEditLogin";
            this.labelEditLogin.Size = new System.Drawing.Size(254, 13);
            this.labelEditLogin.TabIndex = 1;
            this.labelEditLogin.Text = "Выберите логин редактируемой учётной записи:";
            // 
            // panelViewing
            // 
            this.panelViewing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelViewing.Controls.Add(this.AccountsGridView);
            this.panelViewing.Enabled = false;
            this.panelViewing.Location = new System.Drawing.Point(109, 53);
            this.panelViewing.Name = "panelViewing";
            this.panelViewing.Size = new System.Drawing.Size(581, 230);
            this.panelViewing.TabIndex = 21;
            // 
            // AccountsGridView
            // 
            this.AccountsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGridView.Location = new System.Drawing.Point(6, 8);
            this.AccountsGridView.Name = "AccountsGridView";
            this.AccountsGridView.ReadOnly = true;
            this.AccountsGridView.RowTemplate.Height = 25;
            this.AccountsGridView.Size = new System.Drawing.Size(569, 210);
            this.AccountsGridView.TabIndex = 1;
            // 
            // buttonBackAvianavForm
            // 
            this.buttonBackAvianavForm.Location = new System.Drawing.Point(14, 288);
            this.buttonBackAvianavForm.Name = "buttonBackAvianavForm";
            this.buttonBackAvianavForm.Size = new System.Drawing.Size(78, 32);
            this.buttonBackAvianavForm.TabIndex = 18;
            this.buttonBackAvianavForm.Text = "<< Назад";
            this.buttonBackAvianavForm.UseVisualStyleBackColor = true;
            this.buttonBackAvianavForm.Click += new System.EventHandler(this.buttonBackAvianavForm_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(41, 36);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(174, 15);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Введите фамилию пассажира:";
            // 
            // panelAdding
            // 
            this.panelAdding.Controls.Add(this.textBoxPass);
            this.panelAdding.Controls.Add(this.textBoxLogin);
            this.panelAdding.Controls.Add(this.labelPass);
            this.panelAdding.Controls.Add(this.labelLogin);
            this.panelAdding.Controls.Add(this.labelAccessRight);
            this.panelAdding.Controls.Add(this.comboBoxAccessRight);
            this.panelAdding.Controls.Add(this.buttonRegistration);
            this.panelAdding.Enabled = false;
            this.panelAdding.Location = new System.Drawing.Point(287, 54);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(223, 211);
            this.panelAdding.TabIndex = 20;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(6, 128);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(112, 26);
            this.textBoxPass.TabIndex = 21;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(6, 78);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(112, 26);
            this.textBoxLogin.TabIndex = 20;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(3, 111);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(172, 13);
            this.labelPass.TabIndex = 19;
            this.labelPass.Text = "Введите пароль учётной записи:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(3, 62);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(165, 13);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Введите логин учётной записи:";
            // 
            // labelAccessRight
            // 
            this.labelAccessRight.AutoSize = true;
            this.labelAccessRight.Location = new System.Drawing.Point(3, 5);
            this.labelAccessRight.Name = "labelAccessRight";
            this.labelAccessRight.Size = new System.Drawing.Size(217, 13);
            this.labelAccessRight.TabIndex = 17;
            this.labelAccessRight.Text = "Выберите права доступа учётной записи:";
            // 
            // comboBoxAccessRight
            // 
            this.comboBoxAccessRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccessRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAccessRight.FormattingEnabled = true;
            this.comboBoxAccessRight.Items.AddRange(new object[] {
            "Администратор",
            "Диспетчер"});
            this.comboBoxAccessRight.Location = new System.Drawing.Point(6, 23);
            this.comboBoxAccessRight.Name = "comboBoxAccessRight";
            this.comboBoxAccessRight.Size = new System.Drawing.Size(157, 28);
            this.comboBoxAccessRight.TabIndex = 16;
            this.comboBoxAccessRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccessRight_SelectedIndexChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Enabled = false;
            this.buttonRegistration.Location = new System.Drawing.Point(7, 175);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(111, 27);
            this.buttonRegistration.TabIndex = 15;
            this.buttonRegistration.Text = "Добавить";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // WorkAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(795, 339);
            this.Controls.Add(this.panelEditing);
            this.Controls.Add(this.panelDeleting);
            this.Controls.Add(this.panelAdding);
            this.Controls.Add(this.panelViewing);
            this.Controls.Add(this.buttonBackAvianavForm);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WorkAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно работы с учётными записями";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkAccountsForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDeleting.ResumeLayout(false);
            this.panelDeleting.PerformLayout();
            this.panelEditing.ResumeLayout(false);
            this.panelEditing.PerformLayout();
            this.panelViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).EndInit();
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Panel panelDeleting;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Label labelDelete;
        public System.Windows.Forms.Panel panelEditing;
        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.TextBox textBoxNewvalue;
        private System.Windows.Forms.Label labelEditValue;
        private System.Windows.Forms.Label labelEditLogin;
        private System.Windows.Forms.Panel panelViewing;
        private System.Windows.Forms.DataGridView AccountsGridView;
        private System.Windows.Forms.Button buttonBackAvianavForm;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAccessRight;
        private System.Windows.Forms.ComboBox comboBoxAccessRight;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.ComboBox comboBoxEditLogin;
        private System.Windows.Forms.ComboBox comboBoxDelete;
    }
}
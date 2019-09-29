namespace LogisticsAutomation
{
    partial class FormTransports
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
            this.components = new System.ComponentModel.Container();
            this.gpFiltration = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchByStNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpNavigation = new System.Windows.Forms.GroupBox();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpDriverInfo = new System.Windows.Forms.GroupBox();
            this.tbPhoneDriver = new System.Windows.Forms.TextBox();
            this.tbCategoryDriver = new System.Windows.Forms.TextBox();
            this.tbNameDriver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpOperations = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpAdditionally = new System.Windows.Forms.GroupBox();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnBrands = new System.Windows.Forms.Button();
            this.gpFiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.gpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.gpDriverInfo.SuspendLayout();
            this.gpOperations.SuspendLayout();
            this.gpAdditionally.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFiltration
            // 
            this.gpFiltration.Controls.Add(this.btnReset);
            this.gpFiltration.Controls.Add(this.btnSearch);
            this.gpFiltration.Controls.Add(this.tbSearchByStNumber);
            this.gpFiltration.Controls.Add(this.label1);
            this.gpFiltration.Location = new System.Drawing.Point(12, 12);
            this.gpFiltration.Name = "gpFiltration";
            this.gpFiltration.Size = new System.Drawing.Size(679, 64);
            this.gpFiltration.TabIndex = 0;
            this.gpFiltration.TabStop = false;
            this.gpFiltration.Text = "Фильтрация";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(549, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(422, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchObjects);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(LogisticsAutomation.Brand);
            // 
            // tbSearchByStNumber
            // 
            this.tbSearchByStNumber.Location = new System.Drawing.Point(128, 25);
            this.tbSearchByStNumber.Name = "tbSearchByStNumber";
            this.tbSearchByStNumber.Size = new System.Drawing.Size(288, 20);
            this.tbSearchByStNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "По полю \"Госномер\":";
            // 
            // gpNavigation
            // 
            this.gpNavigation.Controls.Add(this.dgvTransport);
            this.gpNavigation.Location = new System.Drawing.Point(12, 82);
            this.gpNavigation.Name = "gpNavigation";
            this.gpNavigation.Size = new System.Drawing.Size(679, 188);
            this.gpNavigation.TabIndex = 1;
            this.gpNavigation.TabStop = false;
            this.gpNavigation.Text = "Навигация";
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.AutoGenerateColumns = false;
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stateNumberDataGridViewTextBoxColumn,
            this.dateEntryDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn});
            this.dgvTransport.DataSource = this.transportBindingSource;
            this.dgvTransport.Location = new System.Drawing.Point(6, 19);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true;
            this.dgvTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransport.Size = new System.Drawing.Size(667, 163);
            this.dgvTransport.TabIndex = 0;
            this.dgvTransport.SelectionChanged += new System.EventHandler(this.LoadDriverInfo);
            this.dgvTransport.DoubleClick += new System.EventHandler(this.btnChange_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 51;
            // 
            // stateNumberDataGridViewTextBoxColumn
            // 
            this.stateNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateNumberDataGridViewTextBoxColumn.DataPropertyName = "StateNumber";
            this.stateNumberDataGridViewTextBoxColumn.HeaderText = "Госномер";
            this.stateNumberDataGridViewTextBoxColumn.Name = "stateNumberDataGridViewTextBoxColumn";
            this.stateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEntryDataGridViewTextBoxColumn
            // 
            this.dateEntryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEntryDataGridViewTextBoxColumn.DataPropertyName = "DateEntry";
            this.dateEntryDataGridViewTextBoxColumn.HeaderText = "Дата ввода";
            this.dateEntryDataGridViewTextBoxColumn.Name = "dateEntryDataGridViewTextBoxColumn";
            this.dateEntryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(LogisticsAutomation.Transport);
            // 
            // gpDriverInfo
            // 
            this.gpDriverInfo.Controls.Add(this.tbPhoneDriver);
            this.gpDriverInfo.Controls.Add(this.tbCategoryDriver);
            this.gpDriverInfo.Controls.Add(this.tbNameDriver);
            this.gpDriverInfo.Controls.Add(this.label5);
            this.gpDriverInfo.Controls.Add(this.label4);
            this.gpDriverInfo.Controls.Add(this.label3);
            this.gpDriverInfo.Location = new System.Drawing.Point(12, 276);
            this.gpDriverInfo.Name = "gpDriverInfo";
            this.gpDriverInfo.Size = new System.Drawing.Size(336, 103);
            this.gpDriverInfo.TabIndex = 2;
            this.gpDriverInfo.TabStop = false;
            this.gpDriverInfo.Text = "Информация о водителе:";
            // 
            // tbPhoneDriver
            // 
            this.tbPhoneDriver.Location = new System.Drawing.Point(113, 72);
            this.tbPhoneDriver.Name = "tbPhoneDriver";
            this.tbPhoneDriver.ReadOnly = true;
            this.tbPhoneDriver.Size = new System.Drawing.Size(164, 20);
            this.tbPhoneDriver.TabIndex = 5;
            // 
            // tbCategoryDriver
            // 
            this.tbCategoryDriver.Location = new System.Drawing.Point(113, 46);
            this.tbCategoryDriver.Name = "tbCategoryDriver";
            this.tbCategoryDriver.ReadOnly = true;
            this.tbCategoryDriver.Size = new System.Drawing.Size(164, 20);
            this.tbCategoryDriver.TabIndex = 4;
            // 
            // tbNameDriver
            // 
            this.tbNameDriver.Location = new System.Drawing.Point(113, 20);
            this.tbNameDriver.Name = "tbNameDriver";
            this.tbNameDriver.ReadOnly = true;
            this.tbNameDriver.Size = new System.Drawing.Size(164, 20);
            this.tbNameDriver.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Категория:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО:";
            // 
            // gpOperations
            // 
            this.gpOperations.Controls.Add(this.btnChange);
            this.gpOperations.Controls.Add(this.btnRemove);
            this.gpOperations.Controls.Add(this.btnAdd);
            this.gpOperations.Location = new System.Drawing.Point(12, 385);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(679, 55);
            this.gpOperations.TabIndex = 3;
            this.gpOperations.TabStop = false;
            this.gpOperations.Text = "Операции";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(453, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(220, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(229, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(220, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpAdditionally
            // 
            this.gpAdditionally.Controls.Add(this.btnDrivers);
            this.gpAdditionally.Controls.Add(this.btnBrands);
            this.gpAdditionally.Location = new System.Drawing.Point(355, 276);
            this.gpAdditionally.Name = "gpAdditionally";
            this.gpAdditionally.Size = new System.Drawing.Size(336, 103);
            this.gpAdditionally.TabIndex = 4;
            this.gpAdditionally.TabStop = false;
            this.gpAdditionally.Text = "Дополнительно";
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(6, 63);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(324, 32);
            this.btnDrivers.TabIndex = 1;
            this.btnDrivers.Text = "Водители";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnBrands
            // 
            this.btnBrands.Location = new System.Drawing.Point(6, 20);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Size = new System.Drawing.Size(324, 32);
            this.btnBrands.TabIndex = 0;
            this.btnBrands.Text = "Марки";
            this.btnBrands.UseVisualStyleBackColor = true;
            this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
            // 
            // FormTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.gpAdditionally);
            this.Controls.Add(this.gpOperations);
            this.Controls.Add(this.gpDriverInfo);
            this.Controls.Add(this.gpNavigation);
            this.Controls.Add(this.gpFiltration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTransports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автотранспорт";
            this.gpFiltration.ResumeLayout(false);
            this.gpFiltration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.gpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.gpDriverInfo.ResumeLayout(false);
            this.gpDriverInfo.PerformLayout();
            this.gpOperations.ResumeLayout(false);
            this.gpAdditionally.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFiltration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchByStNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpNavigation;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.GroupBox gpDriverInfo;
        private System.Windows.Forms.TextBox tbPhoneDriver;
        private System.Windows.Forms.TextBox tbCategoryDriver;
        private System.Windows.Forms.TextBox tbNameDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpOperations;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpAdditionally;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnBrands;
        private System.Windows.Forms.BindingSource brandBindingSource;
    }
}
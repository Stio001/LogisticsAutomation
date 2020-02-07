namespace LogisticsAutomation
{
    partial class FormTariffs
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.gpNavigation = new System.Windows.Forms.GroupBox();
            this.dgvTariffs = new System.Windows.Forms.DataGridView();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpDescription = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.gpOperations = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perKMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpFiltration.SuspendLayout();
            this.gpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.gpDescription.SuspendLayout();
            this.gpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFiltration
            // 
            this.gpFiltration.Controls.Add(this.btnReset);
            this.gpFiltration.Controls.Add(this.btnSearch);
            this.gpFiltration.Controls.Add(this.label1);
            this.gpFiltration.Controls.Add(this.tbSearchByName);
            this.gpFiltration.Location = new System.Drawing.Point(12, 12);
            this.gpFiltration.Name = "gpFiltration";
            this.gpFiltration.Size = new System.Drawing.Size(544, 58);
            this.gpFiltration.TabIndex = 0;
            this.gpFiltration.TabStop = false;
            this.gpFiltration.Text = "Фильтрация";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(464, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchObjects);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "По полю \"Название\":";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(120, 19);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(263, 20);
            this.tbSearchByName.TabIndex = 0;
            // 
            // gpNavigation
            // 
            this.gpNavigation.Controls.Add(this.dgvTariffs);
            this.gpNavigation.Location = new System.Drawing.Point(12, 76);
            this.gpNavigation.Name = "gpNavigation";
            this.gpNavigation.Size = new System.Drawing.Size(544, 235);
            this.gpNavigation.TabIndex = 1;
            this.gpNavigation.TabStop = false;
            this.gpNavigation.Text = "Навигация";
            // 
            // dgvTariffs
            // 
            this.dgvTariffs.AllowUserToAddRows = false;
            this.dgvTariffs.AllowUserToDeleteRows = false;
            this.dgvTariffs.AutoGenerateColumns = false;
            this.dgvTariffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTariffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.perKMDataGridViewTextBoxColumn,
            this.perHourDataGridViewTextBoxColumn,
            this.perKGDataGridViewTextBoxColumn});
            this.dgvTariffs.DataSource = this.tariffBindingSource;
            this.dgvTariffs.Location = new System.Drawing.Point(6, 19);
            this.dgvTariffs.Name = "dgvTariffs";
            this.dgvTariffs.ReadOnly = true;
            this.dgvTariffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTariffs.Size = new System.Drawing.Size(532, 210);
            this.dgvTariffs.TabIndex = 0;
            this.dgvTariffs.SelectionChanged += new System.EventHandler(this.LoadDescription);
            this.dgvTariffs.DoubleClick += new System.EventHandler(this.btnChange_Click);
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(LogisticsAutomation.Tariff);
            // 
            // gpDescription
            // 
            this.gpDescription.Controls.Add(this.rtbDescription);
            this.gpDescription.Location = new System.Drawing.Point(12, 317);
            this.gpDescription.Name = "gpDescription";
            this.gpDescription.Size = new System.Drawing.Size(544, 86);
            this.gpDescription.TabIndex = 2;
            this.gpDescription.TabStop = false;
            this.gpDescription.Text = "Описание";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(6, 19);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(532, 61);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // gpOperations
            // 
            this.gpOperations.Controls.Add(this.btnChange);
            this.gpOperations.Controls.Add(this.btnRemove);
            this.gpOperations.Controls.Add(this.btnAdd);
            this.gpOperations.Location = new System.Drawing.Point(12, 409);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(544, 52);
            this.gpOperations.TabIndex = 3;
            this.gpOperations.TabStop = false;
            this.gpOperations.Text = "Операции";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(363, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(184, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(175, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perKMDataGridViewTextBoxColumn
            // 
            this.perKMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perKMDataGridViewTextBoxColumn.DataPropertyName = "PerKM";
            this.perKMDataGridViewTextBoxColumn.HeaderText = "За КМ";
            this.perKMDataGridViewTextBoxColumn.Name = "perKMDataGridViewTextBoxColumn";
            this.perKMDataGridViewTextBoxColumn.ReadOnly = true;
            this.perKMDataGridViewTextBoxColumn.Width = 64;
            // 
            // perHourDataGridViewTextBoxColumn
            // 
            this.perHourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perHourDataGridViewTextBoxColumn.DataPropertyName = "PerHour";
            this.perHourDataGridViewTextBoxColumn.HeaderText = "За минуту";
            this.perHourDataGridViewTextBoxColumn.Name = "perHourDataGridViewTextBoxColumn";
            this.perHourDataGridViewTextBoxColumn.ReadOnly = true;
            this.perHourDataGridViewTextBoxColumn.Width = 83;
            // 
            // perKGDataGridViewTextBoxColumn
            // 
            this.perKGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perKGDataGridViewTextBoxColumn.DataPropertyName = "PerKG";
            this.perKGDataGridViewTextBoxColumn.HeaderText = "За КГ";
            this.perKGDataGridViewTextBoxColumn.Name = "perKGDataGridViewTextBoxColumn";
            this.perKGDataGridViewTextBoxColumn.ReadOnly = true;
            this.perKGDataGridViewTextBoxColumn.Width = 61;
            // 
            // FormTariffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 470);
            this.Controls.Add(this.gpOperations);
            this.Controls.Add(this.gpDescription);
            this.Controls.Add(this.gpNavigation);
            this.Controls.Add(this.gpFiltration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTariffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы";
            this.gpFiltration.ResumeLayout(false);
            this.gpFiltration.PerformLayout();
            this.gpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.gpDescription.ResumeLayout(false);
            this.gpOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFiltration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.GroupBox gpNavigation;
        private System.Windows.Forms.DataGridView dgvTariffs;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.GroupBox gpDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox gpOperations;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perKGDataGridViewTextBoxColumn;
    }
}
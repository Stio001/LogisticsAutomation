namespace LogisticsAutomation
{
    partial class FormCargoes
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
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpNavigation = new System.Windows.Forms.GroupBox();
            this.dgvCargoes = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpCargoInfo = new System.Windows.Forms.GroupBox();
            this.rtbCTDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCTPhoto = new System.Windows.Forms.PictureBox();
            this.tbCTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpAdditionally = new System.Windows.Forms.GroupBox();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCargoType = new System.Windows.Forms.Button();
            this.gpOperations = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpFiltration.SuspendLayout();
            this.gpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.gpCargoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCTPhoto)).BeginInit();
            this.gpAdditionally.SuspendLayout();
            this.gpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFiltration
            // 
            this.gpFiltration.Controls.Add(this.btnReset);
            this.gpFiltration.Controls.Add(this.btnSearch);
            this.gpFiltration.Controls.Add(this.tbSearchByName);
            this.gpFiltration.Controls.Add(this.label1);
            this.gpFiltration.Location = new System.Drawing.Point(12, 12);
            this.gpFiltration.Name = "gpFiltration";
            this.gpFiltration.Size = new System.Drawing.Size(611, 55);
            this.gpFiltration.TabIndex = 0;
            this.gpFiltration.TabStop = false;
            this.gpFiltration.Text = "Фильтрация";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(502, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchObjects);
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(130, 19);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(260, 20);
            this.tbSearchByName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "По полю \"Название\":";
            // 
            // gpNavigation
            // 
            this.gpNavigation.Controls.Add(this.dgvCargoes);
            this.gpNavigation.Location = new System.Drawing.Point(12, 73);
            this.gpNavigation.Name = "gpNavigation";
            this.gpNavigation.Size = new System.Drawing.Size(611, 275);
            this.gpNavigation.TabIndex = 1;
            this.gpNavigation.TabStop = false;
            this.gpNavigation.Text = "Навигация";
            // 
            // dgvCargoes
            // 
            this.dgvCargoes.AllowUserToAddRows = false;
            this.dgvCargoes.AllowUserToDeleteRows = false;
            this.dgvCargoes.AutoGenerateColumns = false;
            this.dgvCargoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.unitMeasurementDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dgvCargoes.DataSource = this.cargoBindingSource;
            this.dgvCargoes.Location = new System.Drawing.Point(6, 19);
            this.dgvCargoes.Name = "dgvCargoes";
            this.dgvCargoes.ReadOnly = true;
            this.dgvCargoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargoes.Size = new System.Drawing.Size(599, 250);
            this.dgvCargoes.TabIndex = 0;
            this.dgvCargoes.SelectionChanged += new System.EventHandler(this.LoadCargoInfo);
            this.dgvCargoes.DoubleClick += new System.EventHandler(this.btnChange_Click);
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
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitMeasurementDataGridViewTextBoxColumn
            // 
            this.unitMeasurementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitMeasurement";
            this.unitMeasurementDataGridViewTextBoxColumn.HeaderText = "Ед. измерения";
            this.unitMeasurementDataGridViewTextBoxColumn.Name = "unitMeasurementDataGridViewTextBoxColumn";
            this.unitMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(LogisticsAutomation.Cargo);
            // 
            // gpCargoInfo
            // 
            this.gpCargoInfo.Controls.Add(this.rtbCTDescription);
            this.gpCargoInfo.Controls.Add(this.label3);
            this.gpCargoInfo.Controls.Add(this.pbCTPhoto);
            this.gpCargoInfo.Controls.Add(this.tbCTName);
            this.gpCargoInfo.Controls.Add(this.label2);
            this.gpCargoInfo.Location = new System.Drawing.Point(12, 354);
            this.gpCargoInfo.Name = "gpCargoInfo";
            this.gpCargoInfo.Size = new System.Drawing.Size(304, 133);
            this.gpCargoInfo.TabIndex = 2;
            this.gpCargoInfo.TabStop = false;
            this.gpCargoInfo.Text = "Информация и грузе";
            // 
            // rtbCTDescription
            // 
            this.rtbCTDescription.Location = new System.Drawing.Point(9, 71);
            this.rtbCTDescription.Name = "rtbCTDescription";
            this.rtbCTDescription.ReadOnly = true;
            this.rtbCTDescription.Size = new System.Drawing.Size(142, 56);
            this.rtbCTDescription.TabIndex = 4;
            this.rtbCTDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание:";
            // 
            // pbCTPhoto
            // 
            this.pbCTPhoto.Location = new System.Drawing.Point(157, 16);
            this.pbCTPhoto.Name = "pbCTPhoto";
            this.pbCTPhoto.Size = new System.Drawing.Size(141, 111);
            this.pbCTPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCTPhoto.TabIndex = 2;
            this.pbCTPhoto.TabStop = false;
            // 
            // tbCTName
            // 
            this.tbCTName.Location = new System.Drawing.Point(9, 32);
            this.tbCTName.Name = "tbCTName";
            this.tbCTName.ReadOnly = true;
            this.tbCTName.Size = new System.Drawing.Size(142, 20);
            this.tbCTName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип груза:";
            // 
            // gpAdditionally
            // 
            this.gpAdditionally.Controls.Add(this.btnSuppliers);
            this.gpAdditionally.Controls.Add(this.btnCargoType);
            this.gpAdditionally.Location = new System.Drawing.Point(319, 354);
            this.gpAdditionally.Name = "gpAdditionally";
            this.gpAdditionally.Size = new System.Drawing.Size(304, 133);
            this.gpAdditionally.TabIndex = 3;
            this.gpAdditionally.TabStop = false;
            this.gpAdditionally.Text = "Дополнительно";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(6, 78);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(292, 43);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCargoType
            // 
            this.btnCargoType.Location = new System.Drawing.Point(6, 23);
            this.btnCargoType.Name = "btnCargoType";
            this.btnCargoType.Size = new System.Drawing.Size(292, 43);
            this.btnCargoType.TabIndex = 0;
            this.btnCargoType.Text = "Типы груза";
            this.btnCargoType.UseVisualStyleBackColor = true;
            this.btnCargoType.Click += new System.EventHandler(this.btnCargoType_Click);
            // 
            // gpOperations
            // 
            this.gpOperations.Controls.Add(this.btnChange);
            this.gpOperations.Controls.Add(this.btnRemove);
            this.gpOperations.Controls.Add(this.btnAdd);
            this.gpOperations.Location = new System.Drawing.Point(12, 493);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(611, 52);
            this.gpOperations.TabIndex = 4;
            this.gpOperations.TabStop = false;
            this.gpOperations.Text = "Операции";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(409, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(196, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(208, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(196, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormCargoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 557);
            this.Controls.Add(this.gpOperations);
            this.Controls.Add(this.gpAdditionally);
            this.Controls.Add(this.gpCargoInfo);
            this.Controls.Add(this.gpNavigation);
            this.Controls.Add(this.gpFiltration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCargoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грузы";
            this.gpFiltration.ResumeLayout(false);
            this.gpFiltration.PerformLayout();
            this.gpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.gpCargoInfo.ResumeLayout(false);
            this.gpCargoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCTPhoto)).EndInit();
            this.gpAdditionally.ResumeLayout(false);
            this.gpOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFiltration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpNavigation;
        private System.Windows.Forms.DataGridView dgvCargoes;
        private System.Windows.Forms.GroupBox gpCargoInfo;
        private System.Windows.Forms.RichTextBox rtbCTDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCTPhoto;
        private System.Windows.Forms.TextBox tbCTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpAdditionally;
        private System.Windows.Forms.GroupBox gpOperations;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCargoType;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cargoBindingSource;
    }
}
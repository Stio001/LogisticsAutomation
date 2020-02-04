namespace LogisticsAutomation
{
    partial class FormBrands
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
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.gpDescription = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.gpOperations = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carryingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpFiltration.SuspendLayout();
            this.gpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.gpDescription.SuspendLayout();
            this.gpOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
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
            this.gpFiltration.Size = new System.Drawing.Size(472, 53);
            this.gpFiltration.TabIndex = 0;
            this.gpFiltration.TabStop = false;
            this.gpFiltration.Text = "Фильтрация";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(398, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchObjects);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "По полю \"Марка\":";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(112, 19);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(207, 20);
            this.tbSearchByName.TabIndex = 0;
            // 
            // gpNavigation
            // 
            this.gpNavigation.Controls.Add(this.dgvBrands);
            this.gpNavigation.Location = new System.Drawing.Point(12, 71);
            this.gpNavigation.Name = "gpNavigation";
            this.gpNavigation.Size = new System.Drawing.Size(472, 177);
            this.gpNavigation.TabIndex = 1;
            this.gpNavigation.TabStop = false;
            this.gpNavigation.Text = "Навигация";
            // 
            // dgvBrands
            // 
            this.dgvBrands.AllowUserToAddRows = false;
            this.dgvBrands.AllowUserToDeleteRows = false;
            this.dgvBrands.AutoGenerateColumns = false;
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.carryingDataGridViewTextBoxColumn,
            this.Lenght,
            this.Width,
            this.Height});
            this.dgvBrands.DataSource = this.brandBindingSource;
            this.dgvBrands.Location = new System.Drawing.Point(6, 19);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.ReadOnly = true;
            this.dgvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrands.Size = new System.Drawing.Size(460, 152);
            this.dgvBrands.TabIndex = 0;
            this.dgvBrands.SelectionChanged += new System.EventHandler(this.LoadDescription);
            this.dgvBrands.DoubleClick += new System.EventHandler(this.btnChange_Click);
            // 
            // gpDescription
            // 
            this.gpDescription.Controls.Add(this.rtbDescription);
            this.gpDescription.Location = new System.Drawing.Point(12, 254);
            this.gpDescription.Name = "gpDescription";
            this.gpDescription.Size = new System.Drawing.Size(472, 120);
            this.gpDescription.TabIndex = 2;
            this.gpDescription.TabStop = false;
            this.gpDescription.Text = "Описание";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(6, 19);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(460, 95);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // gpOperations
            // 
            this.gpOperations.Controls.Add(this.btnChange);
            this.gpOperations.Controls.Add(this.btnRemove);
            this.gpOperations.Controls.Add(this.btnAdd);
            this.gpOperations.Location = new System.Drawing.Point(12, 380);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(472, 52);
            this.gpOperations.TabIndex = 3;
            this.gpOperations.TabStop = false;
            this.gpOperations.Text = "Операции";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(316, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(161, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(LogisticsAutomation.Brand);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carryingDataGridViewTextBoxColumn
            // 
            this.carryingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.carryingDataGridViewTextBoxColumn.DataPropertyName = "Carrying";
            this.carryingDataGridViewTextBoxColumn.HeaderText = "Грузоподъемность(кг)";
            this.carryingDataGridViewTextBoxColumn.Name = "carryingDataGridViewTextBoxColumn";
            this.carryingDataGridViewTextBoxColumn.ReadOnly = true;
            this.carryingDataGridViewTextBoxColumn.Width = 5;
            // 
            // Lenght
            // 
            this.Lenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lenght.DataPropertyName = "Lenght";
            this.Lenght.HeaderText = "Длина(см)";
            this.Lenght.Name = "Lenght";
            this.Lenght.ReadOnly = true;
            this.Lenght.Width = 85;
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Ширина(см)";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.Width = 91;
            // 
            // Height
            // 
            this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Height.DataPropertyName = "Height";
            this.Height.HeaderText = "Высота(см)";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Width = 90;
            // 
            // FormBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 441);
            this.Controls.Add(this.gpOperations);
            this.Controls.Add(this.gpDescription);
            this.Controls.Add(this.gpNavigation);
            this.Controls.Add(this.gpFiltration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBrands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобильные марки";
            this.gpFiltration.ResumeLayout(false);
            this.gpFiltration.PerformLayout();
            this.gpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.gpDescription.ResumeLayout(false);
            this.gpOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFiltration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.GroupBox gpNavigation;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.GroupBox gpDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox gpOperations;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carryingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
    }
}
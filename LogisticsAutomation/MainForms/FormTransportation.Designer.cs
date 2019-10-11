namespace LogisticsAutomation
{
    partial class FormTransportation
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
            this.gpTransportations = new System.Windows.Forms.GroupBox();
            this.dgvTransportations = new System.Windows.Forms.DataGridView();
            this.gpOperations = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpDetails = new System.Windows.Forms.GroupBox();
            this.tbTariff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTransport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpDescription = new System.Windows.Forms.GroupBox();
            this.rtbAdditionalData = new System.Windows.Forms.RichTextBox();
            this.gpAdditionally = new System.Windows.Forms.GroupBox();
            this.tbDateArrival = new System.Windows.Forms.TextBox();
            this.tbSpeedometerDeparture = new System.Windows.Forms.TextBox();
            this.tbSpeedometerComing = new System.Windows.Forms.TextBox();
            this.tbFuelComing = new System.Windows.Forms.TextBox();
            this.tbFuelDeparture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpDocuments = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gpFiltrations = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ntbSearchByID = new System.Windows.Forms.NumericUpDown();
            this.dgvCargoes = new System.Windows.Forms.DataGridView();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpTransportations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportations)).BeginInit();
            this.gpOperations.SuspendLayout();
            this.gpDetails.SuspendLayout();
            this.gpInfo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpDescription.SuspendLayout();
            this.gpAdditionally.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpDocuments.SuspendLayout();
            this.gpFiltrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSearchByID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpTransportations
            // 
            this.gpTransportations.Controls.Add(this.dgvTransportations);
            this.gpTransportations.Location = new System.Drawing.Point(12, 69);
            this.gpTransportations.Name = "gpTransportations";
            this.gpTransportations.Size = new System.Drawing.Size(500, 394);
            this.gpTransportations.TabIndex = 0;
            this.gpTransportations.TabStop = false;
            this.gpTransportations.Text = "Перечень договоров";
            // 
            // dgvTransportations
            // 
            this.dgvTransportations.AllowUserToAddRows = false;
            this.dgvTransportations.AllowUserToDeleteRows = false;
            this.dgvTransportations.AutoGenerateColumns = false;
            this.dgvTransportations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.placeDeliveryDataGridViewTextBoxColumn,
            this.kilometrageDataGridViewTextBoxColumn,
            this.travelTimeDataGridViewTextBoxColumn});
            this.dgvTransportations.DataSource = this.transportationBindingSource;
            this.dgvTransportations.Location = new System.Drawing.Point(6, 19);
            this.dgvTransportations.Name = "dgvTransportations";
            this.dgvTransportations.ReadOnly = true;
            this.dgvTransportations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportations.Size = new System.Drawing.Size(488, 369);
            this.dgvTransportations.TabIndex = 0;
            this.dgvTransportations.SelectionChanged += new System.EventHandler(this.LoadInfo);
            this.dgvTransportations.DoubleClick += new System.EventHandler(this.btnChange_Click);
            // 
            // gpOperations
            // 
            this.gpOperations.Controls.Add(this.btnChange);
            this.gpOperations.Controls.Add(this.btnRemove);
            this.gpOperations.Controls.Add(this.btnAdd);
            this.gpOperations.Location = new System.Drawing.Point(12, 469);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(500, 54);
            this.gpOperations.TabIndex = 3;
            this.gpOperations.TabStop = false;
            this.gpOperations.Text = "Операции";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(334, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(160, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(170, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpDetails
            // 
            this.gpDetails.Controls.Add(this.tbTariff);
            this.gpDetails.Controls.Add(this.label3);
            this.gpDetails.Controls.Add(this.tbClient);
            this.gpDetails.Controls.Add(this.label2);
            this.gpDetails.Controls.Add(this.tbTransport);
            this.gpDetails.Controls.Add(this.label1);
            this.gpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpDetails.Location = new System.Drawing.Point(6, 6);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.Size = new System.Drawing.Size(468, 103);
            this.gpDetails.TabIndex = 2;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Основные";
            // 
            // tbTariff
            // 
            this.tbTariff.Location = new System.Drawing.Point(259, 58);
            this.tbTariff.Name = "tbTariff";
            this.tbTariff.ReadOnly = true;
            this.tbTariff.Size = new System.Drawing.Size(203, 26);
            this.tbTariff.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тариф:";
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(106, 58);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(143, 26);
            this.tbClient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заказчик:";
            // 
            // tbTransport
            // 
            this.tbTransport.Location = new System.Drawing.Point(106, 26);
            this.tbTransport.Name = "tbTransport";
            this.tbTransport.ReadOnly = true;
            this.tbTransport.Size = new System.Drawing.Size(143, 26);
            this.tbTransport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гос. номер:";
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.tabControl);
            this.gpInfo.Location = new System.Drawing.Point(521, 12);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(500, 511);
            this.gpInfo.TabIndex = 1;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Информация о перевозке";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(6, 19);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 486);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpDescription);
            this.tabPage1.Controls.Add(this.gpAdditionally);
            this.tabPage1.Controls.Add(this.gpDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Детали";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gpDescription
            // 
            this.gpDescription.Controls.Add(this.rtbAdditionalData);
            this.gpDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpDescription.Location = new System.Drawing.Point(6, 311);
            this.gpDescription.Name = "gpDescription";
            this.gpDescription.Size = new System.Drawing.Size(468, 143);
            this.gpDescription.TabIndex = 4;
            this.gpDescription.TabStop = false;
            this.gpDescription.Text = "Дополнительная информация";
            // 
            // rtbAdditionalData
            // 
            this.rtbAdditionalData.Location = new System.Drawing.Point(6, 25);
            this.rtbAdditionalData.Name = "rtbAdditionalData";
            this.rtbAdditionalData.ReadOnly = true;
            this.rtbAdditionalData.Size = new System.Drawing.Size(456, 112);
            this.rtbAdditionalData.TabIndex = 0;
            this.rtbAdditionalData.Text = "";
            // 
            // gpAdditionally
            // 
            this.gpAdditionally.Controls.Add(this.tbDateArrival);
            this.gpAdditionally.Controls.Add(this.tbSpeedometerDeparture);
            this.gpAdditionally.Controls.Add(this.tbSpeedometerComing);
            this.gpAdditionally.Controls.Add(this.tbFuelComing);
            this.gpAdditionally.Controls.Add(this.tbFuelDeparture);
            this.gpAdditionally.Controls.Add(this.label8);
            this.gpAdditionally.Controls.Add(this.label7);
            this.gpAdditionally.Controls.Add(this.label6);
            this.gpAdditionally.Controls.Add(this.label5);
            this.gpAdditionally.Controls.Add(this.label4);
            this.gpAdditionally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpAdditionally.Location = new System.Drawing.Point(6, 115);
            this.gpAdditionally.Name = "gpAdditionally";
            this.gpAdditionally.Size = new System.Drawing.Size(468, 190);
            this.gpAdditionally.TabIndex = 3;
            this.gpAdditionally.TabStop = false;
            this.gpAdditionally.Text = "Информация для путевого листа";
            // 
            // tbDateArrival
            // 
            this.tbDateArrival.Location = new System.Drawing.Point(224, 150);
            this.tbDateArrival.Name = "tbDateArrival";
            this.tbDateArrival.ReadOnly = true;
            this.tbDateArrival.Size = new System.Drawing.Size(238, 26);
            this.tbDateArrival.TabIndex = 8;
            // 
            // tbSpeedometerDeparture
            // 
            this.tbSpeedometerDeparture.Location = new System.Drawing.Point(224, 89);
            this.tbSpeedometerDeparture.Name = "tbSpeedometerDeparture";
            this.tbSpeedometerDeparture.ReadOnly = true;
            this.tbSpeedometerDeparture.Size = new System.Drawing.Size(238, 26);
            this.tbSpeedometerDeparture.TabIndex = 7;
            // 
            // tbSpeedometerComing
            // 
            this.tbSpeedometerComing.Location = new System.Drawing.Point(224, 121);
            this.tbSpeedometerComing.Name = "tbSpeedometerComing";
            this.tbSpeedometerComing.ReadOnly = true;
            this.tbSpeedometerComing.Size = new System.Drawing.Size(238, 26);
            this.tbSpeedometerComing.TabIndex = 7;
            // 
            // tbFuelComing
            // 
            this.tbFuelComing.Location = new System.Drawing.Point(224, 57);
            this.tbFuelComing.Name = "tbFuelComing";
            this.tbFuelComing.ReadOnly = true;
            this.tbFuelComing.Size = new System.Drawing.Size(238, 26);
            this.tbFuelComing.TabIndex = 6;
            // 
            // tbFuelDeparture
            // 
            this.tbFuelDeparture.Location = new System.Drawing.Point(224, 25);
            this.tbFuelDeparture.Name = "tbFuelDeparture";
            this.tbFuelDeparture.ReadOnly = true;
            this.tbFuelDeparture.Size = new System.Drawing.Size(238, 26);
            this.tbFuelDeparture.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Дата и время прибытия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Спидометр кол-во приезд:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Спидометр кол-во выезд:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Топливо кол-во приезд:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Топливо кол-во выезд:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCargoes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Грузы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpDocuments
            // 
            this.gpDocuments.Controls.Add(this.button9);
            this.gpDocuments.Controls.Add(this.button8);
            this.gpDocuments.Controls.Add(this.button7);
            this.gpDocuments.Controls.Add(this.button6);
            this.gpDocuments.Location = new System.Drawing.Point(12, 529);
            this.gpDocuments.Name = "gpDocuments";
            this.gpDocuments.Size = new System.Drawing.Size(1009, 52);
            this.gpDocuments.TabIndex = 2;
            this.gpDocuments.TabStop = false;
            this.gpDocuments.Text = "Документы";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(758, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(245, 27);
            this.button9.TabIndex = 3;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(508, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(245, 27);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(257, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(245, 27);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 27);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // gpFiltrations
            // 
            this.gpFiltrations.Controls.Add(this.btnReset);
            this.gpFiltrations.Controls.Add(this.btnSearch);
            this.gpFiltrations.Controls.Add(this.ntbSearchByID);
            this.gpFiltrations.Location = new System.Drawing.Point(12, 12);
            this.gpFiltrations.Name = "gpFiltrations";
            this.gpFiltrations.Size = new System.Drawing.Size(500, 51);
            this.gpFiltrations.TabIndex = 4;
            this.gpFiltrations.TabStop = false;
            this.gpFiltrations.Text = "Фильтрация";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(381, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSearch);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchObjects);
            // 
            // ntbSearchByID
            // 
            this.ntbSearchByID.Location = new System.Drawing.Point(6, 19);
            this.ntbSearchByID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbSearchByID.Name = "ntbSearchByID";
            this.ntbSearchByID.Size = new System.Drawing.Size(251, 20);
            this.ntbSearchByID.TabIndex = 0;
            // 
            // dgvCargoes
            // 
            this.dgvCargoes.AllowUserToAddRows = false;
            this.dgvCargoes.AllowUserToDeleteRows = false;
            this.dgvCargoes.AutoGenerateColumns = false;
            this.dgvCargoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.unitMeasurementDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dgvCargoes.DataSource = this.cargoBindingSource;
            this.dgvCargoes.Location = new System.Drawing.Point(3, 6);
            this.dgvCargoes.Name = "dgvCargoes";
            this.dgvCargoes.ReadOnly = true;
            this.dgvCargoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargoes.Size = new System.Drawing.Size(471, 448);
            this.dgvCargoes.TabIndex = 0;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(LogisticsAutomation.Cargo);
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
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDeliveryDataGridViewTextBoxColumn
            // 
            this.placeDeliveryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeDeliveryDataGridViewTextBoxColumn.DataPropertyName = "PlaceDelivery";
            this.placeDeliveryDataGridViewTextBoxColumn.HeaderText = "Место доставки";
            this.placeDeliveryDataGridViewTextBoxColumn.Name = "placeDeliveryDataGridViewTextBoxColumn";
            this.placeDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometrageDataGridViewTextBoxColumn
            // 
            this.kilometrageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kilometrageDataGridViewTextBoxColumn.DataPropertyName = "Kilometrage";
            this.kilometrageDataGridViewTextBoxColumn.HeaderText = "Километраж";
            this.kilometrageDataGridViewTextBoxColumn.Name = "kilometrageDataGridViewTextBoxColumn";
            this.kilometrageDataGridViewTextBoxColumn.ReadOnly = true;
            this.kilometrageDataGridViewTextBoxColumn.Width = 96;
            // 
            // travelTimeDataGridViewTextBoxColumn
            // 
            this.travelTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.travelTimeDataGridViewTextBoxColumn.DataPropertyName = "TravelTime";
            this.travelTimeDataGridViewTextBoxColumn.HeaderText = "Затрачено времени";
            this.travelTimeDataGridViewTextBoxColumn.Name = "travelTimeDataGridViewTextBoxColumn";
            this.travelTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.travelTimeDataGridViewTextBoxColumn.Width = 121;
            // 
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataSource = typeof(LogisticsAutomation.Transportation);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "Код";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Width = 51;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 91;
            // 
            // unitMeasurementDataGridViewTextBoxColumn
            // 
            this.unitMeasurementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.unitMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitMeasurement";
            this.unitMeasurementDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitMeasurementDataGridViewTextBoxColumn.Name = "unitMeasurementDataGridViewTextBoxColumn";
            this.unitMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitMeasurementDataGridViewTextBoxColumn.Width = 74;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 51;
            // 
            // FormTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 591);
            this.Controls.Add(this.gpFiltrations);
            this.Controls.Add(this.gpOperations);
            this.Controls.Add(this.gpDocuments);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.gpTransportations);
            this.MaximizeBox = false;
            this.Name = "FormTransportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договора на перевозку";
            this.gpTransportations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportations)).EndInit();
            this.gpOperations.ResumeLayout(false);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpDescription.ResumeLayout(false);
            this.gpAdditionally.ResumeLayout(false);
            this.gpAdditionally.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gpDocuments.ResumeLayout(false);
            this.gpFiltrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ntbSearchByID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTransportations;
        private System.Windows.Forms.GroupBox gpOperations;
        private System.Windows.Forms.GroupBox gpDetails;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.GroupBox gpDocuments;
        private System.Windows.Forms.GroupBox gpFiltrations;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpDescription;
        private System.Windows.Forms.GroupBox gpAdditionally;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown ntbSearchByID;
        private System.Windows.Forms.DataGridView dgvTransportations;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbAdditionalData;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transportationBindingSource;
        private System.Windows.Forms.TextBox tbTariff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDateArrival;
        private System.Windows.Forms.TextBox tbSpeedometerDeparture;
        private System.Windows.Forms.TextBox tbSpeedometerComing;
        private System.Windows.Forms.TextBox tbFuelComing;
        private System.Windows.Forms.TextBox tbFuelDeparture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCargoes;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    }
}
namespace LogisticsAutomation.DialogForms
{
    partial class DFormTransportation
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
            this.gpMainData = new System.Windows.Forms.GroupBox();
            this.gpAdditionally = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.tbPlaceDelivery = new System.Windows.Forms.TextBox();
            this.ntbKilometrage = new System.Windows.Forms.NumericUpDown();
            this.ntbTravelTime = new System.Windows.Forms.NumericUpDown();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbTariff = new System.Windows.Forms.ComboBox();
            this.ntbFuelDeparture = new System.Windows.Forms.NumericUpDown();
            this.ntbFuelComing = new System.Windows.Forms.NumericUpDown();
            this.ntbSpeedometerDeparture = new System.Windows.Forms.NumericUpDown();
            this.ntbSpeedometerComing = new System.Windows.Forms.NumericUpDown();
            this.dtpDateArrival = new System.Windows.Forms.DateTimePicker();
            this.rtbAdditionalData = new System.Windows.Forms.RichTextBox();
            this.dgvCargoes = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvCargoTransportation = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoTransportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpMainData.SuspendLayout();
            this.gpAdditionally.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntbKilometrage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbTravelTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoTransportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTransportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpMainData
            // 
            this.gpMainData.Controls.Add(this.cmbTariff);
            this.gpMainData.Controls.Add(this.cmbClient);
            this.gpMainData.Controls.Add(this.cmbTransport);
            this.gpMainData.Controls.Add(this.ntbTravelTime);
            this.gpMainData.Controls.Add(this.ntbKilometrage);
            this.gpMainData.Controls.Add(this.tbPlaceDelivery);
            this.gpMainData.Controls.Add(this.dtpDateOrder);
            this.gpMainData.Controls.Add(this.label7);
            this.gpMainData.Controls.Add(this.label6);
            this.gpMainData.Controls.Add(this.label5);
            this.gpMainData.Controls.Add(this.label4);
            this.gpMainData.Controls.Add(this.label3);
            this.gpMainData.Controls.Add(this.label2);
            this.gpMainData.Controls.Add(this.label1);
            this.gpMainData.Location = new System.Drawing.Point(12, 12);
            this.gpMainData.Name = "gpMainData";
            this.gpMainData.Size = new System.Drawing.Size(346, 269);
            this.gpMainData.TabIndex = 0;
            this.gpMainData.TabStop = false;
            this.gpMainData.Text = "Основные данные";
            // 
            // gpAdditionally
            // 
            this.gpAdditionally.Controls.Add(this.rtbAdditionalData);
            this.gpAdditionally.Controls.Add(this.dtpDateArrival);
            this.gpAdditionally.Controls.Add(this.ntbSpeedometerComing);
            this.gpAdditionally.Controls.Add(this.ntbSpeedometerDeparture);
            this.gpAdditionally.Controls.Add(this.ntbFuelComing);
            this.gpAdditionally.Controls.Add(this.ntbFuelDeparture);
            this.gpAdditionally.Controls.Add(this.label13);
            this.gpAdditionally.Controls.Add(this.label12);
            this.gpAdditionally.Controls.Add(this.label11);
            this.gpAdditionally.Controls.Add(this.label10);
            this.gpAdditionally.Controls.Add(this.label9);
            this.gpAdditionally.Controls.Add(this.label8);
            this.gpAdditionally.Location = new System.Drawing.Point(364, 12);
            this.gpAdditionally.Name = "gpAdditionally";
            this.gpAdditionally.Size = new System.Drawing.Size(407, 269);
            this.gpAdditionally.TabIndex = 1;
            this.gpAdditionally.TabStop = false;
            this.gpAdditionally.Text = "Дополнительно";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dgvCargoTransportation);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.dgvCargoes);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Грузы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место доставки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Километраж:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Затрачено времени:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Транспорт:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Заказчик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Тариф:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Топливо кол-во выезд:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Топливо кол-во приезд:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Спидометр кол-во выезд:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Спидометр кол-во приезд:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Дата и время прибытия:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дополнительная информация:";
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Location = new System.Drawing.Point(122, 44);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOrder.TabIndex = 7;
            // 
            // tbPlaceDelivery
            // 
            this.tbPlaceDelivery.Location = new System.Drawing.Point(122, 70);
            this.tbPlaceDelivery.MaxLength = 100;
            this.tbPlaceDelivery.Name = "tbPlaceDelivery";
            this.tbPlaceDelivery.Size = new System.Drawing.Size(200, 20);
            this.tbPlaceDelivery.TabIndex = 8;
            // 
            // ntbKilometrage
            // 
            this.ntbKilometrage.Location = new System.Drawing.Point(122, 96);
            this.ntbKilometrage.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbKilometrage.Name = "ntbKilometrage";
            this.ntbKilometrage.Size = new System.Drawing.Size(200, 20);
            this.ntbKilometrage.TabIndex = 9;
            // 
            // ntbTravelTime
            // 
            this.ntbTravelTime.Location = new System.Drawing.Point(122, 122);
            this.ntbTravelTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbTravelTime.Name = "ntbTravelTime";
            this.ntbTravelTime.Size = new System.Drawing.Size(200, 20);
            this.ntbTravelTime.TabIndex = 10;
            // 
            // cmbTransport
            // 
            this.cmbTransport.DataSource = this.transportBindingSource;
            this.cmbTransport.DisplayMember = "StateNumber";
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(122, 148);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(200, 21);
            this.cmbTransport.TabIndex = 11;
            this.cmbTransport.ValueMember = "ID";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.clientBindingSource;
            this.cmbClient.DisplayMember = "Name";
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(122, 175);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 12;
            this.cmbClient.ValueMember = "ID";
            // 
            // cmbTariff
            // 
            this.cmbTariff.DataSource = this.tariffBindingSource;
            this.cmbTariff.DisplayMember = "Name";
            this.cmbTariff.FormattingEnabled = true;
            this.cmbTariff.Location = new System.Drawing.Point(122, 202);
            this.cmbTariff.Name = "cmbTariff";
            this.cmbTariff.Size = new System.Drawing.Size(200, 21);
            this.cmbTariff.TabIndex = 13;
            this.cmbTariff.ValueMember = "ID";
            // 
            // ntbFuelDeparture
            // 
            this.ntbFuelDeparture.Location = new System.Drawing.Point(153, 17);
            this.ntbFuelDeparture.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbFuelDeparture.Name = "ntbFuelDeparture";
            this.ntbFuelDeparture.Size = new System.Drawing.Size(200, 20);
            this.ntbFuelDeparture.TabIndex = 6;
            // 
            // ntbFuelComing
            // 
            this.ntbFuelComing.Location = new System.Drawing.Point(153, 43);
            this.ntbFuelComing.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbFuelComing.Name = "ntbFuelComing";
            this.ntbFuelComing.Size = new System.Drawing.Size(200, 20);
            this.ntbFuelComing.TabIndex = 7;
            // 
            // ntbSpeedometerDeparture
            // 
            this.ntbSpeedometerDeparture.Location = new System.Drawing.Point(153, 69);
            this.ntbSpeedometerDeparture.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbSpeedometerDeparture.Name = "ntbSpeedometerDeparture";
            this.ntbSpeedometerDeparture.Size = new System.Drawing.Size(200, 20);
            this.ntbSpeedometerDeparture.TabIndex = 8;
            // 
            // ntbSpeedometerComing
            // 
            this.ntbSpeedometerComing.Location = new System.Drawing.Point(153, 95);
            this.ntbSpeedometerComing.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbSpeedometerComing.Name = "ntbSpeedometerComing";
            this.ntbSpeedometerComing.Size = new System.Drawing.Size(200, 20);
            this.ntbSpeedometerComing.TabIndex = 9;
            // 
            // dtpDateArrival
            // 
            this.dtpDateArrival.Location = new System.Drawing.Point(153, 121);
            this.dtpDateArrival.Name = "dtpDateArrival";
            this.dtpDateArrival.Size = new System.Drawing.Size(200, 20);
            this.dtpDateArrival.TabIndex = 10;
            // 
            // rtbAdditionalData
            // 
            this.rtbAdditionalData.Location = new System.Drawing.Point(9, 166);
            this.rtbAdditionalData.MaxLength = 200;
            this.rtbAdditionalData.Name = "rtbAdditionalData";
            this.rtbAdditionalData.Size = new System.Drawing.Size(392, 97);
            this.rtbAdditionalData.TabIndex = 11;
            this.rtbAdditionalData.Text = "";
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
            this.cargoTypeDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dgvCargoes.DataSource = this.cargoBindingSource;
            this.dgvCargoes.Location = new System.Drawing.Point(9, 32);
            this.dgvCargoes.Name = "dgvCargoes";
            this.dgvCargoes.ReadOnly = true;
            this.dgvCargoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargoes.Size = new System.Drawing.Size(441, 225);
            this.dgvCargoes.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(456, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 110);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(456, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 110);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvCargoTransportation
            // 
            this.dgvCargoTransportation.AllowUserToAddRows = false;
            this.dgvCargoTransportation.AllowUserToDeleteRows = false;
            this.dgvCargoTransportation.AutoGenerateColumns = false;
            this.dgvCargoTransportation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargoTransportation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.cargoDataGridViewTextBoxColumn});
            this.dgvCargoTransportation.DataSource = this.cargoTransportationBindingSource;
            this.dgvCargoTransportation.Location = new System.Drawing.Point(497, 32);
            this.dgvCargoTransportation.Name = "dgvCargoTransportation";
            this.dgvCargoTransportation.ReadOnly = true;
            this.dgvCargoTransportation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargoTransportation.Size = new System.Drawing.Size(256, 225);
            this.dgvCargoTransportation.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(200, 556);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(398, 557);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(150, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Доступные грузы:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(494, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Грузы в перевозке:";
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
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 5;
            // 
            // unitMeasurementDataGridViewTextBoxColumn
            // 
            this.unitMeasurementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.unitMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitMeasurement";
            this.unitMeasurementDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitMeasurementDataGridViewTextBoxColumn.Name = "unitMeasurementDataGridViewTextBoxColumn";
            this.unitMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitMeasurementDataGridViewTextBoxColumn.Width = 5;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 51;
            // 
            // cargoTypeDataGridViewTextBoxColumn
            // 
            this.cargoTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cargoTypeDataGridViewTextBoxColumn.DataPropertyName = "CargoType";
            this.cargoTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.cargoTypeDataGridViewTextBoxColumn.Name = "cargoTypeDataGridViewTextBoxColumn";
            this.cargoTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoTypeDataGridViewTextBoxColumn.Width = 51;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoTransportationBindingSource
            // 
            this.cargoTransportationBindingSource.DataSource = typeof(LogisticsAutomation.CargoTransportation);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 51;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Груз";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(LogisticsAutomation.Transport);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(LogisticsAutomation.Client);
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(LogisticsAutomation.Tariff);
            // 
            // DFormTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 600);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpAdditionally);
            this.Controls.Add(this.gpMainData);
            this.Name = "DFormTransportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оформление перевозки";
            this.gpMainData.ResumeLayout(false);
            this.gpMainData.PerformLayout();
            this.gpAdditionally.ResumeLayout(false);
            this.gpAdditionally.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntbKilometrage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbTravelTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargoTransportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTransportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMainData;
        private System.Windows.Forms.GroupBox gpAdditionally;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cargoTransportationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        protected internal System.Windows.Forms.NumericUpDown ntbKilometrage;
        protected internal System.Windows.Forms.TextBox tbPlaceDelivery;
        protected internal System.Windows.Forms.DateTimePicker dtpDateOrder;
        protected internal System.Windows.Forms.ComboBox cmbTariff;
        protected internal System.Windows.Forms.ComboBox cmbClient;
        protected internal System.Windows.Forms.ComboBox cmbTransport;
        protected internal System.Windows.Forms.NumericUpDown ntbTravelTime;
        protected internal System.Windows.Forms.RichTextBox rtbAdditionalData;
        protected internal System.Windows.Forms.DateTimePicker dtpDateArrival;
        protected internal System.Windows.Forms.NumericUpDown ntbSpeedometerComing;
        protected internal System.Windows.Forms.NumericUpDown ntbSpeedometerDeparture;
        protected internal System.Windows.Forms.NumericUpDown ntbFuelComing;
        protected internal System.Windows.Forms.NumericUpDown ntbFuelDeparture;
        protected internal System.Windows.Forms.DataGridView dgvCargoTransportation;
        protected internal System.Windows.Forms.DataGridView dgvCargoes;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource transportBindingSource;
    }
}
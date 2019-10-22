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
            this.cmbTariff = new System.Windows.Forms.ComboBox();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ntbTravelTime = new System.Windows.Forms.NumericUpDown();
            this.ntbKilometrage = new System.Windows.Forms.NumericUpDown();
            this.tbPlaceDelivery = new System.Windows.Forms.TextBox();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpAdditionally = new System.Windows.Forms.GroupBox();
            this.rtbAdditionalData = new System.Windows.Forms.RichTextBox();
            this.dtpDateArrival = new System.Windows.Forms.DateTimePicker();
            this.ntbSpeedometerComing = new System.Windows.Forms.NumericUpDown();
            this.ntbSpeedometerDeparture = new System.Windows.Forms.NumericUpDown();
            this.ntbFuelComing = new System.Windows.Forms.NumericUpDown();
            this.ntbFuelDeparture = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCargoes = new System.Windows.Forms.ListBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.gpMainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbTravelTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbKilometrage)).BeginInit();
            this.gpAdditionally.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelComing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelDeparture)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
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
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(LogisticsAutomation.Tariff);
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(LogisticsAutomation.Client);
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
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(LogisticsAutomation.Transport);
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
            // tbPlaceDelivery
            // 
            this.tbPlaceDelivery.Location = new System.Drawing.Point(122, 70);
            this.tbPlaceDelivery.MaxLength = 100;
            this.tbPlaceDelivery.Name = "tbPlaceDelivery";
            this.tbPlaceDelivery.Size = new System.Drawing.Size(200, 20);
            this.tbPlaceDelivery.TabIndex = 8;
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Location = new System.Drawing.Point(122, 44);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOrder.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Заказчик:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Затрачено времени:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место доставки:";
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
            // rtbAdditionalData
            // 
            this.rtbAdditionalData.Location = new System.Drawing.Point(9, 166);
            this.rtbAdditionalData.MaxLength = 200;
            this.rtbAdditionalData.Name = "rtbAdditionalData";
            this.rtbAdditionalData.Size = new System.Drawing.Size(392, 97);
            this.rtbAdditionalData.TabIndex = 11;
            this.rtbAdditionalData.Text = "";
            // 
            // dtpDateArrival
            // 
            this.dtpDateArrival.Location = new System.Drawing.Point(153, 121);
            this.dtpDateArrival.Name = "dtpDateArrival";
            this.dtpDateArrival.Size = new System.Drawing.Size(200, 20);
            this.dtpDateArrival.TabIndex = 10;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дополнительная информация:";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Спидометр кол-во приезд:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Топливо кол-во приезд:";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCargoes);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 259);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Грузы в перевозке";
            // 
            // lbCargoes
            // 
            this.lbCargoes.DataSource = this.cargoBindingSource;
            this.lbCargoes.DisplayMember = "Name";
            this.lbCargoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCargoes.FormattingEnabled = true;
            this.lbCargoes.ItemHeight = 16;
            this.lbCargoes.Location = new System.Drawing.Point(6, 19);
            this.lbCargoes.Name = "lbCargoes";
            this.lbCargoes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCargoes.Size = new System.Drawing.Size(747, 228);
            this.lbCargoes.TabIndex = 0;
            this.lbCargoes.ValueMember = "ID";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataSource = typeof(LogisticsAutomation.Cargo);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(234, 552);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(390, 552);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(150, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // DFormTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 582);
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
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbTravelTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbKilometrage)).EndInit();
            this.gpAdditionally.ResumeLayout(false);
            this.gpAdditionally.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbSpeedometerDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelComing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbFuelDeparture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource transportBindingSource;
        protected internal System.Windows.Forms.ListBox lbCargoes;
    }
}
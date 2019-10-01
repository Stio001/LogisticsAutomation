namespace LogisticsAutomation.DialogForms
{
    partial class DFormCargo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ntbNumber = new System.Windows.Forms.NumericUpDown();
            this.tbUnitMeasurement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ntbWeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCargoType = new System.Windows.Forms.ComboBox();
            this.cargoTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntbNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 25);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(218, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Еденицы измерения:";
            // 
            // ntbNumber
            // 
            this.ntbNumber.Location = new System.Drawing.Point(9, 104);
            this.ntbNumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbNumber.Name = "ntbNumber";
            this.ntbNumber.Size = new System.Drawing.Size(218, 20);
            this.ntbNumber.TabIndex = 3;
            // 
            // tbUnitMeasurement
            // 
            this.tbUnitMeasurement.Location = new System.Drawing.Point(9, 142);
            this.tbUnitMeasurement.MaxLength = 20;
            this.tbUnitMeasurement.Name = "tbUnitMeasurement";
            this.tbUnitMeasurement.Size = new System.Drawing.Size(218, 20);
            this.tbUnitMeasurement.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вес:";
            // 
            // ntbWeight
            // 
            this.ntbWeight.Location = new System.Drawing.Point(9, 182);
            this.ntbWeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbWeight.Name = "ntbWeight";
            this.ntbWeight.Size = new System.Drawing.Size(218, 20);
            this.ntbWeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поставщик:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DataSource = this.supplierBindingSource;
            this.cmbSupplier.DisplayMember = "Name";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(9, 221);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(218, 21);
            this.cmbSupplier.TabIndex = 6;
            this.cmbSupplier.ValueMember = "ID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(LogisticsAutomation.Supplier);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип груза:";
            // 
            // cmbCargoType
            // 
            this.cmbCargoType.DataSource = this.cargoTypeBindingSource;
            this.cmbCargoType.DisplayMember = "Name";
            this.cmbCargoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargoType.FormattingEnabled = true;
            this.cmbCargoType.Location = new System.Drawing.Point(9, 64);
            this.cmbCargoType.Name = "cmbCargoType";
            this.cmbCargoType.Size = new System.Drawing.Size(218, 21);
            this.cmbCargoType.TabIndex = 2;
            this.cmbCargoType.ValueMember = "ID";
            // 
            // cargoTypeBindingSource
            // 
            this.cargoTypeBindingSource.DataSource = typeof(LogisticsAutomation.CargoType);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(9, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(120, 248);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(107, 23);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // DFormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 282);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbCargoType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ntbNumber);
            this.Controls.Add(this.ntbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUnitMeasurement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DFormCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Груз";
            ((System.ComponentModel.ISupportInitialize)(this.ntbNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        protected internal System.Windows.Forms.TextBox tbName;
        protected internal System.Windows.Forms.NumericUpDown ntbNumber;
        protected internal System.Windows.Forms.ComboBox cmbCargoType;
        private System.Windows.Forms.BindingSource cargoTypeBindingSource;
        protected internal System.Windows.Forms.TextBox tbUnitMeasurement;
        protected internal System.Windows.Forms.NumericUpDown ntbWeight;
        protected internal System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}
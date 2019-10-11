namespace LogisticsAutomation.DialogForms
{
    partial class DFormTariff
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.ntbPerHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ntbPerKG = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ntbPerKM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerKG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerKM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 20);
            this.tbName.TabIndex = 1;
            // 
            // ntbPerHour
            // 
            this.ntbPerHour.Location = new System.Drawing.Point(12, 64);
            this.ntbPerHour.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbPerHour.Name = "ntbPerHour";
            this.ntbPerHour.Size = new System.Drawing.Size(219, 20);
            this.ntbPerHour.TabIndex = 4;
            this.ntbPerHour.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "За час:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "За КГ:";
            // 
            // ntbPerKG
            // 
            this.ntbPerKG.Location = new System.Drawing.Point(12, 103);
            this.ntbPerKG.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbPerKG.Name = "ntbPerKG";
            this.ntbPerKG.Size = new System.Drawing.Size(219, 20);
            this.ntbPerKG.TabIndex = 6;
            this.ntbPerKG.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "За КМ:";
            // 
            // ntbPerKM
            // 
            this.ntbPerKM.Location = new System.Drawing.Point(12, 142);
            this.ntbPerKM.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ntbPerKM.Name = "ntbPerKM";
            this.ntbPerKM.Size = new System.Drawing.Size(219, 20);
            this.ntbPerKM.TabIndex = 8;
            this.ntbPerKM.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Описание:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 181);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(219, 95);
            this.rtbDescription.TabIndex = 11;
            this.rtbDescription.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(123, 282);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(108, 23);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // DFormTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 310);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ntbPerKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ntbPerKG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ntbPerHour);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DFormTariff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тариф";
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerKG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntbPerKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        protected internal System.Windows.Forms.TextBox tbName;
        protected internal System.Windows.Forms.NumericUpDown ntbPerHour;
        protected internal System.Windows.Forms.NumericUpDown ntbPerKG;
        protected internal System.Windows.Forms.NumericUpDown ntbPerKM;
        protected internal System.Windows.Forms.RichTextBox rtbDescription;
    }
}
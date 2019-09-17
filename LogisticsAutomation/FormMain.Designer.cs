namespace LogisticsAutomation
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьДоговорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путевойЛистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиИДиаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервнаяКопияБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnTariffs = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnCargoType = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.программаToolStripMenuItem,
            this.резервнаяКопияБДToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(405, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформитьДоговорToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // оформитьДоговорToolStripMenuItem
            // 
            this.оформитьДоговорToolStripMenuItem.Name = "оформитьДоговорToolStripMenuItem";
            this.оформитьДоговорToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.оформитьДоговорToolStripMenuItem.Text = "Оформить договор";
            this.оформитьДоговорToolStripMenuItem.Click += new System.EventHandler(this.frmTranspotationOpen);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.путевойЛистToolStripMenuItem,
            this.графикиИДиаграммыToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // путевойЛистToolStripMenuItem
            // 
            this.путевойЛистToolStripMenuItem.Name = "путевойЛистToolStripMenuItem";
            this.путевойЛистToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.путевойЛистToolStripMenuItem.Text = "Путевой лист";
            this.путевойЛистToolStripMenuItem.Click += new System.EventHandler(this.frmReportOpen);
            // 
            // графикиИДиаграммыToolStripMenuItem
            // 
            this.графикиИДиаграммыToolStripMenuItem.Name = "графикиИДиаграммыToolStripMenuItem";
            this.графикиИДиаграммыToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.графикиИДиаграммыToolStripMenuItem.Text = "Графики и диаграммы";
            this.графикиИДиаграммыToolStripMenuItem.Click += new System.EventHandler(this.frmStatOpen);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.frmUsersOpen);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.frmAboutOpen);
            // 
            // резервнаяКопияБДToolStripMenuItem
            // 
            this.резервнаяКопияБДToolStripMenuItem.Name = "резервнаяКопияБДToolStripMenuItem";
            this.резервнаяКопияБДToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.резервнаяКопияБДToolStripMenuItem.Text = "Резервная копия БД";
            this.резервнаяКопияБДToolStripMenuItem.Click += new System.EventHandler(this.РезервнаяКопияБДToolStripMenuItem_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(12, 27);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(179, 63);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "Доставка";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.frmTranspotationOpen);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(12, 96);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(179, 63);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.Text = "Водители";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.frmDriversOpen);
            // 
            // btnTransport
            // 
            this.btnTransport.Location = new System.Drawing.Point(12, 165);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(179, 63);
            this.btnTransport.TabIndex = 3;
            this.btnTransport.Text = "Автотранспорт";
            this.btnTransport.UseVisualStyleBackColor = true;
            this.btnTransport.Click += new System.EventHandler(this.frmTransportsOpen);
            // 
            // btnTariffs
            // 
            this.btnTariffs.Location = new System.Drawing.Point(12, 234);
            this.btnTariffs.Name = "btnTariffs";
            this.btnTariffs.Size = new System.Drawing.Size(179, 63);
            this.btnTariffs.TabIndex = 4;
            this.btnTariffs.Text = "Тарифы";
            this.btnTariffs.UseVisualStyleBackColor = true;
            this.btnTariffs.Click += new System.EventHandler(this.frmTariffsOpen);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(12, 303);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(179, 63);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "Заказчики";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.frmClientsOpen);
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(208, 165);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(179, 63);
            this.btnCargos.TabIndex = 6;
            this.btnCargos.Text = "Грузы";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.frmCargosOpen);
            // 
            // btnCargoType
            // 
            this.btnCargoType.Location = new System.Drawing.Point(208, 234);
            this.btnCargoType.Name = "btnCargoType";
            this.btnCargoType.Size = new System.Drawing.Size(179, 63);
            this.btnCargoType.TabIndex = 7;
            this.btnCargoType.Text = "Тип груза";
            this.btnCargoType.UseVisualStyleBackColor = true;
            this.btnCargoType.Click += new System.EventHandler(this.frmCargosTypeOpen);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(208, 303);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(179, 63);
            this.btnSuppliers.TabIndex = 8;
            this.btnSuppliers.Text = "Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.frmSuppliersOpen);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 379);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnCargoType);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnTariffs);
            this.Controls.Add(this.btnTransport);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Система автоматизации логистической компании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьДоговорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путевойЛистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиИДиаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервнаяКопияБДToolStripMenuItem;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnTariffs;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnCargoType;
        private System.Windows.Forms.Button btnSuppliers;
    }
}


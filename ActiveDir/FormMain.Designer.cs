namespace ActiveDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox_common = new System.Windows.Forms.TextBox();
            this.comboBox__addMFU_3 = new System.Windows.Forms.ComboBox();
            this.label_addMFU_3 = new System.Windows.Forms.Label();
            this.label_addMFU_2 = new System.Windows.Forms.Label();
            this.textBox_addMFU_2 = new System.Windows.Forms.TextBox();
            this.textBox_addMFU_1 = new System.Windows.Forms.TextBox();
            this.label_addMFU_1 = new System.Windows.Forms.Label();
            this.label_addMFU = new System.Windows.Forms.Label();
            this.textBox_addU = new System.Windows.Forms.TextBox();
            this.label_addU = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel_scan = new System.Windows.Forms.Panel();
            this.button_createScan = new System.Windows.Forms.Button();
            this.button_createUser = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.panel_scan.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_common
            // 
            this.textBox_common.Location = new System.Drawing.Point(12, 183);
            this.textBox_common.Multiline = true;
            this.textBox_common.Name = "textBox_common";
            this.textBox_common.Size = new System.Drawing.Size(338, 187);
            this.textBox_common.TabIndex = 1;
            // 
            // comboBox__addMFU_3
            // 
            this.comboBox__addMFU_3.FormattingEnabled = true;
            this.comboBox__addMFU_3.Items.AddRange(new object[] {
            "share",
            "fl"});
            this.comboBox__addMFU_3.Location = new System.Drawing.Point(223, 73);
            this.comboBox__addMFU_3.Name = "comboBox__addMFU_3";
            this.comboBox__addMFU_3.Size = new System.Drawing.Size(100, 21);
            this.comboBox__addMFU_3.TabIndex = 6;
            // 
            // label_addMFU_3
            // 
            this.label_addMFU_3.Location = new System.Drawing.Point(13, 72);
            this.label_addMFU_3.Name = "label_addMFU_3";
            this.label_addMFU_3.Size = new System.Drawing.Size(177, 20);
            this.label_addMFU_3.TabIndex = 5;
            this.label_addMFU_3.Text = "Укажите корень шары:";
            this.label_addMFU_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_addMFU_2
            // 
            this.label_addMFU_2.Location = new System.Drawing.Point(13, 52);
            this.label_addMFU_2.Name = "label_addMFU_2";
            this.label_addMFU_2.Size = new System.Drawing.Size(177, 20);
            this.label_addMFU_2.TabIndex = 4;
            this.label_addMFU_2.Text = "Подразделение, например ОБУ:";
            this.label_addMFU_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_addMFU_2
            // 
            this.textBox_addMFU_2.Location = new System.Drawing.Point(223, 52);
            this.textBox_addMFU_2.Name = "textBox_addMFU_2";
            this.textBox_addMFU_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_addMFU_2.TabIndex = 3;
            // 
            // textBox_addMFU_1
            // 
            this.textBox_addMFU_1.Location = new System.Drawing.Point(223, 31);
            this.textBox_addMFU_1.Name = "textBox_addMFU_1";
            this.textBox_addMFU_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_addMFU_1.TabIndex = 2;
            // 
            // label_addMFU_1
            // 
            this.label_addMFU_1.Location = new System.Drawing.Point(13, 31);
            this.label_addMFU_1.Name = "label_addMFU_1";
            this.label_addMFU_1.Size = new System.Drawing.Size(177, 20);
            this.label_addMFU_1.TabIndex = 1;
            this.label_addMFU_1.Text = "Номер принтера, например 0001:";
            this.label_addMFU_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_addMFU
            // 
            this.label_addMFU.Location = new System.Drawing.Point(13, 13);
            this.label_addMFU.Name = "label_addMFU";
            this.label_addMFU.Size = new System.Drawing.Size(310, 18);
            this.label_addMFU.TabIndex = 0;
            this.label_addMFU.Text = "Создать учетную запись для МФУ и GPO, введите";
            // 
            // textBox_addU
            // 
            this.textBox_addU.Location = new System.Drawing.Point(12, 46);
            this.textBox_addU.Name = "textBox_addU";
            this.textBox_addU.Size = new System.Drawing.Size(307, 20);
            this.textBox_addU.TabIndex = 1;
            // 
            // label_addU
            // 
            this.label_addU.Location = new System.Drawing.Point(13, 13);
            this.label_addU.Name = "label_addU";
            this.label_addU.Size = new System.Drawing.Size(310, 30);
            this.label_addU.TabIndex = 0;
            this.label_addU.Text = "Создать учетную запись пользователя согласно правилам транслитерации ГОСТ, введит" +
    "е ФИО:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователяПоФИОToolStripMenuItem,
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem});
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // пользователяПоФИОToolStripMenuItem
            // 
            this.пользователяПоФИОToolStripMenuItem.Name = "пользователяПоФИОToolStripMenuItem";
            this.пользователяПоФИОToolStripMenuItem.Size = new System.Drawing.Size(495, 22);
            this.пользователяПоФИОToolStripMenuItem.Text = "Пользователя по ФИО";
            this.пользователяПоФИОToolStripMenuItem.Click += new System.EventHandler(this.пользователяПоФИОToolStripMenuItem_Click);
            // 
            // папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem
            // 
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem.Name = "папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem";
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem.Size = new System.Drawing.Size(495, 22);
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem.Text = "Папку сканирования (пользователя scan, группу и gpo для маппинга шары)";
            this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem.Click += new System.EventHandler(this.папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.panel_scan);
            this.panel_user.Controls.Add(this.button_createUser);
            this.panel_user.Controls.Add(this.textBox_addU);
            this.panel_user.Controls.Add(this.label_addU);
            this.panel_user.Location = new System.Drawing.Point(12, 42);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(338, 135);
            this.panel_user.TabIndex = 5;
            // 
            // panel_scan
            // 
            this.panel_scan.Controls.Add(this.button_createScan);
            this.panel_scan.Controls.Add(this.comboBox__addMFU_3);
            this.panel_scan.Controls.Add(this.label_addMFU);
            this.panel_scan.Controls.Add(this.label_addMFU_3);
            this.panel_scan.Controls.Add(this.label_addMFU_1);
            this.panel_scan.Controls.Add(this.label_addMFU_2);
            this.panel_scan.Controls.Add(this.textBox_addMFU_1);
            this.panel_scan.Controls.Add(this.textBox_addMFU_2);
            this.panel_scan.Location = new System.Drawing.Point(0, 0);
            this.panel_scan.Name = "panel_scan";
            this.panel_scan.Size = new System.Drawing.Size(338, 135);
            this.panel_scan.TabIndex = 6;
            this.panel_scan.Visible = false;
            // 
            // button_createScan
            // 
            this.button_createScan.Location = new System.Drawing.Point(248, 101);
            this.button_createScan.Name = "button_createScan";
            this.button_createScan.Size = new System.Drawing.Size(75, 23);
            this.button_createScan.TabIndex = 7;
            this.button_createScan.Text = "Создать";
            this.button_createScan.UseVisualStyleBackColor = true;
            this.button_createScan.Click += new System.EventHandler(this.button_createScan_Click);
            // 
            // button_createUser
            // 
            this.button_createUser.Location = new System.Drawing.Point(244, 72);
            this.button_createUser.Name = "button_createUser";
            this.button_createUser.Size = new System.Drawing.Size(75, 23);
            this.button_createUser.TabIndex = 2;
            this.button_createUser.Text = "Создать";
            this.button_createUser.UseVisualStyleBackColor = true;
            this.button_createUser.Click += new System.EventHandler(this.button_createUser_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 381);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_common);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Active Directory: add-on";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.panel_scan.ResumeLayout(false);
            this.panel_scan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox_common;
        private System.Windows.Forms.Label label_addMFU_2;
        private System.Windows.Forms.TextBox textBox_addMFU_2;
        private System.Windows.Forms.TextBox textBox_addMFU_1;
        private System.Windows.Forms.Label label_addMFU_1;
        private System.Windows.Forms.Label label_addMFU;
        private System.Windows.Forms.TextBox textBox_addU;
        private System.Windows.Forms.Label label_addU;
        private System.Windows.Forms.ComboBox comboBox__addMFU_3;
        private System.Windows.Forms.Label label_addMFU_3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователяПоФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Panel panel_scan;
        private System.Windows.Forms.Button button_createUser;
        private System.Windows.Forms.Button button_createScan;
    }
}


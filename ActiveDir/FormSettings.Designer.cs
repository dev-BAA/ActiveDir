
namespace ActiveDir
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label_domain = new System.Windows.Forms.Label();
            this.label_GPO_FQDN = new System.Windows.Forms.Label();
            this.textBox_GPO_FQDN = new System.Windows.Forms.TextBox();
            this.groupBox_Mail = new System.Windows.Forms.GroupBox();
            this.label_mailFrom = new System.Windows.Forms.Label();
            this.textBox_mailFrom = new System.Windows.Forms.TextBox();
            this.label_mailTo = new System.Windows.Forms.Label();
            this.textBox_mailTo = new System.Windows.Forms.TextBox();
            this.label_mailServer = new System.Windows.Forms.Label();
            this.textBox_mailServer = new System.Windows.Forms.TextBox();
            this.checkBox_mailCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox_GPO = new System.Windows.Forms.GroupBox();
            this.label_Folder_OU_GPO_selected = new System.Windows.Forms.Label();
            this.label_Folder_OU_User_selected = new System.Windows.Forms.Label();
            this.button_GPO_OUgpo = new System.Windows.Forms.Button();
            this.button_GPO_OUuser = new System.Windows.Forms.Button();
            this.label_GPO_OUgpo = new System.Windows.Forms.Label();
            this.label_GPO_OUuser = new System.Windows.Forms.Label();
            this.groupBox_User = new System.Windows.Forms.GroupBox();
            this.numericUpDown_User_Password = new System.Windows.Forms.NumericUpDown();
            this.label_User_OU_selected = new System.Windows.Forms.Label();
            this.button_User_OU = new System.Windows.Forms.Button();
            this.label_User_Password = new System.Windows.Forms.Label();
            this.label_User_OU = new System.Windows.Forms.Label();
            this.groupBox_Common = new System.Windows.Forms.GroupBox();
            this.label_current_domain = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox_Mail.SuspendLayout();
            this.groupBox_GPO.SuspendLayout();
            this.groupBox_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_User_Password)).BeginInit();
            this.groupBox_Common.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_domain
            // 
            this.label_domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_domain.Location = new System.Drawing.Point(8, 25);
            this.label_domain.Name = "label_domain";
            this.label_domain.Size = new System.Drawing.Size(154, 21);
            this.label_domain.TabIndex = 4;
            this.label_domain.Text = "Active Directory домен";
            this.label_domain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_GPO_FQDN
            // 
            this.label_GPO_FQDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GPO_FQDN.Location = new System.Drawing.Point(6, 26);
            this.label_GPO_FQDN.Name = "label_GPO_FQDN";
            this.label_GPO_FQDN.Size = new System.Drawing.Size(304, 21);
            this.label_GPO_FQDN.TabIndex = 6;
            this.label_GPO_FQDN.Text = "FQDN файлового сервера";
            this.label_GPO_FQDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_GPO_FQDN
            // 
            this.textBox_GPO_FQDN.Location = new System.Drawing.Point(365, 19);
            this.textBox_GPO_FQDN.Name = "textBox_GPO_FQDN";
            this.textBox_GPO_FQDN.Size = new System.Drawing.Size(145, 20);
            this.textBox_GPO_FQDN.TabIndex = 7;
            // 
            // groupBox_Mail
            // 
            this.groupBox_Mail.Controls.Add(this.label_mailFrom);
            this.groupBox_Mail.Controls.Add(this.textBox_mailFrom);
            this.groupBox_Mail.Controls.Add(this.label_mailTo);
            this.groupBox_Mail.Controls.Add(this.textBox_mailTo);
            this.groupBox_Mail.Controls.Add(this.label_mailServer);
            this.groupBox_Mail.Controls.Add(this.textBox_mailServer);
            this.groupBox_Mail.Controls.Add(this.checkBox_mailCheckBox);
            this.groupBox_Mail.Location = new System.Drawing.Point(13, 352);
            this.groupBox_Mail.Name = "groupBox_Mail";
            this.groupBox_Mail.Size = new System.Drawing.Size(534, 94);
            this.groupBox_Mail.TabIndex = 8;
            this.groupBox_Mail.TabStop = false;
            this.groupBox_Mail.Text = "Настройки уведомлений";
            // 
            // label_mailFrom
            // 
            this.label_mailFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mailFrom.Location = new System.Drawing.Point(272, 60);
            this.label_mailFrom.Name = "label_mailFrom";
            this.label_mailFrom.Size = new System.Drawing.Size(87, 21);
            this.label_mailFrom.TabIndex = 12;
            this.label_mailFrom.Text = "От кого";
            this.label_mailFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_mailFrom
            // 
            this.textBox_mailFrom.Location = new System.Drawing.Point(365, 61);
            this.textBox_mailFrom.Name = "textBox_mailFrom";
            this.textBox_mailFrom.Size = new System.Drawing.Size(145, 20);
            this.textBox_mailFrom.TabIndex = 13;
            // 
            // label_mailTo
            // 
            this.label_mailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mailTo.Location = new System.Drawing.Point(272, 39);
            this.label_mailTo.Name = "label_mailTo";
            this.label_mailTo.Size = new System.Drawing.Size(87, 21);
            this.label_mailTo.TabIndex = 10;
            this.label_mailTo.Text = "Кому";
            this.label_mailTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_mailTo
            // 
            this.textBox_mailTo.Location = new System.Drawing.Point(365, 40);
            this.textBox_mailTo.Name = "textBox_mailTo";
            this.textBox_mailTo.Size = new System.Drawing.Size(145, 20);
            this.textBox_mailTo.TabIndex = 11;
            // 
            // label_mailServer
            // 
            this.label_mailServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mailServer.Location = new System.Drawing.Point(272, 18);
            this.label_mailServer.Name = "label_mailServer";
            this.label_mailServer.Size = new System.Drawing.Size(87, 21);
            this.label_mailServer.TabIndex = 8;
            this.label_mailServer.Text = "SMTP сервер";
            this.label_mailServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_mailServer
            // 
            this.textBox_mailServer.Location = new System.Drawing.Point(365, 19);
            this.textBox_mailServer.Name = "textBox_mailServer";
            this.textBox_mailServer.Size = new System.Drawing.Size(145, 20);
            this.textBox_mailServer.TabIndex = 9;
            // 
            // checkBox_mailCheckBox
            // 
            this.checkBox_mailCheckBox.AutoSize = true;
            this.checkBox_mailCheckBox.Checked = global::ActiveDir.Properties.Settings.Default.mailCheckBox;
            this.checkBox_mailCheckBox.Location = new System.Drawing.Point(9, 23);
            this.checkBox_mailCheckBox.Name = "checkBox_mailCheckBox";
            this.checkBox_mailCheckBox.Size = new System.Drawing.Size(216, 17);
            this.checkBox_mailCheckBox.TabIndex = 0;
            this.checkBox_mailCheckBox.Text = "Отправлять учетные данные на почту";
            this.checkBox_mailCheckBox.UseVisualStyleBackColor = true;
            this.checkBox_mailCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxSendPost_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(392, 462);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(473, 462);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(311, 462);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox_GPO
            // 
            this.groupBox_GPO.Controls.Add(this.label_Folder_OU_GPO_selected);
            this.groupBox_GPO.Controls.Add(this.label_Folder_OU_User_selected);
            this.groupBox_GPO.Controls.Add(this.button_GPO_OUgpo);
            this.groupBox_GPO.Controls.Add(this.button_GPO_OUuser);
            this.groupBox_GPO.Controls.Add(this.label_GPO_OUgpo);
            this.groupBox_GPO.Controls.Add(this.label_GPO_OUuser);
            this.groupBox_GPO.Controls.Add(this.label_GPO_FQDN);
            this.groupBox_GPO.Controls.Add(this.textBox_GPO_FQDN);
            this.groupBox_GPO.Location = new System.Drawing.Point(13, 202);
            this.groupBox_GPO.Name = "groupBox_GPO";
            this.groupBox_GPO.Size = new System.Drawing.Size(534, 144);
            this.groupBox_GPO.TabIndex = 12;
            this.groupBox_GPO.TabStop = false;
            this.groupBox_GPO.Text = "Создание Политики сканирования";
            // 
            // label_Folder_OU_GPO_selected
            // 
            this.label_Folder_OU_GPO_selected.AutoSize = true;
            this.label_Folder_OU_GPO_selected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Folder_OU_GPO_selected.Location = new System.Drawing.Point(6, 112);
            this.label_Folder_OU_GPO_selected.Name = "label_Folder_OU_GPO_selected";
            this.label_Folder_OU_GPO_selected.Size = new System.Drawing.Size(92, 13);
            this.label_Folder_OU_GPO_selected.TabIndex = 15;
            this.label_Folder_OU_GPO_selected.Text = "organizational unit";
            // 
            // label_Folder_OU_User_selected
            // 
            this.label_Folder_OU_User_selected.AutoSize = true;
            this.label_Folder_OU_User_selected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Folder_OU_User_selected.Location = new System.Drawing.Point(6, 68);
            this.label_Folder_OU_User_selected.Name = "label_Folder_OU_User_selected";
            this.label_Folder_OU_User_selected.Size = new System.Drawing.Size(92, 13);
            this.label_Folder_OU_User_selected.TabIndex = 14;
            this.label_Folder_OU_User_selected.Text = "organizational unit";
            // 
            // button_GPO_OUgpo
            // 
            this.button_GPO_OUgpo.Location = new System.Drawing.Point(419, 102);
            this.button_GPO_OUgpo.Name = "button_GPO_OUgpo";
            this.button_GPO_OUgpo.Size = new System.Drawing.Size(91, 23);
            this.button_GPO_OUgpo.TabIndex = 13;
            this.button_GPO_OUgpo.Text = "Выберите OU";
            this.button_GPO_OUgpo.UseVisualStyleBackColor = true;
            this.button_GPO_OUgpo.Click += new System.EventHandler(this.button_GPO_OUgpo_Click);
            // 
            // button_GPO_OUuser
            // 
            this.button_GPO_OUuser.Location = new System.Drawing.Point(419, 58);
            this.button_GPO_OUuser.Name = "button_GPO_OUuser";
            this.button_GPO_OUuser.Size = new System.Drawing.Size(91, 23);
            this.button_GPO_OUuser.TabIndex = 12;
            this.button_GPO_OUuser.Text = "Выберите OU";
            this.button_GPO_OUuser.UseVisualStyleBackColor = true;
            this.button_GPO_OUuser.Click += new System.EventHandler(this.button_GPO_OUuser_Click);
            // 
            // label_GPO_OUgpo
            // 
            this.label_GPO_OUgpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GPO_OUgpo.Location = new System.Drawing.Point(5, 91);
            this.label_GPO_OUgpo.Name = "label_GPO_OUgpo";
            this.label_GPO_OUgpo.Size = new System.Drawing.Size(358, 21);
            this.label_GPO_OUgpo.TabIndex = 10;
            this.label_GPO_OUgpo.Text = "Укажите OU, к которой будет прилинкована созданная политика";
            this.label_GPO_OUgpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_GPO_OUuser
            // 
            this.label_GPO_OUuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GPO_OUuser.Location = new System.Drawing.Point(6, 47);
            this.label_GPO_OUuser.Name = "label_GPO_OUuser";
            this.label_GPO_OUuser.Size = new System.Drawing.Size(358, 21);
            this.label_GPO_OUuser.TabIndex = 8;
            this.label_GPO_OUuser.Text = "Укажите OU, где будут созданы пользователь и группа";
            this.label_GPO_OUuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_User
            // 
            this.groupBox_User.Controls.Add(this.numericUpDown_User_Password);
            this.groupBox_User.Controls.Add(this.label_User_OU_selected);
            this.groupBox_User.Controls.Add(this.button_User_OU);
            this.groupBox_User.Controls.Add(this.label_User_Password);
            this.groupBox_User.Controls.Add(this.label_User_OU);
            this.groupBox_User.Location = new System.Drawing.Point(12, 86);
            this.groupBox_User.Name = "groupBox_User";
            this.groupBox_User.Size = new System.Drawing.Size(535, 110);
            this.groupBox_User.TabIndex = 13;
            this.groupBox_User.TabStop = false;
            this.groupBox_User.Text = "Создание Пользователя";
            // 
            // numericUpDown_User_Password
            // 
            this.numericUpDown_User_Password.Location = new System.Drawing.Point(463, 72);
            this.numericUpDown_User_Password.Name = "numericUpDown_User_Password";
            this.numericUpDown_User_Password.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_User_Password.TabIndex = 12;
            this.numericUpDown_User_Password.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label_User_OU_selected
            // 
            this.label_User_OU_selected.AutoSize = true;
            this.label_User_OU_selected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_User_OU_selected.Location = new System.Drawing.Point(7, 47);
            this.label_User_OU_selected.Name = "label_User_OU_selected";
            this.label_User_OU_selected.Size = new System.Drawing.Size(92, 13);
            this.label_User_OU_selected.TabIndex = 11;
            this.label_User_OU_selected.Text = "organizational unit";
            // 
            // button_User_OU
            // 
            this.button_User_OU.Location = new System.Drawing.Point(420, 37);
            this.button_User_OU.Name = "button_User_OU";
            this.button_User_OU.Size = new System.Drawing.Size(91, 23);
            this.button_User_OU.TabIndex = 10;
            this.button_User_OU.Text = "Выберите OU";
            this.button_User_OU.UseVisualStyleBackColor = true;
            this.button_User_OU.Click += new System.EventHandler(this.button_User_OU_Click);
            // 
            // label_User_Password
            // 
            this.label_User_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_Password.Location = new System.Drawing.Point(6, 70);
            this.label_User_Password.Name = "label_User_Password";
            this.label_User_Password.Size = new System.Drawing.Size(275, 21);
            this.label_User_Password.TabIndex = 8;
            this.label_User_Password.Text = "длина пароля у создаваемого пользователя";
            this.label_User_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_User_OU
            // 
            this.label_User_OU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_OU.Location = new System.Drawing.Point(6, 26);
            this.label_User_OU.Name = "label_User_OU";
            this.label_User_OU.Size = new System.Drawing.Size(275, 21);
            this.label_User_OU.TabIndex = 6;
            this.label_User_OU.Text = "Укажите OU, где будет создан пользователь";
            this.label_User_OU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Common
            // 
            this.groupBox_Common.Controls.Add(this.label_current_domain);
            this.groupBox_Common.Controls.Add(this.groupBox3);
            this.groupBox_Common.Controls.Add(this.label_domain);
            this.groupBox_Common.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Common.Name = "groupBox_Common";
            this.groupBox_Common.Size = new System.Drawing.Size(535, 68);
            this.groupBox_Common.TabIndex = 14;
            this.groupBox_Common.TabStop = false;
            this.groupBox_Common.Text = "Общие";
            // 
            // label_current_domain
            // 
            this.label_current_domain.AutoSize = true;
            this.label_current_domain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_current_domain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_current_domain.Location = new System.Drawing.Point(168, 22);
            this.label_current_domain.Name = "label_current_domain";
            this.label_current_domain.Size = new System.Drawing.Size(137, 24);
            this.label_current_domain.TabIndex = 17;
            this.label_current_domain.Text = "current domain";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(256, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 68);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить домены в список";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(261, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(68, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Добавить домены в список";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(468, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Active Directory домен";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(482, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 499);
            this.Controls.Add(this.groupBox_Common);
            this.Controls.Add(this.groupBox_User);
            this.Controls.Add(this.groupBox_GPO);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox_Mail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.groupBox_Mail.ResumeLayout(false);
            this.groupBox_Mail.PerformLayout();
            this.groupBox_GPO.ResumeLayout(false);
            this.groupBox_GPO.PerformLayout();
            this.groupBox_User.ResumeLayout(false);
            this.groupBox_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_User_Password)).EndInit();
            this.groupBox_Common.ResumeLayout(false);
            this.groupBox_Common.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_domain;
        private System.Windows.Forms.Label label_GPO_FQDN;
        private System.Windows.Forms.TextBox textBox_GPO_FQDN;
        private System.Windows.Forms.GroupBox groupBox_Mail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox_GPO;
        private System.Windows.Forms.CheckBox checkBox_mailCheckBox;
        private System.Windows.Forms.Label label_mailServer;
        private System.Windows.Forms.TextBox textBox_mailServer;
        private System.Windows.Forms.Label label_mailFrom;
        private System.Windows.Forms.TextBox textBox_mailFrom;
        private System.Windows.Forms.Label label_mailTo;
        private System.Windows.Forms.TextBox textBox_mailTo;
        private System.Windows.Forms.GroupBox groupBox_User;
        private System.Windows.Forms.Label label_User_OU;
        private System.Windows.Forms.Label label_GPO_OUgpo;
        private System.Windows.Forms.Label label_GPO_OUuser;
        private System.Windows.Forms.Label label_User_Password;
        private System.Windows.Forms.GroupBox groupBox_Common;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_User_OU;
        private System.Windows.Forms.Button button_GPO_OUgpo;
        private System.Windows.Forms.Button button_GPO_OUuser;
        public System.Windows.Forms.Label label_User_OU_selected;
        public System.Windows.Forms.Label label_Folder_OU_GPO_selected;
        public System.Windows.Forms.Label label_Folder_OU_User_selected;
        private System.Windows.Forms.NumericUpDown numericUpDown_User_Password;
        public System.Windows.Forms.Label label_current_domain;
    }
}